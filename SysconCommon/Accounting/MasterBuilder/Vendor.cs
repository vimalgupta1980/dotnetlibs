using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Accounting;
using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Vendor : IVendor
    {
        public long Recnum { get; set; }

        public Vendor(long recnum)
        {
            this.Recnum = recnum;
        }

        public string Name
        {
            get 
            {
                try
                {
                    return Connections.GetScalar<string>("select vndnme from actpay where recnum = {0}", Recnum).Trim();
                }
                catch
                {
                    return "";
                }
            }
        }
    }
}
