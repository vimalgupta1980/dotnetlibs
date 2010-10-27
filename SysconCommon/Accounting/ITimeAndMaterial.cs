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

        decimal MaterialHidden { get; set; }
        decimal MaterialShown { get; set; }
        decimal MaterialOverhead { get; set; }
        decimal MaterialProfit { get; set; }

        decimal LaborHidden { get; set; }
        decimal LaborShown { get; set; }
        decimal LaborOverhead { get; set; }
        decimal LaborProfit { get; set; }

        decimal EquipmentHidden { get; set; }
        decimal EquipmentShown { get; set; }
        decimal EquipmentOverhead { get; set; }
        decimal EquipmentProfit { get; set; }

        decimal SubcontractHidden { get; set; }
        decimal SubcontractShown { get; set; }
        decimal SubcontractOverhead { get; set; }
        decimal SubcontractProfit { get; set; }

        decimal OtherHidden { get; set; }
        decimal OtherShown { get; set; }
        decimal OtherOverhead { get; set; }
        decimal OtherProfit { get; set; }

        decimal UserDef6Hidden { get; set; }
        decimal UserDef6Shown { get; set; }
        decimal UserDef6Overhead { get; set; }
        decimal UserDef6Profit { get; set; }

        decimal UserDef7Hidden { get; set; }
        decimal UserDef7Shown { get; set; }
        decimal UserDef7Overhead { get; set; }
        decimal UserDef7Profit { get; set; }

        decimal UserDef8Hidden { get; set; }
        decimal UserDef8Shown { get; set; }
        decimal UserDef8Overhead { get; set; }
        decimal UserDef8Profit { get; set; }

        decimal UserDef9Hidden { get; set; }
        decimal UserDef9Shown { get; set; }
        decimal UserDef9Overhead { get; set; }
        decimal UserDef9Profit { get; set; }

    }
}
