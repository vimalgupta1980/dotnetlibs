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
    public partial class WebLink : Label
    {
        public WebLink()
        {
            InitializeComponent();
            // this.ForeColor = Color.Blue;
        }

        protected override void OnClick(EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + this.Text);
            base.OnClick(e);
        }
    }
}
