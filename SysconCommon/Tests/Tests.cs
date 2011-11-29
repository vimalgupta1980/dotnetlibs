using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common;
using SysconCommon.Parsing;
using SysconCommon.Common.Environment;
using SysconCommon.GUI;
using SysconCommon.Analysis;

namespace SysconCommon.Tests
{
    [TestFixture, RequiresSTA]
    public class Tests
    {
        private COMMethods MBAPI = null;

        [SetUp]
        // [Ignore]
        public void Setup()
        {
            // Env.SetMBDir(@"C:\mb7\sample company");
            MBAPI = new COMMethods();
            MBAPI.smartGetSMBDir();
        }

        [Test]
        public void SelectSMBDir()
        {
            MBAPI.smartSelectSMBDirByGUI();
        }

        [Test]
        [Ignore]
        public void CsvTest()
        {
            var origdt = new
            {
                One = 1,
                Two = 2
            }.MakeSingletonCollection().ToDataTable("testdt");

            var csvtext = origdt.AsCSVText();

            var newdt = CSV.ParseText(csvtext);
            Assert.IsNotNull(newdt);
        }

        [Test]
        [Ignore]
        public void AccessSMBTest()
        {
            Env.AccessSMB();
        }

        [Test]
        [Ignore]
        public void FldlibBasedGridTest()
        {
            var dlg = new SysconCommon.GUI.FldlibBasedGrid();
            dlg.SetEditTable("dedmap");
            dlg.ShowDialog();
        }

        [Test]
        [Ignore]
        public void LoginTest()
        {
            var dlg = new SysconCommon.GUI.SMBLogin();
            dlg.ShowDialog();
            var username = dlg.LoggedInUser;

            Assert.IsNotNull(username);
        }

        [Test]
        public void SortedTest()
        {
            var count = 10000000;
            var my_nums = new int[count];
            for (var i = 0; i < count; i++)
            {
                my_nums[i] = i * 2;
            }

            SysconCommon.Algebras.MemoryDB.BTree<int> tree = new Algebras.MemoryDB.BTree<int>(my_nums.ToList(), input_is_sorted: true);
            Assert.AreEqual(count, tree.Count);

            var find_tree = tree.Find(Algebras.MemoryDB.BTree<int>.FindOps.LessThan, count);
            Assert.AreEqual(count / 2, find_tree.Count);

            find_tree = tree.Find(Algebras.MemoryDB.BTree<int>.FindOps.EqualTo, 500);
            Assert.AreEqual(1, find_tree.Count);

            var is500 = false;

            foreach (var i in find_tree.ToIEnumerable())
            {
                is500 = i == 500;
            }

            Assert.IsTrue(is500);
        }

        [Test]
        public void SqlLiteTests()
        {
            using (var con = new System.Data.SQLite.SQLiteConnection())
            {
                con.ConnectionString = "Data Source=:memory:";
                con.Open();

                var mydt = new System.Data.DataTable("testdt");
                mydt.Columns.Add("one", typeof(int));
                mydt.Columns.Add("two", typeof(int));

                var data = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };
                foreach (var drow in data)
                {
                    var row = mydt.NewRow();
                    row["one"] = drow[0];
                    row["two"] = drow[1];
                    mydt.Rows.Add(row);
                }

                con.LoadDataTable(mydt);

                var results = con.GetScalar<int>("select count(*) from testdt where one > 1");
                Assert.AreEqual(2, results);
            }
        }

        [Test]
        public void ConvertToDecimal()
        {
            Assert.AreEqual(1.0, Convert.ToDecimal(true));
            Assert.AreEqual(0.0, Convert.ToDecimal(false));
        }

        [Test]
        public void EditJobTypes()
        {
            MBAPI.EditJobTypes();
        }

        [Test]
        public void PaygroupSelector()
        {
            var frm = new Multi_Paygroup_Selector(MBAPI);
            frm.ShowDialog();

            Assert.IsTrue(frm.SelectedItems.Any());
        }

        [Test]
        public void UnionSelector()
        {
            var frm = new Multi_Union_Selector(MBAPI);
            frm.ShowDialog();

            Assert.IsTrue(frm.SelectedItems.Any());
        }

        [Test]
        public void PaygroupAnalysis()
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                var paygrps = from pg in Multi_Paygroup_Selector.SelectPaygroups(MBAPI)
                              select pg.recnum;

                Assert.IsTrue(paygrps.Any());

                using (var paygrp_recnum_tbl = con.BuildRecnumTable(paygrps))
                {
                    var lines = con.GetDataTable("TC Lines", "select recnum, linnum from tmcdln where paygrp in (select recnum from {0})", paygrp_recnum_tbl)
                        .Rows.ToIEnumerable()
                        .Select(r =>
                        {
                            return new TimeCardLinesAnalysis.TCLineKey(Convert.ToInt64(r["recnum"]), Convert.ToInt64(r["linnum"]));
                        });

                    var results = TimeCardLinesAnalysis.FindAmount(lines, TimeCardLinesAnalysis.TCAmountType.Calculation, 7).Select(l =>
                    {
                        return new
                        {
                            l.line.payrec,
                            l.line.lineno,
                            LineERMed = l.amount,
                            RecordERMed = l.payrec_ttl,
                        };
                    }).ToDataTable("ER Medicare");

                    ShowDataTable.ShowTable(results);
                }
            }
        }

        [Test]
        public void TemplateTest()
        {
            var tmplt = SysconTemplate.FromString("some $value$ is value");
            tmplt.SetAttribute("value", 0);
            tmplt.SetAttribute("non-existant", -1);

            Assert.AreEqual("some 0 is value", tmplt.ToString());
        }
    }
}
