using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Environment;
using SysconCommon.Accounting;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class TimeAndMaterial : ITimeAndMaterial
    {
        private static string _cache_string;
        private static DataTable _cache;
        private static Dictionary<int, DataRow> _cache_dictionary;

        public static void SetCache(string sqlfmt, params object[] args)
        {
            var sql = string.Format(sqlfmt, args);
            if (_cache_string == sql)
                return;

            ClearCache();

            _cache_string = sql;
            _cache = Connections.Connection.GetDataTable("cache", sqlfmt, args);
            _cache_dictionary = new Dictionary<int,DataRow>();

            foreach (DataRow row in _cache.Rows)
            {
                _cache_dictionary.Add(Convert.ToInt32(row["recnum"]), row);
            }
        }

        public static void ClearCache()
        {
            _cache_dictionary = null;
            _cache = null;
            _cache_string = null;
        }
        
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
                try
                {
                    return Convert.ToInt32(_cache_dictionary[Recnum]["emptbl"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<int>("select emptbl from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToInt32(_cache_dictionary[Recnum]["eqptbl"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<int>("select eqptbl from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return _cache_dictionary[Recnum]["eqptbl"].ToString();
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<string>("select notes from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["labhdn"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select labhdn from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["labshw"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select labshw from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["labovh"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select labovh from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["labpft"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select labpft from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["eqphdn"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select eqphdn from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["eqpshw"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select eqpshw from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["eqpovh"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select eqpovh from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["eqppft"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select eqppft from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["subhdn"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select subhdn from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["subshw"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select subshw from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["subovh"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select subovh from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["subpft"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select subpft from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["otrhdn"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select otrhdn from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["otrshw"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select otrshw from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["otrovh"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select otrovh from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["otrpft"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select otrpft from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["cs6hdn"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select cs6hdn from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["cs6shw"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select cs6shw from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["cs6ovh"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select cs6ovh from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[Recnum]["cs6pft"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select cs6pft from timmat where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
