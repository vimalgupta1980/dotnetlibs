using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IVendor
    {
        long Recnum { get; }
        string Name { get; }
    }
}
