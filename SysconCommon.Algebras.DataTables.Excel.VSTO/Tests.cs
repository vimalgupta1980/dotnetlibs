using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;

using SysconCommon.Common.Environment;

namespace SysconCommon.Algebras.DataTables.Excel.VSTO
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void LoadDataTableTest()
        {
            var test_workbook = Env.GetMyAssemblyDirectory() + "/test.xlsx";
            var testdt = ExcelAddinUtil.GetNamedRangeData(test_workbook, "Sheet1", "test", true);
            Assert.AreEqual(testdt.Columns["one"].DataType, typeof(decimal));
            using (var con = Connections.GetInMemoryDB())
            {
                con.LoadDataTable(testdt);
                var biggerThan10 = con.GetScalar<int>("select count(*) from test where one > 10");
                Assert.AreEqual(95, biggerThan10);
            }
        }
    }
}
