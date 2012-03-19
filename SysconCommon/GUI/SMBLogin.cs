using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Common.Environment;
using SysconCommon.Common;
using SysconCommon;

namespace SysconCommon.GUI
{
    public partial class SMBLogin : Form
    {
        COMMethods methods;

        public string LoggedInUser = null;

        public SMBLogin()
            : this(null)
        {
        }

        public SMBLogin(COMMethods _methods)
        {
            methods = _methods == null ? new COMMethods() : _methods;
            InitializeComponent();
        }

        private void SMBLogin_Load(object sender, EventArgs e)
        {

            // show the SMB Dir
            txtSMBDir.Text = methods.smartGetSMBDir();

            // load the last login
            txtUsername.Text = Env.GetConfigVar("last_login_username", "Supervisor", true);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim().ToUpper();
            var password = txtPassword.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Please enter a username");
                return;
            }

            var hashed_password = methods.smartEncrypt(password);

            using (var con = Connections.GetOLEDBConnection())
            {
                var login_result = con.GetScalar<int>("select count(*) from usrlst where upper(usrnme) == '{0}' and usrpsw == '{1}'", username, hashed_password);
                if (login_result != 0)
                {
                    Env.SetConfigVar("last_login_username", username);
                    LoggedInUser = username;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void btnChangeSMBDir_Click(object sender, EventArgs e)
        {
            txtSMBDir.Text = methods.smartSelectSMBDirByGUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoggedInUser = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 2.1.1 (law) - Don't change the mbdir if the user cancels out of the program
            // This was set as a legacy/backward compatible for earlier versions of applications
            // methods.SetSMBDir(null);
            this.Close();
        }
    }
}
