using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IEquipmentType
    {
        int Recnum { get; }
        string Name { get; set; }
        string Notes { get; set; }
    }
}
