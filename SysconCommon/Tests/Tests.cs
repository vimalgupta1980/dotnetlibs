using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common;
using SysconCommon.Parsing;
using SysconCommon.Common.Environment;

namespace SysconCommon.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Env.SetMBDir(@"C:\mb7\sample company");
        }

        [Test]
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
        public void AccessSMBTest()
        {
            Env.AccessSMB();
        }

        [Test]
        public void FldlibBasedGridTest()
        {
            var dlg = new SysconCommon.GUI.FldlibBasedGrid();
            dlg.SetEditTable("dedmap");
            dlg.ShowDialog();
        }

        [Test]
        public void LoginTest()
        {
            var dlg = new SysconCommon.GUI.SMBLogin();
            dlg.ShowDialog();
            var username = dlg.LoggedInUser;

            Assert.IsNotNull(username);
        }
    }
}
