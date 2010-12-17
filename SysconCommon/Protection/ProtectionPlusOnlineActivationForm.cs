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
    public partial class ProtectionPlusOnlineActivationForm : Form
    {
        private readonly int product_id;
        private readonly string product_version;

        private bool _ActivationSuccessful = false;
        public bool ActivationSuccessful
        {
            get
            {
                return _ActivationSuccessful;
            }
        }

        public ProtectionPlusOnlineActivationForm(int product_id, string product_version)
        {
            this.product_id = product_id;
            this.product_version = product_version;

            InitializeComponent();
        }

        private void ProtectionPlusOnlineActivationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                var license = Protection.ProtectionInfo.GetLicense(product_id, product_version);

                if (!(license is TrialLicense))
                    throw new NotImplementedException();

                var l = license as TrialLicense;
                var activated = l.ActivateOnline(int.Parse(this.txtLicenseId.Text), this.txtPassword.Text);

                if (activated)
                {
                    MessageBox.Show("Activation Succeessful.  Your software is now fully authorized.");
                    _ActivationSuccessful = true;
                }
                else
                {
                    MessageBox.Show("Activation failed: " + l.LastError);
                }
            }
            catch
            {
                MessageBox.Show("Activation failed");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
