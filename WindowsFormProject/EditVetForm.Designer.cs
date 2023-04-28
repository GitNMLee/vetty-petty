namespace WindowsFormProject
{
    partial class EditVetForm
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
            this.uxEditVetControls = new System.Windows.Forms.GroupBox();
            this.uxEVSubmitButton = new System.Windows.Forms.Button();
            this.uxEVHireDateTB = new System.Windows.Forms.TextBox();
            this.uxEVHireDateLabel = new System.Windows.Forms.Label();
            this.uxEVFireButton = new System.Windows.Forms.Button();
            this.uxEVLastNameTB = new System.Windows.Forms.TextBox();
            this.uxEVLastNameLabel = new System.Windows.Forms.Label();
            this.uxEVFirstNameLabel = new System.Windows.Forms.Label();
            this.uxEVFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxEditVetControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxEditVetControls
            // 
            this.uxEditVetControls.AutoSize = true;
            this.uxEditVetControls.Controls.Add(this.uxEVSubmitButton);
            this.uxEditVetControls.Controls.Add(this.uxEVHireDateTB);
            this.uxEditVetControls.Controls.Add(this.uxEVHireDateLabel);
            this.uxEditVetControls.Controls.Add(this.uxEVFireButton);
            this.uxEditVetControls.Controls.Add(this.uxEVLastNameTB);
            this.uxEditVetControls.Controls.Add(this.uxEVLastNameLabel);
            this.uxEditVetControls.Controls.Add(this.uxEVFirstNameLabel);
            this.uxEditVetControls.Controls.Add(this.uxEVFirstNameTB);
            this.uxEditVetControls.Location = new System.Drawing.Point(11, 13);
            this.uxEditVetControls.Name = "uxEditVetControls";
            this.uxEditVetControls.Size = new System.Drawing.Size(312, 202);
            this.uxEditVetControls.TabIndex = 24;
            this.uxEditVetControls.TabStop = false;
            this.uxEditVetControls.Text = "Edit Vet";
            // 
            // uxEVSubmitButton
            // 
            this.uxEVSubmitButton.Location = new System.Drawing.Point(27, 135);
            this.uxEVSubmitButton.Name = "uxEVSubmitButton";
            this.uxEVSubmitButton.Size = new System.Drawing.Size(115, 42);
            this.uxEVSubmitButton.TabIndex = 20;
            this.uxEVSubmitButton.Text = "Submit";
            this.uxEVSubmitButton.UseVisualStyleBackColor = true;
            this.uxEVSubmitButton.Click += new System.EventHandler(this.uxEVSubmitButton_Click);
            // 
            // uxEVHireDateTB
            // 
            this.uxEVHireDateTB.Location = new System.Drawing.Point(91, 85);
            this.uxEVHireDateTB.Name = "uxEVHireDateTB";
            this.uxEVHireDateTB.ReadOnly = true;
            this.uxEVHireDateTB.Size = new System.Drawing.Size(188, 26);
            this.uxEVHireDateTB.TabIndex = 18;
            // 
            // uxEVHireDateLabel
            // 
            this.uxEVHireDateLabel.AutoSize = true;
            this.uxEVHireDateLabel.Location = new System.Drawing.Point(6, 88);
            this.uxEVHireDateLabel.Name = "uxEVHireDateLabel";
            this.uxEVHireDateLabel.Size = new System.Drawing.Size(77, 20);
            this.uxEVHireDateLabel.TabIndex = 17;
            this.uxEVHireDateLabel.Text = "Hire Date";
            // 
            // uxEVFireButton
            // 
            this.uxEVFireButton.Location = new System.Drawing.Point(165, 135);
            this.uxEVFireButton.Name = "uxEVFireButton";
            this.uxEVFireButton.Size = new System.Drawing.Size(114, 42);
            this.uxEVFireButton.TabIndex = 16;
            this.uxEVFireButton.Text = "Fire";
            this.uxEVFireButton.UseVisualStyleBackColor = true;
            this.uxEVFireButton.Click += new System.EventHandler(this.uxEVFireButton_Click);
            // 
            // uxEVLastNameTB
            // 
            this.uxEVLastNameTB.Location = new System.Drawing.Point(91, 54);
            this.uxEVLastNameTB.Name = "uxEVLastNameTB";
            this.uxEVLastNameTB.Size = new System.Drawing.Size(188, 26);
            this.uxEVLastNameTB.TabIndex = 15;
            // 
            // uxEVLastNameLabel
            // 
            this.uxEVLastNameLabel.AutoSize = true;
            this.uxEVLastNameLabel.Location = new System.Drawing.Point(6, 57);
            this.uxEVLastNameLabel.Name = "uxEVLastNameLabel";
            this.uxEVLastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxEVLastNameLabel.TabIndex = 14;
            this.uxEVLastNameLabel.Text = "Last Name";
            // 
            // uxEVFirstNameLabel
            // 
            this.uxEVFirstNameLabel.AutoSize = true;
            this.uxEVFirstNameLabel.Location = new System.Drawing.Point(6, 26);
            this.uxEVFirstNameLabel.Name = "uxEVFirstNameLabel";
            this.uxEVFirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxEVFirstNameLabel.TabIndex = 13;
            this.uxEVFirstNameLabel.Text = "First Name";
            // 
            // uxEVFirstNameTB
            // 
            this.uxEVFirstNameTB.Location = new System.Drawing.Point(91, 22);
            this.uxEVFirstNameTB.Name = "uxEVFirstNameTB";
            this.uxEVFirstNameTB.Size = new System.Drawing.Size(188, 26);
            this.uxEVFirstNameTB.TabIndex = 12;
            // 
            // EditVetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 223);
            this.Controls.Add(this.uxEditVetControls);
            this.Name = "EditVetForm";
            this.Text = "EditVetForm";
            this.uxEditVetControls.ResumeLayout(false);
            this.uxEditVetControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox uxEditVetControls;
        private System.Windows.Forms.Button uxEVFireButton;
        private System.Windows.Forms.TextBox uxEVLastNameTB;
        private System.Windows.Forms.Label uxEVLastNameLabel;
        private System.Windows.Forms.Label uxEVFirstNameLabel;
        private System.Windows.Forms.TextBox uxEVFirstNameTB;
        private System.Windows.Forms.TextBox uxEVHireDateTB;
        private System.Windows.Forms.Label uxEVHireDateLabel;
        private System.Windows.Forms.Button uxEVSubmitButton;
    }
}