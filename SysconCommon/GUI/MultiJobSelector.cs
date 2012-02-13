using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon.Algebras.DataTables;
using SMB.Tables;

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

            [ColumnOrder(80)]
            public string supervisor;

            [ColumnOrder(90)]
            public string sitecontact;
        }

        private long[] initialJobList;

        public MultiJobSelector(long[] jobList)
        {
            InitializeComponent();
            initialJobList = jobList;
        }

        public MultiJobSelector() : this(null) { }

        private DataTable datalines_dt = null;

        // Runtime Analysis:
        // A = COUNT(*) in actrec
        // C = COUNT(*) in clnnum
        // J = COUNT(*) in jobtyp
        // E = COUNT(*) in employ
        // N = count of records in initialJobList, or 1 if initialJobList is null
        private void MultiJobSelector_Load(object sender, EventArgs e)
        {
            try
            {
                using (var con = Connections.GetOLEDBConnection())
                {
                    using (var joblist = con.GetTempDBF())
                    {
                        if (initialJobList != null)
                        {
                            // Runtime: O(N*Log(N))
                            // specifying that recnum is unique means it is indexed, which gives us better join times
                            con.ExecuteNonQuery("create table {0} (recnum n(10,0) not null unique)", joblist);
                            foreach (var recnum in initialJobList)
                            {
                                con.ExecuteNonQuery("insert into {0} (recnum) values ({1})", joblist, recnum);
                            }
                        }

                        // Runtime: O(A+A*Log(R)+A*Log(J)+A*Log(E))
                        var sql = string.Format(
                            "select actrec.recnum as JobNumber, jobnme as JobName, jobtyp.typnme as JobType, actrec.status as JobStatus"
                            + ", clnnum as ClientNumber, reccln.shtnme as ClientName"
                            + ", alltrim(employ.fullst) as Supervisor, actrec.contct as SiteContact"
                            + " from actrec"
                            + " left join reccln on clnnum = reccln.recnum"
                            + " left join jobtyp on actrec.jobtyp = jobtyp.recnum"
                            + " left join employ on actrec.sprvsr = employ.recnum");
                            
                        // Runtime: O(A*Log(N))
                        sql += initialJobList != null
                            ? string.Format(" join {0} ijoblst on actrec.recnum = ijoblst.recnum", joblist)
                            : "";

                        // Runtime: O(N)
                        datalines_dt = con.GetDataTable("Job List", sql);
                        datalines_dt = datalines_dt.ToList<DataLine>().ToDataTable("datalines");
                        current_dt = datalines_dt;

                        // Total Runtime: O(N*Log(N) + A + A*Log(R) + A*Log(J) + A*Log(E) + A*Log(N) + N)
                        // we know that A > N, so we can drop the N*Log(N) term
                        // O(MAX(A*Log(R)+A*Log(J)+A*Log(E)+A*Log(N))) - simplify to dominate term without constants
                        // O(A*MAX(Log(R),Log(J),Log(E),Log(N))) - simplify to dominate term
                        // O(A*Log(MAX(R,J,E,N))
                    }

                    // load the project supervisors
                    var supervisors_dt = con.GetDataTable("Supervisors", "select distinct employ.recnum, employ.fullst from actrec join employ on actrec.sprvsr = employ.recnum order by employ.fullst asc");
                    cmbSupervisors.DataSource = new string [] { "*Any*" }.Concat(
                                                    (from s in supervisors_dt.Rows.ToIEnumerable()
                                                     select s["fullst"].ToString().Trim())).ToArray();
                                                     
                    cmbSupervisors.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Env.Log("{0}\r\n{1}", ex.Message, ex.StackTrace);
                MessageBox.Show("Error Loading Job List Form", "Error", MessageBoxButtons.OK);
            }
#if false
            // Runtime: O(A+A*Log(R)+A*Log(J)+A*Log(E))
            datalines_dt = Connections.Connection.GetDataTable("datalines"
                , "select actrec.recnum as JobNumber, jobnme as JobName, jobtyp.typnme as JobType, actrec.status as JobStatus"
                + ", clnnum as ClientNumber, reccln.shtnme as ClientName"
                + ", alltrim(employ.fstnme) + ' ' + alltrim(employ.lstnme) as Supervisor, actrec.contct as SiteContact"
                + " from actrec"
                + " left join reccln on clnnum = reccln.recnum"
                + " left join jobtyp on actrec.jobtyp = jobtyp.recnum"
                + " left join employ on actrec.sprvsr = employ.recnum");

            var progress = new ProgressDialog(datalines_dt.Rows.Count + 1);
            progress.Text = "Getting Job List";

            if (initial_job_filter != null)
            {
                progress.Show();
            }

            // Runtime: O(A)
            // get the correct types, and make sure all columns exist
            var datalines = datalines_dt.ToList<DataLine>();
            datalines_dt = datalines.ToDataTable("datalines");

            var jobs = (from j in smbtable.GetAll<actrec>()
                        where initial_job_filter(j)
                        select j.recnum).ToArray();

            progress.Tick();

            if (initial_job_filter != null)
            {
                progress.Text = "Filtering Job List";

                // Runtime: O(AN)
                datalines_dt = datalines_dt.FilterRows(row =>
                {
                    progress.Tick();
                    return jobs.Contains(Convert.ToInt64(row["JobNumber"]));
                    // return true;
                });
            }

            current_dt = datalines_dt;
            
            progress.Close();

            // Total Runtime: O(A + A*Log(R) + A*Log(J) + A*Log(E) + A + AN)
            // O(A*MAX(Log(R),Log(J),Log(E),N)) - Simplify to dominate term
            // O(AN)

#endif



            this.chkStatus1.Checked = Env.GetConfigVar("mjselect_chkStatus1", true, true);
            this.chkStatus2.Checked = Env.GetConfigVar("mjselect_chkStatus2", false, true);
            this.chkStatus3.Checked = Env.GetConfigVar("mjselect_chkStatus3", true, true);
            this.chkStatus4.Checked = Env.GetConfigVar("mjselect_chkStatus4", true, true);
            this.chkStatus5.Checked = Env.GetConfigVar("mjselect_chkStatus5", true, true);
            this.chkStatus6.Checked = Env.GetConfigVar("mjselect_chkStatus6", true, true);

            DoFilter();

            this.txtFilter.KeyPress += new KeyPressEventHandler(txtFilter_KeyPress);
            this.chkStatus1.CheckedChanged += new EventHandler(chkStatus_CheckedChanged);
            this.chkStatus2.CheckedChanged += chkStatus_CheckedChanged;
            this.chkStatus3.CheckedChanged += chkStatus_CheckedChanged;
            this.chkStatus4.CheckedChanged += chkStatus_CheckedChanged;
            this.chkStatus5.CheckedChanged += chkStatus_CheckedChanged;
            this.chkStatus6.CheckedChanged += chkStatus_CheckedChanged;
        }

        void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            Env.SetConfigVar("mjselect_chkStatus1", chkStatus1.Checked);
            Env.SetConfigVar("mjselect_chkStatus2", chkStatus2.Checked);
            Env.SetConfigVar("mjselect_chkStatus3", chkStatus3.Checked);
            Env.SetConfigVar("mjselect_chkStatus4", chkStatus4.Checked);
            Env.SetConfigVar("mjselect_chkStatus5", chkStatus5.Checked);
            Env.SetConfigVar("mjselect_chkStatus6", chkStatus6.Checked);

            DoFilter();
        }

        void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // throw new NotImplementedException();
            if (e.KeyChar == '\r')
            {
                DoFilter();
            }
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
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DoFilter();
        }

        private void DoFilter()
        {
            // first filter by status
            List<long> Statuses = new List<long>();
            if (chkStatus1.Checked) Statuses.Add(1);
            if (chkStatus2.Checked) Statuses.Add(2);
            if (chkStatus3.Checked) Statuses.Add(3);
            if (chkStatus4.Checked) Statuses.Add(4);
            if (chkStatus5.Checked) Statuses.Add(5);
            if (chkStatus6.Checked) Statuses.Add(6);

            var statuses_array = Statuses.ToArray();

            var filtered_dt = datalines_dt.FilterRows(row => statuses_array.Contains((long)row["jobstatus"]));

            // filter by job supervisor
            var supvsr = cmbSupervisors.SelectedValue.ToString();
            if (supvsr != "*Any*")
            {
                filtered_dt = filtered_dt.FilterRows(row => ((string)row["supervisor"]).NullToBlank().Trim() == supvsr.Trim());
            }

            // do free-form filter
            var filter_text = this.txtFilter.Text.Trim();

            if (filter_text == "")
            {
                current_dt = filtered_dt;
            }
            else
            {
                current_dt = filtered_dt.FilterRows(row =>
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in current_dt.Rows)
            {
                row["IsSelected"] = false;
            }

            this.Close();
        }

        private void cmbSupervisors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoFilter();
        }
    }
}
