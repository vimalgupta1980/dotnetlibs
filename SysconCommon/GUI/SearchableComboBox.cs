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
    public partial class SearchableComboBox : ComboBox
    {
        public SearchableComboBox()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(SearchableComboBox_KeyDown);
            this.LostFocus += new EventHandler(SearchableComboBox_LostFocus);
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
    }
}
