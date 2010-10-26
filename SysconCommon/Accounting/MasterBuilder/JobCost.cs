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
            Id = id;
        }

        public int Id { get; set; }

        public IJob Job
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new Job(Connections.GetScalar<string>("select jobnum from jobcst where recnum = {0}", Id));
                }, Id);
            }
        }

        public decimal CostHours
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select csthrs from jobcst where recnum = {0}", Id);
                }, Id);
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
                    return Connections.GetScalar<int>("select actprd from jobcst where recnum = {0}", Id);
                }, Id);
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
                    return Connections.GetScalar<int>("select status from jobcst where recnum = {0}", Id);
                }, Id);
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
                    return new CostCode(Connections.GetScalar<decimal>("select cstcde from jobcst where recnum = {0}", Id));
                }, Id);
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
                    var empnum = Connections.GetScalar<int>("select empnum from jobcst where recnum = {0}", Id);
                    return empnum == 0 ? null : new Employee(empnum);
                }, Id);
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
                    return Connections.GetScalar<decimal>("select cstamt from jobcst where recnum = {0}", Id);
                }, Id);
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
                    return new CostType(Connections.GetScalar<int>("select csttyp from jobcst where recnum = {0}", Id));
                }, Id);
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
                    var eqpnum = Connections.GetScalar<int>("select eqpnum from jobcst where recnum = {0}", Id);
                    if (eqpnum == 0)
                        return null;
                    else
                        return new Equipment(eqpnum);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
