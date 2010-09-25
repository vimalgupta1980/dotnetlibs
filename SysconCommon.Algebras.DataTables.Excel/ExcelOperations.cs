using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

using GemBox.ExcelLite;
using SysconCommon.Common;
using SysconCommon.Common.Validity;
using SysconCommon.Common.Environment;

namespace SysconCommon.Algebras.DataTables.Excel
{
    public class ExcelException : SysconException
    {
        public ExcelException(string format, params object[] arguments)
            : base(format, arguments) { }

        public ExcelException(Exception innerException, string format, params object[] arguments)
            : base(innerException, format, arguments) { }
    }

    /// <summary>
    /// A functional API for working with Excel Files
    /// </summary>
    static public class ExcelOperations
    {
        /// <summary>
        /// list worksheets
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>the list of worksheet names</returns>
        public static IEnumerable<string> GetWorksheetNames(string fileName)
        {
            initialize();
            var file = getExcelFile(fileName);
            var sheets = file.Worksheets;

            for (var i = 0; i < sheets.Count; i++)
            {
                yield return sheets[i].Name;
            }
        }

        private static int getColumnCount(ExcelRow row)
        {
            var highest = 0;

            for(int i = 0; i < row.Cells.LastColumnIndex; i++)
            {
                if(row.Cells[i].Value != null)
                    highest = i;
            }

            return highest + 1;
        }

        /// <summary>
        /// get the column count of a worksheet
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worksheetName"></param>
        /// <returns></returns>
        public static int GetColumnCount(string fileName, string worksheetName)
        {
            initialize();
            var ws = getExcelWorksheet(fileName, worksheetName);

            var colCount = 0;
            for(int r = 0; r < GetLastRow(fileName, worksheetName); r++)
            {
                var lc = getColumnCount(ws.Rows[r]);
                if(lc > colCount)
                    colCount = lc;
            }

            return colCount;
        }

        /// <summary>
        /// get the row count of a worksheet
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worksheetName"></param>
        /// <returns></returns>
        public static int GetLastRow(string fileName, string worksheetName)
        {
            initialize();
            var ws = getExcelWorksheet(fileName, worksheetName);

            return ws.Rows.Count;
        }

        /// <summary>
        /// return a new datatable from a range in excel
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worksheetName"></param>
        /// <param name="topLeftCell"></param>
        /// <param name="columns"></param>
        /// <param name="rows"></param>
        public static DataTable LoadFromExcel(bool includesHeaders, string fileName, 
            string worksheetName, int leftColumn, int topRow, int columns, 
            int rows)
        {
            initialize();
            var file = getExcelFile(fileName);

            try
            {
                var worksheet = file.Worksheets[worksheetName];
                var range = worksheet.Cells.GetSubrangeRelative(topRow, leftColumn, columns, rows);
                
                return range.ToDataTable(includesHeaders);
            }
            finally
            {
                /// FIXME: How the fuck can i close the ExcelFile...  It doesn't seem to
                /// be locking the actual file, so maybe ExcelFile only opens/closes on
                /// demand or something.
            }
        }

        public static DataTable LoadFromExcel(bool includesHeaders, string fileName, string worksheetName, int leftColumn, int topRow)
        {
            var cols = GetColumnCount(fileName, worksheetName) - leftColumn;
            var rows = GetLastRow(fileName, worksheetName) - topRow;

            return LoadFromExcel(includesHeaders, fileName, worksheetName, leftColumn, topRow, cols, rows);
        }

        public static DataTable LoadFromExcel(bool includesHeaders, string fileName, string worksheetName)
        {
            return LoadFromExcel(includesHeaders, fileName, worksheetName, 0, 0);
        }

        /// <summary>
        /// Write the contents of a datatable into an excel region
        /// </summary>
        /// <param name="self"></param>
        /// <param name="filename"></param>
        /// <param name="worksheetName"></param>
        /// <param name="topRow"></param>
        /// <param name="leftColumn"></param>
        public static void WriteToExcel(this DataTable self, string filename, string worksheetName,
            int topRow, int leftColumn, bool showHeaders, Color headerFg, Color headerBg, Color dataFg, Color dataBg)
        {
            initialize();
            var file = getExcelFile(filename);
            var ws = getExcelWorksheet(filename, worksheetName);
            var range = FromDataTable(self, ws, topRow, leftColumn, showHeaders, headerFg, headerBg, dataFg, dataBg);


            file.SaveXls(filename);
        }

