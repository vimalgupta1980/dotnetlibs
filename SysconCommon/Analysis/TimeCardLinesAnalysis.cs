using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon;
using SysconCommon.Common;
using SysconCommon.Common.Validity;
using SysconCommon.Foxpro;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;
using SMB.Tables;
using System.Data.OleDb;

namespace SysconCommon.Analysis
{
    public static class TimeCardLinesAnalysis
    {
        public class TCLineKey
        {
            /// <summary>
            /// payrec.recnum
            /// </summary>
            public readonly long payrec;

            /// <summary>
            /// tmcdln.linnum, if this is set to 0, it means the entire payroll record
            /// </summary>
            public readonly long lineno;

            public TCLineKey(long _payrec, long _lineno)
            {
                payrec = _payrec;
                lineno = _lineno;
            }
        }

        public enum TCAmountType
        {
            GrossPay = 1,
            Calculation = 2,
        }

        public class TCLineAmount
        {
            public readonly long clcnum;
            public readonly TCAmountType type;
            public readonly TCLineKey line;
            public readonly decimal amount;
            public readonly decimal payrec_ttl;

            public TCLineAmount(decimal _amount, decimal _payrec_ttl, TCLineKey _line, TCAmountType _type = TCAmountType.GrossPay, long _clcnum = 0)
            {
                if (_type != TCAmountType.Calculation)
                    Validity.Assert(_clcnum == 0, "non payroll calculation analysis results cannot have a clcnum");
                else
                    Validity.Assert(_clcnum > 0, "payrol calculation result must have a clcnum");

                clcnum = _clcnum;
                type = _type;
                line = _line;
                amount = _amount;
                payrec_ttl = _payrec_ttl;
            }
        }

        private static void SetAmountToGrossPay(Env.TempDBFPointer analysis_tbl)
        {
            var con = analysis_tbl.connection;

            con.ExecuteNonQuery("update anal set anal.amount = IIF(tmcdln.hrswrk=0,1,tmcdln.hrswrk) * tmcdln.payrte"
                + " from {0} anal"
                + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                , analysis_tbl);

            con.ExecuteNonQuery("update anal set anal.recttl = payrec.grspay"
                + " from {0} anal"
                + " join payrec on payrec.recnum = anal.recnum"
                , analysis_tbl);

            // populate the payrate for salaried employees
            using (var zeros = con.GetTempDBF())
            {
                con.ExecuteNonQuery("select anal.recnum, sum(amount) as amount, sum(tmcdln.hrswrk) as ttlhrs, max(anal.recttl) as recttl"
                    + " from {0} anal"
                    + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                    + " join payrec on payrec.recnum = anal.recnum and payrec.grspay <> 0" // filter out payroll records that sum up to zero, becuase these screw up the below calcs
                    + " group by anal.recnum"
                    + " into table {1}"
                    , analysis_tbl, zeros);

                con.ExecuteNonQuery("delete from {0} where amount <> 0", zeros);

                con.ExecuteNonQuery("update {0} set amount = recttl / ttlhrs where ttlhrs <> 0", zeros);

                con.ExecuteNonQuery("update anal set anal.amount = zeros.amount * tmcdln.hrswrk"
                    + " from {0} anal"
                    + " join {1} zeros on zeros.recnum = anal.recnum"
                    + " join tmcdln on tmcdln.recnum = anal.recnum and tmcdln.linnum = anal.linnum"
                    , analysis_tbl, zeros);
            }
        }

        private static void _do_weight(payded ded, Env.TempDBFPointer analysis_tbl)
        {
            // wtf, this isn't making any changes!
            // sometimes anal.recttl is 0, if this is the case, set it to 1 because all our amounts should be 0 anyways and therefore
            analysis_tbl.connection.ExecuteNonQuery(
                "update anal set anal.amount = nvl(tmcddd.amount * (anal.amount / anal.recttl), 0), anal.recttl = nvl(tmcddd.amount, 0)"
                + " from {0} anal"
                + " left join tmcddd on tmcddd.recnum = anal.recnum and tmcddd.clcnum = {1}"
                , analysis_tbl, ded.recnum);
        }

