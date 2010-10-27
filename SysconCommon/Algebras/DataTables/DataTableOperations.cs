/// This file creates a set of core operations on datatables to make them
/// more useful for manipulating data.  It is more flexible than ORM but
/// is not typesafe. On the other hand, it doesn't abuse state like ORM
/// does.
/// 
/// You can still use ORM as well and only use this where necessary
/// because it provides generic functions that construct a datarow
/// into a type of your choosing and vice versa.
/// 
/// If you are only used to OO and not functional programming, the one
/// "suprise" you may hit is that most operators return a new datatable
/// instead of manipulating an existing one.  This makes reasoning about
/// data transformation code easier.
/// 
/// FIXME: if there is time....
/// There are too many "core" functions, many of these should be rewritten
/// to compose from a much smaller core to lower the chances of a bug being
/// in this library. (Although it has been pretty sound for me so far)

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Data;
using System.Data.Odbc;
using System.Data.SQLite;
using System.Reflection;

using Antlr.StringTemplate;

using SysconCommon.Common;
using SysconCommon.Common.Validity;
using SysconCommon.Common.Environment;

namespace SysconCommon.Algebras.DataTables
{
    /// <summary>
    /// standard boiler plate exception type
    /// </summary>
    public class DataTableAlgebraException : SysconException
    {
        public DataTableAlgebraException(Exception innerException, string formatstring, params object[] elements)
            : base(innerException, formatstring, elements)
        {
        }

        public DataTableAlgebraException(string formatstring, params object[] elements)
            : this(null, formatstring, elements)
        {
        }

        public DataTableAlgebraException(Exception innerException)
            : this(innerException, null, null)
        {
        }
    }


