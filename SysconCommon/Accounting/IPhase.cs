using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting
{
    public interface IPhase
    {
        IJob Job { get; }
        long PhaseNumber { get; }
    }
}
