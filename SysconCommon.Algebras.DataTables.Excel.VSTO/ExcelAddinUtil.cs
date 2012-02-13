// This file helps interface with Excel via datatables and hiding
// the fucked up VSTO API.  It only helps with data importing and outputing.
// Any styling will need to be done another way, but this *can* open
// templates, and that is the suggested form of styling.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.IO;
// using System.Windows.Forms;

using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Common.Validity;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Foxpro;

namespace SysconCommon.Algebras.DataTables.Excel.VSTO
{
    public static class ExcelAddinUtil
    {
        static private Application _app = null;
        static public Application app
        {
            get
            {
                if (_app == null)
                    _app = new Application();
                return _app;
            }
        }

        static private Workbook openWorkbook(string fileName)
        {
            if (workbooks.ContainsKey(fileName))
                return workbooks[fileName];

            Workbook rv = app.Workbooks.Open(fileName, ReadOnly: ReadOnly);
            workbooks.Add(fileName, rv);
            return rv;
        }

        static private Dictionary<string, Workbook> workbooks = new Dictionary<string, Workbook>();

        static public void RunMacro(params object[] oRunArgs)
        {
            app.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, app, oRunArgs);
        }

        static public Workbook getWorkbook(string template)
        {
            if (template == null)
            {
                return app.Workbooks.Add(Type.Missing);
            }

            if (workbooks.ContainsKey(template))
                return workbooks[template];

            if (!File.Exists(template))
            {
                throw new SysconException("Workbook " + template + " does not exist");
           } 

            workbooks.Add(template, app.Workbooks.Add(template));
            return workbooks[template];
        }

        static public Worksheet getWorksheet(this Workbook wb, string sheetname)
        {
            foreach (var i in FunctionalOperators.Range(wb.Worksheets.Count))
            {
                Worksheet ws = wb.Worksheets[i + 1];
                if (ws.Name == sheetname)
                    return ws;
            }

            var missing = System.Reflection.Missing.Value;
            wb.Worksheets.Add(missing, missing, missing, missing);
            wb.ActiveSheet.Name = sheetname;
            return wb.ActiveSheet;
        }

        public static Application WriteScalarToExcel<T>(this T self, string template, string worksheet, string namedrange)
        {
            var tmpdt = new System.Data.DataTable();
            tmpdt.Columns.Add("Value");
            var tmprow = tmpdt.NewRow();
            tmprow["Value"] = self;
            tmpdt.Rows.Add(tmprow);
            return tmpdt.WriteToExcel(template, worksheet, namedrange);
        }

        public static System.Data.DataTable GetNamedRangeData(string filename, string worksheet_name, string named_range_name, bool includes_headers = false)
        {
            var wb = openWorkbook(filename);
            var ws = getWorksheet(wb, worksheet_name);
            Range rng = ws.get_Range(named_range_name);
            object[,] val = rng.get_Value();

            var dt = new System.Data.DataTable(named_range_name);

            Func<int, Type> GuessColumnType = (colnum) =>
            {
                var rows = val.GetLength(0) - (includes_headers ? 1 : 0);
                // only check the first hundred rows, for speed purposes
                if (rows > 100)
                {
                    rows = 100;
                }

                var is_decimal = true;
                for (var i = (includes_headers ? 1 : 0); i < rows; i++)
                {
                    var value = val[i + 1, colnum];
                    try
                    {
                        if (value == null || value.ToString() == "")
                            continue;

                        Convert.ToDecimal(value);
                    }
                    catch
                    {
                        is_decimal = false;
                        break;
                    }
                }

                return is_decimal ? typeof(decimal) : typeof(string);
            };

            var column_types = new Type[val.GetLength(1)];
            for (int i = 1; i < val.GetLength(1) + 1; i++)
            {
                column_types[i - 1] = GuessColumnType(i);
            }

            if (!includes_headers)
            {
                for (var i = 1; i < val.GetLength(1) + 1; i++)
                {
                    dt.Columns.Add("Column" + i.ToString(), column_types[i - 1]);
                }
            }
            else
            {
                for (var i = 1; i < val.GetLength(1) + 1; i++)
                {
                    dt.Columns.Add(val[1, i].ToString(), column_types[i - 1]);
                }
            }

            for (var r = includes_headers ? 2 : 1; r < val.GetLength(0) + 1; r++)
            {
                var row = dt.NewRow();
                for (var c = 1; c < val.GetLength(1) + 1; c++)
                {
                    if (val[r,c] == null || val[r, c].ToString() == "")
                    {
                        row[c - 1] = Activator.CreateInstance(column_types[c - 1]);
                    }
                    else
                    {
                        row[c - 1] = Convert.ChangeType(val[r, c], column_types[c - 1]);
                    }
                }

                dt.Rows.Add(row);
            }

            return dt;

            // throw new NotImplementedException();
        }

