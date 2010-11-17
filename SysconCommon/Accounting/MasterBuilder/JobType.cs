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
    public class JobType : IJobType
    {
        private static DataTable _cache = null;
        private static string _cache_string = null;

        static public void SetCache(string sqlfmt, params object[] args)
        {
            var cache_string = string.Format(sqlfmt, args);

            if (_cache_string == cache_string)
                return;

            _cache = Connections.Connection.GetDataTable("cache", cache_string);
            _cache_string = cache_string;
        }

        static public void ClearCache()
        {
            _cache = null;
            _cache_string = null;
        }

        public JobType(int id)
        {
            if (_cache != null)
            {
                var row = (from r in _cache.Rows.ToIEnumerable()
                           where Convert.ToInt32(r["recnum"]) == id
                           select r).FirstOrDefault();

                if (row != null)
                {
                    loadFromDataRow(row);
                    return;
                }
            }

            this.Recnum = id;
        }

        public void loadFromDataRow(DataRow row)
        {
            this.Recnum = Convert.ToInt32(row["recnum"]);
            this.Name = row["typnme"].ToString();
        }

        public int Recnum { get; set; }

        private string _Name = null;
        public string Name
        {
            get
            {
                if (_Name != null)
                    return _Name;

                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select typnme from jobtyp where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                _Name = value;
            }
        }

        public override string ToString()
        {
            return this.Name != null ? string.Format("{0} - {1}", this.Recnum, this.Name) : this.Recnum.ToString();
        }
    }
}
