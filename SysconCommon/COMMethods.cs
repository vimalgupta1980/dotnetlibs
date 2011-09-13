using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

using SysconCommon.GUI;
using SysconCommon.Common.Environment;

namespace SysconCommon
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("A34C7614-6778-4441-B814-EFF72D2FD896")]
    [ProgId("Syscon.MasterBuilder")]
    public class COMMethods
    {
        private string _mbdir = null;

        // required for COM
        public COMMethods()
        {
        }

        public string omDecryptEx(string input)
        {
            return SMBReversed.Security.omDecryptEx(input);
        }

        public string omEncryptEx(string input)
        {
            return SMBReversed.Security.omEncryptEx(input);
        }
        
        [return:MarshalAs(UnmanagedType.SafeArray)]
        public int[] SelectJobsByGUI()
        {
            var dlg = new MultiJobSelector();
            dlg.ShowDialog();
            return dlg.SelectedJobNumbers.Select(i => Convert.ToInt32(i)).ToArray();
        }

        public void SetMBDir(string mbdir)
        {
            _mbdir = mbdir;
            Env.SetMBDir(mbdir);
        }

        public string GetMBDir()
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

        private int _last_int_id = 0;

        public int GetIntId()
        {
            _last_int_id += 1;
            return _last_int_id;
        }

        public void ResetIntId()
        {
            _last_int_id = 0;
        }
    }
}
