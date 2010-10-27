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

        static public IEnumerable<ICostCode> GetCostCodes()
        {
            switch (AccountingSystem)
            {
                case AccountingSystems.MasterBuilder:
                    return GetMBCostCodes();
                default:
                    throw new NotImplementedException();
            }
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
            }, c.Recnum);
        }

        static public IEnumerable<IEquipmentLineItem> GetEquipmentLineItemsByEquipment(IEquipment e)
        {
            return Cache.CacheResult(() =>
            {
                switch (AccountingSystem)
                {
                    case AccountingSystems.MasterBuilder:
                        return GetMBEquipmentLineItemsByEquipment(e);
                    default:
                        throw new NotImplementedException();
                }
            }, e.EquipmentNumber);
        }

        #region MasterBuilder
        static private IEnumerable<IEquipmentLineItem> GetMBEquipmentLineItemsByEquipment(IEquipment e)
        {
            using (var cmd = Connections.Connection.CreateCommand())
            {
                cmd.CommandText = string.Format("select recnum, linnum from tmeqln where eqpnum = {0}", e.EquipmentNumber);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    yield return new MasterBuilder.EquipmentLineItem(Convert.ToInt32(rdr[0]), Convert.ToInt32(rdr[1]));
                }
            }
        }

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

        static private IEnumerable<ICostCode> GetMBCostCodes()
        {
            var costcodes = Connections.GetList<decimal>("select recnum from cstcde order by recnum");
            return from c in costcodes
                   select (ICostCode) new MasterBuilder.CostCode(c);
        }

        static private IEnumerable<ITimeAndMaterialLineItem> GetMBTimeAndMaterialLineItemsByCostCode(ICostCode c)
        {
            //var results = from ln in Connections.GetList<int>("select recnum from tmemln where cstcde = {0}", c.EquipmentNumber)
            //              select (ITimeAndMaterialLineItem)new MasterBuilder.TimeAndMaterialLineItem(ln);

            using (var cmd = Connections.Connection.CreateCommand())
            {
                cmd.CommandText = string.Format("select recnum, linnum from tmemln where cstcde = {0}", c.Recnum);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    yield return new MasterBuilder.TimeAndMaterialLineItem(Convert.ToInt32(rdr[0]), Convert.ToInt32(rdr[1]));
                }
            }
        }
        #endregion
    }
}