        public static FileStream WriteToExcelStream(this DataTable self, string worksheetName, int topRow, int leftColumn, bool showHeaders,
            Color headerFg, Color headerBg, Color dataFg, Color dataBg)
        {
            var tmpFile = Env.GetTempFile();
            self.WriteToExcel(tmpFile.FileName, worksheetName, topRow, leftColumn, showHeaders, headerFg, headerBg, dataFg, dataBg);
            return tmpFile.ReadFileStream;
        }

        public static FileStream WriteToExcelStream(this DataTable self, string worksheetName, int topRow, int leftColumn, bool showHeaders)
        {
            var headerFg = Color.Black;
            var headerBg = Color.Yellow;
            var dataFg = Color.Black;
            var dataBg = Color.White;

            return WriteToExcelStream(self, worksheetName, topRow, leftColumn, showHeaders, headerFg, headerBg, dataFg, dataBg);
        }

        public static FileStream WriteToExcelStream(this DataTable self, string worksheetName, int topRow, int leftColumn)
        {
            return WriteToExcelStream(self, worksheetName, topRow, leftColumn, true);
        }

        public static void WriteToExcel(this DataTable self, string filename, string worksheetName, int topRow, int leftColumn, bool showHeaders)
        {
            var headerFg = Color.Black;
            var headerBg = Color.Yellow;
            var dataFg = Color.Black;
            var dataBg = Color.White;

            self.WriteToExcel(filename, worksheetName, topRow, leftColumn, showHeaders, headerFg, headerBg, dataFg, dataBg);
        }

        public static void WriteToExcel(this DataTable self, string filename, string worksheetname, int topRow, int leftColumn)
        {
            self.WriteToExcel(filename, worksheetname, topRow, leftColumn, true);
        }

