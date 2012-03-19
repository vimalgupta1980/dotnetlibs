using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

using SysconCommon.Foxpro;
using SysconCommon;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Algebras.DataTables.Excel.VSTO
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Syscon.Excel")]
    [Guid("3C36A739-3835-4881-9A5F-9762812D840A")]
    public class ExcelCOMMethods
    {
        public void LoadDbfToExcel(COMMethods mbapi, string dbfname, string template, string sheetName, string namedRange)
        {
            mbapi.smartGetSMBDir();

            using(var con = Connections.GetOLEDBConnection()) 
            {
                var dbfdata = con.GetDataTable("dbfdata", "select * from {0}", dbfname.FoxproQuote());
                dbfdata.ConfigurableWriteToExcel(template, sheetName, namedRange);
                con.Close();
                // ExcelAddinUtil.app.Visible = true;
            }
        }

        public void SetNamedRangeHeight(string workbook, string worksheet, string namedRange, int rowCount)
        {
            ExcelAddinUtil.SetNamedRangeRowCount(workbook, worksheet, namedRange, rowCount);
        }

        public void UseNewApp()
        {
            ExcelAddinUtil.UseNewApp();
        }

        public void SetVisibility(bool visibile)
        {
            ExcelAddinUtil.app.Visible = true;
        }

        public void RunMacro(string macroName)
        {
            ExcelAddinUtil.app.Run(macroName);
        }
    }
}
