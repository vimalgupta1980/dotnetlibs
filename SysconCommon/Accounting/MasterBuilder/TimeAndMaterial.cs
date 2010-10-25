using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common.Environment;
using SysconCommon.Accounting;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class TimeAndMaterial : ITimeAndMaterial
    {
        public TimeAndMaterial(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }


        public IJob Job
        {
            get { return new Job(Id.ToString()); }
        }

        public decimal WageRate
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select emptbl from timmat where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal EquipmentRate
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select eqptbl from timmat where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Notes
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select notes from timmat where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