        /// <summary>
        /// Convert to a datatable.
        /// keeping this private so that none of the user interface actually references
        /// excel types
        /// </summary>
        /// <param name="range"></param>
        /// <param name="includesHeaders">specifies if the excel range includes headers</param>
        /// <returns></returns>
        private static DataTable ToDataTable(this CellRange range, bool includesHeaders)
        {
            Validity.Assert(range.LastColumnIndex - range.FirstColumnIndex > 0, "Range has no columns");
            Validity.Assert(range.LastRowIndex - range.FirstRowIndex > 0, "Range has no rows");

            var dt = new DataTable();

            foreach (var i in FunctionalOperators.Range(range.LastColumnIndex - range.FirstColumnIndex + 1))
            {
                if (includesHeaders)
                {
                    var val = range[0, i].Value;
                    // dt.Columns.Add(val != null ? val.ToString() : "");
                    if (val != null && val.ToString().Trim() != "")
                        dt.Columns.Add(val.ToString());
                    else
                        dt.Columns.Add();
                }
                else
                {
                    dt.Columns.Add();
                }
            }

            foreach (var i in FunctionalOperators.Range(includesHeaders ? 1 : 0, range.LastRowIndex - range.FirstRowIndex + 1))
            {
                var row = dt.NewRow();
                foreach (var j in FunctionalOperators.Range(range.LastColumnIndex - range.FirstColumnIndex + 1))
                {
                    row[j] = range[i, j].Value;
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        // the colors are ignored at the moment because they are not working and are causing some issues
        private static CellRange FromDataTable(DataTable dt, ExcelWorksheet ws, int top, int left, bool showHeaders, Color headerFg, Color headerBg, Color dataFg, Color dataBg)
        {
            Validity.Assert(dt.Rows.Count > 0, "datatable has no rows");
            Validity.Assert(dt.Columns.Count > 0, "datatable has no columns");

            var range = ws.Cells.GetSubrangeRelative(top, left, dt.Columns.Count, dt.Rows.Count + (showHeaders ? 1 : 0));

            if (showHeaders)
            {   
                foreach (var i in FunctionalOperators.Range(dt.Columns.Count))
                {
                    range[0, i].Value = dt.Columns[i].Caption != null ? dt.Columns[i].Caption : dt.Columns[i].ColumnName;
                    //range[0, i].Style.FillPattern.PatternBackgroundColor = headerBg;
                    //range[0, i].Style.FillPattern.PatternForegroundColor = headerFg;
                }
            }

            foreach (var i in FunctionalOperators.Range(showHeaders ? 1 : 0, dt.Rows.Count + (showHeaders ? 1 : 0)))
            {
                foreach (var j in FunctionalOperators.Range(dt.Columns.Count))
                {
                    var dtrown = showHeaders ? i - 1 : i;

                    try
                    {
                        range[i, j].Value = dt.Rows[dtrown][j];
                        //range[i, j].Style.FillPattern.PatternForegroundColor = dataFg;
                        //range[i, j].Style.FillPattern.PatternBackgroundColor = dataBg;
                    }
                    catch (Exception ex)
                    {
                        throw new SysconException(ex);
                    }
                }
            }

            return range;
        }

        /// <summary>
        /// this really shouldn't be accessed by anthing except initialize()
        /// </summary>
        private static bool Initialized { get; set; }

        /// <summary>
        /// if initialization already happend, this does nothing
        /// otherwise it sets the excel lite license key, all of the
        /// public functions should call this before doing anything
        /// else
        /// </summary>
        private static void initialize()
        {
            if (Initialized)
                return;

            ExcelLite.SetLicense("EW1P-D116-JKQP-1ERS");
            Initialized = true;
        }

        /// <summary>
        /// there should only ever be one excel file opened, otherwise
        /// calls to SaveXls will override previous saves
        /// </summary>
        private static IDictionary<string, ExcelFile> _excelFiles = new Dictionary<string, ExcelFile>();

        /// <summary>
        /// this will return an excel file with the filename, if it is already opened it will
        /// return the same instance, otherwise it will open it
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static ExcelFile getExcelFile(string fileName)
        {
            if (!_excelFiles.ContainsKey(fileName))
            {
                _excelFiles[fileName] = new ExcelFile();

                if (Env.FileExists(fileName))
                {
                    _excelFiles[fileName].LoadXls(fileName);
                }
            }

            return _excelFiles[fileName];
        }

        /// <summary>
        /// gets a worksheet from an excel book, if the specified sheet does not exist
        /// it will be created
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="worksheetName"></param>
        /// <returns>the worksheet</returns>
        private static ExcelWorksheet getExcelWorksheet(string fileName, string worksheetName)
        {
            var file = getExcelFile(fileName);

            for (var i = 0; i < file.Worksheets.Count; i++)
            {
                var ws = file.Worksheets[i];
                if (ws.Name == worksheetName)
                    return ws;
            }

            return file.Worksheets.Add(worksheetName);
        }

        /// <summary>
        /// make a copy of an existing worksheet in the same book
        /// </summary>
        /// <param name="fileName">name of the excel book name</param>
        /// <param name="sourceSheet">name of source sheet</param>
        /// <param name="destSheet">name of destination sheet</param>
        /// <returns>new worksheet name</returns>
        public static string CopyWorksheet(string fileName, string sourceSheet, string destSheet)
        {
            var file = getExcelFile(fileName);
            file.Worksheets.AddCopy(destSheet, file.Worksheets[sourceSheet]);
            file.SaveXls(fileName);
            return destSheet;
        }

        /// <summary>
        /// makes a copy of the source sheet, if the sheet name ends with a number, that number will be
        /// increased by one in the destination sheet name, otherwise it will be "Copy of [original name]"
        /// </summary>
        /// <param name="fileName">filename of the workbook</param>
        /// <param name="sourceSheet">sheet name</param>
        /// <returns>new worksheet name</returns>
        public static string CopyWorksheet(string fileName, string sourceSheet)
        {
            var dest = sourceSheet;
            dest = dest.Trim();
            var match = Regex.Match(dest, @"^(.*)(\d+)$");
            var destName = match.Success 
                ? match.Groups[1].Value + (int.Parse(match.Groups[2].Value) + 1).ToString() 
                : string.Format("Copy of {0}", dest);
            return CopyWorksheet(fileName, sourceSheet, destName);
        }

        /// <summary>
        /// makes a copy of the first sheet in the book, if the sheet name ends with a number, that number will be
        /// increased by one in the destination sheet name, otherwise it will be "Copy of [original name]"
        /// </summary>
        /// <param name="fileName">filename of the workbook</param>
        /// <param name="sourceSheet">sheet name</param>
        /// <returns>new worksheet name</returns>
        public static string CopyWorksheet(string fileName)
        {
            var file = getExcelFile(fileName);
            var sourceSheet = file.Worksheets[0].Name;
            return CopyWorksheet(fileName, sourceSheet);
        }

        /// <summary>
        /// Apply a set of values to an excel sheet using StringTemplate
        /// </summary>
        /// <param name="worksheetName">name of the worksheet to alter</param>
        /// <param name="templateFilename">input template</param>
        /// <param name="outputFilename">output excel file name</param>
        /// <param name="leftColumn">first column</param>
        /// <param name="topRow">first row</param>
        /// <param name="columns">count of columns</param>
        /// <param name="rows">count of rows</param>
        /// <param name="values">a dictionary of names to values</param>
        public static void ApplyExcelTemplate(
            string InputWorksheetName,
            string OutputWorksheetName,
            string templateFilename, 
            string outputFilename, 
            int leftColumn,
            int topRow,
            int columns,
            int rows,
            IDictionary<string, object> values)
        {
            try
            {
                Validity.Assert(templateFilename != outputFilename, "template and output files must differ");
                Validity.FilesExist(templateFilename);

                // copy the template file to the new file before we use it, this way we get styling from the
                // template
                File.Copy(templateFilename, outputFilename, true);
                Validity.FilesExist(outputFilename);

                // load excel data into a datatable
                var tmpltdt = LoadFromExcel(false, templateFilename, InputWorksheetName, leftColumn, topRow, columns, rows);

                // run string template against the datatable
                tmpltdt = tmpltdt.ReplaceTemplateParams(values);

                // export new values back out to excel
                tmpltdt.WriteToExcel(outputFilename, OutputWorksheetName, topRow, leftColumn, false);
            }
            catch (Exception ex)
            {
                throw new ExcelException(ex, 
                    "Could not apply template {0} into {1}", templateFilename, outputFilename);
            }
        }

        /// <summary>
        /// Apply a set of values to an excel sheet using StringTemplate
        /// </summary>
        /// <param name="worksheetName">name of the worksheet to alter</param>
        /// <param name="templateFilename">input template</param>
        /// <param name="outputFilename">output excel file name</param>
        /// <param name="values">a dictionary of names to values</param>
        public static void ApplyExcelTemplate(
            string inputWorksheetName,
            string outputWorksheetName,
            string templateFilename,
            string outputFilename,
            IDictionary<string, object> values)
        {
            ApplyExcelTemplate(inputWorksheetName, outputWorksheetName, templateFilename, outputFilename, 0, 0, 
                GetColumnCount(templateFilename, inputWorksheetName), 
                GetLastRow(templateFilename, inputWorksheetName), 
                values);
        }

        /// <summary>
        /// Apply a set of values to an excel sheet using StringTemplate
        /// </summary>
        /// <param name="templateFilename">input template</param>
        /// <param name="outputFilename">output excel file name</param>
        /// <param name="values">a dictionary of names to values</param>
        public static void ApplyExcelTemplate(
            string templateFilename, 
            string outputFilename, 
            IDictionary<string,object> values)
        {
            var wsheets = GetWorksheetNames(templateFilename);
            Validity.Assert(wsheets.Count() > 0, "template file must have at least one worksheet");
            var wsname = wsheets.ElementAt(0);

            ApplyExcelTemplate(wsname, wsname, templateFilename, outputFilename, values);
        }
    }
}
