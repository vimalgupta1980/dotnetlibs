using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using System.Web.Mvc;

using SysconCommon.Common.Environment;

namespace SysconCommon.Common.Validity
{
    /// <summary>
    /// boiler plate exception
    /// </summary>
    public class UnsafeException : SysconException
    {
        public UnsafeException(string format, params object[] arguments)
            : base(format, arguments) { }

        public UnsafeException(Exception innerException, string format, params object[] arguments)
            : base(innerException, format, arguments) { }
    }

    /// <summary>
    /// By using this for all user input functions, it can help verify that
    /// the string has been checked.... don't subvert it.  Strings will implicity
    /// cast to this if required.
    /// </summary>
    public class UnsafeString
    {
        private string value;

        public UnsafeString(string val)
        {
            value = val;
        }

        /// <summary>
        /// verify the value and extract it with an arbitrary function
        /// </summary>
        /// <param name="isSecure">verification function</param>
        /// <returns></returns>
        public string getValue(Func<string, bool> isSecure)
        {
            if(isSecure(value))
                return value;

            throw new UnsafeException("value failed security check", value);
        }

        /// <summary>
        /// verify the value with a regex and extract it, regex's for this should be anchored and a warning 
        /// will be logged if they are not
        /// </summary>
        /// <param name="regex">verification regex</param>
        /// <returns></returns>
        public string getValue(string regex)
        {
            if (regex.Length == 0)
                throw new UnsafeException("Empty regex not allowed, if you don't want to sanitize use getUnsanitizedValue instead");

            if (regex[0] != '^' || regex[regex.Length - 1] != '$')
                Env.DebugPrint("Validation regex {0} does not start with ^ and end with $, anchors are highly suggested for security reasons", regex);

            return getValue(str =>
            {
                if (Regex.Match(str, regex).Success)
                    return true;

                throw new UnsafeException("\"{0}\" does not match /{1}/", str, regex);
            });
        }

        /// <summary>
        /// get the value without any verification, requires a justification is written
        /// so others know why it's ok
        /// </summary>
        /// <param name="justification"></param>
        /// <returns></returns>
        public string getUnsanitizedValue(string justification)
        {
            if (justification == null || justification.Trim() == "")
                throw new UnsafeException("Justification for lack of sanitiation can not be null or empty");

            Env.DebugPrint("Value not sanitized: {0}", justification);
            return value;
        }


        /// <summary>
        /// return the value but sanitize it for SQL first, this shouldn't be used in
        /// conjunction with sql insertion parameters
        /// </summary>
        /// <returns></returns>
        public string getSanitizedSqlValue()
        {
            return Regex.Replace(value, "'", "''");
        }

        /// <summary>
        /// allows normal strings to be assigned to an UnsafeString
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static implicit operator UnsafeString(string val)
        {
            return new UnsafeString(val);
        }

        /// <summary>
        /// This is overridden so that it will fail, it throws
        /// an exception immediatly
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new UnsafeException("ToString() cannot be used on an UnsafeString object");
        }

        /// <summary>
        /// overridden, unsafestring values can be compared to regular strings
        /// and other unsafestring values
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var unsafe_other = obj as UnsafeString;

            if (unsafe_other == null)
                return false;

            return unsafe_other.value == this.value;
        }

        /// <summary>
        /// returns a hashcode, for use in dictionaries
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Format("Unsafe{0}Insecure", this.value).GetHashCode();
        }
    }

    /// <summary>
    /// An attribute for mvc controllers.  If this attribute is used, UnsafeString will
    /// be used instead of string for any parameters to action methods.  If a parameter
    /// is declared as a normal string, an exception will be thrown.  Enforcing a policy
    /// that all input should be validated.
    /// </summary>
    public class SecureParametersAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// happens prior to execution
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            foreach (var p in filterContext.ActionDescriptor.GetParameters())
            {
                if (p.ParameterType == typeof(UnsafeString))
                {
                    var val = filterContext.HttpContext.Request.Params[p.ParameterName];
                    filterContext.ActionParameters[p.ParameterName] = new UnsafeString(val);
                }
                else if (p.ParameterType == typeof(string))
                {
                    throw new UnsafeException(
                        "Parameters of type string are disallowed, use SysconCommon.Common.Validity.UnsafeString instead");
                }
            }
        }
    }
}