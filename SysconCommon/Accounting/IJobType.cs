using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IJobType
    {
        int Recnum { get; set; }
        string Name { get; set; }
    }
}
