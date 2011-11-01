using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

using SysconCommon.Common;
using SysconCommon.Common.Validity;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.Foxpro
{
    public static class FoxproUtil
    {
        public static string ToFoxproDate(this DateTime input)
        {
            return string.Format("Date({0},{1},{2})", input.Year, input.Month, input.Day);
        }

        public static string FoxproInsertString(this DataRow self, string table_name)
        {
            var numeric_types = new Type[] {
                typeof(decimal), typeof(int), typeof(long), typeof(double), typeof(float)
            };

            var date_types = new Type[] {
                typeof(DateTime)
            };

            var keys = from c in self.Table.Columns
                       select c.ColumnName;

            var vals = self.ItemArray.Select(v =>
            {
                if (numeric_types.Contains(v.GetType()))
                    return v.ToString();

                if (date_types.Contains(v.GetType()))
                    return ((DateTime)v).ToFoxproDate();

                return v.ToString().FoxproQuote();
            });

            return string.Format("insert into {0} ({1}) values ({2})", table_name, string.Join(",", keys), string.Join(",", vals));
        }

        public static string FoxproQuote(this string input)
        {
            if (!input.Contains("'"))
                return "'" + input + "'";

            if (!input.Contains("\""))
                return "\"" + input + "\"";

            if (!input.Contains("[") && !input.Contains("]"))
                return "[" + input + "]";

            throw new FoxproQuoteException(input);
        }

        public static string[] SortAlphaNumericCombined(this IEnumerable<string> self)
        {
            return self.InsertSort(AlphaNumericCombinedSortFunc).ToArray();
        }

        public static int AlphaNumericCombinedSortFunc(string a, string b)
        {
            if (a == null)
                return -1;

            if (b == null)
                return 1;

            if (a.Length == 0)
                return -1;

            if (b.Length == 0)
                return 1;

            if (char.IsNumber(a[0]) && !char.IsNumber(b[0]))
                return -1;

            if (char.IsNumber(b[0]) && !char.IsNumber(a[0]))
                return 1;

            if (!char.IsNumber(a[0]))
                return a.CompareTo(b);

            // if they both start with numbers it gets interesting, first compare the numbers, then if they are equal compair the remainder of the string
            var amatch = Regex.Match(a, @"^(\d+)(.*)$");
            var bmatch = Regex.Match(b, @"^(\d+)(.*)$");

            var anum = int.Parse(amatch.Groups[1].Value);
            var bnum = int.Parse(bmatch.Groups[1].Value);

            if (anum == bnum)
                return amatch.Groups[2].Value.CompareTo(bmatch.Groups[2].Value);

            return anum.CompareTo(bnum);
        }
    }

    public class FoxproQuoteException : SysconCommon.Common.SysconException
    {
        public FoxproQuoteException(string unquoteable_string) : base("Could not quote string: " + unquoteable_string) { }
    }
}
