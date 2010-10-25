using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IJobType
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
