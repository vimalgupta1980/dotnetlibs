using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;

using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.Algebras.JSON
{
    public static class CommonJsonExtensions
    {
        private static string DataTableToJson(DataTable dt)
        {
            var records = new List<string>();

            foreach (var r in dt.Rows.ToIEnumerable())
            {
                var elms = from c in dt.Columns.ToIEnumerable()
                           from rightside in new string[] { r[c].ToJSON() }
                           select string.Format("\"{0}\":{1}", c.ColumnName, rightside);

                records.Add("{" + string.Join(",", elms.ToArray()) + "}");
            }

            return string.Format("[{0}]", string.Join(",", records.ToArray()));
        }

        private static string jsonify(this string self)
        {
            self = Regex.Replace(self, @"\\", @"\\\\");
            self = Regex.Replace(self, "\"", "\\\"");
            return self;
        }

        public static string ToJSON(this object self)
        {
            if (self == null)
            {
                return "null";
            }
            else if (self is int || self is double || self is decimal)
            {
                return self.ToString();
            }
            else if (self is string)
            {
                return string.Format("\"{0}\"", jsonify(self as string));
            }
            else if (self is DataTable)
            {
                return DataTableToJson(self as DataTable);
            }
            else if (self.GetType().IsArray)
            {
                var aself = self as Array;
                var elms = from i in FunctionalOperators.Range(aself.Length)
                           select aself.GetValue(i).ToJSON();

                return string.Format("[{0}]", string.Join(",", elms.ToArray()));
            }
            else if (self.GetType().IsEnum)
            {
                return string.Format("\"{0}\"", self.ToString());
            }
            else
            {
                var props = from p in self.GetType().GetProperties()
                            select "\"" + p.Name + "\":" + p.GetValue(self, null).ToJSON();

                var fields = from f in self.GetType().GetFields()
                             select "\"" + f.Name + "\":" + f.GetValue(self).ToJSON();

                var everything = props.Concat(fields);

                return "{" + string.Join(",", everything.ToArray()) + "}";
            }
        }
    }
}
