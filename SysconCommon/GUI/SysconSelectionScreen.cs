using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon;
using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    public partial class SysconSelectionScreen : Form
    {
        protected readonly DataTable DataSource;
        protected readonly string SelectionColumn;
        protected readonly Func<DataRow, bool> LoadFunc;

        public SysconSelectionScreen(DataTable datasource, string selectionColumn = "selected", bool select_all = false, Func<DataRow, bool> loadFunc = null)
        {
            if (!datasource.Columns.Contains(selectionColumn))
            {
                datasource.Columns.Add(selectionColumn, typeof(int));

                if (select_all)
                {
                    foreach (DataRow row in datasource.Rows)
                    {
                        row["selected"] = 1;
                    }
                }
                else
                {
                    foreach (DataRow row in datasource.Rows)
                    {
                        row["selected"] = 0;
                    }
                }
            }

            datasource.ApplyMods(
                DTColumns.ReadOnly(),
                DTColumns.AllowEdit(selectionColumn),
                DTColumns.SetCaptions(selectionColumn, "Select"),
                DTColumns.CheckBoxColumns(selectionColumn));

            DataSource = datasource;
            SelectionColumn = selectionColumn;

            LoadFunc = loadFunc;

            InitializeComponent();
        }

        private void SysconSelectionScreen_Load(object sender, EventArgs e)
        {
            // this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            grdSelection.SetSysconDataTable(DataSource);
            grdSelection.Columns[SelectionColumn].DisplayIndex = 0;

            if (LoadFunc == null)
                btnLoad.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            object trueValue = 1, falseValue = 0;
            if (DataSource.Columns[SelectionColumn].DataType == typeof(bool))
            {
                trueValue = true;
                falseValue = false;
            }

            var total = 0;

            foreach (DataRow row in DataSource.Rows)
            {
                if (LoadFunc(row))
                {
                    row[SelectionColumn] = trueValue;
                    total += 1;
                }
                else
                    row[SelectionColumn] = falseValue;
            }

            MessageBox.Show(string.Format("Selected {0} items", total), "Info", MessageBoxButtons.OK);
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            object setVal = chkSelectAll.Checked;

            if (DataSource.Columns[SelectionColumn].DataType != typeof(bool))
            {
                setVal = chkSelectAll.Checked ? 1 : 0;
            }

            foreach (DataRow row in DataSource.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    row[SelectionColumn] = setVal;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataSource.RejectChanges();

            if (txtFilter.Text.IsEmpty())
                return;

            var filterTxt = txtFilter.Text.ToLower().Trim();

            DataSource.DeleteRowsWhere(row =>
            {
                foreach (DataColumn c in DataSource.Columns)
                {
                    if (row[c] != null && row[c].ToString().ToLower().Contains(filterTxt))
                        return false;
                }

                return true;
            });
        }

        public IEnumerable<DataRow> SelectedRows
        {
            get
            {
                foreach (DataRow row in DataSource.Rows)
                {
                    if (row.RowState != DataRowState.Deleted && Convert.ToInt32(row[SelectionColumn]) > 0)
                        yield return row;
                }
            }
        }
    }
}
