using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysconCommon.GUI
{
    public partial class ShowDataTable : Form
    {
        DataTable datasource;

        public ShowDataTable(DataTable data)
        {
            datasource = data;
            InitializeComponent();
        }

        private void ShowDataTable_Load(object sender, EventArgs e)
        {
            this.Text = datasource.TableName;
            grdData.DataSource = datasource;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowTable(DataTable data)
        {
            var frm = new ShowDataTable(data);
            frm.ShowDialog();
        }
    }
}
