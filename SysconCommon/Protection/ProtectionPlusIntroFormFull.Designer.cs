namespace SysconCommon.Protection
{
    partial class ProtectionPlusIntroFormFull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtectionPlusIntroFormFull));
            this.lblMessage = new System.Windows.Forms.Label();
            this.radioActivateNow = new System.Windows.Forms.RadioButton();
            this.radioContinueWithTrial = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(22, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 0;
            // 
            // radioActivateNow
            // 
            this.radioActivateNow.AutoSize = true;
            this.radioActivateNow.Location = new System.Drawing.Point(25, 36);
            this.radioActivateNow.Name = "radioActivateNow";
            this.radioActivateNow.Size = new System.Drawing.Size(89, 17);
            this.radioActivateNow.TabIndex = 1;
            this.radioActivateNow.TabStop = true;
            this.radioActivateNow.Text = "Activate Now";
            this.radioActivateNow.UseVisualStyleBackColor = true;
            // 
            // radioContinueWithTrial
            // 
            this.radioContinueWithTrial.AutoSize = true;
            this.radioContinueWithTrial.Location = new System.Drawing.Point(25, 59);
            this.radioContinueWithTrial.Name = "radioContinueWithTrial";
            this.radioContinueWithTrial.Size = new System.Drawing.Size(158, 17);
            this.radioContinueWithTrial.TabIndex = 2;
            this.radioContinueWithTrial.TabStop = true;
            this.radioContinueWithTrial.Text = "Continue Using Trial Version";
            this.radioContinueWithTrial.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(24, 92);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(107, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProtectionPlusIntroFormFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 127);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioContinueWithTrial);
            this.Controls.Add(this.radioActivateNow);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProtectionPlusIntroFormFull";
            this.Text = "Activation";
            this.Load += new System.EventHandler(this.ProtectionPlusIntroFormFull_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton radioActivateNow;
        private System.Windows.Forms.RadioButton radioContinueWithTrial;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}