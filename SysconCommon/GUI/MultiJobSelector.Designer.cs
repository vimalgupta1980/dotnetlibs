namespace SysconCommon.GUI
{
    partial class MultiJobSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiJobSelector));
            this.grdJobs = new System.Windows.Forms.DataGridView();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.JobNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkStatus1 = new System.Windows.Forms.CheckBox();
            this.chkStatus6 = new System.Windows.Forms.CheckBox();
            this.chkStatus5 = new System.Windows.Forms.CheckBox();
            this.chkStatus4 = new System.Windows.Forms.CheckBox();
            this.chkStatus3 = new System.Windows.Forms.CheckBox();
            this.chkStatus2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSupervisors = new SysconCommon.GUI.SearchableComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // grdJobs
            // 
            this.grdJobs.AllowUserToAddRows = false;
            this.grdJobs.AllowUserToDeleteRows = false;
            this.grdJobs.AllowUserToOrderColumns = true;
            this.grdJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSelected,
            this.JobNumber,
            this.JobName,
            this.JobType,
            this.JobStatus,
            this.Supervisor,
            this.SiteContact,
            this.ClientNumber,
            this.ClientName});
            this.grdJobs.Location = new System.Drawing.Point(0, 110);
            this.grdJobs.Name = "grdJobs";
            this.grdJobs.Size = new System.Drawing.Size(960, 387);
            this.grdJobs.TabIndex = 0;
            // 
            // IsSelected
            // 
            this.IsSelected.DataPropertyName = "IsSelected";
            this.IsSelected.HeaderText = "Select";
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.Width = 50;
            // 
            // JobNumber
            // 
            this.JobNumber.DataPropertyName = "JobNumber";
            this.JobNumber.HeaderText = "Job Number";
            this.JobNumber.Name = "JobNumber";
            this.JobNumber.ReadOnly = true;
            // 
            // JobName
            // 
            this.JobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobName.DataPropertyName = "JobName";
            this.JobName.HeaderText = "Job Name";
            this.JobName.Name = "JobName";
            this.JobName.ReadOnly = true;
            // 
            // JobType
            // 
            this.JobType.DataPropertyName = "JobType";
            this.JobType.HeaderText = "Job Type";
            this.JobType.Name = "JobType";
            this.JobType.ReadOnly = true;
            // 
            // JobStatus
            // 
            this.JobStatus.DataPropertyName = "JobStatus";
            this.JobStatus.HeaderText = "JobStatus";
            this.JobStatus.Name = "JobStatus";
            this.JobStatus.ReadOnly = true;
            // 
            // Supervisor
            // 
            this.Supervisor.DataPropertyName = "Supervisor";
            this.Supervisor.HeaderText = "Supervisor";
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.ReadOnly = true;
            // 
            // SiteContact
            // 
            this.SiteContact.DataPropertyName = "SiteContact";
            this.SiteContact.HeaderText = "Site Contact";
            this.SiteContact.Name = "SiteContact";
            this.SiteContact.ReadOnly = true;
            // 
            // ClientNumber
            // 
            this.ClientNumber.DataPropertyName = "ClientNumber";
            this.ClientNumber.HeaderText = "Client Number";
            this.ClientNumber.Name = "ClientNumber";
            this.ClientNumber.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(12, 87);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 1;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(873, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(13, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(841, 20);
            this.txtFilter.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(866, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(779, 506);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Job Status";
            // 
            // chkStatus1
            // 
            this.chkStatus1.AutoSize = true;
            this.chkStatus1.Location = new System.Drawing.Point(87, 52);
            this.chkStatus1.Name = "chkStatus1";
            this.chkStatus1.Size = new System.Drawing.Size(56, 17);
            this.chkStatus1.TabIndex = 7;
            this.chkStatus1.Text = "1 - Bid";
            this.chkStatus1.UseVisualStyleBackColor = true;
            // 
            // chkStatus6
            // 
            this.chkStatus6.AutoSize = true;
            this.chkStatus6.Location = new System.Drawing.Point(493, 52);
            this.chkStatus6.Name = "chkStatus6";
            this.chkStatus6.Size = new System.Drawing.Size(73, 17);
            this.chkStatus6.TabIndex = 8;
            this.chkStatus6.Text = "6 - Closed";
            this.chkStatus6.UseVisualStyleBackColor = true;
            // 
            // chkStatus5
            // 
            this.chkStatus5.AutoSize = true;
            this.chkStatus5.Location = new System.Drawing.Point(407, 51);
            this.chkStatus5.Name = "chkStatus5";
            this.chkStatus5.Size = new System.Drawing.Size(85, 17);
            this.chkStatus5.TabIndex = 9;
            this.chkStatus5.Text = "5 - Complete";
            this.chkStatus5.UseVisualStyleBackColor = true;
            // 
            // chkStatus4
            // 
            this.chkStatus4.AutoSize = true;
            this.chkStatus4.Location = new System.Drawing.Point(321, 51);
            this.chkStatus4.Name = "chkStatus4";
            this.chkStatus4.Size = new System.Drawing.Size(75, 17);
            this.chkStatus4.TabIndex = 10;
            this.chkStatus4.Text = "4 - Current";
            this.chkStatus4.UseVisualStyleBackColor = true;
            // 
            // chkStatus3
            // 
            this.chkStatus3.AutoSize = true;
            this.chkStatus3.Location = new System.Drawing.Point(235, 51);
            this.chkStatus3.Name = "chkStatus3";
            this.chkStatus3.Size = new System.Drawing.Size(81, 17);
            this.chkStatus3.TabIndex = 11;
            this.chkStatus3.Text = "3 - Contract";
            this.chkStatus3.UseVisualStyleBackColor = true;
            // 
            // chkStatus2
            // 
            this.chkStatus2.AutoSize = true;
            this.chkStatus2.Location = new System.Drawing.Point(149, 52);
            this.chkStatus2.Name = "chkStatus2";
            this.chkStatus2.Size = new System.Drawing.Size(81, 17);
            this.chkStatus2.TabIndex = 12;
            this.chkStatus2.Text = "2 - Refused";
            this.chkStatus2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Supervisor";
            // 
            // cmbSupervisors
            // 
            this.cmbSupervisors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSupervisors.FormattingEnabled = true;
            this.cmbSupervisors.Location = new System.Drawing.Point(679, 44);
            this.cmbSupervisors.Name = "cmbSupervisors";
            this.cmbSupervisors.Size = new System.Drawing.Size(262, 21);
            this.cmbSupervisors.TabIndex = 14;
            this.cmbSupervisors.SelectedIndexChanged += new System.EventHandler(this.cmbSupervisors_SelectedIndexChanged);
            // 
            // MultiJobSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(960, 535);
            this.Controls.Add(this.cmbSupervisors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkStatus2);
            this.Controls.Add(this.chkStatus3);
            this.Controls.Add(this.chkStatus4);
            this.Controls.Add(this.chkStatus5);
            this.Controls.Add(this.chkStatus6);
            this.Controls.Add(this.chkStatus1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.grdJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiJobSelector";
            this.Text = "Select Jobs";
            this.Load += new System.EventHandler(this.MultiJobSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdJobs;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStatus1;
        private System.Windows.Forms.CheckBox chkStatus6;
        private System.Windows.Forms.CheckBox chkStatus5;
        private System.Windows.Forms.CheckBox chkStatus4;
        private System.Windows.Forms.CheckBox chkStatus3;
        private System.Windows.Forms.CheckBox chkStatus2;
        private System.Windows.Forms.Label label2;
        private SearchableComboBox cmbSupervisors;
    }
}