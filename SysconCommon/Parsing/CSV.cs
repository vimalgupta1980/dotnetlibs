using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common;

namespace SysconCommon.Parsing
{
    public class CSV
    {
        public static DataTable ParseFile(string filename)
        {
            var txt = File.ReadAllText(filename);
            return ParseText(txt);
        }

        public static DataTable ParseText(string csvtext)
        {
            var esc_char = from bs in Parse.Char('\\')
                           from c in Parse.Char()
                           select c;

            var csv_qs = from q in Parse.Or(Parse.Char('\''), Parse.Char('"'))
                         from s in Parse.Many(Parse.Or(
                             esc_char, 
                             Parse.NoneOf(new char[] { q }), 
                             from one in Parse.Char(q)
                             from two in Parse.Char(q)
                             select one))
                         from close in Parse.Char(q)
                         select new string(s);

            var field = from n in Parse.Nop()
                        from s in
                            Parse.Or(
                                csv_qs,
                                from _n in Parse.Nop()
                                from chars in Parse.Many(Parse.NoneOf(",\r\n"))
                                select new string(chars))
                        select s;

            var row = from first in field
                      from rest in
                          Parse.Many(from delim in Parse.Char(',')
                               from f in field
                               select f)
                      from eol in Parse.Many(Parse.AnyOf("\r\n"), 1)
                      select first.Cons(rest);

            var csv_table = from headers in row
                            from values in Parse.Many(row)
                            select new
                            {
                                headers,
                                values
                            };

            var stream = new StringParseStream(csvtext);

            var tbl_data = csv_table(stream);

            if (!tbl_data.IsSuccess)
            {
                throw new ParseException("Could not parse CSV text");
            }

            var rv = new DataTable();
            
            foreach (var h in tbl_data.result.headers)
            {
                rv.Columns.Add(h);
            }

            foreach (var datarow in tbl_data.result.values)
            {
                if (datarow.Count() != rv.Columns.Count)
                    throw new ParseException("CSV row does not have the correct amount of fields");

                var datatable_row = rv.NewRow();

                for (var i = 0; i < rv.Columns.Count; i++)
                {
                    datatable_row[i] = datarow.ElementAt(i);
                }

                rv.Rows.Add(datatable_row);
            }

            return rv;
        }
    }
}
