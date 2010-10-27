using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Job : IJob
    {
        public Job(string jobNumber)
        {
            this.JobNumber = jobNumber;
        }

        public string JobNumber { get; set; }

        public string JobName
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select jobnme from actrec where recnum = {0}", JobNumber).Trim();
                }, JobNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IClient Client
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.JobNumber, this.JobName);
        }


        public IJobType JobType
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new JobType(Connections.GetScalar<int>("select jobtyp from actrec where recnum = {0}", JobNumber));
                }, JobNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IEnumerable<IJobCost> JobCosts
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var ids = Connections.GetList<int>("select recnum from jobcst where jobnum = {0}", this.JobNumber);
                    return ids.Select(id => new JobCost(id)).ToArray();
                }, JobNumber);
            }

        }


        public IEnumerable<IInvoice> Invoices
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var ids = Connections.GetList<int>("select recnum from acrinv where jobnum = {0}", this.JobNumber);
                    return ids.Select(id => new Invoice(id)).ToArray();
                }, JobNumber);
            }
        }


        public ITimeAndMaterial TimeAndMaterials
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var reccount = Connections.GetScalar<int>("select count(*) from timmat where recnum = {0}", this.JobNumber);
                    if (reccount == 0)
                        return null;
                    else
                        return new TimeAndMaterial(int.Parse(this.JobNumber));
                }, JobNumber);
            }
        }


        public decimal LotPremium
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<decimal>(
                    "select lotprm from actrec where recnum = {0}", this.JobNumber), this.JobNumber);
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IEmployee Supervisor
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var sprvsr = Connections.GetScalar<int>("select sprvsr from actrec where recnum = {0}", this.JobNumber);
                    return new Employee(sprvsr);
                });
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
