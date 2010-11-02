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

using SysconCommon.Common;

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

        public static Application WriteToExcel(this System.Data.DataTable self, string template, string worksheet, int top_row, int left_column, bool write_headers)
        {
            // throw new NotImplementedException();
            var wb = getWorkbook(template);
            var ws = getWorksheet(wb, worksheet);

            var top_diff = top_row + 1;
            var left_diff = left_column + 1;

            if (write_headers)
            {
                foreach (var c in self.Columns.ToIEnumerable())
                {
                    ws.Cells[top_diff, c.Ordinal + left_diff].Value = c.ColumnName;
                }

                top_diff += 1;
            }

            foreach (var i in FunctionalOperators.Range(self.Rows.Count))
            {
                foreach (var j in FunctionalOperators.Range(self.Columns.Count))
                {
                    ws.Cells[i + top_diff, j + left_diff].Value = self.Rows[i][j];
                }
            }

            return app;
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
