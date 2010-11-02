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
        public string ProductName = null;

        public ProtectionPlusOnlineActivationForm()
        {
            InitializeComponent();
        }

        private void ProtectionPlusOnlineActivationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductName == null)
                    throw new Exception("Product Name is not set in the activation dialog");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
