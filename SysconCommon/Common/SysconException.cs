// DTSException
//
// Copyright 2010 Data Transfer Solutions, LLC
//
// Author: Brandon Niemczyk
//
// Summary: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using SysconCommon.Common.Environment;

namespace SysconCommon.Common
{
    public class SysconException : Exception
    {
        private void _init(bool printDebugMsg)
        {
            if (printDebugMsg)
            {
                Env.DebugPrint(this);
            }
        }

        public SysconException(string msg, params object[] args) : base(string.Format(msg, args)) { _init(false); }
        public SysconException(Exception innerException, string msg, params object[] args) : base(string.Format(msg, args), innerException) { _init(false); }
        public SysconException(Exception innerException) : base(innerException.Message, innerException) { _init(false); }
    }

    public class TempPathNotFoundException : SysconException
    {
        public TempPathNotFoundException()
            : base("Could not find a suitable temporary path")
        {
            this.LogError("Temporary Path Error");
        }
    }

    public static class SysconErrorHandling
    {
        public static void LogError(this Exception self, string msg = null)
        {
            try
            {
                if (msg == null)
                    msg = "";

                Env.Log("Error: {0}\r\n{1}\r\n{2}", msg, self.Message, self.StackTrace);
            }
            catch { }
        }

        public static void GenericHandleError(this Exception self, string msg = null)
        {
            self.LogError(msg);

            if(msg == null)
                msg = self.Message;
         
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK);
        }
    }
}
