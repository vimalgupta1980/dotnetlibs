﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysconCommon.GUI
{
    public partial class ProgressDialog : Form
    {
        private readonly int total_ticks;
        private readonly DateTime start_time;

        public ProgressDialog(int ticks, string title)
        {
            InitializeComponent();
            progressBar1.Maximum = ticks;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            this.Text = title;
            total_ticks = ticks;
            start_time = DateTime.Now;
        }

        public ProgressDialog(int ticks)
            : this(ticks, "Progress")
        {
        }

        private void ProgressDialog_Load(object sender, EventArgs e)
        {

        }

        public int Tick()
        {
            var percent_done = Convert.ToDecimal(progressBar1.Value) / Convert.ToDecimal(total_ticks);
            var time = percent_done == 0.0m ? int.MaxValue : Convert.ToInt32(Math.Round(Convert.ToDecimal((DateTime.Now - start_time).TotalSeconds) / percent_done, 0));
            time -= Convert.ToInt32(Math.Round((DateTime.Now - start_time).TotalSeconds, 0));

            var minutes = time / 60;
            var seconds = time % 60;
            progressBar1.Value += 1;

            this.label1.Text = string.Format("{0}% Done ETA: {1} Min and {2} Seconds", Convert.ToInt32(Math.Round(percent_done * 100m, 0)), minutes, seconds);
            this.Refresh();
            return progressBar1.Value;
        }
    }
}
