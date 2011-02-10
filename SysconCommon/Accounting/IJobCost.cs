using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IJobCost
    {
        int Recnum { get; set; }
        IJob Job { get; }
        decimal CostHours { get; set; }
        int Period { get; set; }
        int Status { get; set; }
        ICostCode CostCode { get; set; }
        IEmployee Employee { get; set; }
        ICostType CostType { get; set; }
        decimal Cost { get; set; }
        IEquipment Equipment { get; set; }
        int BillingStatus { get; set; }
        decimal BillingQuantity { get; set; }
        decimal BillingTotal { get; set; }
        int PayType { get; set; }
        decimal EquipmentQuantity { get; set; }
        IInvoice Invoice { get; set; }
        string TransactionNumber { get; set; }
        string Description { get; set; }
        DateTime TransactionDate { get; set; }
        ISource Source { get; set; }
        IPhase Phase { get; set; }
        IVendor Vendor { get; set; }
    }
}
