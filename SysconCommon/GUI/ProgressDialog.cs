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
    public partial class ProgressDialog : Form
    {
        public ProgressDialog(int ticks, string title)
        {
            InitializeComponent();
            progressBar1.Maximum = ticks;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            this.Text = title;
        }

        public ProgressDialog(int ticks)
            : this(ticks, "Progress")
        {
        }

        private void ProgressDialog_Load(object sender, EventArgs e)
        {

        }

        public int Tick()
        {
            progressBar1.Value += 1;
            progressBar1.Refresh();
            return progressBar1.Value;
        }
    }
}
