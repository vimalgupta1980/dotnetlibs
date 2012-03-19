using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Common.Environment;

namespace SysconCommon.GUI
{
    public partial class SearchableComboBox : ComboBox
    {
        private string _config_var = null;

        [Browsable(true)]
        [Category("Configuration")]
        public string ConfigVarName
        {
            get
            {
                return _config_var;
            }
            set
            {
                _config_var = value;
                if (value != null)
                {
                    this.SetByText(Env.GetConfigVar(value));
                }
            }
        }

        public SearchableComboBox()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(SearchableComboBox_KeyDown);
            this.LostFocus += new EventHandler(SearchableComboBox_LostFocus);
            this.SelectedIndexChanged += new EventHandler(SearchableComboBox_SelectedIndexChanged);
        }

        void SearchableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (ConfigVarName != null)
            {
                Env.SetConfigVar(ConfigVarName, this.SelectedItem.ToString());
            }
        }

        void SearchableComboBox_LostFocus(object sender, EventArgs e)
        {
            foreach (var i in this.Items)
            {
                var s = i.ToString();
                if (s.ToUpper().Contains(this.Text.Trim().ToUpper()))
                {
                    this.SelectedItem = i;
                    return;
                }
            }
        }

        void SearchableComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var i in this.Items)
                {
                    var s = i.ToString();
                    if (s.ToUpper().Contains(this.Text.Trim().ToUpper()))
                    {
                        this.SelectedItem = i;
                        return;
                    }
                }
            }
        }

        public void SetByText(string txt)
        {
            foreach (var i in this.Items)
            {
                if (i.ToString().ToUpper().Trim() == txt.ToUpper().Trim())
                {
                    this.SelectedItem = i;
                    return;
                }
            }
        }

        public void SetItems(params object[] items)
        {
            this.Items.Clear();
            this.Items.AddRange(items);

            if (ConfigVarName != null)
            {
                SetByText(Env.GetConfigVar(ConfigVarName));
            }
        }
    }
}
