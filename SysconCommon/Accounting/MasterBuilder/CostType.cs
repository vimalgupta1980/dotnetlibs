using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class CostType : ICostType
    {
        public CostType(int id)
        {
            this.Recnum = id;
        }

        public int Recnum { get; set; }
    }
}
