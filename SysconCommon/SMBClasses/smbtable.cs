using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Validity;

namespace SMB.Tables
{
    public class smbtable
    {
        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
                return false;

            var type = this.GetType();
            
            foreach (var fi in type.GetFields())
            {
                if (!fi.GetValue(this).Equals(fi.GetValue(obj)))
                {
                    return false;
                }
            }

            // all fields match
            return true;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public static T[] GetAll<T>(string tblname)
            where T: smbtable, new()
        {
            if(tblname == null)
                tblname = typeof(T).Name;

            var dt = Connections.Connection.GetDataTable(tblname, "select * from " + tblname);
            return dt.ToList<T>().ToArray();
        }

        public static T[] GetAll<T>()
            where T : smbtable, new()
        {
            return GetAll<T>(null);
        }

        public static T[] Get<T>(string sql, params object[] args)
            where T: smbtable, new()
        {
            var dt = Connections.Connection.GetDataTable("tmptable", sql, args);
            return dt.ToList<T>().ToArray();
        }

        public virtual void Save(params string[] UpdateFields)
        {
            var mytype = this.GetType();
            var tblname = mytype.Name;

            var members = from m in mytype.GetFields()
                          where m.GetCustomAttributes(typeof(SMBFieldNameAttribute), false).Length > 0
                          select m;

            if (UpdateFields.Length == 0)
            {
                var names = (from m in members
                             select ((SMBFieldNameAttribute)m.GetCustomAttributes(typeof(SMBFieldNameAttribute), false).First()).name).ToArray();

                var values = (from m in members
                              select m.GetValue(this).ToString()).ToArray();

                string sql = string.Format("insert into {0} ({1}) values ('{2}')", tblname, string.Join(",", names), string.Join("','", values));

                using (var cmd = Connections.Connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }

    public class SMBFieldDescriptionAttribute : Attribute
    {
        public readonly string description;
        public SMBFieldDescriptionAttribute(string desc)
        {
            description = desc;
        }
    }

    public class SMBFieldNameAttribute : Attribute
    {
        public readonly string name;
        public SMBFieldNameAttribute(string name)
        {
            this.name = name;
        }
    }

    public partial class actrec : smbtable
    {
        public override string ToString()
        {
            // return base.ToString();
            return string.Format("{0} - {1}", this.recnum, this.jobnme.Trim());
        }
    }

    public partial class employ : smbtable
    {
        public override string ToString()
        {
            // return base.ToString();
            return string.Format("{0} {1}", this.fstnme.Trim(), this.lstnme.Trim());
        }

        /// <summary>
        /// checks the ssn and zipcode for validity
        /// </summary>
        public bool IsValid
        {
            get
            {
                var match = Regex.Match(this.socsec, @"^\s*(\d\d\d)-(\d\d)-(\d\d\d\d)\s*$");
                if (!match.Success)
                    return false;

                int aaa = int.Parse(match.Groups[1].Value);
                int gg = int.Parse(match.Groups[2].Value);
                int ssss = int.Parse(match.Groups[3].Value);
                if (aaa == 0 || aaa == 66 || aaa > 800)
                    return false;
                if (gg == 0)
                    return false;
                if (ssss == 0)
                    return false;

                match = Regex.Match(this.zipcde, @"^\s*\d{5}([-]\d{4})?\s*$");
                if (!match.Success)
                    return false;

                return true;
            }
        }
    }

    public partial class payrec : smbtable
    {
        private decimal? _nontaxable_deductions_total = null;
        public decimal NonTaxableDeductionsTotal
        {
            get
            {
                if (_nontaxable_deductions_total == null)
                {
                    using (var con = Connections.GetOLEDBConnection())
                    {
                        _nontaxable_deductions_total = con.GetScalar<decimal>(
                            "select sum(amount) from tmcddd join payded on tmcddd on payded.recnum = tmcddd.clcnum where tmcddd.recnum = {0} and payded.fedtax = 0 and payded.clctyp = 1"
                            , this.recnum);
                    }
                }

                return _nontaxable_deductions_total.Value;
            }
        }
    }

    public partial class tmcdln : smbtable
    {
        public decimal CalculationTotal(long payded_recnum)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                // var dt = con.GetDataTable("data", "select payded.clcmth, payded.bsdded, payrec.grspay, tmcddd.amount, 
                throw new NotImplementedException();
            }
        }

        public decimal CalculationTotal(long clcmth, long bsdded, decimal grspay, decimal totalDeduction, decimal NonTaxableDeductionsTotal, decimal ttlhrs, long taxtyp)
        {
            // Validity.IsNotNull(deduction);
            // Validity.IsNotNull(payrecord);
            // Validity.IsNotNull(calc);

            // if (this.paygrp > 0)
                // Validity.IsNotNull(paygroup);

            switch (clcmth)
            {
                case 1:
                    return CalculationByGrossTotal(grspay, totalDeduction);
                
                case 2:
                    return CalculationByTaxableGrossTotal(grspay, NonTaxableDeductionsTotal, totalDeduction);
                
                case 7:
                    // use the base calculation type
                    // calc.clcmth = calc.bsdded;
                    // var rv = CalculationTotal(deduction, payrecord, calc, paygroup);
                    // calc.clcmth = 7;
                    // return rv;
                    using(var con = Connections.GetOLEDBConnection()) 
                    {
                        clcmth = con.GetScalar<long>("select clcmth from payded where recnum = {0}", bsdded);
                        bsdded = con.GetScalar<long>("select bsdded from payded where recnum = {0}", bsdded);
                        return CalculationTotal(clcmth, bsdded, grspay, totalDeduction, NonTaxableDeductionsTotal, ttlhrs, taxtyp);
                    }

                case 8:
                    return CalculationByWorkingHours(ttlhrs, this.hrswrk, totalDeduction);

                case 11: // Per Pay Period... no great way to allocate this across line items, so just do it as a % of the total
                    return CalculationByGrossTotal(grspay, totalDeduction);

                case 17:
                    switch (taxtyp)
                    {
                        case 11: // it's workmans comp
                            return CalculateWorkmansComp();                   
                        case 12: // it's liability insurance
                            return CalculateLiabilityInsurance();
                        default: // we don't know what it is, and cannot calculate it
                            throw new NotImplementedException();
                    }

                default:
                    throw new NotImplementedException();
            }
        }

        private decimal CalculateWorkmansComp()
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                var pctrte = con.GetScalar<decimal>("select pctrte from wrkcmp where recnum = {0}", this.cmpcde);
                return NonOvertimeGrossWages * pctrte / 100.0m;
            }
        }

