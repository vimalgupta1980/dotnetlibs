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
    public partial class Multi_Paygroup_Selector : Form
    {
        private readonly COMMethods MBAPI;
        private readonly ProgramInfo ProgInfo;
        private readonly bool _include_zero;

        public Multi_Paygroup_Selector(COMMethods mbapi, bool include_zero_paygroup=false)
        {
            MBAPI = mbapi;
            ProgInfo = mbapi.GetProgramInfo();
            _include_zero = include_zero_paygroup;

            InitializeComponent();
        }

        // TODO: enter properties for each column
        public class _SelectRow
        {
            public bool IsSelected { get; set; }
            public long recnum { get; set; }
            public string grpnme { get; set; }
            public string wrkcls { get; set; }
            public string uninme { get; set; }
        }

        public bool UserHitOK
        {
            get
            {
                return OK;
            }
        }

        _SelectRow[] SelectItems = null;

        public IEnumerable<_SelectRow> SelectedItems
        {
            get
            {
                if (OK)
                {
                    foreach (var i in SelectItems)
                        if (i.IsSelected)
                            yield return i;
                }
            }
        }

        private void _Load(object sender, EventArgs e)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                // TODO: load the SelectItems array
                var paygroups_dt = con.GetDataTable("Paygroups", "select paygrp.recnum, paygrp.grpnme, paygrp.wrkcls, payuni.uninme"
                    + " from paygrp"
                    + " left join payuni on payuni.recnum = paygrp.uninum");

                var zeros = new _SelectRow[_include_zero ? 1 : 0];
                if (_include_zero)
                {
                    zeros[0] = new _SelectRow()
                    {
                        grpnme = "No Paygroup",
                        recnum = 0,
                        uninme = null,
                        wrkcls = null,
                    };
                }

                SelectItems = zeros.Append(paygroups_dt.ToList<_SelectRow>()).ToArray();

                this.grdItems.DataSource = SelectItems;
            }
        }

        private bool OK = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK = true;
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

        public static IEnumerable<_SelectRow> SelectPaygroups(COMMethods mbapi, bool include_zero_paygrp=false)
        {
            var frm = new Multi_Paygroup_Selector(mbapi,include_zero_paygroup:include_zero_paygrp);
            frm.ShowDialog();
            return frm.SelectedItems;
        }
    }
}
