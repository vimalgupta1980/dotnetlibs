﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IEquipment
    {
        int EquipmentNumber { get; }
        IEquipmentType EquipmentType { get; set; }
        string Name { get; }
    }
}
