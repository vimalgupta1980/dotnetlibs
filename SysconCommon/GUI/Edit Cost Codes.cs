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
    public partial class Edit_Cost_Codes : Form
    {
        private COMMethods MBAPI;
        private ProgramInfo ProgInfo;

        public Edit_Cost_Codes(COMMethods mbapi)
        {
            MBAPI = mbapi;
            ProgInfo = mbapi.GetProgramInfo();

            InitializeComponent();
        }

        /// <summary>
        /// enter the table name here
        /// </summary>
        public string EmptyTableName = "syscon_cstcde";

        public string TargetEmptyTableName
        {
            get
            {
                return ProgInfo.SMBDir + "/" + EmptyTableName + ".dbf";
            }
        }

        public string TargetIndexName
        {
            get
            {
                return Path.GetDirectoryName(TargetEmptyTableName) + "/" + Path.GetFileNameWithoutExtension(TargetEmptyTableName) + ".cdx";
            }
        }

        public string SourceEmptyTableName
        {
            get
            {
                return Env.GetEXEDirectory() + "/" + EmptyTableName + ".dbf";
            }
        }

        public string SourceIndexName
        {
            get
            {
                return Path.GetDirectoryName(SourceEmptyTableName) + "/" + Path.GetFileNameWithoutExtension(SourceEmptyTableName) + ".cdx";
            }
        }

        // enter properties for each column
        class _EditRow
        {
            public decimal recnum { get; set; }
            public string cdenme { get; set; }
            public int unbillable { get; set; }
        }

        _EditRow[] EditItems = null;

        private void _Load(object sender, EventArgs e)
        {
            try
            {
                using (var con = Connections.GetOLEDBConnection())
                {
                    // make sure the setup table exists
                    if (!File.Exists(TargetEmptyTableName))
                    {
                        File.Copy(SourceEmptyTableName, TargetEmptyTableName);
                        File.Copy(SourceIndexName, TargetIndexName);
                    }

                    // remove deleted items
                    con.ExecuteNonQuery("delete from syscon_cstcde where recnum not in (select recnum from cstcde)");

                    // make sure all the items exist
                    var new_cstcdes = con.GetDataTable("cstcde", "select recnum from cstcde where recnum not in (select recnum from syscon_cstcde)");
                    foreach (var row in new_cstcdes.Rows.ToIEnumerable())
                    {
                        con.ExecuteNonQuery("insert into syscon_cstcde (recnum, unbillable) values ({0}, 0)", row[0]);
                    }

                    // load the EditItems array
                    var cstcdes_dt = con.GetDataTable("cstcde", "select syscon_cstcde.*, cstcde.cdenme from syscon_cstcde join cstcde on cstcde.recnum = syscon_cstcde.recnum order by syscon_cstcde.recnum asc");
                    EditItems = cstcdes_dt.ToList<_EditRow>().ToArray();

                    this.grdItems.DataSource = EditItems;
                }
            }
            catch (Exception ex)
            {
                Env.Log("Could not load cost code editor: {0}\r\n", ex.Message, ex.StackTrace);
                MessageBox.Show("Could not load cost code editor, see log for details", "Error", MessageBoxButtons.OK);
                this.Close();
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
                        // update the item
                        con.ExecuteNonQuery("update syscon_cstcde set unbillable = {0} where recnum = {1}", _item.unbillable, _item.recnum);
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Close();
        }
    }
}
