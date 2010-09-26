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
using System.Data.SQLite; // used for sql dependancies, ie.. cursors

using SysconCommon.Common.Validity;
using SysconCommon.Algebras.Graphs;
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
            File.AppendAllText(GetConfigVar("logfile", defaultLogFile, true), string.Format(msgFormat + "\n", arguments));
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
        /// set the config file name, this can only happen before the config
        /// is ever used.  The default is config.xml in the directory of the
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

            Validity.Validity.Assert(!_config_file_used, "SetConfigFile set after config use");

            if (!File.Exists(filename))
            {
                if (createIfMissing)
                    File.WriteAllText(filename, "<configuration />");
                else
                    throw new SysconException(string.Format("Config file {0} missing", filename));
            }

            _config_file = filename;
            _config_file_used = true;
        }

        /// <summary>
        /// set the config file name, this can only happen before the config
        /// is ever used.  The default is config.xml in the directory of the
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

        /// <summary>
        /// we don't want multiple instances of configDoc because that creates a race
        /// condition and saves may be overwritten out of order
        /// </summary>
        static private XmlDocument _configDoc = null;

        static private XmlDocument configDoc
        {
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

        /// <summary>
        /// progmatically set a configuration value, overwriting the existing one if required
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="value"></param>
        static public void SetConfigVar<T>(string name, T value)
        {
            var query = string.Format("/configuration/{0}", name);
            EnsureNodeExists(query, "/");

            name = Regex.Replace(query, @"^.*/", "");
            var xdoc = configDoc;
            var node = xdoc.SelectSingleNode(query);

            var new_node = xdoc.CreateNode(XmlNodeType.Element, name, null);
            new_node.InnerText = value.ToString();
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
            var n = configDoc.SelectSingleNode(string.Format("/configuration/{0}", name));

            if (n != null)
                return (T) Convert.ChangeType(n.InnerText, typeof(T));

            if (writeIfMissing)
            {
                SetConfigVar(name, defaultValue);
                n = configDoc.SelectSingleNode(string.Format("/configuration/{0}", name));
                return (T)Convert.ChangeType(n.InnerText, typeof(T));
            }
            else
            {
                throw new EnvironmentalError(null, "Cannot get configuration value ({0})", name);
                    //string.Format("Cannot get configuration value ({0})", name)
                    //, null);
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
            var query = string.Format("/configuration/{0}", name);
            // DebugPrint("XPath query: {0}", query);
            var n = configDoc.SelectSingleNode(string.Format("/configuration/{0}", name));
            Validity.Validity.IsNotNull(n);
            return n;
        }

        static private string ReplaceSqlInputs(string sql)
        {
            var matches = Regex.Matches(sql, @"\{input:(.*?)\}");
            foreach (var m in matches.ToIEnumerable())
            {
                DebugPrint("replacing {0}", m.Groups[1]);
                var value = GetConfigVar("userdefined/" + m.Groups[1].Value);
                sql = sql.Replace(m.Groups[0].Value, value.Trim());
            }

            return sql;
        }

        /// <summary>
        /// Runs an sql statement, this is smart enough to run any dependancies into cursors and select from that
        /// </summary>
        /// <param name="con"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        static public DataTable RunSqlStatement(this OdbcConnection con, string name, params string[] arguments)
        {
            var graph = SQLGraph;
            
            var sqlStatementName = graph.Nodes.Where(n => n == name).FirstOrDefault();
            Validity.Validity.IsNotNull(sqlStatementName);
            var sqlStatement = GetConfigVar("sql/" + name).Trim();

            sqlStatement = ReplaceSqlInputs(sqlStatement);

            if (graph.NeighborFinder(sqlStatementName).IsEmpty())
            {
                // it doesn't require creating any in memory tables
                DebugPrint("Running SQL: [{0}]\r\n\twith arguments [{1}]", sqlStatement, string.Join(",", arguments));
                return con.GetDataTable(name, sqlStatement, arguments);
            }
            else
            {
                var sqlite = RunCursor(null, con, name, arguments);
                try
                {
                    var sqlselect = string.Format("select * from {0}", name);
                    DebugPrint("Selecting CURSOR: {0}", sqlselect);
                    return sqlite.GetDataTable(name, sqlselect);
                }
                finally
                {
                    sqlite.Close();
                    sqlite.Dispose();
                }
            }
        }

        /// <summary>
        /// select into a new table (cursor)
        /// </summary>
        /// <param name="con">sqlite connection for new cursor, if null then this is created new</param>
        /// <param name="src_con">src odbc connection, if this is null it is assumed that the sqlite connection contains the src table</param>
        /// <param name="name"></param>
        /// <returns>the sqlite connection</returns>
        static private SQLiteConnection RunCursor(this SQLiteConnection con, OdbcConnection src_con, string name, params string[] arguments)
        {
            // ensure it's valid input
            var graph = SQLGraph;
            // Validity.Validity.Assert(graph.Nodes.Contains(name), "Invalid sql statement name: {0}", name);

            if(con == null)
            {
                con = new SQLiteConnection("Data Source=:memory:");
                con.Open();
            }

            // get sql to run
            var sql = GetConfigVar("sql/" + name).Trim();
            sql = ReplaceSqlInputs(sql);

            // make sure dependancies are run
            var neighbors = graph.NeighborFinder(name);
            if (!neighbors.IsEmpty())
            {
                foreach (var n in neighbors)
                {
                    RunCursor(con, src_con, n);
                }

                // we know that the src data is in sql lite now
                src_con = null;
            }

            var datatable = src_con == null ? con.GetDataTable(name, sql) : src_con.GetDataTable(name, sql);
            con.CreateTableFromDataTable(datatable);
            return con;
        }

        static public void CreateTableFromDataTable(this SQLiteConnection con, DataTable datatable)
        {
            var create_sql = string.Format("create table {0} ({1})", datatable.TableName, string.Join(",", datatable.Columns.ToIEnumerable().Select(c => c.ColumnName).ToArray()));
            DebugPrint("Creating new cursor: {0}", create_sql);

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
                    // DebugPrint("Cursor: {0}", insert_sql);
                    cmd.CommandText = insert_sql;
                    cmd.ExecuteNonQuery();
                }
            }
        }

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

                    // DebugPrint("neighbor: {0}", n);
                    var node = GetConfigXmlNode("sql/" + n);
                    var deps = node.Attributes["dependancies"];
                    if (deps == null || deps.Value.Trim() == "")
                        return new string[] { };
                    else
                        return deps.Value.Split(',');
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

        #endregion
    }
}
