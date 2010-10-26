using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common.Environment;
using SysconCommon.Accounting;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class CostCode : ICostCode
    {
        public CostCode(decimal id)
        {
            Recnum = id;
        }

        public decimal Recnum { get; set; }

        public string Description
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select cdenme from cstcde where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Unit
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select untdsc from cstcde where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal LaborBurden
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<decimal>("select lbrbur from cstcde where recnum = {0}", Recnum);
                }, Recnum);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
