using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon.GUI;

namespace SysconCommon.Accounting
{
    public enum AccountingSystems
    {
        MasterBuilder,
    }

    public static class Accounting
    {
        static public AccountingSystems AccountingSystem = AccountingSystems.MasterBuilder;

        static public IEnumerable<IJobType> GetJobTypes()
        {
            switch (AccountingSystem)
            {
                case AccountingSystems.MasterBuilder:
                    return GetMBJobTypes();
                default:
                    throw new NotImplementedException();
            }
        }

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

        static public IEnumerable<ILedgerAccount> GetLedgerAccounts(Expression<Func<ILedgerAccount, bool>> filterExp)
        {
            switch (AccountingSystem)
            {
                case AccountingSystems.MasterBuilder:
                    return GetMBLedgerAccounts(filterExp);
                default:
                    throw new NotImplementedException();
            }
        }

        static private IEnumerable<ILedgerAccount> GetMBLedgerAccounts(Expression<Func<ILedgerAccount, bool>> filterExp)
        {
            var recnums = Connections.GetList<int>("select recnum from lgract");
            foreach (var r in recnums)
            {
                var fn = filterExp.Compile();
                var act = new MasterBuilder.LedgerAccount(r);
                if (fn(act))
                    yield return act;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter">takes a job number and filters</param>
        /// <returns></returns>
        static public IEnumerable<IJob> GetJobs(Func<string, bool> filterexp)
        {
            return Cache.CacheResult(() =>
            {
                // var filter = filterexp.Compile();
                switch (AccountingSystem)
                {
                    case AccountingSystems.MasterBuilder:
                        return GetMBJobs(filterexp);
                    default:
                        throw new NotImplementedException();
                }
            }, filterexp);
        }

        static public IEnumerable<IJob> GetJobs()
        {
            return Cache.CacheResult(() =>
            {
                var count = Connections.GetScalar<int>("select count(*) from actrec");
                var progress = new ProgressDialog(count, "Selecting Job List");
                progress.Show();
                var result = GetJobs(jobNumber => {
                    progress.Tick();
                    return true;
                });

                progress.Close();
                return result;
            }, "AllJobs");
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
        static private IEnumerable<IJobType> GetMBJobTypes()
        {
            return Cache.CacheResult(() => Connections.GetList<int>("select recnum from jobtyp").Select(r => (IJobType) new MasterBuilder.JobType(r)));
        }

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
            using (var cmd = Connections.Connection.CreateCommand())
            {
                cmd.CommandText = "select recnum, jobnme from actrec order by recnum";
                var rdr = cmd.ExecuteReader();
                List<IJob> rv = new List<IJob>();
                while (rdr.Read())
                {
                    if (filter(rdr[0].ToString()))
                    {
                        rv.Add(new MasterBuilder.Job(rdr[0].ToString()) { JobName = rdr[1].ToString() });
                    }
                }

                return rv;
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
            MasterBuilder.TimeAndMaterialLineItem.SetCache("select * from tmemln", c.Recnum);

            try
            {
                return MasterBuilder.TimeAndMaterialLineItem.GetFromCache(r => Convert.ToDecimal(r["cstcde"]) == c.Recnum);
            }
            catch
            {
                return Cache.CacheResult(() =>
                {
                    using (var cmd = Connections.Connection.CreateCommand())
                    {
                        var rv = new List<ITimeAndMaterialLineItem>();
                        cmd.CommandText = string.Format("select recnum, linnum from tmemln where cstcde = {0}", c.Recnum);
                        var rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            rv.Add(new MasterBuilder.TimeAndMaterialLineItem(Convert.ToInt32(rdr[0]), Convert.ToInt32(rdr[1])));
                        }

                        return rv;
                    }
                }, c.Recnum);
            }
        }
        #endregion
    }
}
