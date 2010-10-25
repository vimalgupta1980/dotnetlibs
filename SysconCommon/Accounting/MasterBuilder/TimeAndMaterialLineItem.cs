using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Accounting;
using SysconCommon.Common.Environment;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class TimeAndMaterialLineItem : ITimeAndMaterialLineItem
    {
        public TimeAndMaterialLineItem(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }

        public int LineNumber
        {
            get
            {
                return Cache.CacheResult<int>(() =>
                {
                    return Connections.GetScalar<int>("select linnum from tmemln where recnum = {0}", Id);
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
                return Cache.CacheResult<IEmployee>(() =>
                {
                    return new Employee(Connections.GetScalar<int>("select empnum from tmemln where recnum = {0}", Id));
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
                    return new CostCode(Connections.GetScalar<int>("select cstcde from tmemln where recnum = {0}", Id));
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal PayRate1
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select rate01 from tmemln where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal PayRate2
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select rate02 from tmemln where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal PayRate3
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select rate03 from tmemln where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal MinHours
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select minhrs from tmemln where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
