using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using SysconCommon;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Environment;

namespace SysconCommon.Analysis
{
    public static class PaygroupAnalysis
    {
        internal static IEnumerable<long> GetAllPaygroups(OleDbConnection con)
        {
            var grpsdt = con.GetDataTable("paygroups", "select recnum from paygrp");

            return from r in grpsdt.Rows.ToIEnumerable()
                   select Convert.ToInt64(r["recnum"]);
        }

        public static Env.TempDBFPointer GetPaygroupAnalysisTable(OleDbConnection con, IEnumerable<long> paygroups = null)
        {
            var anal = con.GetTempDBF();

            using (var tmpanal = GetPaygroupOverheadAnalysisTable(con, paygroups))
            {
                con.ExecuteNonQuery("select paygrp, sum(overhead1) as overhead1 from {0} group by paygrp into table {1}"
                    , tmpanal, anal);

                return anal;
            }
        }

        public static Env.TempDBFPointer GetPaygroupOverheadAnalysisTable(OleDbConnection con, IEnumerable<long> paygroups = null)
        {
            var hourly_methods = new int[] { 8, 9, 14, 15, 16 };
            var pcnt_methods = new int[] { 1, 2, 6 };
            var allowed_methods = hourly_methods.Concat(pcnt_methods).ToArray();

            var hourly_methods_list = string.Format("({0})", string.Join(",", hourly_methods.Select(m => m.ToString()).ToArray()));
            var pcnt_methods_list = string.Format("({0})", string.Join(",", pcnt_methods.Select(m => m.ToString()).ToArray()));
            var allowed_methods_list = string.Format("({0})", string.Join(",", allowed_methods.Select(m => m.ToString()).ToArray()));

            var anal = con.GetTempDBF();

            using (Env.TempDBFPointer
                paygrps = con.BuildRecnumTable(
                    paygroups == null
                        ? GetAllPaygroups(con)
                        : paygroups),
                tmpanal = con.GetTempDBF()
            )   
            {
                // con.ExecuteNonQuery("select recnum as paygrp, 0000000000.0000 as overhead1 from {0} into table {1}", paygrps, anal);
                con.ExecuteNonQuery("create table {0} (paygrp n(15) not null, clcnum n(15) not null, overhead1 n(15,4) not null)", tmpanal);

                // build our list of clcs to find values for
                // - first grab paygroup specific benefits
                con.ExecuteNonQuery("insert into {0}"
                    + " select p.recnum, b.dednum as clcnum, b.dedrte as overhead1"
                        + " from {1} p"
                        + " join benfit b on b.paygrp = p.recnum"
                        + " join payded on payded.recnum = b.dednum"
                        + " where payded.clctyp = 3"
                        + " and payded.benovr > 0"
                        + " and payded.clcmth in {2}"
                        , tmpanal, paygrps, allowed_methods_list);

                // now grab our non paygrp specific rates
                con.ExecuteNonQuery("insert into {0}"
                    + " select p.recnum, payded.recnum as clcnum, payded.dftrte as overhead1"
                        + " from {1} p"
                        + " join payded on payded.clctyp = 3 and payded.clcmth in {2} and payded.benovr = 0 and payded.dftact > 0"
                        , tmpanal, paygrps, allowed_methods_list);

                // update hour pcnt rates to actual overhead
                con.ExecuteNonQuery("update anal set anal.overhead1 = anal.overhead1 * paygrp.payrt1 / 100"
                    + " from {0} anal"
                    + " join paygrp on paygrp.recnum = anal.paygrp"
                    + " join payded on payded.recnum = anal.clcnum"
                    + " where payded.clcmth in {1}"
                    , tmpanal, pcnt_methods_list);

                // remove state and local taxes
                /*
                con.ExecuteNonQuery("delete anal from {0} anal"
                    + " join payded on payded.recnum = anal.clcnum and payded.taxloc <> 0"
                    , tmpanal);

                con.ExecuteNonQuery("delete anal from {0} anal"
                    + " join payded on payded.recnum = anal.clcnum and !isnull(payded.taxste) and !empty(payded.taxste)"
                    , tmpanal);
                */

                // fill out the table
                con.ExecuteNonQuery("select anal.paygrp, paygrp.grpnme, anal.clcnum, payded.clcnme, anal.overhead1"
                    + " from {0} anal"
                    + " join paygrp on paygrp.recnum = anal.paygrp"
                    + " join payded on payded.recnum = anal.clcnum"
                    + " into table {1}"
                    , tmpanal, anal);
#if false
                // add hourly rates
                // - paygrp specific
                con.ExecuteNonQuery("select anal.paygrp, payded.recnum as clcnum, sum(nvl(benfit.dedrte,00000000000.0000)) as dedrte"
                    + " from {0} anal"
                    + " left join benfit on benfit.paygrp = anal.paygrp and anal.clcnum = benfit.dednum"
                    + " left join payded on payded.recnum = benfit.dednum"
                    + " where payded.clcmth in (8, 9, 14, 15, 16)"
                    + " and payded.clctyp = 3"
                    + " and payded.benovr > 0"
                    + " group by 1"
                    + " into table {1}", anal, sums);

                con.ExecuteNonQuery("update anal set anal.overhead1 = sums.dedrte"
                    + " from {0} anal"
                    + " join {1} sums on sums.paygrp = anal.paygrp and anal.clcnum = sums.clcnum"
                    , anal, sums);

                // - nonpaygrp specific
                var nonpghourly = con.GetScalar<decimal>("select p.recnum as paygrp, payded.recnum as clcnum, payded.dftrte as dedrte"
                    + " from payded"
                    + " where payded.clctyp = 3"
                    + " and payded.clcmth in (8, 9, 14, 15, 16)"
                    + " and payded.benovr = 0");

                con.ExecuteNonQuery("update anal set anal.overhead1 = anal.overhead1 + {0} from {1} anal", nonpghourly, anal);

                // percentage rates
                // - paygrp specific
                con.ExecuteNonQuery("select anal.paygrp, sum(benfit.dedrte) as dedrte"
                    + " from {0} anal"
                    + " join benfit on benfit.paygrp = anal.paygrp"
                    + " join payded on payded.recnum = benfit.dednum"
                    + " where payded.clcmth in (1, 2, 6)"
                    + " and payded.clctyp = 3"
                    + " and payded.benovr > 0"
                    + " group by 1"
                    + " into table {1}", anal, sums);

                con.ExecuteNonQuery("update anal set anal.overhead1 = anal.overhead1 + ((sums.dedrte / 100.0000) * paygrp.payrt1)"
                    + " from {0} anal"
                    + " join {1} sums on sums.paygrp = anal.paygrp"
                    + " join paygrp on paygrp.recnum = anal.paygrp"
                    , anal, sums);

                // - nonpaygrp specific
                var nonpgpcnt = con.GetScalar<decimal>("select sum(dftrte / 100.0000)"
                    + " from payded"
                    + " where payded.clctyp = 3"
                    + " and payded.clcmth in (1, 2, 6)"
                    + " and payded.benovr = 0");

                con.ExecuteNonQuery("update anal set anal.overhead1 = anal.overhead1 + (paygrp.payrt1 * {0})"
                    + " from {1} anal"
                    + " join paygrp on paygrp.recnum = anal.paygrp"
                    , nonpgpcnt, anal);
#endif
            }

            return anal;
        }
    }
}