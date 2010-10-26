using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IInvoice
    {
        int Recnum { get; set; }
        decimal InvoiceTotal { get; set; }
        IJob Job { get; }
        int Period { get; set; }
        int Status { get; set; }
    }
}