        private static void SetAmountToCalculation(Env.TempDBFPointer analysis_tbl, long clcnum)
        {
            Validity.Assert(clcnum > 0, "clcnum not provided");
            var _payded = SMB.Tables.smbtable.Get<payded>("select * from payded where recnum = {0}", clcnum).FirstOrDefault();
            Validity.Assert(_payded != null, "invalid clcnum");

            // % Other calculation is special, we just calculate using the other calculation
            if (_payded.clcmth == 7)
            {
                _payded.clcmth = analysis_tbl.connection.GetScalar<long>("select clcmth from payded where recnum = {0}", _payded.bsdded);
            }

            SetCalculationMults(analysis_tbl, _payded);

            var con = analysis_tbl.connection;
            
            switch (SelectBaseType(_payded))
            {
                case BaseType.Gross:
                    // should 11 be calculated this way?  It's a subjective question.
                    /*
                    con.ExecuteNonQuery("update anal set amount = tmcdln.hrswrk * tmcdln.payrte"
                        + " from {0} anal"
                        + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                        , analysis_tbl);
                    */
                    SetAmountToGrossPay(analysis_tbl);

                    // sometimes for salaried employees there are hours on the timecard
                    // but no rates, assuming all cases like this are for salaried employees
                    // we can just take the hours and let the scaling to match tmcddd work
                    // out the rest
                    con.ExecuteNonQuery("update anal set amount = tmcdln.hrswrk"
                        + " from {0} anal"
                        + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                        + " where anal.amount = 0 or isnull(anal.amount)"
                        , analysis_tbl);

                    break;
                case BaseType.Hours:
                    con.ExecuteNonQuery("update anal set amount = tmcdln.hrswrk"
                        + " from {0} anal"
                        + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                        , analysis_tbl);
                    break;
                default:
                    throw new NotImplementedException();
            }

            // do our calculation, it's easy at this point
            con.ExecuteNonQuery("update {0} set amount = amount * mult", analysis_tbl);

            // find our zeros, then weigh them against the zeros in tmcddd
            using (Env.TempDBFPointer 
                totals = con.GetTempDBF(),
                zeros = con.GetTempDBF())
            {
                con.ExecuteNonQuery("select anal.recnum, sum(anal.amount) as amount, payrec.ttlhrs"
                    + " from {0} anal"
                    + " join payrec on payrec.recnum = anal.recnum"
                    + " group by recnum into table {1}"
                    , analysis_tbl, totals);

                con.ExecuteNonQuery("update anal set anal.recttl = zeros.amount"
                    + " from {0} anal"
                    + " join {1} zeros on zeros.recnum = anal.recnum"
                    , analysis_tbl, totals);

                // some calculations (like workmans comp may still have a recttl of 0 even though the tmcddd has an entry... fix this
                // con.ExecuteNonQuery("select distinct recnum from {0} where recttl = 0 into table {1}", analysis_tbl, zeros);
                /* this is mad slow... so break into multiple steps
                con.ExecuteNonQuery("update anal set anal.amount = tmcdln.hrswrk, anal.recttl = 1"
                    + " from {0} anal"
                    + " join {0} anal2 on anal2.recttl = 0 and anal2.recnum = anal.recnum and anal2.linnum = anal.linnum"
                    + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                    + " join tmcddd on tmcddd.clcnum = {1} and tmcddd.recnum = anal.recnum"
                    // + " where anal.recttl = 0"
                    , analysis_tbl, _payded.recnum);
                 */

                con.ExecuteNonQuery("select anal.recnum, anal.linnum, tmcdln.hrswrk"
                    + " from {0} anal"
                    + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                    + " join tmcddd on tmcddd.clcnum = {1} and tmcddd.recnum = anal.recnum"
                    + " where anal.recttl = 0"
                    + " into table {2}"
                    , analysis_tbl, _payded.recnum, zeros);

                con.ExecuteNonQuery("update anal set anal.amount = zeros.hrswrk"
                    + " from {0} anal"
                    + " join {1} zeros on zeros.recnum = anal.recnum and zeros.linnum = anal.linnum"
                    , analysis_tbl, zeros);

                con.ExecuteNonQuery("select anal.recnum, sum(anal.amount) as recttl"
                    + " from {0} anal"
                    + " join {1} zeros on zeros.recnum = anal.recnum and zeros.linnum = anal.linnum"
                    + " group by anal.recnum"
                    + " into table {2}"
                    , analysis_tbl, zeros, totals);

                con.ExecuteNonQuery("update anal set anal.recttl = zeros.recttl"
                    + " from {0} anal"
                    + " join {1} zeros on zeros.recnum = anal.recnum"
                    , analysis_tbl, totals);
            }

            _do_weight(_payded, analysis_tbl);
        }

