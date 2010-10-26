using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IEquipmentLineItem
    {
        int Recnum { get; }
        int LineNumber { get; }
        IEquipment Equipment { get; set; }
        decimal OperatedRate { get; set; }
        decimal StandbyRate { get; set; }
        decimal IdleRate { get; set; }
        decimal MinimumHours { get; set; }
    }
}
