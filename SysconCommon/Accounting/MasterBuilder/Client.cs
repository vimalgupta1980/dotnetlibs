using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Accounting;

namespace SysconCommon.Accounting.MasterBuilder
{
    class Client : IClient
    {
        public string Contact { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }
    }
}
