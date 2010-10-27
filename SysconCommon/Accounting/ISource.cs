using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface ISource
    {
        int Recnum { get; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
