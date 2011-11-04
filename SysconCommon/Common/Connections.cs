using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.IO;

namespace SysconCommon.Common.Environment
{
    public static class Connections
    {
        static private OdbcConnection _con = null;

        static public void SetOLEDBFreeTableDirectory(string mbdir)
        {
            SysconCommon.Common.Environment.Connections.OLEDBConnectionString = string.Format(
                "Provider=VFPOLEDB.1;Data Source={0};Mode=ReadWrite|Share Deny None;Password=\"\";Collating Sequence=Machine"
                , mbdir);
        }

        static public System.Data.SQLite.SQLiteConnection GetInMemoryDB()
        {
            var con = new System.Data.SQLite.SQLiteConnection();
            con.ConnectionString = "Data Source=:memory:";
            con.Open();
            return con;
        }

        static private string _OLEDBConnectionString = null;
        static public string OLEDBConnectionString
        {
            get
            {
                return _OLEDBConnectionString;
            }
            set
            {
                if (_OLEDBConnectionString == value)
                    return;

                _OLEDBConnectionString = value;
            }
        }

        static public OleDbConnection GetExcelOleDbConnection(string workbook)
        {
            OleDbConnection con = null;

            switch (Path.GetExtension(workbook).ToLower())
            {
                case ".xlsm":
                    con = new OleDbConnection(string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Macro;HDR=Yes;\"", workbook));
                    break;
                case ".xlsx":
                    con = new OleDbConnection(string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=Yes;\"", workbook));
                    break;
                default:
                    throw new NotImplementedException();
            }

            con.Open();
            return con;
        }

        static public OleDbConnection GetOLEDBConnection()
        {
            var con = new OleDbConnection(OLEDBConnectionString);
            con.Open();
            return con;
        }

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
                var scalar = cmd.ExecuteScalar();
                if (scalar != null && scalar.GetType() == typeof(string))
                {
                    var sscalar = scalar as string;
                    if (sscalar.Trim() == "")
                        return default(T);
                }
                if (scalar == null)
                {
                    return default(T);
                }

                return (T) Convert.ChangeType(scalar, typeof(T));
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

        static public void ExecuteNonQuery(this IDbConnection con, OleDbTransaction trans, string sqlfmt, params object[] args)
        {
            var cmd = con.CreateCommand();
            
            if (trans != null)
            {
                var oledbcmd = cmd as OleDbCommand;
                if (oledbcmd == null)
                {
                    throw new SysconException("Oledb transaction provided for non oledb connection!");
                }
                oledbcmd.Transaction = trans;
            }

            cmd.CommandText = string.Format(sqlfmt, args);
            cmd.ExecuteNonQuery();
        }

        static public void ExecuteNonQuery(this IDbConnection con, string sqlfmt, params object[] args)
        {
            con.ExecuteNonQuery(null, sqlfmt, args);
        }
    }
}