        private static void SetCalculationMults(Env.TempDBFPointer analysis_tbl, payded ded)
        {
            var con = analysis_tbl.connection;

            // workmans comp and liability insurance both come from the wkrcmp table
            if (ded.clcmth == 17 && ded.taxtyp == 11)
            {
                con.ExecuteNonQuery("update anal set anal.mult = (wkrcmp.pctrte / 100.00000) * (IIF(inlist(tmcdln.paytyp, 2, 3), tmcdln.cmpsub, tmcdln.payrte))"
                    + " from {0} anal"
                    + " join tmcdln on tmcdln.recnum = anal.recnum and tmcdln.linnum = anal.linnum"
                    + " join wkrcmp on wkrcmp.recnum = tmcdln.cmpcde"
                    , analysis_tbl);

                goto cleanup;  // we are done
            }

            if (ded.clcmth == 17 && ded.taxtyp == 12)
            {
                con.ExecuteNonQuery("update anal set anal.mult = (wkrcmp.libins / 100.00000) * (IIF(inlist(tmcdln.paytyp, 2, 3), tmcdln.cmpsub, tmcdln.payrte))"
                    + " from {0} anal"
                    + " join tmcdln on tmcdln.recnum = anal.recnum and tmcdln.linnum = anal.linnum"
                    + " join wkrcmp on wkrcmp.recnum = tmcdln.cmpcde"
                    , analysis_tbl);

                goto cleanup; // we are done
            }

            if (ded.benovr == 0) // rates across timecard lines within a single pay record should not vary
            {
                // we use 1, we can use anything we want because the results will get scaled correctly to match
                // tmcddd later on, but 1 leads to few rounding errors
                con.ExecuteNonQuery("update {0} set mult = 1", analysis_tbl);

                /// We shouldn't do this... 
                /*
                if (ded.uninum > 0)
                {
                    // if the benefit is a union benefit, set the mult to zero for non-union lines
                    con.ExecuteNonQuery("update anal set anal.mult = 0"
                        + " from {0} anal"
                        + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                        + " join paygrp on paygrp.recnum = tmcdln.paygrp"
                        + " where isnull(paygrp.uninum) or paygrp.uninum <> {1}"
                        , analysis_tbl, ded.uninum);
                }
                */
            }
            else // we have to pull the rates from paygroups
            {
                con.ExecuteNonQuery("update anal set anal.mult = benfit.dedrte"
                    + " from {0} anal"
                    + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                    + " join benfit on benfit.paygrp = tmcdln.paygrp and benfit.dednum = {1}"
                    , analysis_tbl, ded.recnum);

                // sometimes the calculation was removed from benfits, so we have to make these work as well
                using (var zero_payrecs = con.GetTempDBF())
                {
                    con.ExecuteNonQuery("select recnum, sum(mult) as mult_sum from {0} into table {1} group by recnum", analysis_tbl, zero_payrecs);
                    con.ExecuteNonQuery("delete from {0} where mult_sum <> 0", zero_payrecs);

                    con.ExecuteNonQuery("delete zeros"
                        + " from {0} zeros"
                        + " left join tmcddd on tmcddd.recnum = zeros.recnum and tmcddd.clcnum = {1}"
                        + " where isnull(tmcddd.amount)"
                        , zero_payrecs, ded.recnum);

                    if (ded.benovr == 0)
                    {
                        con.ExecuteNonQuery("update anal set mult = 1"
                            + " from {0} anal"
                            + " join {1} zeros on zeros.recnum = anal.recnum"
                            , analysis_tbl, zero_payrecs);
                    }
                    else
                    {
                        using (var valid_paygroups = con.GetTempDBF())
                        {
                            // this is really just a guess, but it should usually be a valid one
                            con.ExecuteNonQuery("select recnum as paygrp from paygrp where paygrp.uninum = {0} into table {1}", ded.uninum, valid_paygroups);

                            con.ExecuteNonQuery("update anal set mult = 1"
                                + " from {0} anal"
                                + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                                + " join {1} zeros on zeros.recnum = anal.recnum"
                                + " join {2} vpg on vpg.paygrp = tmcdln.paygrp"
                                , analysis_tbl, zero_payrecs, valid_paygroups);
                        }
                    }
                }
            }

            // certain calculation methods multiply by different amounts based on the paytyp, instead of having special
            // logic later, we just multiply the multipliers by them now
            var special = new decimal[][] {
                // clcmth, paytyp, mult
                new decimal[] { 12, 1, 0 },
                new decimal[] { 13, 2, 1.5m },
                new decimal[] { 13, 3, 2 },
                new decimal[] { 14, 2, 1.5m },
                new decimal[] { 14, 3, 1.5m },
                new decimal[] { 15, 2, 1.5m },
                new decimal[] { 15, 3, 2.0m },
                new decimal[] { 16, 2, 2 },
                new decimal[] { 16, 3, 2 },
                new decimal[] { 4, 2, 0 },
                new decimal[] { 4, 3, 0 },
                new decimal[] { 9, 2, 0 },
                new decimal[] { 9, 3, 0 },
            };

            foreach (var modification in special)
            {
                if(ded.clcmth != modification[0])
                    continue;

                con.ExecuteNonQuery("update anal set anal.mult = anal.mult * {1} where tmcdln.paytyp {2}"
                        + " from {0} anal"
                        + " join tmcdln on tmcdln.recnum = anal.recnum and tmcdln.linnum = anal.linnum"
                    , analysis_tbl
                    , modification[2]
                    , modification[1] == 1 ? "not in (2, 3)" : " = " + modification[1].ToString());
            }

            var remove_above_typ3 = new decimal[] { 4, 9, 12, 13, 14, 15, 16 };

            if (remove_above_typ3.Contains(ded.clcmth))
            {
                con.ExecuteNonQuery("update anal set anal.mult = 0"
                    + " from {0} anal"
                    + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                    + " where tmcdln.paytyp > 3"
                    , analysis_tbl);
            }


            if (ded.loctax > 0)
            {
                con.ExecuteNonQuery("update anal set anal.mult = 0"
                    + " from {0} anal"
                    + " join tmcdln on tmcdln.linnum = anal.linnum and tmcdln.recnum = anal.recnum"
                    + " where tmcdln.loctax <> {1}"
                    , analysis_tbl, ded.loctax);
            }

            if (ded.taxste != null && ded.taxste.Trim() != "")
            {
                con.ExecuteNonQuery("update {0} set mult = 0 where taxste <> {1}", analysis_tbl, ded.taxste.FoxproQuote());
            }

        cleanup:
            // remove line items with a multiplier of 0, but first we have to make sure that not all the multipliers are 0
            using (var zeros = con.GetTempDBF())
            {
                con.ExecuteNonQuery("select recnum, sum(mult) as ttl from {0} group by recnum into table {1}", analysis_tbl, zeros);
                con.ExecuteNonQuery("delete from {0} where ttl <> 0", zeros);

                con.ExecuteNonQuery("delete anal"
                    + " from {0} anal"
                    + " left join {1} zeros on zeros.recnum = anal.recnum"
                    + " where isnull(zeros.recnum) and anal.mult = 0"
                    , analysis_tbl, zeros);
            }
        }

