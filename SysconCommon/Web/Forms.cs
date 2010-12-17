using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using SysconCommon.Common;

namespace SysconCommon.Web
{
    public interface IForm
    {
        // string PostURL { get; }
    }

    public class FormAttribute : Attribute
    {
        public readonly string Name;
        public readonly string Caption;

        public FormAttribute(string name, string caption)
        {
            Name = name;
            Caption = caption;
        }

        public class FormComboBoxAttribute : FormAttribute
        {
            public readonly string OptionsSql;
            public readonly string ValueField;
            public readonly string CaptionField;

            public FormComboBoxAttribute(string name, string caption, string options_sql, string value_field, string caption_field)
                : base(name, caption)
            {
                OptionsSql = options_sql;
                ValueField = value_field;
                CaptionField = caption_field;
            }
        }

        public class FormTextBoxAttribute : FormAttribute
        {
            public readonly bool MultiLine;

            public FormTextBoxAttribute(string name, string caption, bool multiline)
                : base(name, caption)
            {
                MultiLine = multiline;
            }

            public FormTextBoxAttribute(string name, string caption)
                : this(name, caption, false)
            {
            }
        }

        public class FormDatePickerAttribute : FormAttribute
        {
            public FormDatePickerAttribute(string name, string caption)
                : base(name, caption)
            {
            }
        }

        public static class Forms
        {
            public static string FormTableClass = "form";

            private static IEnumerable<System.Tuple<MemberInfo, FormAttribute>> GetFormMembers<T>()
            {
                return from m in typeof(T).GetMembers()
                       from att in m.GetCustomAttributes(false)
                       where att is FormAttribute
                       select new System.Tuple<MemberInfo, FormAttribute>(m, (FormAttribute)att);
            }

            public static string Build<T>(T default_values)
                where T : IForm
            {
                var mems = GetFormMembers<T>();
                if (mems.IsEmpty())
                    throw new SysconException("Form type {0} has no form members", typeof(T));

                string html = string.Format("<table class='{0}'>");

                foreach (var m in mems)
                {
                    html += "<tr>";
                    html += "<td>" + m.Item2.Caption + "</td>";

                    object value = null;

                    if (m.Item1 is PropertyInfo)
                    {
                        var p = m.Item1 as PropertyInfo;
                        value = p.GetValue(m.Item2, null);
                    }
                    else if (m.Item1 is FieldInfo)
                    {
                        var f = m.Item1 as FieldInfo;
                        value = f.GetValue(m.Item2);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }

                    html += "<td>";

                    if (m.Item1.GetType() == typeof(FormComboBoxAttribute))
                    {
                        html += BuildComboBox(m);
                    }
                    else if (m.Item1.GetType() == typeof(FormTextBoxAttribute))
                    {
                        html += BuildTextBox(m);
                    }
                    else if (m.Item1.GetType() == typeof(FormDatePickerAttribute))
                    {
                        html += BuildDatePicker(m);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }

                    html += "</td></tr>";
                }

                html += "<tr><td colspan='2'><input type='submit' /></td></tr>";
                html += "</table>";

                return html;
            }

            private static string BuildDatePicker(System.Tuple<MemberInfo, FormAttribute> m)
            {
                throw new NotImplementedException();
            }

            private static string BuildTextBox(System.Tuple<MemberInfo, FormAttribute> m)
            {
                throw new NotImplementedException();
            }

            private static string BuildComboBox(System.Tuple<MemberInfo, FormAttribute> m)
            {
                throw new NotImplementedException();
            }

            public static string Build<T>()
                where T : IForm, new()
            {
                return Build(new T());
            }

            public static T Read<T>(T default_values)
                where T : IForm
            {
                throw new NotImplementedException();
            }

            public static T Read<T>()
                where T : IForm, new()
            {
                return Read(new T());
            }
        }
    }
}
