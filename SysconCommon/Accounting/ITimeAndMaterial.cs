using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface ITimeAndMaterial
    {
        int Id { get; set; }
        IJob Job { get; }
        decimal WageRate { get; set; }
        decimal EquipmentRate { get; set; }
        string Notes { get; set; }
    }
}
