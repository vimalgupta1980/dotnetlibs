using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
// using System.Data.SQLite; // used for sql dependancies, ie.. cursors

using SysconCommon.Common.Validity;
using SysconCommon.Algebras.Graphs;
// using SysconCommon.Algebras.JSON;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.Common.Environment
{
    public class EnvironmentalError : SysconException
    {
        public EnvironmentalError(Exception inner, string msg, params object[] args) : base(inner, string.Format(msg,args)) { }
    }

    /// <summary>
    /// This class is meant to wrap up any interaction with the environment on the machine.  Hopefully 
    /// making it easier to debug and so on.  These benefits only happen if you actually use this...
    /// 
    /// If you find your code requires anything in the System.IO or System.Console namespaces, then
    /// either you aren't using this when you should be, or this needs another operation to match
    /// what you need to do
    /// </summary>
    static public class Env
    {
        /// <summary>
        /// Setting Debug to true will tmpCopy in more logging
        /// </summary>
        static public bool Debug
        {
            get
            {
                return GetConfigVar("debug", true, true);
            }
            set
            {
                SetConfigVar("debug", value);
            }
        }

        /// <summary>
        /// ensure that a file exists
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        static private string _mbdir = null;

        static public string GetMBDir()
        {
            return _mbdir;
        }

        /// <summary>
        /// set master builder directory, sets odbc and oledb connections up
        /// </summary>
        static public void SetMBDir(string mbdir)
        {
            _mbdir = mbdir;

            Connections.SetOLEDBFreeTableDirectory(mbdir);
            Connections.OdbcConnectionString = string.Format(
                "Driver={{Microsoft Visual FoxPro Driver}};UID=;PWD=;SourceDB={0};SourceType=DBF;"
                + "Exclusive=No;BackgroundFetch=Yes;Collate=Machine;Null=Yes;Deleted=Yes;", mbdir);
        }

        static private string _LogFile = null;

        /// <summary>
        /// Get and set the log file name, this can be changed
        /// at any time and doesn't have to remain the same throughout
        /// the time the program runs.  By default the log file is
        /// set to log.txt in the directory of the .exe file running
        /// </summary>
        static public string LogFile
        {
            get
            {
                if (_LogFile == null)
                {
                    return GetEXEDirectory() + "/log.txt";
                }
                else
                {
                    return _LogFile;
                }
            }
            set
            {
                _LogFile = value;
            }
        }

        /// <summary>
        /// Log a message to LogFile, the format is the same as string.Format
        /// </summary>
        /// <param name="msgFormat"></param>
        /// <param name="arguments"></param>
        static public void Log(string msgFormat, params object[] arguments)
        {
            // var defaultLogFile = GetEXEDirectory() + "/log.txt";
            var defaultLogFile = "log.txt";
            File.AppendAllText(LogFile, string.Format(DateTime.Now.ToString() + " - " + msgFormat + "\r\n", arguments));
        }

        /// <summary>
        /// prints to stderr and logs if Debug is set to true, otherwise it 
        /// does nothing, on print it will append a single newline
        /// </summary>
        /// <param name="msgFormat"></param>
        /// <param name="arguments"></param>
        static public void DebugPrint(string msgFormat, params object[] arguments)
        {
            if (!Debug)
                return;

            var str = string.Format(msgFormat, arguments);

            Console.Error.WriteLine(str);
            Log("{0}: {1}", DateTime.Now.Date, str);
        }

        /// <summary>
        /// logs the exception to stderr and the log file
        /// </summary>
        /// <param name="ex"></param>
        static public void DebugPrint(Exception ex)
        {
            if (!Debug)
                return;

            if (ex.InnerException != null)
                DebugPrint(ex);

            DebugPrint("{0}\n{1}", ex.Message, ex.StackTrace);
        }

        /// <summary>
        /// returns the path to the directory that the calling assembly is in
        /// </summary>
        /// <returns></returns>
        static public string GetMyAssemblyDirectory()
        {
            var loc = Path.GetDirectoryName(Assembly.GetCallingAssembly().CodeBase.Substring(8));
            return loc;
        }

        /// <summary>
        /// Sets the current directory to the directory of the calling assembly
        /// </summary>
        static public void SetCurDirToMe()
        {
            var loc = Path.GetDirectoryName(Assembly.GetCallingAssembly().CodeBase.Substring(8));
            Directory.SetCurrentDirectory(loc);
        }

        /// <summary>
        /// returns the directory that the .exe lives in
        /// </summary>
        /// <returns></returns>
        static public string GetEXEDirectory()
        {
            try
            {
                var ass = Assembly.GetEntryAssembly();
                if (ass == null)
                    ass = Assembly.GetCallingAssembly();

                var codebase = ass.CodeBase;
                var exedir = Path.GetDirectoryName(codebase.Substring(8));
                return exedir;
            }
            catch (Exception ex)
            {
                /// we can't use a DTSException, because that may cause an infinite loop
                throw new Exception("Could not get EXE file", ex);
            }
        }

        /// <summary>
        /// returns all the string in a text file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        static public string GetFileText(string filename)
        {
            return File.ReadAllText(filename);
        }

        /// <summary>
        /// writes all text to the given filename, if the file already exists,
        /// it will be overwritten
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="filename"></param>
        static public void WriteFileText(string txt, string filename)
        {
            File.WriteAllText(filename, txt);
        }

        static public void AccessSMB()
        {
            var con = Connections.GetOLEDBConnection();

            con.ExecuteNonQuery("USE lckcmp");
            con.ExecuteNonQuery("APPEND BLANK");
            con.ExecuteNonQuery("GO BOTTOM");
            var lck = con.GetScalar<object>("RLOCK()");
        }

        #region Configuration Stuff

        /// <summary>
        /// allows a config file to be set, this file must already exist
        /// this will fail if the configuration file already been used
        /// because we want to ensure one config file is used throughout
        /// the entire running time
        /// </summary>
        static string _config_file = null;

        /// <summary>
        /// tracks if the config file has been used, this is used with
        /// _config_file to choose the correct file and throw an exception
        /// if necessary
        /// </summary>
        static bool _config_file_used = false;

        /// <summary>
        /// set the config file name.  The default is config.xml in the directory of the
        /// .exe file if this is never called.
        /// </summary>
        /// <param name="filename">
        /// the file to store configuration options in
        /// </param>
        /// <param name="createIfMissing">
        /// create the file if it doesn't already exist, defaults to true
        /// </param>
        static public void SetConfigFile(string filename, bool createIfMissing)
        {
            // being set to the same file multiple times is fine, and sometimes more conveneint
            if (filename == _config_file && _config_file_used)
                return; 

            // Validity.Validity.Assert(!_config_file_used, "SetConfigFile set after config use")

            if (!File.Exists(filename))
            {
                if (createIfMissing)
                    File.WriteAllText(filename, "<configuration />");
                else
                    throw new SysconException(string.Format("Config file {0} missing", filename));
            }

            _config_file = filename;
            _config_file_used = true;
            configDoc = null;
        }

        static public string GetConfigFile()
        {
            return configDocFileName;
        }

        /// <summary>
        /// set the config file name.  The default is config.xml in the directory of the
        /// .exe file if this is never called.
        /// </summary>
        /// <param name="filename">
        /// the file to store configuration options in
        /// </param>
        /// <param name="createIfMissing">
        /// create the file if it doesn't already exist, defaults to true
        /// </param>
        static public void SetConfigFile(string filename)
        {
            SetConfigFile(filename, true);
        }

        /// <summary>
        /// duh......
        /// </summary>
        static private string configDocFileName
        {
            get
            {
                if (_config_file != null)
                {
                    return _config_file;
                }
                else
                {
                    _config_file_used = true;
                    return string.Format("{0}/config.xml", GetEXEDirectory());
                }
            }
        }

#if false
        static private XmlDocument configDoc
        {
            get
            {
                string fname = configDocFileName;
                try
                {
                    if (!File.Exists(fname))
                    {
                        File.WriteAllText(fname, "<configuration />");
                        Validity.Validity.FilesExist(fname);
                    }

                    var xdoc = new XmlDocument();
                    xdoc.Load(fname);
                    return xdoc;
                }
                catch (Exception ex)
                {
                    throw new EnvironmentalError(ex, "Could not open config document ({0})", fname);
                }
            }
        }
#else
        /// <summary>
        /// we don't want multiple instances of configDoc because that creates a race
        /// condition and saves may be overwritten out of order
        /// </summary>
        static private XmlDocument _configDoc = null;

        static private XmlDocument configDoc
        {
            set
            {
                _configDoc = value;
            }
            get
            {
                if (_configDoc != null)
                    return _configDoc;

                string fname = configDocFileName;

                try
                {
                    if (!File.Exists(fname))
                    {
                        File.WriteAllText(fname, "<configuration />");
                    }

                    Validity.Validity.FilesExist(fname);

                    var xdoc = new XmlDocument();
                    xdoc.Load(fname);
                    _configDoc = xdoc;
                    return xdoc;
                }
                catch (Exception ex)
                {
                    throw new EnvironmentalError(ex, "Could not open config document ({0})", fname);
                }
            }
        }

        static private Func<string, string> _ConfigInjector = null;

        static public Func<string, string> ConfigInjector
        {
            get
            {
                return _ConfigInjector == null ? (s => s) : _ConfigInjector;
            }
            set
            {
                _ConfigInjector = value;
            }
        }
#endif

        static public void SetConfigVar<T>(string name, T value)
        {
            SetConfigVar(name, value, true);
        }

        /// <summary>
        /// progmatically set a configuration value, overwriting the existing one if required
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="value"></param>
        static private void SetConfigVar<T>(string name, T value, bool useInjector)
        {
            name = useInjector ? ConfigInjector(name) : name;

            var query = string.Format("/configuration/{0}", name);
            EnsureNodeExists(query, "/");

            name = Regex.Replace(query, @"^.*/", "");
            var xdoc = configDoc;
            var node = xdoc.SelectSingleNode(query);

            var new_node = xdoc.CreateNode(XmlNodeType.Element, name, null);
            new_node.InnerText = value == null ? null : value.ToString();
            node.ParentNode.ReplaceChild(new_node, node);
            xdoc.Save(configDocFileName);
        }

        /// <summary>
        /// used above to allow configuration variable "names" like someparent/somechild
        /// </summary>
        /// <param name="node_name"></param>
        /// <param name="root_name"></param>
        static private void EnsureNodeExists(string node_name, string root_name)
        {
            var nodes = node_name.Split('/').Where(node => node != "").ToArray();
            var n = configDoc.SelectSingleNode(root_name + "/" + nodes[0]);

            // create it if it doesn't exist
            if (n == null)
            {
                var root = configDoc.SelectSingleNode(root_name);
                n = configDoc.CreateNode(XmlNodeType.Element, nodes[0], null);
                root.AppendChild(n);
            }

            if (nodes.Count() > 1)
            {
                var new_root = string.Format("{0}/{1}", root_name, n.Name);
                var new_node_name = string.Join("/", nodes.Tail().ToArray());
                EnsureNodeExists(new_node_name, new_root);
            }
        }

        /// <summary>
        /// returns the configuration value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">name of the config var</param>
        /// <param name="defaultValue">default value if the config var doesn't exist</param>
        /// <param name="writeIfMissing">if this is true and the config var is missing, then the config var is saved</param>
        /// <returns></returns>
        static public T GetConfigVar<T>(string name, T defaultValue, bool writeIfMissing)
        {
            name = ConfigInjector(name);

            var n = configDoc.SelectSingleNode(string.Format("/configuration/{0}", name));

            if (n != null)
                return (T) Convert.ChangeType(n.InnerText.Trim(), typeof(T));

            if (writeIfMissing)
            {
                SetConfigVar(name, defaultValue, false);
                n = configDoc.SelectSingleNode(string.Format("/configuration/{0}", name));
                return (T)Convert.ChangeType(n.InnerText.Trim(), typeof(T));
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// returns the value of a configuration variable
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string GetConfigVar(string name)
        {
            return GetConfigVar<string>(name, null, false);
        }

        public static IEnumerable<XmlNode> ToIEnumerable(this XmlNodeList nodes)
        {
            foreach (var i in FunctionalOperators.Range(nodes.Count))
                yield return nodes[i];
        }

        /// <summary>
        /// returns the xml node of a configuration option for more complicated
        /// uses such as storing an list of items
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public XmlNode GetConfigXmlNode(string name)
        {
            name = ConfigInjector(name);

            var query = string.Format("/configuration/{0}", name);
            // DebugPrint("XPath query: {0}", query);
            var n = configDoc.SelectSingleNode(string.Format("/configuration/{0}", name));
            Validity.Validity.IsNotNull(n);
            return n;
        }

        static private string ReplaceSqlInputs(string sql, bool quote_lists)
        {
            var matches = Regex.Matches(sql, @"\{input:(.*?)\}");
            foreach (var m in matches.ToIEnumerable())
            {
                // DebugPrint("replacing {0}", m.Groups[1]);
                var value = GetConfigVar("userdefined/" + m.Groups[1].Value);
                value = value.Trim();

                if (quote_lists && Regex.Match(value, @"^[,1234567890]+$").Success)
                {
                    // DebugPrint("ListQuoting {0}", value);
                    var ids = value.Split(',');
                    value = string.Format("'{0}'", string.Join("','", ids));
                }
                else
                {
                    // DebugPrint("Not ListQuoting {0}", value);
                }

                sql = sql.Replace(m.Groups[0].Value, value.Trim());
            }

            return sql;
        }
#if false
        static public DataTable RunSqlStatementFromCursors(this OdbcConnection con, string tablename, string sql, params string[] args) 
        {
            // find the dependancies
            sql = string.Format(sql, args);
            var matches = Regex.Matches(sql, @"(from\s*(\w+)|join\s+(\w+)\s+on)");
            
            foreach(var m in matches.ToIEnumerable()) 
            {
                foreach (var i in FunctionalOperators.Range(2, m.Groups.Count))
                {
                    if (m.Groups[i].Value == "")
                        continue;

                    RunSqlStatement(con, m.Groups[i].Value);
                }
            }

            return SqliteCon.GetDataTable(tablename, sql);
        }
#endif

        static private bool IsQuery(string sql)
        {
            sql = sql.Trim().ToUpper();

            if (sql.Substring(0, 6) == "SELECT")
                return true;
            else
                return false;
        }

#if false
        /// <summary>
        /// Runs an sql statement, this is smart enough to run any dependancies into cursors and select from that
        /// </summary>
        /// <param name="con"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        static public DataTable RunSqlStatement(this OdbcConnection con, string name)
        {
            var graph = SQLGraph;
            Validity.Validity.Assert(graph.IsAcylic, "SQL Graph of dependancies must be acylic");
            
            var sqlStatementName = graph.Nodes.Where(n => n == name).FirstOrDefault();
            Validity.Validity.IsNotNull(sqlStatementName);
            var sqlStatement = GetConfigVar("sql/" + name).Trim();

            // get neighbors
            var neighbors = graph.NeighborFinder(name);

            if (!neighbors.IsEmpty())
            {
                // make sure the dependancies are run first
                foreach (var n in neighbors)
                {
                    con.RunSqlStatement(n);
                }

                sqlStatement = ReplaceSqlInputs(sqlStatement, true);

                // non-queries don't have a datatable to return, so are handled a bit differently
                if (!IsQuery(sqlStatement))
                {
                    SqliteCon.RunNonQuery(sqlStatement);
                    return null;
                }
                else
                {

                    var nonq = string.Format("create table if not exists {0} as {1}", name, sqlStatement);
                    DebugPrint(nonq);
                    SqliteCon.RunNonQuery(nonq);
                    return SqliteCon.GetDataTable(name, "select * from {0}", name);
                }
            } 
            else 
            {
                // if neighbors are empty, then this comes from the original datasource and needs to be put in as a cursor
                Validity.Validity.Assert(IsQuery(sqlStatement), "Only queries may be run against the original data source [{0}] is invalid", sqlStatement);
                var cursordt = con.GetDataTable(name, ReplaceSqlInputs(sqlStatement, false));

                var exists_rows = from r in SqliteCon.GetSchema("Tables").Select()
                                  where r["TABLE_NAME"].ToString().ToLower().Trim() == name.ToLower().Trim()
                                  select r;

                if(exists_rows.IsEmpty())
                    SqliteCon.CreateTableFromDataTable(cursordt);
                
                return cursordt;
            }
        }

        static private SQLiteConnection _sqlitecon = null;
        static private SQLiteConnection SqliteCon
        {
            get
            {
                if (_sqlitecon == null)
                {
                    _sqlitecon = new SQLiteConnection(string.Format("Data Source={0}", Env.GetConfigVar("sqlitefile", ":memory:", true)));
                }

                if (_sqlitecon.State != ConnectionState.Open)
                    _sqlitecon.Open();

                return _sqlitecon;
            }
        }

        static public void RunNonQuery(this SQLiteConnection con, string sqlfmt, params string[] args)
        {
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = string.Format(sqlfmt, args);
                cmd.ExecuteNonQuery();
            }
        }


 

        static public void CreateTableFromDataTable(this SQLiteConnection con, DataTable datatable)
        {
            var create_sql = string.Format("create table {0} ({1})", datatable.TableName, string.Join(",", datatable.Columns.ToIEnumerable().Select(c => c.ColumnName).ToArray()));
            // DebugPrint("Creating new cursor: {0}", create_sql);

            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = create_sql;
                cmd.ExecuteNonQuery();
                foreach (var row in datatable.Rows.ToIEnumerable())
                {
                    var insert_sql = string.Format("insert into {0} values ('{1}')", datatable.TableName, string.Join("','", datatable
                                                                                                                               .Columns
                                                                                                                               .ToIEnumerable()
                                                                                                                               .Select(c => row[c]
                                                                                                                                   .ToString()
                                                                                                                                   .Replace("'", "''"))
                                                                                                                               .ToArray()));
                    DebugPrint("Cursor: {0}", insert_sql);
                    cmd.CommandText = insert_sql;
                    cmd.ExecuteNonQuery();
                }
            }
        }
#endif

        static public IEnumerable<string> SqlStatements
        {
            get 
            {
                var nodes = configDoc.SelectNodes("/configuration/sql/*");
                foreach(var n in nodes.ToIEnumerable()) 
                {
                    yield return n.Name;
                }
            }
        }

        static public DirectionalGraph<string> SQLGraph
        {
            get
            {
                var nodes = configDoc.SelectNodes("/configuration/sql/*");
                var graphNodes = nodes.ToIEnumerable().Select(n => n.Name);

                Func<string, IEnumerable<string>> neighbors = (n) =>
                {
                    if (n == "")
                        return new string[] { };

                    var node = GetConfigXmlNode("sql/" + n);
                    var deps = node.Attributes["dependancies"];
                    if (deps == null || deps.Value.Trim() == "")
                        return new string[] { };
                    else
                    {
                        var ns = deps.Value.Split(',').Select(r => r.Trim()).ToArray();
                        return ns;
                    }
                };

                var rv = new DirectionalGraph<string>(graphNodes, neighbors);
                return rv;
            }
        }

        public class TempFile
        {
            public readonly string FileName;

            private FileStream _WriteFileStream = null;
            public FileStream WriteFileStream
            {
                get
                {
                    if (_WriteFileStream == null)
                        _WriteFileStream = File.OpenWrite(FileName);

                    return _WriteFileStream;
                }
            }

            private FileStream _ReadFileStream = null;
            public FileStream ReadFileStream
            {
                get
                {
                    if (_ReadFileStream == null)
                        _ReadFileStream = File.OpenRead(FileName);

                    return _ReadFileStream;
                }
            }

            public TempFile(string fileName)
            {
                FileName = fileName;
            }
        }

        static public TempFile GetTempFile()
        {
            var tempDir = Env.GetConfigVar("TempFileDirectory", Path.GetTempPath(), true);
            var tempFileName = FunctionalOperators.CreateRandomString(10, 20);

            return new TempFile(tempDir + "/" + tempFileName);

        }

        public class TempDBFPointer : IDisposable
        {
            public readonly string filename;
            public OleDbConnection connection;

            public TempDBFPointer(string fname, OleDbConnection con)
            {
                this.filename = fname;
                this.connection = con;
            }

            public override string ToString()
            {
                return "[" + filename + "]";
            }

            public void Dispose()
            {
                connection.Disposed += new EventHandler(connection_Disposed);
            }

            void connection_Disposed(object sender, EventArgs e)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch
                    {
                        Env.Log("Cleanup Error: Could not delete [{0}]", filename);
                    }
                }

                var cdx_file = Path.GetDirectoryName(filename) + "/" + Path.GetFileNameWithoutExtension(filename) + ".cdx";
                if (File.Exists(cdx_file))
                {
                    try
                    {
                        File.Delete(cdx_file);
                    }
                    catch { }
                }
                
                var idx_file = Path.GetDirectoryName(filename) + "/" + Path.GetFileNameWithoutExtension(filename) + ".idx";
                if (File.Exists(idx_file))
                {
                    try
                    {
                        File.Delete(idx_file);
                    }
                    catch { }
                }
            }

            public void CreateIndex(string fldnme)
            {
                // FIXME: this doesn't work
                throw new NotImplementedException();

                try
                {
                    var tag = fldnme;
                    this.connection.ExecuteNonQuery("execscript([select 0]+chr(13)+chr(10)+'use {0} exclusive again'+chr(13)+chr(10)+[index on {1} tag {2}])", filename, fldnme, tag);
                }
                catch
                {
                    Env.Log("Could not index {0} in {1}", fldnme, filename);
                }
            }
        }

        static public TempDBFPointer GetTempDBF(this OleDbConnection con)
        {
            var tempDir = Env.GetConfigVar("TempFileDirectory", Path.GetTempPath(), true);
            var tempFileName = FunctionalOperators.CreateRandomString(10,20) + ".dbf";
            return new TempDBFPointer(tempDir + @"\" + tempFileName, con);
        }

        #endregion
    }
}
