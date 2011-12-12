namespace SysconCommon.GUI
{
    partial class Edit_Cost_Codes
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
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.recnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdenme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unbillable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grdItems
            // 
            this.grdItems.AllowUserToAddRows = false;
            this.grdItems.AllowUserToDeleteRows = false;
            this.grdItems.AllowUserToOrderColumns = true;
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recnum,
            this.cdenme,
            this.unbillable});
            this.grdItems.Location = new System.Drawing.Point(12, 12);
            this.grdItems.Name = "grdItems";
            this.grdItems.Size = new System.Drawing.Size(483, 179);
            this.grdItems.TabIndex = 0;
            // 
            // recnum
            // 
            this.recnum.DataPropertyName = "recnum";
            this.recnum.HeaderText = "Cost Code";
            this.recnum.Name = "recnum";
            this.recnum.ReadOnly = true;
            // 
            // cdenme
            // 
            this.cdenme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdenme.DataPropertyName = "cdenme";
            this.cdenme.HeaderText = "Name";
            this.cdenme.Name = "cdenme";
            this.cdenme.ReadOnly = true;
            // 
            // unbillable
            // 
            this.unbillable.DataPropertyName = "unbillable";
            this.unbillable.FalseValue = "0";
            this.unbillable.HeaderText = "Unbillable";
            this.unbillable.IndeterminateValue = "";
            this.unbillable.Name = "unbillable";
            this.unbillable.TrueValue = "1";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(330, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(420, 204);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Edit_Cost_Codes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 239);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdItems);
            this.Name = "Edit_Cost_Codes";
            this.Text = "Edit Cost Codes";
            this.Load += new System.EventHandler(this._Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn recnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdenme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn unbillable;
    }
}