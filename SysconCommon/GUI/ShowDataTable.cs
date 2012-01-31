using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    public partial class ShowDataTable : Form
    {
        readonly DataTable datasource;
        readonly bool is_editable;

        public ShowDataTable(DataTable data, bool editable)
        {
            datasource = data;
            is_editable = editable;
            InitializeComponent();
        }

        private void ShowDataTable_Load(object sender, EventArgs e)
        {
            if (is_editable)
            {
                grdData.ReadOnly = false;
            }

            this.Text = datasource.TableName;
            grdData.SetSysconDataTable(datasource);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public static DialogResult ShowTable(DataTable data, bool editable = false)
        {
            var frm = new ShowDataTable(data, editable);
            return frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
