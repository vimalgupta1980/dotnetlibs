using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IJobCost
    {
        int Id { get; set; }
        IJob Job { get; }
        decimal CostHours { get; set; }
        int Period { get; set; }
        int Status { get; set; }
        ICostCode CostCode { get; set; }
        IEmployee Employee { get; set; }
        ICostType CostType { get; set; }
        decimal Cost { get; set; }
        IEquipment Equipment { get; set; }
    }
}
