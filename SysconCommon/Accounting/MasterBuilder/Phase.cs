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
        private readonly int _PhaseNumber;

        public Phase(IJob job, int phaseNumber)
        {
            _Job = job;
            _PhaseNumber = phaseNumber;
        }

        public IJob Job
        {
            get { return _Job; }
        }

        public int PhaseNumber
        {
            get { return _PhaseNumber; }
        }
    }
}
