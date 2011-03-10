using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    public partial class MultiJobSelector : Form
    {
        class DataLine
        {
            [ColumnOrder(10)]
            public bool IsSelected;

            [ColumnOrder(20)]
            public long jobnumber;

            [ColumnOrder(30)]
            public string jobname;

            [ColumnOrder(40)]
            public string jobtype;

            [ColumnOrder(50)]
            public long jobstatus;

            [ColumnOrder(60)]
            public long clientnumber;

            [ColumnOrder(70)]
            public string clientname;
        }

        public MultiJobSelector()
        {
            InitializeComponent();
        }

        private DataTable datalines_dt = null;

        private void MultiJobSelector_Load(object sender, EventArgs e)
        {
            datalines_dt = Connections.Connection.GetDataTable("datalines"
                , "select actrec.recnum as JobNumber, jobnme as JobName, jobtyp.typnme as JobType, actrec.status as JobStatus, clnnum as ClientNumber, reccln.shtnme as ClientName"
                + " from actrec"
                + " left join reccln on clnnum = reccln.recnum"
                + " left join jobtyp on actrec.jobtyp = jobtyp.recnum");

            // get the correct types, and make sure all columns exist
            var datalines = datalines_dt.ToList<DataLine>();
            datalines_dt = datalines.ToDataTable("datalines");

            current_dt = datalines_dt;
        }

        private DataTable current_dt
        {
            get
            {
                return this.grdJobs.DataSource as DataTable;
            } set 
            {
                this.grdJobs.DataSource = value;
            }
        }

        public IEnumerable<long> SelectedJobNumbers
        {
            get
            {
                foreach (DataLine row in current_dt.ToList<DataLine>())
                {
                    if (row.IsSelected)
                        yield return row.jobnumber;
                }
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in current_dt.Rows)
            {
                row["IsSelected"] = this.chkSelectAll.Checked;
            }

            this.grdJobs.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filter_text = this.txtFilter.Text.Trim();

            if (filter_text == "")
            {
                current_dt = datalines_dt;
            }
            else
            {
                current_dt = datalines_dt.FilterRows(row =>
                {
                    foreach (DataColumn c in row.Table.Columns)
                    {
                        if (row[c].ToString().ToUpper().Contains(filter_text.ToUpper()))
                            return true;
                    }

                    return false;
                });
            }
        }
    }
}
