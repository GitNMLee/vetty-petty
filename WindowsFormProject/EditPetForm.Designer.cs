namespace WindowsFormProject
{
    partial class EditPetForm
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
            this.uxEPFirstNameLabel = new System.Windows.Forms.Label();
            this.uxEPFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxEPLastNameLabel = new System.Windows.Forms.Label();
            this.uxEPLastNameTB = new System.Windows.Forms.TextBox();
            this.uxEPPetSpeciesLabel = new System.Windows.Forms.Label();
            this.uxEPPetBreedLabel = new System.Windows.Forms.Label();
            this.uxEPPetBreedCB = new System.Windows.Forms.ComboBox();
            this.uxEPPetDescLabel = new System.Windows.Forms.Label();
            this.uxEPPetDescTB = new System.Windows.Forms.TextBox();
            this.uxEditPetControls = new System.Windows.Forms.GroupBox();
            this.uxEPSubmitButton = new System.Windows.Forms.Button();
            this.uxEPKillPetButton = new System.Windows.Forms.Button();
            this.uxEPPetSpeciesTB = new System.Windows.Forms.TextBox();
            this.uxEditPetControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxEPFirstNameLabel
            // 
            this.uxEPFirstNameLabel.AutoSize = true;
            this.uxEPFirstNameLabel.Location = new System.Drawing.Point(7, 26);
            this.uxEPFirstNameLabel.Name = "uxEPFirstNameLabel";
            this.uxEPFirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxEPFirstNameLabel.TabIndex = 0;
            this.uxEPFirstNameLabel.Text = "First Name";
            // 
            // uxEPFirstNameTB
            // 
            this.uxEPFirstNameTB.Location = new System.Drawing.Point(99, 20);
            this.uxEPFirstNameTB.Name = "uxEPFirstNameTB";
            this.uxEPFirstNameTB.Size = new System.Drawing.Size(178, 26);
            this.uxEPFirstNameTB.TabIndex = 1;
            // 
            // uxEPLastNameLabel
            // 
            this.uxEPLastNameLabel.AutoSize = true;
            this.uxEPLastNameLabel.Location = new System.Drawing.Point(7, 58);
            this.uxEPLastNameLabel.Name = "uxEPLastNameLabel";
            this.uxEPLastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxEPLastNameLabel.TabIndex = 2;
            this.uxEPLastNameLabel.Text = "Last Name";
            // 
            // uxEPLastNameTB
            // 
            this.uxEPLastNameTB.Location = new System.Drawing.Point(99, 52);
            this.uxEPLastNameTB.Name = "uxEPLastNameTB";
            this.uxEPLastNameTB.Size = new System.Drawing.Size(178, 26);
            this.uxEPLastNameTB.TabIndex = 3;
            // 
            // uxEPPetSpeciesLabel
            // 
            this.uxEPPetSpeciesLabel.AutoSize = true;
            this.uxEPPetSpeciesLabel.Location = new System.Drawing.Point(6, 91);
            this.uxEPPetSpeciesLabel.Name = "uxEPPetSpeciesLabel";
            this.uxEPPetSpeciesLabel.Size = new System.Drawing.Size(94, 20);
            this.uxEPPetSpeciesLabel.TabIndex = 17;
            this.uxEPPetSpeciesLabel.Text = "Pet Species";
            // 
            // uxEPPetBreedLabel
            // 
            this.uxEPPetBreedLabel.AutoSize = true;
            this.uxEPPetBreedLabel.Location = new System.Drawing.Point(6, 125);
            this.uxEPPetBreedLabel.Name = "uxEPPetBreedLabel";
            this.uxEPPetBreedLabel.Size = new System.Drawing.Size(80, 20);
            this.uxEPPetBreedLabel.TabIndex = 19;
            this.uxEPPetBreedLabel.Text = "Pet Breed";
            // 
            // uxEPPetBreedCB
            // 
            this.uxEPPetBreedCB.FormattingEnabled = true;
            this.uxEPPetBreedCB.Location = new System.Drawing.Point(104, 122);
            this.uxEPPetBreedCB.Name = "uxEPPetBreedCB";
            this.uxEPPetBreedCB.Size = new System.Drawing.Size(121, 28);
            this.uxEPPetBreedCB.TabIndex = 20;
            // 
            // uxEPPetDescLabel
            // 
            this.uxEPPetDescLabel.AutoSize = true;
            this.uxEPPetDescLabel.Location = new System.Drawing.Point(6, 159);
            this.uxEPPetDescLabel.Name = "uxEPPetDescLabel";
            this.uxEPPetDescLabel.Size = new System.Drawing.Size(117, 20);
            this.uxEPPetDescLabel.TabIndex = 21;
            this.uxEPPetDescLabel.Text = "Pet Description";
            // 
            // uxEPPetDescTB
            // 
            this.uxEPPetDescTB.Location = new System.Drawing.Point(10, 182);
            this.uxEPPetDescTB.Multiline = true;
            this.uxEPPetDescTB.Name = "uxEPPetDescTB";
            this.uxEPPetDescTB.Size = new System.Drawing.Size(284, 89);
            this.uxEPPetDescTB.TabIndex = 22;
            // 
            // uxEditPetControls
            // 
            this.uxEditPetControls.AutoSize = true;
            this.uxEditPetControls.Controls.Add(this.uxEPPetSpeciesTB);
            this.uxEditPetControls.Controls.Add(this.uxEPSubmitButton);
            this.uxEditPetControls.Controls.Add(this.uxEPKillPetButton);
            this.uxEditPetControls.Controls.Add(this.uxEPPetDescTB);
            this.uxEditPetControls.Controls.Add(this.uxEPPetDescLabel);
            this.uxEditPetControls.Controls.Add(this.uxEPPetBreedCB);
            this.uxEditPetControls.Controls.Add(this.uxEPPetBreedLabel);
            this.uxEditPetControls.Controls.Add(this.uxEPPetSpeciesLabel);
            this.uxEditPetControls.Controls.Add(this.uxEPLastNameTB);
            this.uxEditPetControls.Controls.Add(this.uxEPLastNameLabel);
            this.uxEditPetControls.Controls.Add(this.uxEPFirstNameTB);
            this.uxEditPetControls.Controls.Add(this.uxEPFirstNameLabel);
            this.uxEditPetControls.Location = new System.Drawing.Point(13, 13);
            this.uxEditPetControls.Name = "uxEditPetControls";
            this.uxEditPetControls.Size = new System.Drawing.Size(312, 416);
            this.uxEditPetControls.TabIndex = 0;
            this.uxEditPetControls.TabStop = false;
            this.uxEditPetControls.Text = "Edit Pet";
            // 
            // uxEPSubmitButton
            // 
            this.uxEPSubmitButton.Location = new System.Drawing.Point(28, 318);
            this.uxEPSubmitButton.Name = "uxEPSubmitButton";
            this.uxEPSubmitButton.Size = new System.Drawing.Size(131, 32);
            this.uxEPSubmitButton.TabIndex = 24;
            this.uxEPSubmitButton.Text = "Submit";
            this.uxEPSubmitButton.UseVisualStyleBackColor = true;
            this.uxEPSubmitButton.Click += new System.EventHandler(this.uxEPSubmitButton_Click);
            // 
            // uxEPKillPetButton
            // 
            this.uxEPKillPetButton.Image = global::WindowsFormProject.Properties.Resources.ObiButtonImage1;
            this.uxEPKillPetButton.Location = new System.Drawing.Point(184, 277);
            this.uxEPKillPetButton.Name = "uxEPKillPetButton";
            this.uxEPKillPetButton.Size = new System.Drawing.Size(122, 114);
            this.uxEPKillPetButton.TabIndex = 23;
            this.uxEPKillPetButton.UseVisualStyleBackColor = true;
            this.uxEPKillPetButton.Click += new System.EventHandler(this.uxEPKillPetButton_Click);
            // 
            // uxEPPetSpeciesTB
            // 
            this.uxEPPetSpeciesTB.Location = new System.Drawing.Point(107, 91);
            this.uxEPPetSpeciesTB.Name = "uxEPPetSpeciesTB";
            this.uxEPPetSpeciesTB.ReadOnly = true;
            this.uxEPPetSpeciesTB.Size = new System.Drawing.Size(118, 26);
            this.uxEPPetSpeciesTB.TabIndex = 25;
            // 
            // EditPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 404);
            this.Controls.Add(this.uxEditPetControls);
            this.Name = "EditPetForm";
            this.Text = "EditPetForm";
            this.uxEditPetControls.ResumeLayout(false);
            this.uxEditPetControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxEPFirstNameLabel;
        private System.Windows.Forms.TextBox uxEPFirstNameTB;
        private System.Windows.Forms.Label uxEPLastNameLabel;
        private System.Windows.Forms.TextBox uxEPLastNameTB;
        private System.Windows.Forms.Label uxEPPetSpeciesLabel;
        private System.Windows.Forms.Label uxEPPetBreedLabel;
        private System.Windows.Forms.ComboBox uxEPPetBreedCB;
        private System.Windows.Forms.Label uxEPPetDescLabel;
        private System.Windows.Forms.TextBox uxEPPetDescTB;
        private System.Windows.Forms.Button uxEPKillPetButton;
        private System.Windows.Forms.GroupBox uxEditPetControls;
        private System.Windows.Forms.Button uxEPSubmitButton;
        private System.Windows.Forms.TextBox uxEPPetSpeciesTB;
    }
}