using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Protection;
using SysconCommon.Common;
using SysconCommon;
using SysconCommon.Common.Environment;

namespace SysconCommon.Protection
{
    public partial class ProtectionPlusIntroFormFull : Form
    {
        public readonly TrialLicense TrialLicense;
        public bool LicenseOK = false;

        public ProtectionPlusIntroFormFull(TrialLicense trialLicense)
        {
            InitializeComponent();
            TrialLicense = trialLicense;
        }

        private void ProtectionPlusIntroFormFull_Load(object sender, EventArgs e)
        {
            if (!TrialLicense.IsValid())
            {
                this.radioContinueWithTrial.Enabled = false;
                this.lblMessage.Text = "Trial is expired.";
                this.radioActivateNow.Checked = true;
            }
            else
            {
                this.lblMessage.Text = "Trial has " + TrialLicense.DaysLeft.ToString() + " days left.";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioActivateNow.Checked)
            {
                var activationDialog = new ProtectionPlusOnlineActivationForm(TrialLicense.ProductID, TrialLicense.ProductVersion);
                activationDialog.ShowDialog();
                if (!activationDialog.ActivationSuccessful)
                {
                    return;
                }
                LicenseOK = true;
            }
            else if (radioContinueWithTrial.Checked)
            {
                LicenseOK = true;
            }
            else
            {
                throw new NotImplementedException();
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
