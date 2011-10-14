using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Accounting;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Phase : IPhase
    {
        private readonly IJob _Job;
        private readonly long _PhaseNumber;

        public Phase(IJob job, long phaseNumber)
        {
            _Job = job;
            _PhaseNumber = phaseNumber;
        }

        public IJob Job
        {
            get { return _Job; }
        }

        public long PhaseNumber
        {
            get { return _PhaseNumber; }
        }
    }
}
