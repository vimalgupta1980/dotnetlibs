using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Accounting;
using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class JobCost : IJobCost
    {
        public JobCost(int id)
        {
            Recnum = id;
        }

        public int Recnum { get; set; }

        public IJob Job
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new Job(Connections.GetScalar<string>("select jobnum from jobcst where recnum = {0}", Recnum));
                }, Recnum);
            }
        }

        public decimal CostHours
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select csthrs from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Period
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select actprd from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Status
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select status from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public ICostCode CostCode
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new CostCode(Connections.GetScalar<decimal>("select cstcde from jobcst where recnum = {0}", Recnum));
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IEmployee Employee
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var empnum = Connections.GetScalar<int>("select empnum from jobcst where recnum = {0}", Recnum);
                    return empnum == 0 ? null : new Employee(empnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public decimal Cost
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cstamt from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public ICostType CostType
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new CostType(Connections.GetScalar<int>("select csttyp from jobcst where recnum = {0}", Recnum));
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IEquipment Equipment
        {
            get
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
            set
            {
                throw new NotImplementedException();
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

        public decimal BillingTotal
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select blgttl from jobcst where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public int PayType
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<int>("select paytyp from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public decimal EquipmentQuantity
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<decimal>("select eqpqty from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IInvoice Invoice
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var acrinv = Connections.GetScalar<int>("select acrinv from jobcst where recnum = {0}", Recnum);
                    
                    if (acrinv == 0)
                        return null;

                    return new Invoice(acrinv);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public decimal BillingQuantity
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<decimal>(
                    "select blgqty from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public string TransactionNumber
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select trnnum from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Description
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select dscrpt from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public DateTime TransactionDate
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<DateTime>(
                    "select trndte from jobcst where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public ISource Source
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var srcnum = Connections.GetScalar<int>("select srcnum from jobcst where recnum = {0}", Recnum);
                    return srcnum == 0 ? null : new Source(srcnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IPhase Phase
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var phsnum = Connections.GetScalar<int>("select phsnum from jobcst where recnum = {0}", Recnum);
                    return new Phase(this.Job, phsnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
