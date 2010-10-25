using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IClient
    {
        string Contact { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
    }
}
