using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysconCommon.Protection
{
    public partial class ProtectionPlusIntroForm : Form
    {
        private readonly TrialLicense _license;
        private readonly Func<bool> _onActivate;
        public bool ActivationSuccessful = false;

        public ProtectionPlusIntroForm(TrialLicense license)
        {
            InitializeComponent();
            _license = license;
        }

        private void ProtectionPlusIntroForm_Load(object sender, EventArgs e)
        {
            this.lblStatus.Text = "You have " + _license.DaysLeft + " days left to evaluate this product";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new ProtectionPlusOnlineActivationForm(_license.ProductID, _license.ProductVersion);
            dlg.ShowDialog();
            ActivationSuccessful = dlg.ActivationSuccessful;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // activate later
            // do nothing
            this.Close();
        }
    }
}
