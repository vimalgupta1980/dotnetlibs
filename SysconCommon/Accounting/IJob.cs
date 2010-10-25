using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IJob
    {
        string JobNumber { get; set; }
        string JobName { get; set; }
        IClient Client { get; set; }
        IJobType JobType { get; set; }
        IEnumerable<IJobCost> JobCosts { get; }
        IEnumerable<IInvoice> Invoices { get; }
        ITimeAndMaterial TimeAndMaterials { get; }
    }
}
