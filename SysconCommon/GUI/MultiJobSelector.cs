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
            public bool IsSelected;
            public long jobnumber;
            public string jobname;
            public string jobtype;
            public long jobstatus;
            public long clientnumber;
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

            this.grdJobs.DataSource = datalines_dt;
        }

        public IEnumerable<long> SelectedJobNumbers
        {
            get
            {
                foreach (DataLine row in datalines_dt.ToList<DataLine>())
                {
                    if (row.IsSelected)
                        yield return row.jobnumber;
                }
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in datalines_dt.Rows)
            {
                row["IsSelected"] = this.chkSelectAll.Checked;
            }

            this.grdJobs.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
