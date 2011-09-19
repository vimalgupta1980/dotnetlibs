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
    public partial class CopyableMsgBox : Form
    {
        public static void Show(string msg)
        {
            var dlg = new CopyableMsgBox(msg);
            dlg.ShowDialog();
        }

        private string _msg = null;

        private CopyableMsgBox(string msg)
        {
            InitializeComponent();
            _msg = msg;
        }

        private void CopyableMsgBox_Load(object sender, EventArgs e)
        {
            this.txtMessage.Text = _msg;
            this.txtMessage.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
