using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Reflection;

using SysconCommon.Common;
using SysconCommon;
using SysconCommon.Foxpro;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    public partial class Multi_Union_Selector : Form
    {
        private COMMethods MBAPI;
        private ProgramInfo ProgInfo;

        public Multi_Union_Selector(COMMethods mbapi)
        {
            MBAPI = mbapi;
            ProgInfo = mbapi.GetProgramInfo();

            InitializeComponent();
        }

        // TODO: enter properties for each column
        public class _SelectRow
        {
            public bool IsSelected { get; set; }
            public long recnum { get; set; }
            public string uninme { get; set; }
        }

        _SelectRow[] SelectItems = null;

        public IEnumerable<_SelectRow> SelectedItems
        {
            get
            {
                foreach (var i in SelectItems)
                    if (i.IsSelected)
                        yield return i;
            }
        }

        private void _Load(object sender, EventArgs e)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                var unions_dt = con.GetDataTable("Unions", "select recnum, uninme from payuni");
                SelectItems = unions_dt.ToList<_SelectRow>().ToArray();

                this.grdItems.DataSource = SelectItems;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyFilter()
        {
            IEnumerable<_SelectRow> items = SelectItems;

            // TODO: Add any custom filter logic here

            var filterTxt = txtFilter.Text.ToLower().Trim();

            if (filterTxt == "")
            {
                grdItems.DataSource = items;
            }
            else
            {
                var txtFiltered = new List<_SelectRow>(items);
                var props = typeof(_SelectRow).GetProperties();
                var keep = new List<_SelectRow>();

                foreach (var row in items)
                {
                    foreach (var p in props)
                    {
                        var v = p.GetValue(row, null);
                        if (v != null && v.ToString().ToLower().Contains(filterTxt))
                        {
                            keep.Add(row);
                            break;
                        }
                    }
                }

                grdItems.DataSource = keep.ToArray();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter();

            foreach (var i in SelectItems)
                i.IsSelected = false;

            chkSelectAll.Checked = false;
            grdItems.Refresh();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            var items = grdItems.DataSource as _SelectRow[];

            foreach (var i in items)
                i.IsSelected = chkSelectAll.Checked;

            grdItems.Refresh();
        }
    }
}
