using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Accounting;
using SysconCommon.Common.Environment;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Source : ISource
    {
        private int _Recnum;
        public Source(int recnum)
        {
            _Recnum = recnum;
        }

        public int Recnum
        {
            get { return _Recnum; }
        }

        public string Name
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select srcnme from source where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Description
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<string>(
                    "select srcdsc from source where recnum = {0}", Recnum), Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
