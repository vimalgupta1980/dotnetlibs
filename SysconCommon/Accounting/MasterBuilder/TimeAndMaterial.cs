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
            this.Recnum = id;
        }

        public int Recnum { get; set; }


        public IJob Job
        {
            get { return new Job(Recnum.ToString()); }
        }

        public int WageRate
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select emptbl from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int EquipmentRate
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select eqptbl from timmat where recnum = {0}", Recnum);
                }, Recnum);
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
                    return Connections.GetScalar<string>("select notes from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
