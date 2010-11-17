using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;

namespace SysconCommon.Common.Environment
{
    public static class Connections
    {
        static private OdbcConnection _con = null;

        static private string _OdbcConnectionString = null;
        static public string OdbcConnectionString
        {
            get
            {
                if (_OdbcConnectionString == null)
                {
                    _OdbcConnectionString = string.Format("DSN={0}", Env.GetConfigVar("dsnname"));
                }

                return _OdbcConnectionString;
            }
            set
            {
                _OdbcConnectionString = value;

                if (_con != null)
                {
                    try
                    {
                        _con.Close();
                        _con.Dispose();
                    }
                    finally
                    {
                        _con = null;
                    }
                }
            }
        }

        static public OdbcConnection Connection
        {
            get
            {
                if (_con == null)
                {
                    _con = new OdbcConnection(OdbcConnectionString);
                    _con.Open();
                }

                return _con;
            }
        }

        static public T GetScalar<T>(this OdbcConnection con, string sqlfmt, params object[] args)
        {
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(sqlfmt, args);
                Env.DebugPrint(cmd.CommandText);
                return (T) Convert.ChangeType(cmd.ExecuteScalar(), typeof(T));
            }
        }

        static public T GetScalar<T>(string sqlfmt, params object[] args)
        {
            return Connection.GetScalar<T>(sqlfmt, args);
        }

        static public IEnumerable<T> GetList<T>(this OdbcConnection con, string sqlfmt, params object[] args)
        {
            List<T> rv = new List<T>();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(sqlfmt, args);
                Env.DebugPrint(cmd.CommandText);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    rv.Add((T)Convert.ChangeType(rdr[0], typeof(T)));
                }
            }

            return rv;
        }

        static public IEnumerable<T> GetList<T>(string sqlfmt, params object[] args)
        {
            return Connection.GetList<T>(sqlfmt, args);
        }
    }
}