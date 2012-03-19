using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.OleDb;
using System.IO;

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

        public static string FQ(this object obj)
        {
            var t = obj.GetType();

            var numeric_types = new Type[] {
                typeof(decimal), typeof(int), typeof(long), typeof(double), typeof(float)
            };

            var date_types = new Type[] {
                typeof(DateTime)
            };

            if (DBNull.Value.Equals(obj) || obj == null)
            {
                return "null";
            }

            if (numeric_types.Contains(t))
            {
                return obj.ToString();
            }

            if (date_types.Contains(t))
            {
                return ((DateTime)obj).ToFoxproDate();
            }

            return obj.ToString().FoxproQuote();
        }

        public static bool IsFoxproNull(this object obj)
        {
            return obj == null || DBNull.Value.Equals(obj);
        }

        public static string FoxproInsertString(this DataRow self, string table_name)
        {
            var keys = from c in self.Table.Columns
                       select c.ColumnName;

            var vals = self.ItemArray.Select(v => v.FQ());

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

        #region DataTable Extensions
        private static string GetFoxproDeleteSql(this DataRowView self, string tblnam, string key_column)
        {
            return string.Format("delete from {0} where {1} = {2}", tblnam.FoxproQuote(), key_column, self[key_column].FQ());
        }

        private static string GetFoxproInsertSql(this DataRowView self, string tblnam, string[] columns)
        {
            var vals = (from c in columns
                        select self[c].FQ()).ToArray();

            return string.Format("insert into {0} ({1}) values ({2})"
                , tblnam.FoxproQuote()
                , string.Join(",", columns)
                , string.Join(",", vals));
        }

        private static string GetFoxproUpdateSql(this DataRowView self, string tblnam, string key_column, string[] columns)
        {
            var sets = (from c in columns
                        select string.Format("{0} = {1}", c, self[c].FQ())).ToArray();

            return string.Format("update {0} set {1} where {2} = {3}"
                , tblnam.FoxproQuote()
                , string.Join(", ", sets)
                , key_column
                , self[key_column].FQ());
        }

        public static Func<DataRowView, bool> MkIdGen<T>(this OleDbConnection con, string tblname, params string[] colnames)
        {
            return (row) =>
            {
                foreach (var c in colnames)
                {
                    if (row[c].IsFoxproNull())
                    {
                        row[c] = con.GetScalar<T>("select max({0})+1 from {1}", c, tblname);
                    }
                }

                return true;
            };
        }

        public static FoxproCommitResults UpdateFoxproTable(this DataTable self, OleDbConnection con, string tblname, string key_column = null, Func<DataRowView,bool> DefaultValGen = null, params string[] columns)
        {
            if (key_column == null)
            {
                try
                {
                    key_column = self.FindUpdateIndex().ColumnName;
                }
                catch
                {
                    throw new SysconException("Could not determine the key column");
                }
            }

            // get deleted rows
            var deletedview = new DataView(self, "", "", DataViewRowState.Deleted);
            var updatedview = new DataView(self, "", "", DataViewRowState.ModifiedCurrent);
            var insertedview = new DataView(self, "", "", DataViewRowState.Added);

            if (columns.Length == 0)
            {
                columns = (from c in self.Columns.ToIEnumerable()
                           where c.ColumnName != key_column
                           select c.ColumnName).ToArray();
            }

            var result = new FoxproCommitResults();

            using (var cmd = con.CreateCommand())
            {
                foreach (DataRowView row in deletedview)
                {
                    cmd.CommandText = row.GetFoxproDeleteSql(tblname, key_column);
                    result.DeletedCount += cmd.ExecuteNonQuery();
                }

                foreach (DataRowView row in updatedview)
                {
                    cmd.CommandText = row.GetFoxproUpdateSql(tblname, key_column, columns);
                    result.UpdatedCount += cmd.ExecuteNonQuery();
                }

                foreach (DataRowView row in insertedview)
                {
                    if (DefaultValGen != null && !DefaultValGen(row))
                    {
                        throw new SysconException("Could not load default values for row");
                    }

                    var all_columns = columns.Concat(new string[] { key_column }).ToArray();
                    cmd.CommandText = row.GetFoxproInsertSql(tblname, all_columns);
                    result.InsertedCount += cmd.ExecuteNonQuery();
                }

                self.AcceptChanges();

                return result;
            }
        }
        #endregion



        public static DataTable FoxproUserEdit (this OleDbConnection con, string tableName, bool save_edits, params DTColumns.DataColumnOp[] columnMods)
        {
            var name = Path.GetFileNameWithoutExtension(tableName);

            var dt = con.GetDataTable(name, "select * from {0}", tableName.FoxproQuote());
            dt.ApplyMods(columnMods);

            var uindex = dt.FindUpdateIndex();

            Validity.Assert(uindex != null, "Index column must be specified");

            var key_column = uindex.ColumnName;
            dt.Columns[key_column].SetAsKey();
            dt.Columns[key_column].ReadOnly = true;

            SysconCommon.GUI.ShowDataTable.ShowTable(dt, true);
            dt.UpdateFoxproTable(con, tableName, key_column, null);

            return dt;
        }
    }


    public class FoxproQuoteException : SysconCommon.Common.SysconException
    {
        public FoxproQuoteException(string unquoteable_string) : base("Could not quote string: " + unquoteable_string) { }
    }

    public class FoxproCommitResults
    {
        public int DeletedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InsertedCount { get; set; }
    }
}
