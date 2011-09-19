using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public partial class FldlibBasedGrid : Form
    {
        private string FldlibTable()
        {
            return FldlibTable(source_table);
        }

        private string FldlibTable(string tblnam)
        {
            if (tblnam != null && File.Exists(Env.GetMBDir() + @"\syscon_fldlib.dbf"))
            {
                using (var con = Connections.GetOLEDBConnection())
                {
                    var count = con.GetScalar<int>("select count(*) from syscon_fldlib where tblnam == '{0}'", tblnam);
                    if (count > 0)
                        return "syscon_fldlib";
                }
            }

            return "fldlib";
        }

        public FldlibBasedGrid()
        {
            InitializeComponent();
            
            // todo: allow new rows
            this.grdTableView.AllowUserToAddRows = false;
        }

        private void FldlibBasedGrid_Load(object sender, EventArgs e)
        {
            this.grdTableView.DataError += new DataGridViewDataErrorEventHandler(grdTableView_DataError);
        }

        void grdTableView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // throw new NotImplementedException();
            // MessageBox.Show("Invalid data for combo box");
        }

        private string source_table = null;
        private DataTable data_dt = null;

        public void SetEditTable(string tblnam)
        {
            source_table = tblnam;

            using (var con = Connections.GetOLEDBConnection())
            {
                var fldlib_dt = con.GetDataTable("fldlib", "select * from {1} where tblnam == '{0}' order by fldnum asc", tblnam, FldlibTable());

                foreach (var row in fldlib_dt.Rows.ToIEnumerable())
                {
                    // var celltemplate = new DataGridViewTextBoxCell();

                    DataGridViewColumn newcol = new DataGridViewTextBoxColumn();

                    if (DBNull.Value.Equals(row["wndbtn"])) // it's not something that should be editable by the user, so hide the column
                    {
                        newcol.Visible = false;
                    }
                    else
                    {
                        // if it's supposed to be a lookup, make a combobox column and populate it's data
                        if (Convert.ToInt32(row["scnrel"]) == 1)
                        {
                            try
                            {
                                newcol = new DataGridViewComboBoxColumn();
                                var cmbcol = newcol as DataGridViewComboBoxColumn;

                                // figure out relative field
                                var reffld = row["relfld"].ToString().Trim();
                                var m = Regex.Match(reffld, @"^(\w+)[.](\w+)$");
                                var table = m.Groups[1].Value;
                                var field = m.Groups[2].Value;
                                var name_field = con.GetScalar<string>("select fldnme from {1} where tblnam = '{0}' and fldnum = 1", table, FldlibTable(table)).Trim();

                                cmbcol.DisplayMember = "display";
                                cmbcol.ValueMember = "id";

                                // if the field isn't required, allow a blank
                                if (Convert.ToInt32(row["fldreq"]) == 0)
                                {
                                    // don't worry about it
                                }

                                // this crazy query gives us a list of all the possible values, including zero'd out if they exist
                                var options_sql = string.Format(
                                    "select distinct nvl({4}.{3}, {2}.{0}) as id, nvl(alltrim(str({2}.{0})) + '-' + alltrim({2}.{1}), 'None') as display "
                                    + "from {2} "
                                    + "full join {4} on {2}.{0} = {4}.{3} "
                                    + "order by 1"
                                    , field, name_field, table, row["fldnme"], tblnam);

                                // CopyableMsgBox.Show(options_sql);
                                var options_dt = con.GetDataTable("Options", options_sql);

                                foreach (var option in options_dt.Rows.ToIEnumerable())
                                {
                                    cmbcol.Items.Add(new { id = option["id"], display = option["display"].ToString() });
                                }
                            }
                            catch
                            {
                                newcol = new DataGridViewTextBoxColumn();
                            }
                        }

                        // if it's supposed to be a checkbox, make it a checkbox column
                        // wrap in a try catch in case lowval or highval are too big or small to fit in an int32
                        try
                        {
                            if (Convert.ToString(row["fldtyp"]).Trim() == "N"
                                && Convert.ToInt32(row["lowval"]) == 0
                                && Convert.ToInt32(row["hghval"]) == 1)
                            {
                                newcol = new DataGridViewCheckBoxColumn();
                                var chkcol = newcol as DataGridViewCheckBoxColumn;

                                chkcol.FalseValue = 0;
                                chkcol.TrueValue = 1;
                                chkcol.ValueType = typeof(int);
                            }
                        }
                        catch { }
                    }

                    // don't make recnum editable
                    if(Convert.ToInt32(row["fldnum"]) == 0)
                        newcol.ReadOnly = true;

                    newcol.Name = row["fldnme"].ToString();
                    newcol.DataPropertyName = row["fldnme"].ToString();
                    newcol.HeaderText = row["flddsc"].ToString();
                    
                    grdTableView.Columns.Add(newcol);
                }

                data_dt = con.GetDataTable("data", "select * from {0}", tblnam);
                grdTableView.DataSource = data_dt;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TODO: make this save new records too
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                this.grdTableView.BindingContext[data_dt].EndCurrentEdit();

                var changed_dt = data_dt.GetChanges();

                // find the recnum field
                var recnum_field = "recnum";
                try
                {
                    recnum_field = con.GetScalar<string>("select fldnme from {1} where tblnam == '{0}' and fldnum = 0", source_table, FldlibTable()).Trim();
                }
                catch { }

                foreach (var row in changed_dt.Rows.ToIEnumerable())
                {
                    Dictionary<string, object> update_values_dict = new Dictionary<string, object>();
                    object recnum = null;
                
                    foreach (var col in changed_dt.Columns.ToIEnumerable())
                    {
                        if (col.ColumnName != recnum_field)
                        {
                            update_values_dict.Add(col.ColumnName, row[col]);
                        } else {
                            recnum = row[col];
                        }
                    }

                    var update_sql = string.Format("update {0} set {3} where {1} = {2}"
                        , source_table, recnum_field, recnum,
                        string.Join(",", update_values_dict.Keys.Select(k =>
                        {
                            var v = update_values_dict[k];
                            
                            if (DBNull.Value.Equals(v))
                                return string.Format("{0} = null", k);

                            var vstr = new Type[] { typeof(int), typeof(long), typeof(double), typeof(float), typeof(decimal) }.Contains(v.GetType())
                                ? v.ToString()
                                : v.GetType() == typeof(DateTime)
                                    ? string.Format("DATE({0},{1},{2})", ((DateTime)v).Year,  ((DateTime)v).Month, ((DateTime)v).Day)
                                    : "'" + v.ToString() + "'";

                            return string.Format("{0} = {1}", k, vstr);
                        }).ToArray()));

                    // CopyableMsgBox.Show(update_sql);

                    try
                    {
                        con.ExecuteNonQuery(update_sql);
                    }
                    catch
                    {
                        CopyableMsgBox.Show("Could not update data: BAD SQL STATEMENT IS: " + update_sql);
                    }
                }
            }

            this.Close();
        }
    }
}
