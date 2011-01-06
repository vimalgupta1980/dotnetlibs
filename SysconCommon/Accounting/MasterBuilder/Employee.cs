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
    public class Employee : IEmployee
    {
        static private DataTable _cache;
        static private string _cache_string;
        static private Dictionary<int, DataRow> _cache_dictionary;

        static public void SetCache(string sqlfmt, params object[] args)
        {
            try
            {
                var sql = string.Format(sqlfmt, args);
                if (_cache_string == sql)
                    return;

                _cache = Connections.Connection.GetDataTable("cache", sqlfmt, args);
                _cache_string = sql;
                _cache_dictionary = new Dictionary<int,DataRow>();

                foreach (DataRow r in _cache.Rows)
                {
                    _cache_dictionary.Add(Convert.ToInt32(r["recnum"]), r);
                }
            }
            catch
            {
                ClearCache();
            }
        }

        static public void ClearCache()
        {
            _cache = null;
            _cache_string = null;
            _cache_dictionary = null;
        }

        public Employee(int id)
        {
            try
            {
                var row = _cache_dictionary[id];
                loadFromDataRow(row);
            }
            catch
            {
                var dt = Connections.Connection.GetDataTable("emp", "select * from employ where recnum = {0}", id);
                if (dt.Rows.Count == 0)
                // throw new SysconException("Employee row not found");
                {
                    this.Recnum = id;
                    this.FirstName = "";
                    this.LastName = "";
                    this.MiddleName = "";
                }

                loadFromDataRow(dt.Rows[0]);
            }
        }

        private void loadFromDataRow(DataRow row)
        {
            this.Recnum = Convert.ToInt32(row["recnum"]);
            this.FirstName = row["fstnme"].ToString();
            this.LastName = row["lstnme"].ToString();
            this.MiddleName = row["midini"].ToString();
        }

        public int Recnum { get; set; }

        private string _FirstName;
        public string FirstName
        {
            get
            {
                if (_FirstName != null)
                    return _FirstName;

                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select fstnme from employ where recnum = {0}", Recnum).NullToBlank().Trim(), Recnum);
            }
            set
            {
                _FirstName = value;
            }
        }

        private string _LastName;
        public string LastName
        {
            get
            {
                if (_LastName != null)
                    return _LastName;

                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select lstnme from employ where recnum = {0}", Recnum).NullToBlank().Trim(), Recnum);
            }
            set
            {
                _LastName = value;
            }
        }

        private string _MiddleName;
        public string MiddleName
        {
            get
            {
                if (_MiddleName != null)
                    return _MiddleName;

                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select midini from employ where recnum = {0}", Recnum).NullToBlank().Trim(), Recnum);
            }
            set
            {
                _MiddleName = value;
            }
        }
    }
}