        public static Application ClearNamedRange(string filename, string worksheet_name, string named_range_name)
        {
            // var wb = openWorkbook(filename);
            var wb = getWorkbook(filename);
            var ws = getWorksheet(wb, worksheet_name);
            Range r = ws.get_Range(named_range_name);
            r.Clear();
            return _app;
        }

        public static Application ConfigurableWriteToExcel(this System.Data.DataTable self, string template, string worksheet, string namedrange, string clear_worksheet = null, string clear_named_range = null)
        {
            // var config_dt = GetNamedRangeData(template, worksheet, namedrange);
            // var dest_column_names = (from c in config_dt.Columns.ToIEnumerable()
            //                         select config_dt.Rows[0][c].ToString()).ToArray();

            var wb = getWorkbook(template);
            var ws = wb.getWorksheet(worksheet);
            Range r = ws.get_Range(namedrange);
            if (r.Rows.Count < 1)
                throw new SysconException("Named Range has no rows");

            if (r.Columns.Count < 1)
                throw new SysconException("Named range has no columns");

            List<string> dest_column_names = new List<string>();

            var empty = 0;

            for(var i = 1; i <= r.Columns.Count; i++)
            {
                if (r[1, i].Text.Trim() == "")
                {
                    dest_column_names.Add(string.Format("__empty_{0}", empty++));
                }
                else
                {
                    dest_column_names.Add(r[1, i].Text.Trim());
                }
            }

            // var dest_column_names = _dest_column_names.ToArray();

            var all_column_names = (from c in self.Columns.ToIEnumerable()
                                    select c.ColumnName).ToArray();

            // we are going to manipulate self, so make a copy
            self = self.Copy();

            // remove the columns we don't want
            foreach (var c in all_column_names)
            {
                if (!dest_column_names.Contains(c))
                {
                    self = self.RemoveColumn(c);
                }
            }

            // re-order the columns we do want
            foreach (var i in FunctionalOperators.Range(dest_column_names.Count()))
            {
                if (!self.Columns.Exists(dest_column_names[i]))
                {
                    self = self.AddColumnWithData(dest_column_names[i], (dr) => "");
                }

                self.Columns[dest_column_names[i]].SetOrdinal(i);
            }

            return self.WriteToExcel(template, worksheet, namedrange, clear_worksheet, clear_named_range);
        }

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, string namedrange)
        {
            return self.WriteToExcel(template, worksheet, namedrange, null, null);
        }

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, string namedrange, string clear_worksheet, string clear_named_range)
        {
            return self.WriteToExcel(template, worksheet, namedrange, clear_worksheet, clear_named_range, false);
        }

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, string namedrange, string clear_worksheet, string clear_named_range, bool write_headers)
        {
            var wb = getWorkbook(template);
            var ws = getWorksheet(wb, worksheet);

            Range r = ws.get_Range(namedrange, System.Reflection.Missing.Value);
            if (r.Columns.Count < self.Columns.Count)
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Named Range {0} does not contain enough columns", namedrange));
                return app;
            }
            if (r.Rows.Count < self.Rows.Count)
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Named Range {0} does not contain enough rows", namedrange));
                return app;
            }

            // writing to the named range directly fills empty cells with #N/A, we don't want that
            var rv = self.WriteToExcel(template, worksheet, r.Row - 1, r.Column - 1, write_headers);

            if (clear_named_range != null && clear_worksheet != null)
            {
                // hide unused rows in clear_named_range
                var cws = wb.getWorksheet(clear_worksheet);
                Range cr = cws.get_Range(clear_named_range, System.Reflection.Missing.Value);

                var used_row_count = self.Rows.Count;

                // var hide_range = cr.Rows.get_Range(string.Format("{0}:{1}", used_row_count + 1, cr.Rows.Count));
                Range c1 = cr.Cells[used_row_count + 1, 1];
                Range c2 = cr.Cells[cr.Rows.Count, 1];
                Range hide_range = cws.get_Range(c1, c2);
                hide_range.Rows.Hidden = true;
            }

            return rv;
        }

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, int top_row, int left_column, bool write_headers)
        {
            var wb = getWorkbook(template);
            var ws = getWorksheet(wb, worksheet);

            var top_diff = top_row + 1;
            var left_diff = left_column;

            var dtarray = self.ToMultiDimArray<object>(write_headers);

            var row_count = self.Rows.Count + (write_headers ? 1 : 0);
            var cell1 = left_diff.ConvertToExcelColumn() + top_diff.ToString();
            var cell2 = (left_diff + self.Columns.Count - 1).ConvertToExcelColumn() + (top_diff + row_count - 1).ToString();

            Range r = ws.get_Range(cell1, cell2);

            r.set_Value(System.Reflection.Missing.Value, dtarray);

            return app;
        }

        private static string ConvertToExcelColumn(this int colnum)
        {
            if (colnum < 26)
            {
                return new string(new char[] { (char)((int)'A' + colnum) });
            }

            var rem = colnum % 26;
            var first = (colnum / 26) - 1;
            return first.ConvertToExcelColumn() + rem.ConvertToExcelColumn();
        }

        public static System.Data.SQLite.SQLiteConnection LoadWorkbookToInMemoryDb(string workbook, bool include_headers)
        {
            var wb = openWorkbook(workbook);
            var con = SysconCommon.Common.Environment.Connections.GetInMemoryDB();
            Dictionary<string, bool> found = new Dictionary<string, bool>();

            foreach (Name name in wb.Names)
            {
                try
                {
                    var dt = GetNamedRangeData(workbook, name.RefersToRange.Worksheet.Name, name.Name, include_headers);
                    con.LoadDataTable(dt);
                    found.Add(name.Name, true);
                }
                catch { }
            }

            foreach(Worksheet ws in wb.Worksheets) 
            {
                foreach (Name name in ws.Names)
                {
                    if (found.ContainsKey(name.Name))
                        continue;

                    try
                    {
                        var dt = GetNamedRangeData(workbook, ws.Name, name.Name, include_headers);
                        con.LoadDataTable(dt);
                        found.Add(name.Name, true);
                    }
                    catch { }
                }
            }

            return con;
        }

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, int top_row, int left_column)
        {
            return self.WriteToExcel(template, worksheet, top_row, left_column, true);
        }

        private static bool ReadOnly = false;

        public static void UseNewApp(bool _readonly=false)
        {
            ReadOnly = _readonly;
            workbooks.Clear();
            _app = null;
        }

        public static void CloseApp(bool saveChanges)
        {
            if (_app == null)
                return;

            foreach (Workbook wb in app.Workbooks)
            {
                if (saveChanges)
                    wb.Save();
                else
                    wb.Saved = true;
            }

            app.Quit();

            UseNewApp(_readonly: false);
        }

        public static string SelectExcelFile(string directory = null)
        {
            bool set_directory = false;
            if (directory == null)
            {
                directory = Env.GetConfigVar("excel_open_directory", Env.GetEXEDirectory(), true);
                set_directory = true;
            }

            var dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.InitialDirectory = directory;
            dlg.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (set_directory)
                {
                    Env.SetConfigVar("excel_open_directory", System.IO.Path.GetDirectoryName(dlg.FileName));
                }

                return dlg.FileName;
            }
            else
            {
                return null;
            }
        }

        public static System.Windows.Forms.DialogResult SelectItemsWithExcelLoadOption(this System.Data.DataTable self, string named_range, string[] index_columns = null, string workbook = null, string selection_column = "selected")
        {
            if (index_columns == null)
            {
                index_columns = new string[] { self.FindUpdateIndex().ColumnName };
            }

            Validity.Assert(named_range != null, "Named Range must be passed");
            Validity.Assert(index_columns.Length >= 1, "Must specify at least one index column");

            System.Data.SQLite.SQLiteConnection con = null;
            bool canceled = false;

            Func<DataRow, bool> loadFunc = (row) =>
            {
                if (workbook == null && canceled == false)
                    workbook = SelectExcelFile();

                if (workbook == null)
                {
                    canceled = true;
                }

                if (canceled)
                {
                    return Convert.ToBoolean(row[selection_column]);
                }

                if (con == null)
                {
                    con = LoadWorkbookToInMemoryDb(workbook, true);
                }

                var where_criteria = new List<string>();
                foreach (var ic in index_columns)
                {
                    where_criteria.Add(string.Format("{0} = {1}", ic, row[ic].FQ()));
                }

                var where_clause = string.Join(" and ", where_criteria.ToArray());

                var count = con.GetScalar<long>("select count(*) from {0} where {1}", named_range, where_clause);
                return count > 0;
            };

            try
            {
                var dlg = new SysconCommon.GUI.SysconSelectionScreen(self, selection_column, false, loadFunc);
                return dlg.ShowDialog();
            }
            finally
            {
                if (con != null)
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Dispose();
                }
            }
        }
    }
}
