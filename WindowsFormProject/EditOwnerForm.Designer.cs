namespace WindowsFormProject
{
    partial class EditOwnerForm
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
            this.uxEditOwnerControls = new System.Windows.Forms.GroupBox();
            this.uxEOEmailTB = new System.Windows.Forms.TextBox();
            this.uxEOEmailLabel = new System.Windows.Forms.Label();
            this.uxEOLastNameTB = new System.Windows.Forms.TextBox();
            this.uxEOLastNameLabel = new System.Windows.Forms.Label();
            this.uxEOFirstNameLabel = new System.Windows.Forms.Label();
            this.uxEOFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxEditOwnerControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxEditOwnerControls
            // 
            this.uxEditOwnerControls.AutoSize = true;
            this.uxEditOwnerControls.Controls.Add(this.uxEOEmailTB);
            this.uxEditOwnerControls.Controls.Add(this.uxEOEmailLabel);
            this.uxEditOwnerControls.Controls.Add(this.uxEOLastNameTB);
            this.uxEditOwnerControls.Controls.Add(this.uxEOLastNameLabel);
            this.uxEditOwnerControls.Controls.Add(this.uxEOFirstNameLabel);
            this.uxEditOwnerControls.Controls.Add(this.uxEOFirstNameTB);
            this.uxEditOwnerControls.Location = new System.Drawing.Point(9, 13);
            this.uxEditOwnerControls.Name = "uxEditOwnerControls";
            this.uxEditOwnerControls.Size = new System.Drawing.Size(312, 136);
            this.uxEditOwnerControls.TabIndex = 25;
            this.uxEditOwnerControls.TabStop = false;
            this.uxEditOwnerControls.Text = "Edit Owner";
            // 
            // uxEOEmailTB
            // 
            this.uxEOEmailTB.Location = new System.Drawing.Point(60, 85);
            this.uxEOEmailTB.Name = "uxEOEmailTB";
            this.uxEOEmailTB.Size = new System.Drawing.Size(219, 26);
            this.uxEOEmailTB.TabIndex = 18;
            // 
            // uxEOEmailLabel
            // 
            this.uxEOEmailLabel.AutoSize = true;
            this.uxEOEmailLabel.Location = new System.Drawing.Point(6, 88);
            this.uxEOEmailLabel.Name = "uxEOEmailLabel";
            this.uxEOEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.uxEOEmailLabel.TabIndex = 17;
            this.uxEOEmailLabel.Text = "Email";
            // 
            // uxEOLastNameTB
            // 
            this.uxEOLastNameTB.Location = new System.Drawing.Point(91, 54);
            this.uxEOLastNameTB.Name = "uxEOLastNameTB";
            this.uxEOLastNameTB.Size = new System.Drawing.Size(188, 26);
            this.uxEOLastNameTB.TabIndex = 15;
            // 
            // uxEOLastNameLabel
            // 
            this.uxEOLastNameLabel.AutoSize = true;
            this.uxEOLastNameLabel.Location = new System.Drawing.Point(6, 57);
            this.uxEOLastNameLabel.Name = "uxEOLastNameLabel";
            this.uxEOLastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxEOLastNameLabel.TabIndex = 14;
            this.uxEOLastNameLabel.Text = "Last Name";
            // 
            // uxEOFirstNameLabel
            // 
            this.uxEOFirstNameLabel.AutoSize = true;
            this.uxEOFirstNameLabel.Location = new System.Drawing.Point(6, 26);
            this.uxEOFirstNameLabel.Name = "uxEOFirstNameLabel";
            this.uxEOFirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxEOFirstNameLabel.TabIndex = 13;
            this.uxEOFirstNameLabel.Text = "First Name";
            // 
            // uxEOFirstNameTB
            // 
            this.uxEOFirstNameTB.Location = new System.Drawing.Point(91, 22);
            this.uxEOFirstNameTB.Name = "uxEOFirstNameTB";
            this.uxEOFirstNameTB.Size = new System.Drawing.Size(188, 26);
            this.uxEOFirstNameTB.TabIndex = 12;
            // 
            // EditOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 154);
            this.Controls.Add(this.uxEditOwnerControls);
            this.Name = "EditOwnerForm";
            this.Text = "EditOwnerForm";
            this.uxEditOwnerControls.ResumeLayout(false);
            this.uxEditOwnerControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox uxEditOwnerControls;
        private System.Windows.Forms.TextBox uxEOEmailTB;
        private System.Windows.Forms.Label uxEOEmailLabel;
        private System.Windows.Forms.TextBox uxEOLastNameTB;
        private System.Windows.Forms.Label uxEOLastNameLabel;
        private System.Windows.Forms.Label uxEOFirstNameLabel;
        private System.Windows.Forms.TextBox uxEOFirstNameTB;
    }
}