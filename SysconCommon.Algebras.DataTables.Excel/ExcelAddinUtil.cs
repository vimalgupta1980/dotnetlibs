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

namespace DTSCommon.Algebras.DataTables.Excel.VSTO
{
    public class DataTableExcelVSTOException : Exception
    {
        public DataTableExcelVSTOException()
            : base() { }

        public DataTableExcelVSTOException(string format, params object[] arguments)
            : base(string.Format(format, arguments)) { }

        public DataTableExcelVSTOException(Exception innerException, string format, params object[] arguments)
            : base(string.Format(format, arguments), innerException) { }
    }

    /// <summary>
    /// Defines an isomorphism between data from excel ranges and datatables.
    /// Notice this isomrphism does not hold over style information, so style
    /// is completely ignored.
    /// 
    /// Everything is static because it is just a singleton with a few methods.  
    /// The only state is the reference to the excel app itself,
    /// this will need to be set by the user using Initialize(app) 
    /// before anything else can be done.
    /// 
    /// This class is meant to be used while Excel is open, for addins.  It does
    /// not do any standalone excel file manipulation.
    /// </summary>
    public static class ExcelAddinUtil
    {
        private static Application _ExcelApp = null;

        /// <summary>
        /// hook into the excel application, if Initialize is not called first, this will
        /// fire an exception and give up
        /// </summary>
        private static Application ExcelApp
        {
            get
            {
                if (_ExcelApp == null)
                    throw new DataTableExcelVSTOException("ExcelApp is not usable until after Initialize(app) is called");
                else
                    return _ExcelApp;
            }
        }

        /// <summary>
        /// this must be the first call to this class
        /// </summary>
        /// <param name="app"></param>
        public static void Initialize(Application app)
        {
            if (_ExcelApp != null)
                throw new DataTableExcelVSTOException("Initialized should only be called once.");

            _ExcelApp = app;
        }

        /// <summary>
        /// returns a datatable with the cell references that would be used to lookup the value
        /// if the datatable was inserted into excel
        /// </summary>
        /// <param name="worksheetName">Name of the excel worksheet.  It must exist in the opened excel book.</param>
        /// <param name="self"></param>
        /// <param name="topLeft">top left cell of the table inside excel</param>
        /// <returns></returns>
        public static System.Data.DataTable GetExcelCellRefs(this System.Data.DataTable self, string worksheetName, 
            string topLeft)
        {
            self = self.Copy();

            throw new NotImplementedException();
        }

        /// <summary>
        /// Populates the current datatable with data from excel, this is unsafe in the sense
        /// that it changes state in the current datatable instead of creating a new datatable
        /// </summary>
        /// <param name="self"></param>
        /// <param name="worksheetName"></param>
        /// <param name="headersExist"></param>
        /// <param name="topLeftCell"></param>
        /// <param name="bottomRightCell"></param>
        public static void LoadFromExcel(this System.Data.DataTable self, string worksheetName, bool headersExist,
            string topLeftCell, string bottomRightCell)
        {
            var sheet = getWorksheet(worksheetName);
            var range = getRange(topLeftCell, bottomRightCell);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Export your datatable into excel.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="worksheetName"></param>
        /// <param name="headersExist"></param>
        /// <param name="topLeftCell"></param>
        public static void WriteToExcel(this System.Data.DataTable self, string worksheetName, bool headersExist,
            string topLeftCell)
        {
            throw new NotImplementedException();
        }

        private static Worksheet getWorksheet(string name)
        {
            throw new NotImplementedException();
        }

        private static Range getRange(string topLeftCell, string bottomRightCell)
        {
            throw new NotImplementedException();
        }
    }
}
