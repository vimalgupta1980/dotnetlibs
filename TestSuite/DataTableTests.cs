using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit;

using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Environment;

namespace TestSuite
{
    [TestFixture]
    public class DataTableTests
    {
        public DataTable TestData
        {
            get
            {
                return new object[][]
                {
                  new object[] { 1, 2, 3, 4, 5},
                  new object[] { 6, 7, 8, 9, 10}
                }.MultArrayToDataTable("testdt");
            }
        }

        public string TestDataCSV
        {
            get
            {
                return "Column1,Column2,Column3,Column4,Column5\n1,2,3,4,5\n6,7,8,9,10";
            }
        }

        [Test]
        public void DataTable2CSV()
        {
            string csv = TestData.AsCSVText();
            Assert.IsNotNull(csv);
            Assert.AreEqual(TestDataCSV, csv);
        }

        [Test]
        public void TestCsvWrite()
        {
            var filename = "datatabletest.csv";
            TestData.SaveAsCSV(filename);
            var written = Env.GetFileText(filename);
            Assert.AreEqual(TestDataCSV, written);
        }

        [Test]
        public void DataTableFlip()
        {
            var testdt = TestData;
            var flipped = testdt.Flip("OldHeader");
            Assert.AreEqual(3, flipped.Columns.Count);
        }
    }
}
