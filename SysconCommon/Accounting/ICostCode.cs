using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface ICostCode
    {
        decimal Id { get; set; }
        string Description { get; set; }
        string Unit { get; set; }
        decimal LaborBurden { get; set; }
    }
}
