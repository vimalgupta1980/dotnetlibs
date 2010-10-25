using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common.Environment;
using SysconCommon.Accounting;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class JobType : IJobType
    {

        public JobType(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }

        public string Name
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select typnme from jobtyp where recnum = {0}", Id);
                }, Id);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return this.Name != null ? string.Format("{0} - {1}", this.Id, this.Name) : this.Id.ToString();
        }
    }
}
