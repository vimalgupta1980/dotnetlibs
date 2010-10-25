using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface ITimeAndMaterialLineItem
    {
        int Id { get; set; }
        int LineNumber { get; set; }
        IEmployee Employee { get; set; }
        ICostCode CostCode { get; set; }
        decimal PayRate1 { get; set; }
        decimal PayRate2 { get; set; }
        decimal PayRate3 { get; set; }
        decimal MinHours { get; set; }
    }
}
