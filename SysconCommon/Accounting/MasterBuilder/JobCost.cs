using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using SysconCommon.Accounting;
using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class JobCost : IJobCost
    {
        static private string _cache_string = null;
        static private DataTable _cache = null;
        static private Dictionary<int, DataRow> _cache_dictionary;

        public JobCost(int id)
        {
            if (_cache != null)
            {
                DataRow row = null;

                try
                {
                    row = _cache_dictionary[id];
                }
                catch { }

                if (row != null)
                {
                    this.fillFromRow(row);
                    return;
                }
            }

            var dt = Connections.Connection.GetDataTable("jobcosts", "select * from jobcst where recnum = {0}", id);
            if (dt.Rows.Count == 0)
                throw new SysconException("Row not found");

            this.fillFromRow(dt.Rows[0]);
        }

        public static IEnumerable<JobCost> GetFromCache(Func<DataRow, bool> filter)
        {
            List<JobCost> rv = new List<JobCost>();

            if (_cache == null)
                throw new SysconException("No cache available");

            foreach (var row in _cache.Rows.ToIEnumerable())
            {
                if (filter(row))
                {
                    rv.Add(new JobCost(Convert.ToInt32(row["recnum"])));
                }
            }

            return rv;
        }

        public void fillFromRow (DataRow row)
        {
            this.Recnum = Convert.ToInt32(row["recnum"]);
            this.CostHours = Convert.ToDecimal(row["csthrs"]);
            this.Period = Convert.ToInt32(row["actprd"]);
            this.Status = Convert.ToInt32(row["status"]);
            this.Cost = Convert.ToInt32(row["cstamt"]);
            this.BillingStatus = Convert.ToInt32(row["bllsts"]);
            this.BillingTotal = Convert.ToDecimal(row["blgttl"]);
            this.PayType = Convert.ToInt32(row["paytyp"]);
            this.EquipmentQuantity = Convert.ToDecimal(row["eqpqty"]);
            this.BillingQuantity = Convert.ToDecimal(row["blgqty"]);
            this.TransactionNumber = row["trnnum"].ToString().NullToBlank();
            this.Description = row["dscrpt"].ToString().NullToBlank();
            this.TransactionDate = Convert.ToDateTime(row["trndte"]);
            this.CostType = new CostType(Convert.ToInt32(row["csttyp"]));
            this.Vendor = new Vendor(Convert.ToInt64(row["vndnum"]));
            // this.Acrinv = Convert.ToInt64(row["acrinv"]);
        }

        static public void SetCache(string sqlfmt, params object[] args)
        {
            var cache_string = string.Format(sqlfmt, args);
            if(_cache_string == cache_string)
                return;

            _cache_string = cache_string;
            _cache = Connections.Connection.GetDataTable("cache", sqlfmt, args);

            _cache_dictionary = new Dictionary<int, DataRow>();
            foreach (DataRow r in _cache.Rows)
            {
                _cache_dictionary.Add(Convert.ToInt32(r["recnum"]), r);
            }
        }

        static public void ClearCache()
        {
            _cache_string = null;
            _cache = null;

            MasterBuilder.Employee.ClearCache();
            // MasterBuilder.JobType.ClearCache();
        }

        public int Recnum { get; set; }

        public IJob Job
        {
            get
            {
                try
                {
                    return new Job(_cache_dictionary[Recnum]["jobnum"].ToString());
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return new Job(Connections.GetScalar<string>("select jobnum from jobcst where recnum = {0}", Recnum));
                    }, Recnum);
                }
            }
        }

        private decimal? _CostHours;
        public decimal CostHours
        {
            get
            {
                if (_CostHours != null)
                    return _CostHours.Value;

                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select csthrs from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                _CostHours = value;
            }
        }

        private int? _Period;
        public int Period
        {
            get
            {
                if (_Period != null)
                    return _Period.Value;

                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select actprd from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                _Period = value;
            }
        }

        private int? _Status;
        public int Status
        {
            get
            {
                if (_Status != null)
                    return _Status.Value;

                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select status from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                _Status = value;
            }
        }


        public ICostCode _CostCode;
        public ICostCode CostCode
        {
            get
            {
                if(_CostCode != null)
                    return _CostCode;

                try
                {
                    var code = Convert.ToDecimal(_cache_dictionary[Recnum]["cstcde"]);
                    return new CostCode(code);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return new CostCode(Connections.GetScalar<decimal>("select cstcde from jobcst where recnum = {0}", Recnum));
                    }, Recnum);
                }
            }
            set
            {
                _CostCode = value;
            }
        }

        private IEmployee _Employee;
        public IEmployee Employee
        {
            get
            {
                if (_cache != null)
                {
                    /*
                    var all_recnums = (from r in _cache.Rows.ToIEnumerable()
                                       select r["empnum"].ToString().Trim())
                                       .Uniq()
                                       .ToArray();

                    var emp_cache_string = "select * from employ where recnum in ({0})";
                    MasterBuilder.Employee.SetCache(emp_cache_string, string.Join(",", all_recnums));
                     */
                }

                if (_Employee != null)
                    return _Employee;

                return Cache.CacheResult(() =>
                {
                    if (_cache != null)
                    {
                        var empid = Convert.ToInt32(_cache_dictionary[Recnum]["empnum"]);
                        return empid != 0 ? new Employee(empid) : null;
                    }

                    var empnum = Connections.GetScalar<int>("select empnum from jobcst where recnum = {0}", Recnum);
                    return empnum == 0 ? null : new Employee(empnum);
                }, Recnum);
            }
            set
            {
                _Employee = value;
            }
        }


        private decimal? _Cost;
        public decimal Cost
        {
            get
            {
                if(_Cost != null)
                    return _Cost.Value;

                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cstamt from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                _Cost = value;
            }
        }


        private ICostType _CostType;
        public ICostType CostType
        {
            get
            {
                if (_CostType != null)
                    return _CostType;

                return Cache.CacheResult(() =>
                {
                    return new CostType(Connections.GetScalar<int>("select csttyp from jobcst where recnum = {0}", Recnum));
                }, Recnum);
            }
            set
            {
                _CostType = value;
            }
        }

        private IEquipment _Equipment;
        public IEquipment Equipment
        {
            get
            {
                if (_Equipment != null)
                    return _Equipment;

                try
                {
                    var eqpnum = Convert.ToInt32(_cache_dictionary[Recnum]["eqpnum"]);
                    return eqpnum == 0 ? null : new Equipment(eqpnum);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        var eqpnum = Connections.GetScalar<int>("select eqpnum from jobcst where recnum = {0}", Recnum);
                        if (eqpnum == 0)
                            return null;
                        else
                            return new Equipment(eqpnum);
                    }, Recnum);
                }
            }
            set
            {
                _Equipment = value;
            }
        }


        private int? _BillingStatus = null;
        public int BillingStatus
        {
            get
            {
                if (_BillingStatus != null)
                {
                    return _BillingStatus.Value;
                }
                else
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<int>("select bllsts from jobcst where recnum = {0}", Recnum);
                    }, Recnum);
                }
            }
            set
            {
                _BillingStatus = value;
            }
        }

        private decimal? _BillingTotal;
        public decimal BillingTotal
        {
            get
            {
                if (_BillingTotal != null)
                    return _BillingTotal.Value;

                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select blgttl from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                _BillingTotal = value;
            }
        }


        private int? _PayType;
        public int PayType
        {
            get
            {
                if (_PayType != null)
                    return _PayType.Value;

                return Cache.CacheResult(() => Connections.GetScalar<int>("select paytyp from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                _PayType = value;
            }
        }

        private decimal? _EquipmentQuantity;
        public decimal EquipmentQuantity
        {
            get
            {
                if (_EquipmentQuantity != null)
                    return _EquipmentQuantity.Value;

                return Cache.CacheResult(() => Connections.GetScalar<decimal>("select eqpqty from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                _EquipmentQuantity = value;
            }
        }

        private IInvoice _Invoice;
        public IInvoice Invoice
        {
            get
            {
                
                if (_Invoice != null)
                    return _Invoice;
                
                /*
                SysconCommon.Accounting.MasterBuilder.Invoice.SetCache("select * from acrinv where jobnum = {0}", this.Job.JobNumber);
                return MasterBuilder.Invoice.GetFromCache(row => Convert.ToInt32(row["jobcst"]) == Recnum).FirstOrDefault();
                 */
                try
                {
                    var acrinv = Convert.ToInt32(_cache_dictionary[Recnum]["acrinv"]);
                    return acrinv == 0 ? null : new Invoice(acrinv);
                }
                catch
                {
                    var acrinv = Connections.GetScalar<int>("select acrinv from jobcst where recnum = {0}", Recnum);
                    return acrinv == 0 ? null : new Invoice(acrinv);
                }
            }
            set
            {
                _Invoice = value;
            }
        }

        private decimal? _BillingQuantity;
        public decimal BillingQuantity
        {
            get
            {
                if (_BillingQuantity != null)
                    return _BillingQuantity.Value;

                return Cache.CacheResult(() => Connections.GetScalar<decimal>(
                    "select blgqty from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                _BillingQuantity = value;
            }
        }

        private string _TransactionNumber;
        public string TransactionNumber
        {
            get
            {
                if (_TransactionNumber != null)
                    return _TransactionNumber;

                try
                {
                    return _cache_dictionary[Recnum]["trnnum"].ToString();
                }
                catch
                {
                    return Cache.CacheResult(() => Connections.GetScalar<string>(
                        "select trnnum from jobcst where recnum = {0}", Recnum), Recnum);
                }
            }
            set
            {
                _TransactionNumber = null;
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                if(_Description != null)
                    return _Description;

                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select dscrpt from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                _Description = value;
            }
        }

        public DateTime _TransactionDate;
        public DateTime TransactionDate
        {
            get
            {
                if(_TransactionDate != null)
                    return _TransactionDate;

                return Cache.CacheResult(() => Connections.GetScalar<DateTime>(
                    "select trndte from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                _TransactionDate = value;
            }
        }


        private ISource _Source;
        public ISource Source
        {
            get
            {
                if(_Source != null)
                    return _Source;

                try
                {
                    var srcnum = Convert.ToInt32(_cache_dictionary[Recnum]["srcnum"]);
                    return srcnum == 0 ? null : new Source(srcnum);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        var srcnum = Connections.GetScalar<int>("select srcnum from jobcst where recnum = {0}", Recnum);
                        return srcnum == 0 ? null : new Source(srcnum);
                    }, Recnum);
                }
            }
            set
            {
                _Source = value;
            }
        }


        private IPhase _Phase;
        public IPhase Phase
        {
            get
            {
                if(_Phase != null)
                    return _Phase;

                try
                {
                    var phsnum = Convert.ToInt32(_cache_dictionary[Recnum]["phsnum"]);
                    return new Phase(this.Job, phsnum);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        var phsnum = Connections.GetScalar<int>("select phsnum from jobcst where recnum = {0}", Recnum);
                        return new Phase(this.Job, phsnum);
                    }, Recnum);
                }
            }
            set
            {
                _Phase = value;
            }
        }

        public IVendor Vendor { get; set; }


        public long Acrinv
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
