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
            try
            {
                Env.Log("Temporary Path Error: {0}\r\n{1}", this.Message, this.StackTrace);
            }
            catch { }
        }
    }
}
