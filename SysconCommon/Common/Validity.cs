using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Algebras.Graphs;

namespace SysconCommon.Common.Validity
{
    public class AssertionError : SysconException 
    {
        public AssertionError(string msg) : base(msg) { }
    }

    /// <summary>
    /// Any assumptions that are not validated at compile time should
    /// validate at run time, this tries to provide a single set ways
    /// to do so easily.
    /// </summary>
    public static class Validity
    {
        /// <summary>
        /// throws a new assertion error if condition is false, the error msg
        /// can take additional arguments and formats like string.Format does
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="errMsg">the message included in the new assertion error on failure</param>
        public static void Assert(bool condition, string errMsg, params object[] errMsgObjects)
        {
            if (!condition)
                throw new AssertionError(string.Format(errMsg, errMsgObjects));
        }

        /// <summary>
        /// Easy way to validate a bunch of things at once
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="ValidateFunction"></param>
        public static void Validate<T>(IEnumerable<T> values, Func<T, bool> ValidateFunction)
        {
            foreach (var v in values)
            {
                Assert(ValidateFunction(v), "Validation Failed on object: {0}", v);
            }
        }

        /// <summary>
        /// verify a lot of boolean statements at once
        /// </summary>
        /// <param name="firstOp"></param>
        /// <param name="rest"></param>
        public static void Validate(bool firstOp, params bool[] rest)
        {
            Validate<bool>(firstOp.Cons(rest), b => b);
        }

        /// <summary>
        /// Validate that one or more values are not null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        public static void IsNotNull<T>(T val, params T[] values)
        {
            Validate<T>(val.Cons(values), v => v != null);
        }

        /// <summary>
        /// Checks if one or more files exist
        /// </summary>
        /// <param name="firstFName"></param>
        /// <param name="restFNames"></param>
        public static void FilesExist(string firstFName, params string[] restFNames)
        {
            foreach (var f in firstFName.Cons(restFNames))
                Assert(System.IO.File.Exists(f), "File {0} doesn't exist", f);
        }

        /// <summary>
        /// Checks if one or more directories exist
        /// </summary>
        /// <param name="firstDName"></param>
        /// <param name="restDNames"></param>
        public static void DirectoriesExist(string firstDName, params string[] restDNames)
        {
            foreach (var d in firstDName.Cons(restDNames))
            {
                Assert(System.IO.Directory.Exists(d), "Directory {0} doesn't exist", d);
            }
        }
    }
}