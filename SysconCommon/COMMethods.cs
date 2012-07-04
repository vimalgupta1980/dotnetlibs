using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

using System.Runtime.InteropServices;

using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;
using SysconCommon.GUI;
using SysconCommon.Common.Environment;
using SysconCommon.Common.Validity;
using SysconCommon.Foxpro;

namespace SysconCommon
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("A34C7614-6778-4441-B814-EFF72D2FD896")]
    [ProgId("Syscon.MasterBuilder")]
    public class COMMethods
    {
        private string _mbdir
        {
            get
            {
                return Env.GetMBDir();
            }
        }

        // required for COM
        public COMMethods()
        {
        }

        ///// <summary>
        ///// VX 4/6/12 caller customized SMBLogin Title
        ///// </summary>
        //public COMMethods(string userLoginTitle)
        //{
        //    this.LoginUserTitle = userLoginTitle;
        //}

        public void UseGlobalConfig()
        {
            Env.UseGlobalConfig = true;
        }

        public void UseUserConfig()
        {
            Env.UseGlobalConfig = false;
        }

        public string GetCalcMethodName(int clcmth)
        {
            Validity.Assert(clcmth >= 1, "invalid calc method");
            Validity.Assert(clcmth <= SMBConstants.CalcMethods.Length - 1, "invalid calc method");
 
            return SMBConstants.CalcMethods[clcmth];
        }

        public string smartEncrypt(string input, bool checkEncStatus)
        {
            if (input.Trim() == "")
                return "";

            var pinfo = GetProgramInfo();

            if (checkEncStatus && !pinfo.DataVersion.isEncrypted())
            {
                    return input;
            }

            return pinfo.DataVersion.Major >= 17
                ? EncryptEx(input)
                : Encrypt(input);
        }

        public string smartEncrypt(string input)
        {
            return this.smartEncrypt(input, true);
        }

        public string smartDecrypt(string input, bool checkEncStatus)
        {
            if (input.Trim() == "")
                return "";

            var pinfo = GetProgramInfo();

            if (checkEncStatus && !pinfo.DataVersion.isEncrypted())
            {
                return input;
            }

            return pinfo.DataVersion.Major >= 17
                ? DecryptEx(input)
                : Decrypt(input);
        }

        public string smartDecrypt(string input)
        {
            return this.smartDecrypt(input, true);
        }

        public string DecryptEx(string input)
        {
            return SMBReversed.Security.omDecryptEx(input);
        }

        public string EncryptEx(string input)
        {
            return SMBReversed.Security.omEncryptEx(input);
        }

        public string Decrypt(string input)
        {
            return SMBReversed.Security.omDecrypt(input.Trim());
        }

        public string Encrypt(string input)
        {
            return SMBReversed.Security.omEncrypt(input.Trim());
        }
        
        [return:MarshalAs(UnmanagedType.SafeArray)]
        public int[] SelectJobsByGUI()
        {
            smartGetSMBDir();

            // if it's still null, cancel
            if (_mbdir == null)
                return null;

            var dlg = new MultiJobSelector();
            dlg.ShowDialog();
            return dlg.SelectedJobNumbers.Select(i => Convert.ToInt32(i)).ToArray();
        }

        [return: MarshalAs(UnmanagedType.SafeArray)]
        public int[] SelectTMJobsByGUI()
        {
            smartGetSMBDir();

            if (_mbdir == null)
                return null;

            EnsureJobTypesExist();

            using (var con = Connections.GetOLEDBConnection())
            {
                var jobs_dt = con.GetDataTable("jobs", 
                    "select a.recnum from actrec a join syscon_jobtyp s on a.jobtyp = s.recnum and s.istimmat > 0");
                var dlg = new MultiJobSelector(jobs_dt.Rows.Select(r => Convert.ToInt64(r[0])).ToArray());
                dlg.ShowDialog();
                return dlg.SelectedJobNumbers.Select(i => Convert.ToInt32(i)).ToArray();
            }
        }

        [return: MarshalAs(UnmanagedType.SafeArray)]
        public int[] SelectNonTMJobsByGUI()
        {
            smartGetSMBDir();

            if (_mbdir == null)
                return null;

            EnsureJobTypesExist();

            using (var con = Connections.GetOLEDBConnection())
            {
                var jobs_dt = con.GetDataTable("jobs",
                    "select a.recnum from actrec a left join syscon_jobtyp s on a.jobtyp = s.recnum where isnull(s.istimmat) or s.istimmat = 0");
                var dlg = new MultiJobSelector(jobs_dt.Rows.Select(r => Convert.ToInt64(r[0])).ToArray());
                dlg.ShowDialog();
                return dlg.SelectedJobNumbers.Select(i => Convert.ToInt32(i)).ToArray();
            }
        }

        public void EditJobTypesByGUI()
        {
            smartGetSMBDir();

            if (_mbdir == null)
                return;

            var dlg = new Edit_Job_Types(this);
            dlg.ShowDialog();
        }

        public void SetSMBDir(string mbdir)
        {
            // _mbdir = mbdir;
            // _mbdir = mbdir;
            Env.SetMBDir(mbdir);
            SetConfigVar("mbdir", mbdir);
        }

        /// <summary>
        /// selects any smb directory, does not update the smb dir, or save to a configuration file
        /// </summary>
        /// <returns></returns>
        public string SelectAnySMBDirectory()
        {
            var dlg = new FolderBrowserDialog();
            
            if (_mbdir != null)
            {
                dlg.SelectedPath = Directory.GetParent(_mbdir).ToString();
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var result = dlg.SelectedPath.AddBS();

                if (!File.Exists(result + "actrec.dbf"))
                {
                    MessageBox.Show("Was not a valid SMB Directory", "Error", MessageBoxButtons.OK);
                    return null;
                }
                else
                {
                    return result;
                }
            }
            
            return null;
        }

        public string GetSMBDir()
        {
            return _mbdir;
        }

        public void SetConfigFile(string fname)
        {
            Env.SetConfigFile(fname);
        }

        public string GetConfigVar(string name)
        {
            return Env.GetConfigVar<string>(name, "", true);
        }

        public void SetConfigVar(string name, string value)
        {
            Env.SetConfigVar(name, value);
        }

        public override string ToString()
        {
            // return base.ToString();
            return "Syscon SMB COM API";
        }

        public string smartGetSMBDir()
        {
            if (_mbdir != null)
                return _mbdir;

            var __mbdir = Env.GetConfigVar("mbdir");

            if (__mbdir == null)
            {
                var dlg = new FolderBrowserDialog();
                dlg.Description = "Please select your SMB data directory";
                dlg.SelectedPath = @"C:\MB7\Sample Company";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    __mbdir = dlg.SelectedPath;
                    Env.SetConfigVar("mbdir", __mbdir);
                }
            }

            if (__mbdir != null)
                Env.SetMBDir(__mbdir);

            return __mbdir;
        }

        public string smartSelectSMBDirByGUI()
        {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "Please select your SMB data directory";
            dlg.SelectedPath = Env.GetConfigVar("mbdir");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // _mbdir = dlg.SelectedPath;
                Env.SetConfigVar("mbdir", dlg.SelectedPath);
                Env.SetMBDir(dlg.SelectedPath);
            }

            return _mbdir;
        }

        public string smartSelectSMBDirByGUI(string configName)
        {
            var dflt = @"c:\mb7\sample company";
            var dlg = new FolderBrowserDialog();
            dlg.Description = "Please select your SMB data directory";
            dlg.SelectedPath = Env.GetConfigVar(configName, dflt, true);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // _mbdir = dlg.SelectedPath;
                Env.SetConfigVar(configName, dlg.SelectedPath);
                // Env.SetMBDir(dlg.SelectedPath);
            }

            return Env.GetConfigVar(configName, dflt, true);
        }

        public ProgramInfo GetProgramInfo()
        {
            return new ProgramInfo()
            {
                methods = this
            };
        }

        public void EditTableWithGrid(string table_name)
        {
            smartGetSMBDir();
            var dlg = new SysconCommon.GUI.FldlibBasedGrid();
            dlg.SetEditTable(table_name);
            dlg.ShowDialog();
        }

        private string _logged_in_user = null;

        public string LoggedInUser
        {
            get
            {
                return _logged_in_user;
            }
        }

        public string LoginUserTitle = "SMBLogin(Default)";   /// VX 4/6/12 added for customized SMBLogin title

        public string RequireSMBLogin()
        {
            var dlg = new SysconCommon.GUI.SMBLogin(this);
            dlg.ShowDialog();
            if (dlg.LoggedInUser != null)
                _logged_in_user = dlg.LoggedInUser;

            return dlg.LoggedInUser;
        }
        /// <summary>
        /// VX 4/6/12 Overloaded w/ passed in User Login Title
        /// </summary>
        /// <returns></returns>
        public string RequireSMBLogin(string userTitle)
        {
            this.LoginUserTitle = userTitle;
            return this.RequireSMBLogin();
        }

        public void EnsureJobTypesExist()
        {
            var pi = GetProgramInfo();
            if (!File.Exists(pi.SMBDir + "/syscon_jobtyp.dbf"))
                EditJobTypesByGUI();
        }

        public void EditCostCodesByGUI()
        {
            var frm = new Edit_Cost_Codes(this);
            frm.ShowDialog();
        }

        public void EnsureCostCodesExist()
        {
            var pi = GetProgramInfo();
            if (!File.Exists(pi.SMBDir + "/syscon_cstcde.dbf"))
                EditCostCodesByGUI();
        }

        public void Log(string msg)
        {
            Env.Log("{0}", msg);
        }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class SMBVersion
    {
        [ComVisible(false)]
        public COMMethods methods;

        public override string  ToString()
        {
            methods.smartGetSMBDir();
            using (var con = Connections.GetOLEDBConnection())
            {
                return con.GetScalar<string>("select alltrim(vernum) from cmpany").Trim();
            }
        }

        public int Major
        {
            get
            {
                var m = Regex.Match(this.ToString(), @"^(\d+)[.](\d+)$");
                return int.Parse(m.Groups[1].Value);
            }
        }

        public int Minor
        {
            get
            {
                var m = Regex.Match(this.ToString(), @"^(\d+)[.](\d+)$");
                return int.Parse(m.Groups[2].Value);
            }
        }

        //public bool? IsEncrypted 
        //{
        //    get
        //    {
        //        if (IsEncrypted == null)
        //            IsEncrypted = isEncrypted();

        //        return IsEncrypted;
        //    }
        //    set { }
        //}


        /// <summary>
        /// VX 4/13/2012 start from Sage v.17.x, cmpany table has col ONEISE to indicate
        /// ssn is encrypted or not
        /// </summary>
        /// <returns></returns>
        public bool isEncrypted()
        {
            if (Major >= 17)
            {
                methods.smartGetSMBDir();
                using (var con = Connections.GetOLEDBConnection())
                {
                    var oneise = con.GetScalar<string>("select ONEISE from cmpany").Trim();
                    return oneise.ToString().Trim() == "1";
                }
            }
            return false;
        }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class ProgramInfo
    {
        [ComVisible(false)]
        public COMMethods methods = new COMMethods();

        public string SMBDir
        {
            get
            {
                return methods.smartGetSMBDir();
            }
        }

       
        public string ConfigFile
        {
            get
            {
                return Env.GetConfigFile();
            }
        }

        public SMBVersion DataVersion
        {
            get
            {
                return new SMBVersion() { methods = methods };
            }
        }
    }

    /// <summary>
    /// this is just a wrapper around Dictionary<string,object> because foxpro does not have anything like
    /// it, but it's useful
    /// </summary>
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Syscon.Dictionary")]
    [Guid("4670167D-F5AB-4FCC-9503-4BC617858BC3")]
    public class SysconCOMDictionary
    {
        private Dictionary<string, object> _dict = new Dictionary<string,object>();

        [return:MarshalAs(UnmanagedType.SafeArray)]
        public string[] Keys()
        {
            return _dict.Keys.ToArray();
        }

        [return:MarshalAs(UnmanagedType.SafeArray)]
        public object[] Values()
        {
            return _dict.Values.ToArray();
        }

        public object Get(string key)
        {
            return _dict[key];
        }

        public void Set(string key, object value)
        {
            if(!_dict.ContainsKey(key))
                _dict.Add(key, value);
            else
                _dict[key] = value;
        }

        public string UpdateSQL()
        {
            return string.Join(",", _dict.Keys.Select(k =>
            {
                var v = _dict[k];
                return string.Format("{0} = {1}",
                    k,
                    new Type[] { typeof(int), typeof(decimal), typeof(long), typeof(double), typeof(float) }.Contains(v.GetType())
                        ? v.ToString()
                        : v.GetType() == typeof(DateTime)
                            ? string.Format("DATE({0},{1},{2})", ((DateTime)v).Year, ((DateTime)v).Month, ((DateTime)v).Day)
                            : v.GetType() == typeof(bool)
                                ? ((bool)v) ? ".T." : ".F."
                                : string.Format("'{0}'", v));
            }).ToArray());
        }
    }
}
