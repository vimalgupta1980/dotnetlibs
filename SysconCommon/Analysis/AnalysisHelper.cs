using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Analysis
{
    public static class AnalysisHelper
    {
        public static Env.TempDBFPointer BuildRecnumTable(this OleDbConnection con, IEnumerable<long> recnums)
        {
            var tbl = con.GetTempDBF();
            con.ExecuteNonQuery("create table {0} (recnum n(20, 0) not null)", tbl);

            foreach (var recnum in recnums)
            {
                con.ExecuteNonQuery("insert into {0} (recnum) values ({1})", tbl, recnum);
            }

            return tbl;
        }
    }
}
