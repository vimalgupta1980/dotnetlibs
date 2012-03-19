using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SysconCommon.Common
{
    public class FixedSpaceAttribute : Attribute
    {
        public readonly int Begin;
        public readonly int End;
        public readonly bool Cutoff;

        public FixedSpaceAttribute(int begin, int end, bool cutoff = false)
        {
            Begin = begin;
            End = end;
            Cutoff = cutoff;
        }
    }

    public class FixedSpaceOverFlowException : SysconException
    {
        public FixedSpaceOverFlowException() : base("Overflow Exception") { }
    }

    public static class FixedSpace
    {
        public static string FixedSpaceString<T>(this IEnumerable<T> self, Func<T, MemberInfo, bool> OnOverflowError)
        {
            var rv = "";

            foreach (var item in self)
            {
                var line = new StringBuilder();
                var mis = typeof(T).GetMembers();

                foreach (var mi in mis)
                {
                    var atts = mi.GetCustomAttributes(typeof(FixedSpaceAttribute), false);
                    if (atts.IsEmpty())
                        continue;

                    var fsa = atts.First() as FixedSpaceAttribute;

                    if (line.Length <= fsa.End)
                    {
                        var first_char = line.Length;
                        line.Length = fsa.End + 1;
                        foreach (var i in FunctionalOperators.Range(first_char, line.Length))
                        {
                            line[i] = ' ';
                        }
                    }

                    string value = "";
                    var pi = mi as PropertyInfo;
                    if (pi != null)
                    {
                        value = pi.GetValue(item, null) == null ? "" : pi.GetValue(item, null).ToString();
                    }
                    var fi = mi as FieldInfo;
                    if (fi != null)
                    {
                        value = fi.GetValue(item) == null ? "" : fi.GetValue(item).ToString();
                    }

                    if (value.Length > (fsa.End - fsa.Begin) + 1)
                    {
                        if (fsa.Cutoff)
                        {
                            value = value.Substring(0, (fsa.End - fsa.Begin) + 1);
                        }
                        else
                        {
                            if (!OnOverflowError(item, mi))
                            {
                                line = new StringBuilder();
                                break;
                            }
                        }
                    }

                    foreach (var i in FunctionalOperators.Range(value.Length))
                    {
                        line[i + fsa.Begin] = value[i];
                    }
                }

                if (line.Length == 0)
                    continue;

                rv += line.ToString() + "\r\n";
            }

            return rv;
        }

        public static string FixedSpaceString<T>(this IEnumerable<T> self)
        {
            return FixedSpaceString(self, (eObject, mi) => { throw new FixedSpaceOverFlowException(); });
        }

        public static IEnumerable<T> GetList<T>(string input_string)
            where T: new()
        {
            var lines = input_string.Split('\r', '\n');
            var rv = new List<T>();

            foreach (var line in lines)
            {
                if (line.Trim() == "")
                    continue;

                var item = new T();
                var mis = typeof(T).GetMembers();
                foreach (var mi in mis)
                {
                    var atts = mi.GetCustomAttributes(typeof(FixedSpaceAttribute), false);
                    if (atts.IsEmpty())
                        continue;

                    var fsa = atts[0] as FixedSpaceAttribute;

                    object value = null;
                    var pi = mi as PropertyInfo;
                    if (pi != null)
                    {
                        value = Convert.ChangeType(line.Substring(fsa.Begin, (fsa.End - fsa.Begin) + 1).Trim(), pi.PropertyType);
                        pi.SetValue(item, value, null);
                    }
                    var fi = mi as FieldInfo;
                    if (fi != null)
                    {
                        value = Convert.ChangeType(line.Substring(fsa.Begin, (fsa.End - fsa.Begin) + 1).Trim(), fi.FieldType);
                        fi.SetValue(item, value);
                    }
                }

                rv.Add(item);
            }

            return rv;
        }
    }
}
