using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysconCommon.GUI
{
    public partial class FileSelector : UserControl
    {
        public FileSelector()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            this.txtFilename.Text = ofd.FileName;
        }
    }
}
