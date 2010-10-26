using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface ITimeAndMaterial
    {
        int Recnum { get; set; }
        IJob Job { get; }
        int WageRate { get; set; }
        int EquipmentRate { get; set; }
        string Notes { get; set; }
    }
}
