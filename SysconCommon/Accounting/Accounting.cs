using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting
{
    public enum AccountingSystems
    {
        MasterBuilder,
    }

    public static class Accounting
    {
        static public AccountingSystems AccountingSystem = AccountingSystems.MasterBuilder;

        static public IJob GetJob(string jobNumber)
        {
            return Cache.CacheResult(() =>
            {
                switch (AccountingSystem)
                {
                    case AccountingSystems.MasterBuilder:
                        return GetMBJob(jobNumber);
                    default:
                        throw new NotImplementedException();
                }
            }, jobNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter">takes a job number and filters</param>
        /// <returns></returns>
        static public IEnumerable<IJob> GetJobs(Expression<Func<string, bool>> filterexp)
        {
            return Cache.CacheResult(() =>
            {
                var filter = filterexp.Compile();
                switch (AccountingSystem)
                {
                    case AccountingSystems.MasterBuilder:
                        return GetMBJobs(filter);
                    default:
                        throw new NotImplementedException();
                }
            }, filterexp);
        }

        static public IEnumerable<IJob> GetJobs()
        {
            return Cache.CacheResult(() =>
            {
                return GetJobs(jobNumber => true);
            });
        }

        static public IEnumerable<ITimeAndMaterialLineItem> GetTimeAndMaterialLineItemsByCostCode(ICostCode c)
        {
            return Cache.CacheResult(() =>
            {
                switch (AccountingSystem)
                {
                    case AccountingSystems.MasterBuilder:
                        return GetMBTimeAndMaterialLineItemsByCostCode(c);
                    default:
                        throw new NotImplementedException();
                }
            }, c.Id);
        }

        #region MasterBuilder
        static private IJob GetMBJob(string jobNumber)
        {
            return Cache.CacheResult(() =>
            {
                return new MasterBuilder.Job(jobNumber);
            }, jobNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter">a filter that takes the jobnumber</param>
        /// <returns></returns>
        static private IEnumerable<IJob> GetMBJobs(Func<string, bool> filter)
        {
            var jobnums = Connections
                    .GetList<string>("select recnum from actrec order by recnum")
                    .Where(filter);

            foreach (var j in jobnums)
            {
                yield return GetMBJob(j);
            }
        }

        static private IEnumerable<ITimeAndMaterialLineItem> GetMBTimeAndMaterialLineItemsByCostCode(ICostCode c)
        {
            var results = from ln in Connections.GetList<int>("select recnum from tmemln where cstcde = {0}", c.Id)
                          select (ITimeAndMaterialLineItem)new MasterBuilder.TimeAndMaterialLineItem(ln);

            return results;
        }
        #endregion
    }
}
