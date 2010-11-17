using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common;
using SysconCommon.Accounting;
using SysconCommon.Common.Environment;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class TimeAndMaterialLineItem : ITimeAndMaterialLineItem
    {
        static private string _cache_string;
        static private DataTable _cache;
        static private Dictionary<Common.Tuple<int, int>, DataRow> _cache_dictionary;

        static public void SetCache(string sqlfmt, params object[] args)
        {
            var sql = string.Format(sqlfmt, args);
            if (_cache_string == sql)
                return;

            _cache_string = sql;
            _cache = Connections.Connection.GetDataTable("cache", sqlfmt, args);
            _cache_dictionary = new Dictionary<Common.Tuple<int, int>, DataRow>();

            foreach (DataRow row in _cache.Rows)
            {
                Common.Tuple<int, int> key = new Common.Tuple<int, int>(Convert.ToInt32(row["recnum"]), Convert.ToInt32(row["linnum"]));
                _cache_dictionary.Add(key, row);
            }
        }

        static public IEnumerable<TimeAndMaterialLineItem> GetFromCache(Func<DataRow, bool> filter)
        {
            foreach (DataRow row in _cache.Rows)
            {
                if (filter(row))
                    yield return new TimeAndMaterialLineItem(Convert.ToInt32(row["recnum"]), Convert.ToInt32(row["linnum"]));
            }
        }

        public TimeAndMaterialLineItem(int recnum, int linnum)
        {
            this.Recnum = recnum;
            this.LineNumber = linnum;
        }

        public int Recnum { get; set; }
        public int LineNumber { get; set; }

        private Common.Tuple<int, int> _MyKey 
        {
            get 
            {
                return new Common.Tuple<int,int>(Recnum, LineNumber);
            }
        }

        public IEmployee Employee
        {
            get
            {
                try
                {
                    var empnum = Convert.ToInt32(_cache_dictionary[_MyKey]["empnum"]);
                    return empnum == 0 ? null : new Employee(empnum);
                }
                catch
                {
                    return Cache.CacheResult<IEmployee>(() =>
                    {
                        var empnum = Connections.GetScalar<int>(
                            "select empnum from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);

                        return empnum == 0 ? null : new Employee(empnum);
                    }, Recnum, LineNumber);
                }
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
                try
                {
                    return new CostCode(Convert.ToInt32(_cache_dictionary[_MyKey]["cstcde"]));
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return new CostCode(Connections.GetScalar<int>(
                            "select cstcde from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber));
                    }, Recnum, LineNumber);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[_MyKey]["rate01"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>(
                            "select rate01 from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                    }, Recnum, LineNumber);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[_MyKey]["rate02"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>(
                            "select rate02 from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                    }, Recnum, LineNumber);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[_MyKey]["rate03"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>(
                            "select rate03 from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                    }, Recnum, LineNumber);
                }
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
                try
                {
                    return Convert.ToDecimal(_cache_dictionary[_MyKey]["minhrs"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>(
                            "select minhrs from tmemln where recnum = {0} and linnum = {1}", Recnum, LineNumber);
                    }, Recnum, LineNumber);
                }
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
