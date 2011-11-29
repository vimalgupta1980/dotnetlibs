using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using SysconCommon.Common;
using SysconCommon;
using SysconCommon.Foxpro;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    [Obsolete]
    public partial class Assembly_Editor : Form
    {
        private COMMethods MBAPI;
        private ProgramInfo ProgInfo;
        private readonly bool IsStandAlone;

        public Assembly_Editor(COMMethods mbapi, bool StandAlone = false)
        {
            MBAPI = mbapi;
            ProgInfo = mbapi.GetProgramInfo();

            InitializeComponent();
            menuStrip1.Visible = StandAlone;
            IsStandAlone = StandAlone;
        }

        // TODO: enter properties for each column
        class _EditRow
        {
            public long AsmNo { get; set; }
            public string AsmName { get; set; }
            public long AsmClassNo { get; set; }
            public string AsmClassName { get; set; }
            public long PartNo { get; set; }
            public string PartName { get; set; }
            public string PartUnit { get; set; }
            public string PartAlphaNum { get; set; }
            public decimal PartCostCode { get; set; }
            public long PartCostType { get; set; }
            public string PartTask { get; set; }
            public long AsmLineNo { get; set; }
        }

        _EditRow[] EditItems = null;

        private void _Load(object sender, EventArgs e)
        {
            _Load_Data();
        }

        private void _Load_Data()
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                try
                {
                    // TODO: load the EditItems array
                    var edititems_dt = con.GetDataTable("Edit Items", "select"
                            + " p.recnum as AsmNo, alltrim(a.asmnme) as AsmName, c.recnum as AsmClassNo"
                            + ", alltrim(c.clsnme) as AsmClassName, p.prtnum as PartNo, alltrim(p.prtnme) as PartName"
                            + ", alltrim(p.prtunt) as PartUnit, alltrim(p.alpnum) as PartAlphaNum"
                            + ", p.prtcde as PartCostCode, p.prttyp as PartCostType, alltrim(s.tsknme) as PartTask"
                            + ", p.linnum as AsmLineNo"
                        + " from assemb a"
                        + " join asmprt p on a.recnum = p.recnum"
                        + " left join asmcls c on c.recnum = a.asmcls"
                        + " left join schtsk s on s.recnum = p.prttsk"
                        + " order by c.recnum, p.recnum, p.linnum");

                    EditItems = edititems_dt.ToList<_EditRow>().ToArray();

                    this.grdItems.DataSource = EditItems;
                }
                catch (Exception ex)
                {
                    throw new SysconException(ex);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChanges()
        {
            if (MessageBox.Show("Save Changes?", "User Input", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var con = Connections.GetOLEDBConnection())
                {
                    foreach (var _item in EditItems)
                    {
                        // TODO: update the item
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveChanges();

            if (!this.IsStandAlone)
            {
                this.Close();
            }
            else
            {
                _Load_Data();
            }
        }
    }
}
