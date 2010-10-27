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


        public decimal MaterialHidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select mtrhdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal MaterialShown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select mtrshw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal MaterialOverhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select mtrovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal MaterialProfit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select mtrpft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal LaborHidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select labhdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal LaborShown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select labshw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal LaborOverhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select labovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal LaborProfit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select labpft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal EquipmentHidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select eqphdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal EquipmentShown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select eqpshw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal EquipmentOverhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select eqpovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal EquipmentProfit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select eqppft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal SubcontractHidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select subhdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal SubcontractShown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select subshw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal SubcontractOverhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select subovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal SubcontractProfit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select subpft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal OtherHidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select otrhdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal OtherShown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select otrshw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal OtherOverhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select otrovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal OtherProfit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select otrpft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef6Hidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs6hdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef6Shown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs6shw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef6Overhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs6ovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef6Profit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs6pft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef7Hidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs7hdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef7Shown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs7shw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef7Overhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs7ovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef7Profit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs7pft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef8Hidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs8hdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef8Shown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs8shw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef8Overhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs8ovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef8Profit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs8pft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef9Hidden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs9hdn from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef9Shown
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs9shw from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef9Overhead
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs9ovh from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal UserDef9Profit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select cs9pft from timmat where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