        private enum BaseType
        {
            Hours = 1,
            Gross = 2,
        }

        private static BaseType SelectBaseType(payded ded)
        {
            if (ded.clcmth == 17)
            {
                if (ded.taxtyp == 11 || ded.taxtyp == 12)
                    return BaseType.Hours;
            }

            long[] hours_types = new long[] { 4, 5, 8, 9 };

            return hours_types.Contains(ded.clcmth) ? BaseType.Hours : BaseType.Gross;
        }

        public static IEnumerable<TCLineAmount> FindAmount(IEnumerable<TCLineKey> lines, TCAmountType type, long clcnum = 0)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                using (var analysis_tbl = FindAmountTable(lines, type, clcnum))
                {
                    return from row in con.GetDataTable("Analysis", "select * from {0}", analysis_tbl).Rows.ToIEnumerable()
                           select new TCLineAmount(
                               Convert.ToDecimal(row["amount"]),
                               Convert.ToDecimal(row["recttl"]),
                               new TCLineKey(
                                   Convert.ToInt64(row["recnum"]),
                                   Convert.ToInt64(row["linnum"])),
                               type,
                               clcnum);
                }
            }
        }

        static IEnumerable<TCLineKey> _cached_lines = null;
        static Env.TempDBFPointer payrecs_tbl = null;
        static Env.TempDBFPointer keep = null;
        static OleDbConnection con = null;

        public static void DisposeConnection()
        {
            if (payrecs_tbl != null)
            {
                payrecs_tbl.Dispose();
                payrecs_tbl = null;
            }

            if (keep != null)
            {
                keep.Dispose();
                keep = null;
            }

            if (con != null)
            {
                con.Dispose();
                con = null;
            }
        }

        public static Env.TempDBFPointer FindAmountTable(IEnumerable<TCLineKey> lines, TCAmountType type, long clcnum = 0)
        {
            if (type == TCAmountType.Calculation && clcnum <= 0)
                throw new SysconException("Calculation # not specified");

            var lines_array = lines.ToArray();


            if (con == null)
            {
                con = Connections.GetOLEDBConnection();
            }

            var analysis_tbl = con.GetTempDBF();

            // so basically the solution comes to:
            //      - calculate for all records that belong to the payrecords we care about, this is import because of how
            //              we compare zeros
            //          - select a multiplier, this is the rate*hours_mult
            //          - multiply by some base (hours or gross)
            //          - scale so that our zeros match those in tmcddd
            //      - filter out the records we don't care about

            if (payrecs_tbl == null || _cached_lines != lines)
            {
                _cached_lines = lines;

                var payrecs = (from l in lines_array
                               select l.payrec).Uniq();

                payrecs_tbl = con.BuildRecnumTable(payrecs);
            }

            con.ExecuteNonQuery("select tmcdln.recnum, tmcdln.linnum, "
                    + "00000000000000000000000000000000000.0000 as amount, 000000000000000.0000 as recttl, 000000000000000.00000000 as mult, nvl(loctax.inctax, payrec.taxste) as taxste"
                + " from tmcdln"
                + " join {0} mypayrecs on mypayrecs.recnum = tmcdln.recnum"
                + " left join loctax on loctax.recnum = tmcdln.loctax"
                + " join payrec on payrec.recnum = tmcdln.recnum"
                + " into table {1}"
                , payrecs_tbl, analysis_tbl);

            switch (type)
            {
                case TCAmountType.GrossPay:
                    SetAmountToGrossPay(analysis_tbl);
                    break;

                case TCAmountType.Calculation:
                    // first filter out the lines that this calculation does not apply to
                    con.ExecuteNonQuery("delete anal"
                        + " from {0} anal"
                        + " left join tmcddd on tmcddd.clcnum = {1} and tmcddd.recnum = anal.recnum"
                        + " where isnull(tmcddd.amount) or tmcddd.amount = 0"
                        , analysis_tbl, clcnum);

                    // then run
                    var cnt = con.GetScalar<long>("select count(*) from {0}", analysis_tbl);
                    if (cnt > 0)
                    {
                        SetAmountToCalculation(analysis_tbl, clcnum);
                    }
                    break;

                default:
                    throw new NotImplementedException();
            }

            // filter out the items that we don't care about
            if (keep == null || _cached_lines != lines)
            {
                keep = con.GetTempDBF();

                con.ExecuteNonQuery("create table {0} (recnum n(10,0) not null, linnum n(4,0) not null)", keep);
                foreach (var l in lines_array)
                {
                    con.ExecuteNonQuery("insert into {0} (recnum, linnum) values ({1}, {2})"
                        , keep, l.payrec, l.lineno);
                }
            }

            con.ExecuteNonQuery("delete anal from {0} anal"
                + " left join {1} keep on keep.recnum = anal.recnum and keep.linnum = anal.linnum"
                + " where isnull(keep.recnum)"
                , analysis_tbl, keep);

            // now add the linnum = 0 records to our analysis table, this should be fast
            foreach (var l in lines)
            {
                if (l.lineno == 0)
                {
                    con.ExecuteNonQuery("insert into {0} (recnum, linnum, amount, recttl, mult, taxste) values ({1}, 0, 0, 0, 0, '')", analysis_tbl, l.payrec);
                }
            }

            switch (type)
            {
                case TCAmountType.GrossPay:
                    con.ExecuteNonQuery("update anal set amount = payrec.grspay, recttl = payrec.grspay, mult = 1, taxste = payrec.taxste"
                        + " from {0} anal"
                        + " join payrec on payrec.recnum = anal.recnum"
                        + " where anal.linnum = 0"
                        , analysis_tbl);
                    break;

                case TCAmountType.Calculation:
                    con.ExecuteNonQuery("update anal set amount = tmcddd.amount, recttl = tmcddd.amount, mult = 1, taxste = payded.taxste"
                        + " from {0} anal"
                        + " join tmcddd on tmcddd.clcnum = {1} and tmcddd.recnum = anal.recnum"
                        + " join payded on payded.recnum = tmcddd.clcnum"
                        + " where anal.linnum = 0"
                        , analysis_tbl, clcnum);
                    break;

                default:
                    throw new NotImplementedException();
            }

            return analysis_tbl;
        }
    }
}
