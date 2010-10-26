using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Accounting;
using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Invoice : IInvoice
    {
        public Invoice(int id)
        {
            this.Recnum = id;
        }

        public int Recnum { get; set; }

        public decimal InvoiceTotal
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select invttl from acrinv where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IJob Job
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return new Job(Connections.GetScalar<string>("select jobnum from acrinv where recnum = {0}", Recnum));
                }, Recnum);
            }
        }

        public int Period
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select actper from acrinv where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Status
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<int>("select status from acrinv where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
