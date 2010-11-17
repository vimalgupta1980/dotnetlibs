using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Accounting;
using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Invoice : IInvoice
    {
        static private string _cache_string;
        static private DataTable _cache;
        static private Dictionary<int, DataRow> _cache_dictionary;

        public Invoice(int id)
        {
            this.Recnum = id;
        }

        static public void SetCache(string sqlfmt, params object[] args)
        {
            var sql = string.Format(sqlfmt, args);
            if (sql == _cache_string)
                return;

            ClearCache();
            _cache_string = sql;
            _cache = Connections.Connection.GetDataTable("cache", sqlfmt, args);
            _cache_dictionary = new Dictionary<int, DataRow>();
            foreach (DataRow row in _cache.Rows)
            {
                _cache_dictionary.Add(Convert.ToInt32(row["recnum"]), row);
            }
        }

        static public IEnumerable<Invoice> GetFromCache(Func<DataRow, bool> filter)
        {
            foreach (DataRow r in _cache.Rows)
            {
                if (filter(r))
                    yield return new Invoice(Convert.ToInt32(r["recnum"]));
            }
        }

        static public void ClearCache()
        {
            _cache_string = null;
            _cache_dictionary = null;
            _cache = null;
        }

        public int Recnum { get; set; }

        public decimal InvoiceTotal
        {
            get
            {
                try
                {
                    var row = _cache_dictionary[Recnum];
                    return Convert.ToDecimal(row["invttl"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<decimal>("select invttl from acrinv where recnum = {0}", Recnum);
                    }, Recnum);
                }
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IJob Job
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new Job(Connections.GetScalar<string>("select jobnum from acrinv where recnum = {0}", Recnum));
                }, Recnum);
            }
        }

        public int Period
        {
            get
            {
                try
                {
                    var row = _cache_dictionary[Recnum];
                    return Convert.ToInt32(row["actper"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<int>("select actper from acrinv where recnum = {0}", Recnum);
                    }, Recnum);
                }
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
                try
                {
                    var row = _cache_dictionary[Recnum];
                    return Convert.ToInt32(row["status"]);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return Connections.GetScalar<int>("select status from acrinv where recnum = {0}", Recnum);
                    }, Recnum);
                }
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
