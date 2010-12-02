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

        static private Dictionary<string, Workbook> workbooks = new Dictionary<string, Workbook>();

        static private Workbook getWorkbook(string template)
        {
            if (workbooks.ContainsKey(template))
                return workbooks[template];

            workbooks.Add(template, app.Workbooks.Add(template));
            return workbooks[template];
        }

        static private Worksheet getWorksheet(Workbook wb, string sheetname)
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

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, string namedrange)
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

            var dtarray = self.ToMultiDimArray<object>(false);
            r.set_Value(System.Reflection.Missing.Value, dtarray);

            return app;
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

            var rem = colnum % 26 - 1;
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
