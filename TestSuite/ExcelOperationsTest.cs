using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using NUnit.Framework;

using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Algebras.DataTables.Excel;

namespace TestSuite
{
    [TestFixture]
    public class ExcelOperationsTest
    {
        private string Book { get { return "testbook.xls"; } }

        [TestFixtureSetUp]
        public void SetCorrectPath()
        {
            Env.SetCurDirToMe();
        }

        [Test]
        public void LoadDataFromExcelTest()
        {
            var dt = ExcelOperations.LoadFromExcel(false, Book, "TestSheet", 1, 2, 3, 4);
            Assert.IsNotNull(dt);
        }

        [Test]
        public void WriteDataToExcelTest()
        {
            var dtspec = new object[][]
            {
                new object[] { 10, 20, 30, 40 },
                new object[] { 50, 60, 70, 80 },
                new object[] { 90, 100, 110, 120 }
            };

            var dt = dtspec.MultArrayToDataTable("Sample Write Table");
            dt.Columns[0].ColumnName = "Column One";
            dt.Columns[1].ColumnName = "Column Two";
            dt.Columns[2].ColumnName = "Column Three";

            Assert.IsNotNull(dt);
            dt.WriteToExcel(Book, "Test Output Sheet", 1, 1);
        }

        [Test]
        public void LoadSheetNamesTest()
        {
            IEnumerable<string> sheets = ExcelOperations.GetWorksheetNames(Book);

            Assert.AreEqual(sheets.Count(), 2);
            Assert.IsTrue(sheets.Contains("TestSheet"));
            Assert.IsTrue(sheets.Contains("Test Output Sheet"));
        }

        /*
         * FIXME: Starts with a Z to make it run last because it must run *after*
         * WriteDataToExcelTest .... fugly and I will fix it eventually
         */
        [Test]
        public void ZGetColumnCountTest()
        {
            var count = ExcelOperations.GetColumnCount(Book, "TestSheet");
            Assert.AreEqual(4, count);
        }

        [Test]
        public void ReplaceTemplateParams()
        {
            var tparams = new { one = 1, two = 2 }.ToDictionary();
            ExcelOperations.ApplyExcelTemplate("testtemplate.xls", "templateoutput.xls", tparams);
        }
    }
}