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
    public partial class Edit_Job_Types : Form
    {
        private COMMethods MBAPI;
        private ProgramInfo ProgInfo;

        public Edit_Job_Types(COMMethods mbapi)
        {
            MBAPI = mbapi;
            ProgInfo = mbapi.GetProgramInfo();

            InitializeComponent();
        }

        /// <summary>
        /// enter the table name here
        /// </summary>
        public string EmptyTableName = "syscon_jobtyp";

        public string TargetEmptyTableName
        {
            get
            {
                return ProgInfo.SMBDir + "/" + EmptyTableName + ".dbf";
            }
        }

        public string SourceEmptyTableName
        {
            get
            {
                return Env.GetMyAssemblyDirectory() + "/" + EmptyTableName + ".dbf";
            }
        }

        public string SourceIndexName
        {
            get
            {
                return Env.GetMyAssemblyDirectory() + "/" + EmptyTableName + ".cdx";
            }
        }

        public string TargetIndexName
        {
            get
            {
                return ProgInfo.SMBDir + "/" + EmptyTableName + ".cdx";
            }
        }

        // TODO: enter properties for each column
        class _EditRow
        {
            public int istimmat { get; set; }
            public int recnum { get; set; }
            public string typnme { get; set; }
        }

        _EditRow[] EditItems = null;

        private void _Load(object sender, EventArgs e)
        {
            using (var con = Connections.GetOLEDBConnection())
            {
                // make sure the setup table exists
                if (!File.Exists(TargetEmptyTableName))
                {
                    File.Copy(SourceEmptyTableName, TargetEmptyTableName);
                    File.Copy(SourceIndexName, TargetIndexName);
                }

                // TODO: remove deleted items
                con.ExecuteNonQuery("delete from {0} where recnum not in (select recnum from jobtyp)", EmptyTableName);

                // TODO: make sure all the items exist
                var recnums_dt = con.GetDataTable("Recnums", "select distinct recnum from jobtyp where recnum not in (select recnum from {0})", EmptyTableName);
                foreach (var row in recnums_dt.Rows.ToIEnumerable())
                {
                    con.ExecuteNonQuery("insert into {0} (recnum, istimmat) values ({1}, 0)", EmptyTableName, row["recnum"]);
                }

                // TODO: load the SelectItems array
                EditItems = con.GetDataTable("Edit Items",
                        "select {0}.*, jobtyp.typnme from {0} join jobtyp on jobtyp.recnum = {0}.recnum", EmptyTableName)
                    .ToList<_EditRow>()
                    .ToArray();

                this.grdItems.DataSource = EditItems;
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
                        con.ExecuteNonQuery("update {0} set istimmat = {1} where recnum = {2}", EmptyTableName, _item.istimmat, _item.recnum);
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
