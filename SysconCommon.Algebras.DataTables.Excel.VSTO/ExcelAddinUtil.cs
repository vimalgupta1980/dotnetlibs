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
using SysconCommon.Algebras.DataTables;

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
            return app.Workbooks.Open(fileName);
        }

        static private Dictionary<string, Workbook> workbooks = new Dictionary<string, Workbook>();

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

        public static System.Data.DataTable GetNamedRangeData(string filename, string worksheet_name, string named_range_name)
        {
            var wb = openWorkbook(filename);
            var ws = getWorksheet(wb, worksheet_name);
            Range rng = ws.get_Range(named_range_name);
            object[,] val = rng.get_Value();

            var dt = new System.Data.DataTable(named_range_name);
            
            for(var i = 1; i < val.GetLength(1) + 1; i++) {
                dt.Columns.Add("Column" + i.ToString());
            }

            for (var r = 1; r < val.GetLength(0) + 1; r++)
            {
                var row = dt.NewRow();
                for (var c = 1; c < val.GetLength(1) + 1; c++)
                {
                    row[c - 1] = val[r, c];
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

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, int top_row, int left_column)
        {
            return self.WriteToExcel(template, worksheet, top_row, left_column, true);
        }

        public static void UseNewApp()
        {
            workbooks.Clear();
            _app = null;
        }
    }
}
