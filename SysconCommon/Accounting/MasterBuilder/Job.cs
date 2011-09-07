using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class Job : IJob
    {
        private static DataTable _cache;
        private static string _cache_string;
        private static Dictionary<string, DataRow> _cache_dictionary = null;

        public Job(string jobNumber)
        {
            if (_cache_dictionary != null)
            {
                try
                {
                    var row = _cache_dictionary[jobNumber];
                    loadFromRow(row);
                    return;
                }
                catch (Exception ex) 
                {
                    Env.DebugPrint(ex);
                }
            }

            if (_cache != null)
            {
                var row = (from r in _cache.Rows.ToIEnumerable()
                           where r["recnum"].ToString().Trim() == jobNumber.Trim()
                           select r).FirstOrDefault();

                if (row != null)
                {
                    this.loadFromRow(row);
                    return;
                }
            }

            this.JobNumber = jobNumber;
        }

        private void loadFromRow(DataRow row)
        {
            this.JobNumber = row["recnum"].ToString();
            this.JobTypeId = Convert.ToInt32(row["jobtyp"]);
            this.JobName = row["jobnme"].ToString();
            this.LotPremium = Convert.ToDecimal(row["lotprm"]);
        }

        public string JobNumber { get; set; }

        private string _JobName;
        public string JobName
        {
            get
            {
                if (_JobName != null)
                    return _JobName;

                return Cache.CacheResult(() =>
                {
                    return Connections.GetScalar<string>("select jobnme from actrec where recnum = {0}", JobNumber).Trim();
                }, JobNumber);
            }
            set
            {
                _JobName = value;
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


        private int? JobTypeId = null;
        public IJobType JobType
        {
            get
            {
                if (JobTypeId != null)
                    return new JobType(JobTypeId.Value);

                try
                {
                    var row = _cache_dictionary[JobNumber];
                    return new JobType(Convert.ToInt32(row["jobtyp"]));
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        return new JobType(Connections.GetScalar<int>("select jobtyp from actrec where recnum = {0}", JobNumber));
                    }, JobNumber);
                }
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
                JobCost.SetCache("select * from jobcst where jobnum = {0}", this.JobNumber);

                return Cache.CacheResult(() =>
                {
                    //var ids = Connections.GetList<int>("select recnum from jobcst where jobnum = {0}", this.JobNumber);
                    //return ids.Select(id => new JobCost(id)).ToArray();
                    return JobCost.GetFromCache(r => r["jobnum"].ToString().Trim() == this.JobNumber.Trim());
                }, JobNumber);
            }

        }


        public IEnumerable<IInvoice> Invoices
        {
            get
            {
                Invoice.SetCache("select * from acrinv where jobnum = {0}", this.JobNumber);

                try
                {
                    return Invoice.GetFromCache(r => true);
                }
                catch
                {
                    return Cache.CacheResult(() =>
                    {
                        var ids = Connections.GetList<int>("select recnum from acrinv where jobnum = {0}", this.JobNumber);
                        return ids.Select(id => new Invoice(id)).ToArray();
                    }, JobNumber);
                }
            }
        }

        private bool? _HasTAndM = null;
        public ITimeAndMaterial TimeAndMaterials
        {
            get
            {
                if (true)
                {
                    TimeAndMaterial.SetCache("select * from timmat where recnum = {0}", this.JobNumber);

                    return Cache.CacheResult(() =>
                    {
                        var reccount = Connections.GetScalar<int>("select count(*) from timmat where recnum = {0}", this.JobNumber);
                        if (reccount == 0)
                        {
                            _HasTAndM = false;
                            return null;
                        }
                        else
                        {
                            _HasTAndM = true;
                            return new TimeAndMaterial(int.Parse(this.JobNumber));
                        }
                    }, JobNumber);
                }
                // else
                // {
                //    return _HasTAndM.Value ? new TimeAndMaterial(int.Parse(this.JobNumber)) : null;
                // }
            }
        }

        private decimal? _LotPremium;
        public decimal LotPremium
        {
            get
            {
                if (_LotPremium != null)
                    return _LotPremium.Value;

                return Cache.CacheResult(() => Connections.GetScalar<decimal>(
                    "select lotprm from actrec where recnum = {0}", this.JobNumber), this.JobNumber);
            }
            set
            {
                _LotPremium = value;
            }
        }


        public IEmployee Supervisor
        {
            get
            {
                return Cache.CacheResult(() =>
                {
                    var sprvsr = Connections.GetScalar<int>("select sprvsr from actrec where recnum = {0}", this.JobNumber);
                    return sprvsr == 0 ? null : new Employee(sprvsr);
                });
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public static void SetCache(string sqlfmt, params object[] args)
        {
            var cstr = string.Format(sqlfmt, args);
            if (_cache_string == cstr)
                return;

            ClearCache();

            _cache = Connections.Connection.GetDataTable("cache", sqlfmt, args);
            _cache_string = cstr;
            _cache_dictionary = new Dictionary<string, DataRow>();

            foreach (DataRow row in _cache.Rows)
            {
                _cache_dictionary.Add(row["recnum"].ToString(), row);
            }
        }

        public static void ClearCache()
        {
            _cache_string = null;
            _cache = null;
            _cache_dictionary = null;
        }


        public IEmployee Estimator
        {
            get
            {
                return Cache.CacheResult(() =>
                    {
                        var estemp = Connections.GetScalar<int>("select estemp from actrec where recnum = {0}", this.JobNumber);
                        return estemp == 0 ? null : new Employee(estemp);
                    });
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
