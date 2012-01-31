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
    public partial class SysconTextBox : TextBox
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
                if (value != null)
                {
                    try
                    {
                        Text = Env.GetConfigVar(value);
                    }
                    catch { }
                }

                _config_setting = value;
            }
        }

        [Browsable(true)]
        [Category("Configuration")]
        public string Default { get; set; }

        public SysconTextBox()
        {
            InitializeComponent();

            if (ConfigSettingName != null)
            {
                Text = Env.GetConfigVar(ConfigSettingName, Default == null ? "" : Default, true);
            }

            this.TextChanged += new EventHandler(SysconTextBox_TextChanged);
        }

        void SysconTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ConfigSettingName != null)
                Env.SetConfigVar(ConfigSettingName, this.Text);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