        private decimal CalculateLiabilityInsurance()
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                var libins = con.GetScalar<decimal>("select libins from wrkcmp where recnum = {0}", this.cmpcde);
                return libins * NonOvertimeGrossWages;
            }
        }

        private decimal CalculationByGrossTotal(decimal payrec_gross, decimal deduction_total)
        {
            return deduction_total * (GrossWages / payrec_gross);
        }

        private decimal CalculationByTaxableGrossTotal(decimal paygrec_gross, decimal nontaxable_deductions, decimal deduction_total)
        {
            var taxable_gross = paygrec_gross - nontaxable_deductions;
            var taxable_pcnt = taxable_gross / paygrec_gross;

            return CalculationByGrossTotal(paygrec_gross, deduction_total) * taxable_pcnt;
        }

        private decimal CalculationByWorkingHours(decimal payrec_total_hrs, decimal line_hrs, decimal deduction_total)
        {
            return deduction_total * (line_hrs / payrec_total_hrs);
        }

        public decimal GrossWages 
        {
            get
            {
                return this.payrte * this.hrswrk;
            }
        }

        public decimal NonOvertimeGrossWages
        {
            get
            {
                var grs = GrossWages;
                var ot = this.paytyp == 2 || this.paytyp == 3
                    ? this.payrte * this.hrswrk - this.cmpsub * this.hrswrk
                    : 0.0m;

                return grs - ot;
            }
        }
    }
}
