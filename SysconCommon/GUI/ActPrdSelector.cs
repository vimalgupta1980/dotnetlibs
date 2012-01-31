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
    public partial class ActPrdSelector : SearchableComboBox
    {
        public ActPrdSelector()
        {
            InitializeComponent();

            for(var i = 0; i <= 12; i++)
            {
                this.Items.Add(i);
            }

            var month = DateTime.Today.Month;
            this.SelectedIndex = month;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public int Period
        {
            get
            {
                return int.Parse(this.SelectedItem.ToString());
            }
        }
    }
}