    public static partial class DatatableExtensions
    {
        public static DataTable GetDataTable(this OdbcConnection con, string datatableName, string sqlfmt, params object[] args)
        {
            var da = new OdbcDataAdapter();
            using (var cmd = new OdbcCommand(string.Format(sqlfmt, args)))
            {
                cmd.Connection = con;
                da.SelectCommand = cmd;
                var dt = new DataTable(datatableName);
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDataTable(this SQLiteConnection con, string datatableName, string sqlfmt, params object[] args)
        {
            var da = new SQLiteDataAdapter();
            using (var cmd = new SQLiteCommand(string.Format(sqlfmt, args)))
            {
                cmd.Connection = con;
#if true
                // for some reason this builds invalid queries... probably a bug in the sqlite lib, so work around it
                Env.DebugPrint("Creating datatable with: {0}", cmd.CommandText);
                da.SelectCommand = cmd;
                var dt = new DataTable(datatableName);
                da.Fill(dt);
#else
                Env.DebugPrint("Building datatable from: {0}", cmd.CommandText);
                var reader = cmd.ExecuteReader();
                var dt = new DataTable(datatableName);
                foreach (var i in FunctionalOperators.Range(reader.FieldCount))
                {
                    var cname = reader.GetName(i);
                    Env.DebugPrint("Adding column {0}", cname);
                    DataColumn dc = new DataColumn(reader.GetName(i));
                    dt.Columns.Add(dc);
                }

                while (reader.Read())
                {
                    var row = dt.NewRow();
                    foreach (var c in dt.Columns.ToIEnumerable())
                    {
                        row[c.Ordinal] = reader[c.Ordinal];
                    }
                }
#endif
                return dt;
            }
        }

        /// <summary>
        /// Really this just makes it easy to setup a simple datatable for testing purposes.
        /// I guess it could be used more generally than that, but I doubt it'll be a good fit.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable MultArrayToDataTable<T>(this T[][] self, string name)
        {
            // ensure valid parameters
            Validity.Assert(name != null, "No Name Provided");
            Validity.Assert(self.Length != 0, "no rows for datatable build {0}", name);
            Validity.Assert(self[0].Length != 0, "no columns for datatable build {0}", name);

            // take the array of row lengths and ensure they all match
            var rowsizes = self.Select(r => r.Length).Uniq();
            Validity.Assert(rowsizes.Count() == 1, "row lengths must match");

            var dt = new DataTable();
            dt.TableName = name;

            foreach (var i in FunctionalOperators.Range(self[0].Length))
            {
                dt.Columns.Add();
            }


            foreach (var rlen in FunctionalOperators.Range(self.Length))
            {
                var row = dt.NewRow();
                foreach (var clen in FunctionalOperators.Range(self[0].Length))
                {
                    row[clen] = self[rlen][clen];
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        /// get CSV representation of the datatable
        /// </summary>
        /// <param name="self"></param>
        /// <returns>a string with the CSV</returns>
        public static string AsCSVText(this DataTable self)
        {
            Validity.Assert(self != null, "cannot generate csv from null");

            var headers = self.Columns.ToIEnumerable().Select(c => c.ColumnName);
            var headerTxt = string.Format("{0}\n", string.Join(",", headers.Select(h => string.Format("{0}", h)).ToArray()));

            var rowTexts = new List<string>();
            foreach (var row in self.Rows.ToIEnumerable())
            {
                var vals = from c in self.Columns.ToIEnumerable()
                           select row[c].ToString();

                vals = vals.Select(v => Regex.Replace(v, "'", "''"))
                    .Select(v => string.Format("{0}", Regex.Match(v, @"^\s*([-]?\d+([.]\d+)?)\s*$").Success ? v : @"'" + v + "'"));

                rowTexts.Add(string.Join(",", vals.Select(v => string.Format("{0}", v)).ToArray()));
            }

            return headerTxt + string.Join("\n", rowTexts.ToArray());
        }

        public static string AsHTML(this DataTable self)
        {
            string html = "<html class='datatable'>";
            html += "<tr class='datatableHeader'>";

            foreach (var c in self.Columns.ToIEnumerable())
            {
                html += string.Format("<td>{0}</td>", c.ColumnName);
            }

            html += "</tr>";

            foreach (var r in self.Rows.ToIEnumerable())
            {
                html += "<tr class='datatabledata'>";
                foreach (var c in self.Columns.ToIEnumerable())
                {
                    html += string.Format("<td>{0}</td>", r[c]);
                }
                html += "</tr>";
            }

            html += "</table>";
            return html;
        }
        
        /// <summary>
        /// save a datatable as a csv file
        /// </summary>
        /// <param name="self"></param>
        /// <param name="fileName"></param>
        public static void SaveAsCSV(this DataTable self, string fileName)
        {
            var txt = self.AsCSVText();
            var f = System.IO.File.CreateText(fileName);
            f.Write(txt);
            f.Close();
        }

        public static void SaveAsCSV(this DataTable self)
        {
            var filename = string.Format("{0}.csv", self.TableName);
            self.SaveAsCSV(filename);
        }

        public static DataTable TransformType<T, U>(this DataTable self, Func<T, U> f)
        {
            var colNames = self.Columns.ToIEnumerable().Select(dc => dc.ColumnName);
            foreach(var c in colNames) 
            {
                if (self.Columns[c].DataType == typeof(T))
                {
                    self = self.ReplaceColumn(c,
                        dc =>
                        {
                            return new DataColumn[] { new DataColumn(dc.ColumnName, typeof(U)) };
                        }, o =>
                        {
                            return new object[] { f((T)o) };
                        });
                }
            }

            return self;
        }

        /// <summary>
        /// A map operator across all cells in a datatable
        /// </summary>
        /// <typeparam name="InType"></typeparam>
        /// <typeparam name="OutType"></typeparam>
        /// <param name="self"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static DataTable SelectCells<InType, OutType>(this DataTable self, Func<InType, OutType> selector)
            where InType : class
        {
            self = self.Copy();

            foreach (DataRow row in self.Rows)
                foreach (DataColumn col in self.Columns)
                    row[col] = selector(row[col] as InType);

            return self;
        }

        /*
        public static DataTable InsertRows<T>(this DataTable self, int firstRow, IEnumerable<IEnumerable<T>> items, bool overwriteFirstRow)
        {
            // write to a new dt
            self = self.Copy();

            foreach (var itmRow in items)
            {
                var row = self.NewRow();
                foreach(var i in items.
                self.Rows.InsertAt(row, firstRow++);
            }
        }
         * */

        /// <summary>
        /// Applies the dictionary of replacements to each cell, uses string template
        /// </summary>
        /// <param name="self"></param>
        /// <param name="replacements"></param>
        /// <returns></returns>
        public static DataTable ReplaceTemplateParams(this DataTable self, IDictionary<string, object> replacements)
        {

            /// keep track of the last index taken out, because this is a reference value
            /// it is effectivly shared across calls to the closure before, allowing incremental
            /// changes
            var value_arrays = new Dictionary<string, int>();

            return self.SelectCells<string, object>(cell =>
            {
                var tmplt = new StringTemplate(cell);
                foreach (var k in replacements.Keys)
                {
                    var repType = replacements[k].GetType();

                    if (repType.IsArray)
                    {
                        if (!value_arrays.ContainsKey(k)) // hasn't been seen yet
                        {
                            value_arrays[k] = 0;
                        }
                        else // has been seen
                        {
                            value_arrays[k] += 1;
                        }

                        var values = replacements[k] as Array;
                        Validity.IsNotNull(values);

                        if (values.Length <= value_arrays[k])
                            continue; // we don't have enough values, so don't set it

                        tmplt.SetAttribute(k, values.GetValue(value_arrays[k]));
                    }
                    else // it is not an array
                    {
                        tmplt.SetAttribute(k, replacements[k]);
                    }
                }

                return tmplt.ToString();
            });
        }

        /// <summary>
        /// Create a new datatable that consists of all the columns from both tables
        /// if column names are repeated they will be labled name, name_1, name_2, etc.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="other"></param>
        /// <returns>A datatable with all the columns</returns>
        public static DataTable ColumnMerge(this DataTable self, DataTable other)
        {
            // merge the actual columns, if column names are repeated they will be labled name, name_1, name_2, etc.
            if (self.Rows.Count != other.Rows.Count)
                throw new DataTableAlgebraException("A Column Merge between 2 data tables requires " + 
                    "that both tables have the same count of rows");

            var result_dt = new DataTable();
            foreach (DataColumn c in self.Columns)
            {
                result_dt.Columns.Add(c.ColumnName);
            }

            foreach (DataColumn col in other.Columns)
            {
                var column_name = col.ColumnName;

                if (result_dt.Columns.Contains(column_name))
                {
                    int i = 1;

                    while (result_dt.Columns.Contains(string.Format("{0}_{1}", column_name, i)))
                        i++;

                    column_name = string.Format("{0}_{1}", column_name, i);
                }

                result_dt.Columns.Add(column_name);
            }

            foreach (int i in FunctionalOperators.Range(self.Rows.Count))
            {
                var r = result_dt.NewRow();

                foreach (int j in FunctionalOperators.Range(self.Columns.Count))
                    r[j] = self.Rows[i][j];

                foreach (int j in FunctionalOperators.Range(other.Columns.Count))
                    r[j + self.Columns.Count] = other.Rows[i][j];

                result_dt.Rows.Add(r);
            }

            return result_dt;
        }

        /// <summary>
        /// Create a new datatable that consists of all the columns from all tables
        /// if column names are repeated they will be labled name, name_1, name_2, etc.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="other"></param>
        /// <returns>A datatable with all the columns</returns>
        public static DataTable ColumnMerge(this DataTable self, DataTable a, DataTable b, params DataTable[] rest)
        {
            var dt = self.ColumnMerge(a).ColumnMerge(b);

            foreach (var r in rest)
            {
                dt = dt.ColumnMerge(r);
            }

            return dt;
        }

        /// <summary>
        /// populate object fields from a datarow this is stateful in the sense that
        /// self is directly manipulated instead of copied
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <param name="row"></param>
        public static void LoadFieldsFromDataRow<T>(this T self, DataRow row)
        {
            self.LoadFieldsFromDataRow(row);
        }

        /// <summary>
        /// populate an object of type T with the data from a datarow, assuming that
        /// column names and field names match.  This is stateful in the sense that
        /// the row is updated directly instead of copied
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <param name="item"></param>
        public static void Load<T>(this DataRow row, T item)
        {
            var type = typeof(T);

            var mis = from mi in type.GetMembers()
                      from column in row.Table.Columns.ToIEnumerable()
                      from name in new string[] { column.ColumnName }
                      where column.ColumnName == name
                      select mi;

            foreach (var mi in mis)
            {
                if (mi.MemberType == MemberTypes.Field)
                {
                    var fi = (FieldInfo)mi;
                    row[mi.Name] = fi.GetValue(item);
                }
                else if (mi.MemberType == MemberTypes.Property)
                {
                    var pi = (PropertyInfo)mi;
                    row[mi.Name] = pi.GetValue(item, null);
                }
                else
                {
                    // throw new NotImplementedException("Cannot load membertype " + mi.MemberType.ToString());
                }
            }
        }

        /// <summary>
        /// Creates a datatable from a collection of objects:T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <param name="DataTableName"></param>
        /// <param name="lifter"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> lst, string DataTableName, Func<T, DataTable, DataRow> lifter)
        {
            var type = typeof(T);
            var _columns = from mi in type.GetMembers()
                           from mtype in new MemberTypes[] { mi.MemberType }
                           where new MemberTypes[] { MemberTypes.Field, MemberTypes.Property }.Contains(mtype)
                           select mi;

            _columns = _columns.Sort((m1, m2) => m1.GetColumnOrder() > m2.GetColumnOrder() ? 1 :
                    m1.GetColumnOrder() < m2.GetColumnOrder() ? -1 : 0);

            var columns = _columns.Select(c =>
            {
                if (c is PropertyInfo)
                {
                    var pi = c as PropertyInfo;
                    return new Tuple<Type, string>(pi.PropertyType, pi.Name);
                }
                else if (c is FieldInfo)
                {
                    var fi = c as FieldInfo;
                    return new Tuple<Type, string>(fi.FieldType, fi.Name);
                }
                else
                {
                    throw new NotImplementedException("Code should never reach here");
                }
            });
                          

            var dt = new DataTable(DataTableName);

            foreach (var c in columns) { dt.Columns.Add(new DataColumn(c.Second, c.First)); }
            foreach (var t in lst) { dt.Rows.Add(lifter(t, dt)); }

            return dt;
        }

        /// <summary>
        /// creates a datatable from a collection of objects:T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <param name="DataTableName"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> lst, string DataTableName)
        {
            Func<T, DataTable, DataRow> default_lifter = (t, dt) =>
            {
                var type = typeof(T);
                var row = dt.NewRow();
                row.Load(t);
                return row;
            };

            return lst.ToDataTable(DataTableName, default_lifter);
        }


        /// <summary>
        /// turn a datatable into a list of objects:T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tbl"></param>
        /// <returns></returns>
        public static IEnumerable<T> LoadFields<T>(this DataTable tbl)
            where T: new()
        {
            return LoadFields<T>(tbl, dont_care => true);
        }

        /// <summary>
        /// turn a datatable into a list of objects:T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tbl"></param>
        /// <param name="use_filter"></param>
        /// <returns></returns>
        public static IEnumerable<T> LoadFields<T>(this DataTable tbl, Func<FieldInfo, bool> use_filter)
            where T: new()
        {
            foreach (DataRow row in tbl.Rows)
            {
                var transformed_row = new T();
                transformed_row.LoadFieldsFromDataRow(row);
                yield return transformed_row;
            }
        }

        /// <summary>
        /// create a list of datacolumns that actually implements IEnumerable&lt;DataColumn&rt;
        /// </summary>
        /// <param name="dcc"></param>
        /// <returns></returns>
        public static IEnumerable<DataColumn> ToIEnumerable(this DataColumnCollection dcc)
        {
            foreach (DataColumn c in dcc)
                yield return c;
        }


        /// <summary>
        /// creates a list of datarows that actually implements IEnumerable&lt;DataRow&gt;
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public static IEnumerable<DataRow> ToIEnumerable(this DataRowCollection rows)
        {
            foreach (DataRow r in rows)
                yield return r;
        }

        /// <summary>
        /// create a list of objects:T from the rows in a datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tbl"></param>
        /// <param name="fn">A function to turn a data row into an object:T</param>
        /// <returns></returns>
        public static IEnumerable<T> ToIEnumerable<T>(this DataTable tbl, Func<DataRow, T> fn)
            where T: new()
        {
            foreach (var row in tbl.Rows.ToIEnumerable())
                yield return fn(row);
        }

        /// <summary>
        /// create a list of objects:T from the rows in a datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tbl"></param>
        /// <returns></returns>
        public static IEnumerable<T> ToIEnumerable<T>(this DataTable tbl)
            where T : new()
        {
            return tbl.ToIEnumerable<T>(DefaultToIEnumerableFn<T>);
        }

        private static T DefaultToIEnumerableFn<T>(DataRow row)
            where T: new()
        {
            var self = new T();
            self.LoadFieldsFromDataRow(row);
            return self;
        }

        /// <summary>
        /// create a new datatable with new column names
        /// </summary>
        /// <param name="self"></param>
        /// <param name="f">function/lambda_expression that takes a DataColumn and returns a string</param>
        /// <returns>a copy of the datatable with modified column names</returns>
        public static DataTable ChangeColumnNames(this DataTable self, Func<DataColumn, string> f)
        {
            self = self.Copy();

            foreach (DataColumn c in self.Columns)
                c.ColumnName = f(c);

            return self;
        }

        /// <summary>
        /// create a new datatable that includes copies of the listed columns
        /// </summary>
        /// <param name="self"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static DataTable CopyColumns(this DataTable self, params string[] columns)
        {
            self = self.Copy();
            foreach (DataColumn dc in self.Columns)
                if (!columns.Contains(dc.ColumnName))
                    self = self.RemoveColumn(dc.ColumnName);

            return self;
        }

        public static IEnumerable<object> ToIEnumerable(this DataRow self)
        {
            foreach (var c in self.Table.Columns.ToIEnumerable())
                yield return self[c];
        }

        /// <summary>
        /// replace multiple columns at once, this can be use to remove them as well
        /// </summary>
        /// <param name="self"></param>
        /// <param name="ColumnChangeFn">function that returns a list of columns to replace the input</param>
        /// <param name="DataChangeFn">function that returns a list of data items to replace the input, must be the same length as the num columns returned</param>
        /// <returns></returns>
        public static DataTable ReplaceColumns(this DataTable self, 
            Func<DataColumn, IEnumerable<DataColumn>> ColumnChangeFn, 
            Func<object, IEnumerable<object>> DataChangeFn)
        {
            // gives us all the new values, tied to the correct column
            var data = from dc in self.Columns.ToIEnumerable()
                       from newcols in new IEnumerable<DataColumn>[] { ColumnChangeFn(dc) }
                       from rows in new IEnumerable<DataRow>[] { self.Rows.ToIEnumerable() }
                       from newobjs in rows.Select(r => DataChangeFn(r[dc]))
                       select newcols.Select(c => c.ColumnName).Zip(newobjs);

            var flat_data = data.Flatten();

            // find the total amount of rows and columns
            var cols = flat_data.Select(t => t.First).Uniq();
            Validity.Validate(flat_data.Count() % cols.Count() == 0);
            var rowcount = flat_data.Count() / cols.Count();

            // build the table structure
            var table = new DataTable(self.TableName);
            foreach (var c in cols) { table.Columns.Add(c); }
            foreach (var i in FunctionalOperators.Range(rowcount))
            {
                var row = table.NewRow();
                table.Rows.Add(row);
            }

            // populate the table, order has been preserved, so we don't have to do anything
            // hard
            foreach (var c in cols)
            {
                // zip up the values and their row index
                var flat_items = flat_data.Where(tup => tup.First == c).Select(tup => tup.Second).Zip(FunctionalOperators.CountFrom(0));

                // not much left, just push the data in
                foreach (var i in flat_items)
                {
                    table.Rows[i.Second][c] = i.First;
                }
            }

            return table;
        }

        /// <summary>
        /// Replace one column with zero, one, or many new columns
        /// </summary>
        /// <param name="self"></param>
        /// <param name="ColumnName"></param>
        /// <param name="ColumnChangeFn"></param>
        /// <param name="DataChangeFn"></param>
        /// <returns></returns>
        public static DataTable ReplaceColumn(this DataTable self, string ColumnName, 
            Func<DataColumn, IEnumerable<DataColumn>> ColumnChangeFn
            , Func<object,IEnumerable<object>> DataChangeFn)
        {
            try
            {
                var newdt = new DataTable(self.TableName);

                foreach (var c in self.Columns.ToIEnumerable())
                {
                    if (c.ColumnName != ColumnName)
                    {
                        newdt.Columns.Add(c.ColumnName);
                    }
                    else
                    {
                        var newcols = ColumnChangeFn(c);
                        foreach (var nc in newcols)
                        {
                            newdt.Columns.Add(nc);
                        }
                    }
                }

                foreach (var row in self.Rows.ToIEnumerable())
                {
                    var newrow = newdt.NewRow();
                    var index = 0;
                    foreach (var c in self.Columns.ToIEnumerable())
                    {
                        if (c.ColumnName != ColumnName)
                        {
                            newrow[c.ColumnName] = row[c];
                            index += 1;
                        }
                        else
                        {
                            var newvals = DataChangeFn(row[c]);
                            foreach (var v in newvals)
                            {
                                newrow[index++] = v;
                            }
                        }
                    }

                    newdt.Rows.Add(newrow);
                }

                return newdt;
#if false
                var newdt = self.Copy();

                var old_col = newdt.Columns[ColumnName];
                // newdt = newdt.RemoveColumn(ColumnName);

                var new_columns = ColumnChangeFn(old_col).ToArray();

                foreach (DataColumn dc in new_columns)
                {
                    newdt.Columns.Add(dc);
                }

                foreach (DataRow row in newdt.Rows)
                {
                    var new_values = DataChangeFn(row[old_col]).ToArray();

                    if (new_values.Count() != new_columns.Count())
                        throw new DataTableAlgebraException("New columns and new datapoints need to have the same length");

                    for (var i = 0; i < new_columns.Count(); i++)
                    {
                        var col = new_columns[i];
                        row[col] = new_values[i];
                    }
                }

                // using RemoveColumn causes an infinite loop because RemoveColumn uses ReplaceColumn
                // newdt = newdt.RemoveColumn(ColumnName);
                newdt.Columns.Remove(ColumnName);
                
                return newdt;
#endif
            }
            catch (Exception ex)
            {
                throw new DataTableAlgebraException(ex);
            }
        }

        /// <summary>
        /// This is the equivelant of ReplaceColumn that creates 0 new columns
        /// </summary>
        /// <param name="self"></param>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
        public static DataTable RemoveColumn(this DataTable self, string ColumnName)
        {
            var newdt = self.ReplaceColumn(ColumnName, c => new DataColumn[] { }, c => new object[] { });
            return newdt;
        }

        /// <summary>
        /// Send a datatable to a database via insert statements
        /// </summary>
        /// <param name="self"></param>
        /// <param name="table_name"></param>
        /// <param name="quote_column_names"></param>
        /// <param name="get_value"></param>
        public static IEnumerable<string> DataTableSqlInsertText(
            this DataTable self,
            string table_name,
            bool quote_column_names,
            Func<DataColumn, DataRow, string> get_value)
        {
            var dt = self.Copy(); // self should not be referenced again
            var columns = dt.Columns.ToIEnumerable();

            var names = columns
                .Select(dc => dc.ColumnName)
                .Select(name =>
                {
                    if (name.Split().Length > 1 && !quote_column_names)
                        throw new DataTableAlgebraException(@"column '{0}' cannot be used with out quoting column names", name);

                    return quote_column_names ? "\"" + name + "\"" : name;
                });

            var statements = new List<string>();

            foreach (var row in self.Rows.ToIEnumerable())
            {
                // fields are populated by the user input function
                var fields = new List<string>();
                foreach (var dc in self.Columns.ToIEnumerable())
                {
                    fields.Add(get_value(dc, row));
                }

                var sql = string.Format("insert into \"{0}\" ({1}) values ({2})"
                    , table_name, string.Join(",", names.ToArray()),
                    string.Join(",", fields.Select(f => f == null ? "NULL" : string.Format("'{0}'", ((UnsafeString)f).getSanitizedSqlValue())).ToArray()));

                yield return sql;
            }
        }

         /// <summary>
        /// Send a datatable to a database via insert statements
        /// </summary>
        /// <param name="self"></param>
        /// <param name="dbcon"></param>
        /// <param name="table_name"></param>
        /// <param name="quote_column_names"></param>
        /// <param name="get_value"></param>
        public static void DataTableSqlInsert(
            this DataTable self,
            IDbConnection dbcon,
            string table_name,
            bool quote_column_names,
            Func<DataColumn, DataRow, string> get_value)
        {
            var dt = self.Copy(); // self should not be referenced again
            var columns = dt.Columns.ToIEnumerable();

            var names = columns
                .Select(dc => dc.ColumnName)
                .Select(name =>
                {
                    if (name.Split().Length > 1 && !quote_column_names)
                        throw new DataTableAlgebraException(@"column '{0}' cannot be used with out quoting column names", name);

                    return quote_column_names ? "\"" + name + "\"" : name;
                });

            using (var cmd = dbcon.CreateCommand())
            {
                foreach (var row in self.Rows.ToIEnumerable())
                {
                    // fields are populated by the user input function
                    var fields = new List<string>();
                    foreach (var dc in self.Columns.ToIEnumerable())
                    {
                        fields.Add(get_value(dc, row));
                    }

                    var sql = string.Format("insert into {0} ({1}) values ({2})"
                        , table_name, string.Join(",", names.ToArray()),
                        string.Join(",", fields.Select(f => string.Format("'{0}'", f)).ToArray()));

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// Send a datatable to a database via insert statements
        /// </summary>
        /// <param name="self"></param>
        /// <param name="dbcon"></param>
        /// <param name="table_name"></param>
        /// <param name="quote_column_names"></param>
        public static void DataTableSqlInsert(
            this DataTable self
            , IDbConnection dbcon
            , string table_name
            , bool quote_column_names
            )
        {
            self.DataTableSqlInsert(dbcon, table_name, quote_column_names, (dc, dr) => dr[dc].ToString());
        }

        /// <summary>
        /// Send a datatable to a database via insert statements
        /// </summary>
        /// <param name="self"></param>
        /// <param name="dbcon"></param>
        /// <param name="table_name"></param>
        public static void DataTableSqlInsert(
            this DataTable self
            , IDbConnection dbcon
            , string table_name
            )
        {
            self.DataTableSqlInsert(dbcon, table_name, true);
        }

        /// <summary>
        /// Send a datatable to a database via insert statements
        /// </summary>
        /// <param name="self"></param>
        /// <param name="dbcon"></param>
        public static void DataTableSqlInsert(
            this DataTable self
            , IDbConnection dbcon
            )
        {
            self.DataTableSqlInsert(dbcon, self.TableName);
        }

        /// <summary>
        /// Create a new datatable with the addition of a new column and data for that column
        /// </summary>
        /// <param name="self"></param>
        /// <param name="column_name"></param>
        /// <param name="fn"></param>
        public static DataTable AddColumnWithData(this DataTable self, string column_name, Func<DataRow, object> fn)
        {
            self = self.Copy();

            // used as state in loop
            var colvals = new List<object>();

            foreach (DataRow r in self.Rows)
            {
                colvals.Add(fn(r));
            }

            var colvals_array = colvals.ToArray();

            self.Columns.Add(column_name);
            for(var i = 0; i < colvals.Count; i++)
            {
                self.Rows[i][column_name] = colvals_array[i];
            }

            return self;
        }

        public static DataTable AddColumnWithData<T>(this DataTable self, string column_name, IEnumerable<T> data)
        {
            self = self.Copy();

            self.Columns.Add(column_name);
            
            var i = 0;
            foreach (var d in data)
            {
                if (self.Rows.Count <= i)
                {
                    self.Rows.Add(self.NewRow());
                }

                self.Rows[i++][column_name] = d;
            }

            return self;
        }

        /// <summary>
        /// Similar to the function ZipWith for IEnumerable, except it is 2d
        /// This is a generalization of Zip
        /// 
        /// Both datatables must have the same amount of columns and rows
        /// </summary>
        /// <param name="self"></param>
        /// <param name="other"></param>
        /// <param name="zipFn"></param>
        /// <returns></returns>
        public static DataTable ZipWith(this DataTable self, DataTable other, Func<object, object, object> zipFn)
        {
            if (self.Columns.Count != other.Columns.Count)
                throw new DataTableAlgebraException("datatables must have the same numer of columns to zip");

            if (self.Rows.Count != other.Rows.Count)
                throw new DataTableAlgebraException("datatables must have the same number of rows to zip");

            var newdt = self.Copy();

            for (var i = 0; i < self.Rows.Count; i++)
            {
                for (var j = 0; j < self.Columns.Count; j++)
                {
                    newdt.Rows[j][i] = zipFn(self, other);
                }
            }

            return newdt;
        }


        /// <summary>
        /// similar to the function Zip for IEnumerable, except it is 2d
        /// 
        /// Both datatables must have the same amount of columns and rows
        /// </summary>
        /// <param name="self"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static DataTable Zip(this DataTable self, DataTable other)
        {
            return self.ZipWith(other, (object a, object b) => new Tuple<object, object>(a, b));
        }

        /// <summary>
        /// add a column for integer keys, and automatically fill it
        /// </summary>
        /// <param name="self"></param>
        /// <param name="keyColumnName"></param>
        /// <returns></returns>
        public static DataTable AddKeyColumn(this DataTable self, string keyColumnName)
        {
            Validity.IsNotNull(keyColumnName);
            var keygenRef = new ReferenceWrap<int>(1);

            return self.AddColumnWithData(keyColumnName, row =>
            {
                return keygenRef.Value++;
            });
        }

        /// <summary>
        /// split a datatable into multiple datatables and add a relation column to each one
        /// </summary>
        /// <param name="self">the datatable to split</param>
        /// <param name="relateColumnName">the name of the *new* column used for relation, if this is null no column will be generated</param>
        /// <param name="splitter">function that returns the name of the datatable given a datacolumn</param>
        /// <returns></returns>
        public static Dictionary<string,DataTable> Split(this DataTable self, string relateColumnName, Func<DataColumn, string> splitter)
        {
            var colmap = new Dictionary<string, List<string>>();

            foreach (var dc in self.Columns.ToIEnumerable())
            {
                var dest = splitter(dc);

                if (!colmap.ContainsKey(dest))
                    colmap.Add(dest, new List<string>());

                colmap[dest].Add(dc.ColumnName);
            }

            var result = new Dictionary<string, DataTable>();

            foreach (var dtname in colmap.Keys)
            {
                result.Add(dtname, self.CopyColumns(colmap[dtname].ToArray()));
                
                if(relateColumnName != null)
                    result[dtname] = result[dtname].AddKeyColumn(relateColumnName);
            }

            return result;
        }

        public static IEnumerable<T> ToIEnumerable<T>(this DataRow self)
            where T: class
        {
            var result = new List<T>();
            
            foreach(var item in self.ItemArray)
            {
                var casted_value = item as T;
                Validity.Assert(casted_value != null, "Could not cast {0}:{1} to type {2}", item, item.GetType(), typeof(T));
                yield return casted_value;
            }
        }

        /// <summary>
        /// "Flip" a datatable, making the columns rows and rows columns
        /// </summary>
        /// <param name="self"></param>
        /// <param name="headerColumnName">
        /// name of the column to use for the current column names, if null
        /// then the column names won't be included in the new rows
        /// </param>
        /// <param name="columnNameGenerator">
        /// a function that takes a current datarow and returns a new column name for that row
        /// </param>
        /// <returns></returns>
        public static DataTable Flip(this DataTable self, string headerColumnName, Func<DataRow, string> columnNameGenerator)
        {
            var result = new DataTable();

            if (headerColumnName != null)
            {
                result = result.AddColumnWithData(headerColumnName, self.Columns.ToIEnumerable().Select(c => c.ColumnName));
            }

            foreach (var row in self.Rows.ToIEnumerable())
            {
                result = result.AddColumnWithData(columnNameGenerator(row), row.ToIEnumerable<object>());
            }

            return result;
        }

        /// <summary>
        /// "Flip" a datatable, making the columns rows and rows columns
        /// columns will be named [headerColumnName,Column_1,Column_2,Column_3,...]
        /// </summary>
        /// <param name="self"></param>
        /// <param name="headerColumnName">
        /// the name of the column to use for the current column headers
        /// if this is null, then no column will be created for the headers
        /// </param>
        /// <returns></returns>
        public static DataTable Flip(this DataTable self, string headerColumnName)
        {
            var colNum = new ReferenceWrap<int>(1);
            return self.Flip(headerColumnName, r => string.Format("Column_{0}", colNum.Value++));
        }

        /// <summary>
        /// "Flip" a datatable, making the columns rows and rows columns
        /// the current column names will not be used at all and the new columns
        /// will be named [Column_1,Column_2,Column_3,...]
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static DataTable Flip(this DataTable self)
        {
            return self.Flip(null);
        }

        public static DataTable Pivot(this DataTable self, string index_column, string header_column, string row_column)
        {
            var rv = new DataTable(self.TableName);
            rv.Columns.Add(index_column);

            var index_ordinals = new Dictionary<object, int>();
            var last_ordinal = 0;

            foreach (var col in self.Rows.ToIEnumerable().Select(r => r[header_column].ToString()).Uniq())
            {

                rv.Columns.Add(col);
            }

            foreach (var r in self.Rows.ToIEnumerable())
            {
                if (!index_ordinals.ContainsKey(r[index_column]))
                {
                    index_ordinals[r[index_column]] = last_ordinal++;
                    var row = rv.NewRow();
                    row[index_column] = r[index_column];
                    rv.Rows.Add(row);
                }
            }

            foreach (var r in self.Rows.ToIEnumerable())
            {
                //var rows = rv.Rows[index_ordinals[r[index_column]]];
                rv.Rows[index_ordinals[r[index_column]]][r[header_column].ToString()] = r[row_column];
            }

            return rv;
        }

        public static DataTable Where(this DataTable self, Func<DataRow, bool> pred)
        {
            var dt = new DataTable(self.TableName);

            foreach (var c in self.Columns.ToIEnumerable())
            {
                dt.Columns.Add(c.ColumnName);
            }

            foreach (var row in self.Rows.ToIEnumerable())
            {
                if (!pred(row))
                    continue;

                var newrow = dt.NewRow();
                foreach (var c in self.Columns.ToIEnumerable())
                {
                    newrow[c.Ordinal] = row[c];
                }
                dt.Rows.Add(newrow);
            }

            return dt;
        }

        /// <summary>
        /// extract out a dictionary of rows using a specified column as the key
        /// </summary>
        /// <param name="self"></param>
        /// <param name="keyColumnName"></param>
        /// <returns></returns>
        public static Dictionary<string, DataRow> Extract(this DataTable self, string keyColumnName)
        {
            try
            {
                Validity.Assert(self.Columns.Contains(keyColumnName), "key column {0} does not exist", keyColumnName);

                var result = new Dictionary<string, DataRow>();

                foreach (var row in self.Rows.ToIEnumerable())
                {
                    var k = row[keyColumnName].ToString();
                    if (result.ContainsKey(k))
                        throw new DataTableAlgebraException("Key column must be all unique values, {0} is repeated", k);

                    result.Add(k, row);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new DataTableAlgebraException(ex, "Could not extract dictionaries from the datatable");
            }
        }

        public static DataTable BuildDataTable(string datatableName, params DataColumn[] columns)
        {
            Validity.Assert(columns.Length > 0, "Must provide at least one column");

            var dt = new DataTable(datatableName);

            foreach (var c in columns)
            {
                dt.Columns.Add(c);
            }

            return dt;
        }

        public static DataTable BuildDataTable(string dataTableName, params string[] columns)
        {
            Validity.Assert(columns.Length > 0, "Must provide at least one column");

            var dt = new DataTable(dataTableName);
            foreach (var c in columns)
            {
                dt.Columns.Add(c);
            }

            return dt;
        }
    }
}
