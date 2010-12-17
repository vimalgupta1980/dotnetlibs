using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common;
using SysconCommon.Parsing;

namespace SysconCommon.Tests
{
    [TestFixture]
    public class Tests
    {
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
    }
}
