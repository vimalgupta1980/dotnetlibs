using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon;
using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Analysis;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    public static class UserInteract
    {
        public static IDictionary<long, decimal> GetPaygroupOverhead(params long[] paygroups)
        {
            if(paygroups.Length == 0)
                paygroups = null;

            using(var con = Connections.GetOLEDBConnection()) 
            {
                using (var anal = PaygroupAnalysis.GetPaygroupOverheadAnalysisTable(con, paygroups))
                {
                    var dt = con.GetDataTable("Paygroup Employer Costs", "select * from {0}", anal);

                    dt = dt.AddColumnWithData<bool>("Include", true.Repeat(dt.Rows.Count));

                    dt.ApplyMods(
                        DTColumns.CheckBoxColumns("Include"),
                        DTColumns.SetCaptions("paygrp", "Paygroup #", "grpnme", "Paygroup Name", "clcnum", "Calculation #", "clcnme", "Calculation Name", "overhead1", "Overhead"),
                        DTColumns.SetFillColumn("clcnme"),
                        DTColumns.DisplayFirst("Include")
                        );

                    if (ShowDataTable.ShowTable(dt, true) != System.Windows.Forms.DialogResult.OK)
                        return null;

                    Dictionary<long, decimal> results = new Dictionary<long, decimal>();

                    if (paygroups != null)
                        foreach (var pg in paygroups)
                            results.Add(pg, 0.0m);

                    foreach (DataRow row in dt.Rows)
                    {
                        if (Convert.ToBoolean(row["Include"]))
                        {
                            var recnum = Convert.ToInt64(row["paygrp"]);
                            var rate = Convert.ToDecimal(row["overhead1"]);

                            if (results.ContainsKey(recnum))
                                results[recnum] += rate;
                            else
                                results.Add(recnum, rate);
                        }
                    }

                    return results;
                }
            }
        }
    }
}
