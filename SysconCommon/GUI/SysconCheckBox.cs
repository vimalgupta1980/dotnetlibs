using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Common.Environment;

namespace SysconCommon.GUI
{
    public partial class SysconCheckBox : CheckBox
    {
        private string _config_setting = null;
        [Browsable(true)]
        [Category("Configuration")]
        public string ConfigSettingName
        {
            get
            {
                return _config_setting;
            }
            set
            {
                _config_setting = value;

                if (value != null)
                {
                    Checked = Env.GetConfigVar(value, Checked, true);
                }
            }
        }

        public SysconCheckBox()
        {
            InitializeComponent();

            if (ConfigSettingName != null)
            {
                Checked = Env.GetConfigVar(ConfigSettingName, Checked, true);
            }

            this.CheckedChanged += new EventHandler(SysconCheckBox_CheckedChanged);
        }

        void SysconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ConfigSettingName != null)
            {
                Env.SetConfigVar(ConfigSettingName, Checked);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
