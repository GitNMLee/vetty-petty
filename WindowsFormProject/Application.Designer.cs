namespace WindowsFormProject
{
    partial class Application
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
            this.uxConnectDB = new System.Windows.Forms.Button();
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxMenuAddPet = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuCreateApt = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuViewQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddPetControls = new System.Windows.Forms.GroupBox();
            this.uxPetBreedCB = new System.Windows.Forms.ComboBox();
            this.uxPetBreedLabel = new System.Windows.Forms.Label();
            this.uxPetSpeciesCB = new System.Windows.Forms.ComboBox();
            this.uxPetSpeciesLabel = new System.Windows.Forms.Label();
            this.uxPCFirstNameLabel = new System.Windows.Forms.Label();
            this.uxPCPetFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxQueryControls = new System.Windows.Forms.GroupBox();
            this.uxQuerySelectQueryCB = new System.Windows.Forms.ComboBox();
            this.uxQuerySelectQueryLabel = new System.Windows.Forms.Label();
            this.uxCreateAptControls = new System.Windows.Forms.GroupBox();
            this.uxAptAptTimeCB = new System.Windows.Forms.ComboBox();
            this.uxAptAptDateLabel = new System.Windows.Forms.Label();
            this.uxAptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxAptDateLabel = new System.Windows.Forms.Label();
            this.uxAptOwnerNameTB = new System.Windows.Forms.TextBox();
            this.uxAptVetCB = new System.Windows.Forms.ComboBox();
            this.uxAptVetLabel = new System.Windows.Forms.Label();
            this.uxAptOwnerNameLabel = new System.Windows.Forms.Label();
            this.uxAptPetNameLabel = new System.Windows.Forms.Label();
            this.uxAptPetNameTB = new System.Windows.Forms.TextBox();
            this.uxPCPetLastNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxPCOwnerLastNameLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerLastNameTB = new System.Windows.Forms.TextBox();
            this.uxPCOwnerFirstNameLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxPCOwnerEmailLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uxPCPetDescriptionLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.uxMenuStrip.SuspendLayout();
            this.uxAddPetControls.SuspendLayout();
            this.uxQueryControls.SuspendLayout();
            this.uxCreateAptControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxConnectDB
            // 
            this.uxConnectDB.Location = new System.Drawing.Point(981, 0);
            this.uxConnectDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxConnectDB.Name = "uxConnectDB";
            this.uxConnectDB.Size = new System.Drawing.Size(219, 35);
            this.uxConnectDB.TabIndex = 0;
            this.uxConnectDB.Text = "Connect to DB";
            this.uxConnectDB.UseVisualStyleBackColor = true;
            this.uxConnectDB.Click += new System.EventHandler(this.uxConnectDB_Click);
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuAddPet,
            this.uxMenuCreateApt,
            this.uxMenuViewQueries});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(1200, 33);
            this.uxMenuStrip.TabIndex = 1;
            this.uxMenuStrip.Text = "MenuStrip";
            // 
            // uxMenuAddPet
            // 
            this.uxMenuAddPet.Name = "uxMenuAddPet";
            this.uxMenuAddPet.Size = new System.Drawing.Size(192, 29);
            this.uxMenuAddPet.Text = "Add Pet to Database";
            this.uxMenuAddPet.Click += new System.EventHandler(this.uxMenuAddPet_Click);
            // 
            // uxMenuCreateApt
            // 
            this.uxMenuCreateApt.Name = "uxMenuCreateApt";
            this.uxMenuCreateApt.Size = new System.Drawing.Size(189, 29);
            this.uxMenuCreateApt.Text = "Create Appointment";
            this.uxMenuCreateApt.Click += new System.EventHandler(this.uxMenuCreateApt_Click);
            // 
            // uxMenuViewQueries
            // 
            this.uxMenuViewQueries.Name = "uxMenuViewQueries";
            this.uxMenuViewQueries.Size = new System.Drawing.Size(230, 29);
            this.uxMenuViewQueries.Text = "View Aggregated Queries";
            this.uxMenuViewQueries.Click += new System.EventHandler(this.uxMenuViewQueries_Click);
            // 
            // uxAddPetControls
            // 
            this.uxAddPetControls.Controls.Add(this.textBox3);
            this.uxAddPetControls.Controls.Add(this.uxPCPetDescriptionLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerEmailLabel);
            this.uxAddPetControls.Controls.Add(this.textBox2);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerLastNameLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerLastNameTB);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerFirstNameLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerFirstNameTB);
            this.uxAddPetControls.Controls.Add(this.uxPCPetLastNameLabel);
            this.uxAddPetControls.Controls.Add(this.textBox1);
            this.uxAddPetControls.Controls.Add(this.uxPetBreedCB);
            this.uxAddPetControls.Controls.Add(this.uxPetBreedLabel);
            this.uxAddPetControls.Controls.Add(this.uxPetSpeciesCB);
            this.uxAddPetControls.Controls.Add(this.uxPetSpeciesLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCFirstNameLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCPetFirstNameTB);
            this.uxAddPetControls.Location = new System.Drawing.Point(0, 36);
            this.uxAddPetControls.Name = "uxAddPetControls";
            this.uxAddPetControls.Size = new System.Drawing.Size(651, 404);
            this.uxAddPetControls.TabIndex = 2;
            this.uxAddPetControls.TabStop = false;
            this.uxAddPetControls.Text = "AddPet";
            this.uxAddPetControls.Visible = false;
            // 
            // uxPetBreedCB
            // 
            this.uxPetBreedCB.FormattingEnabled = true;
            this.uxPetBreedCB.Location = new System.Drawing.Point(125, 122);
            this.uxPetBreedCB.Name = "uxPetBreedCB";
            this.uxPetBreedCB.Size = new System.Drawing.Size(121, 28);
            this.uxPetBreedCB.TabIndex = 6;
            // 
            // uxPetBreedLabel
            // 
            this.uxPetBreedLabel.AutoSize = true;
            this.uxPetBreedLabel.Location = new System.Drawing.Point(25, 125);
            this.uxPetBreedLabel.Name = "uxPetBreedLabel";
            this.uxPetBreedLabel.Size = new System.Drawing.Size(80, 20);
            this.uxPetBreedLabel.TabIndex = 5;
            this.uxPetBreedLabel.Text = "Pet Breed";
            // 
            // uxPetSpeciesCB
            // 
            this.uxPetSpeciesCB.FormattingEnabled = true;
            this.uxPetSpeciesCB.Location = new System.Drawing.Point(125, 88);
            this.uxPetSpeciesCB.Name = "uxPetSpeciesCB";
            this.uxPetSpeciesCB.Size = new System.Drawing.Size(121, 28);
            this.uxPetSpeciesCB.TabIndex = 4;
            // 
            // uxPetSpeciesLabel
            // 
            this.uxPetSpeciesLabel.AutoSize = true;
            this.uxPetSpeciesLabel.Location = new System.Drawing.Point(25, 91);
            this.uxPetSpeciesLabel.Name = "uxPetSpeciesLabel";
            this.uxPetSpeciesLabel.Size = new System.Drawing.Size(94, 20);
            this.uxPetSpeciesLabel.TabIndex = 3;
            this.uxPetSpeciesLabel.Text = "Pet Species";
            // 
            // uxPCFirstNameLabel
            // 
            this.uxPCFirstNameLabel.AutoSize = true;
            this.uxPCFirstNameLabel.Location = new System.Drawing.Point(21, 29);
            this.uxPCFirstNameLabel.Name = "uxPCFirstNameLabel";
            this.uxPCFirstNameLabel.Size = new System.Drawing.Size(114, 20);
            this.uxPCFirstNameLabel.TabIndex = 1;
            this.uxPCFirstNameLabel.Text = "Pet First Name";
            // 
            // uxPCPetFirstNameTB
            // 
            this.uxPCPetFirstNameTB.Location = new System.Drawing.Point(141, 24);
            this.uxPCPetFirstNameTB.Name = "uxPCPetFirstNameTB";
            this.uxPCPetFirstNameTB.Size = new System.Drawing.Size(174, 26);
            this.uxPCPetFirstNameTB.TabIndex = 0;
            // 
            // uxQueryControls
            // 
            this.uxQueryControls.Controls.Add(this.uxQuerySelectQueryCB);
            this.uxQueryControls.Controls.Add(this.uxQuerySelectQueryLabel);
            this.uxQueryControls.Location = new System.Drawing.Point(4, 37);
            this.uxQueryControls.Name = "uxQueryControls";
            this.uxQueryControls.Size = new System.Drawing.Size(909, 404);
            this.uxQueryControls.TabIndex = 11;
            this.uxQueryControls.TabStop = false;
            this.uxQueryControls.Text = "View AggregatedQueries";
            this.uxQueryControls.Visible = false;
            // 
            // uxQuerySelectQueryCB
            // 
            this.uxQuerySelectQueryCB.FormattingEnabled = true;
            this.uxQuerySelectQueryCB.Location = new System.Drawing.Point(121, 29);
            this.uxQuerySelectQueryCB.Name = "uxQuerySelectQueryCB";
            this.uxQuerySelectQueryCB.Size = new System.Drawing.Size(121, 28);
            this.uxQuerySelectQueryCB.TabIndex = 6;
            // 
            // uxQuerySelectQueryLabel
            // 
            this.uxQuerySelectQueryLabel.AutoSize = true;
            this.uxQuerySelectQueryLabel.Location = new System.Drawing.Point(15, 32);
            this.uxQuerySelectQueryLabel.Name = "uxQuerySelectQueryLabel";
            this.uxQuerySelectQueryLabel.Size = new System.Drawing.Size(100, 20);
            this.uxQuerySelectQueryLabel.TabIndex = 5;
            this.uxQuerySelectQueryLabel.Text = "Select Query";
            // 
            // uxCreateAptControls
            // 
            this.uxCreateAptControls.Controls.Add(this.uxAptAptTimeCB);
            this.uxCreateAptControls.Controls.Add(this.uxAptAptDateLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptDatePicker);
            this.uxCreateAptControls.Controls.Add(this.uxAptDateLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptOwnerNameTB);
            this.uxCreateAptControls.Controls.Add(this.uxAptVetCB);
            this.uxCreateAptControls.Controls.Add(this.uxAptVetLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptOwnerNameLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptPetNameLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptPetNameTB);
            this.uxCreateAptControls.Location = new System.Drawing.Point(5, 37);
            this.uxCreateAptControls.Name = "uxCreateAptControls";
            this.uxCreateAptControls.Size = new System.Drawing.Size(859, 404);
            this.uxCreateAptControls.TabIndex = 8;
            this.uxCreateAptControls.TabStop = false;
            this.uxCreateAptControls.Text = "Create Appointment";
            this.uxCreateAptControls.Visible = false;
            // 
            // uxAptAptTimeCB
            // 
            this.uxAptAptTimeCB.FormattingEnabled = true;
            this.uxAptAptTimeCB.Location = new System.Drawing.Point(566, 69);
            this.uxAptAptTimeCB.Name = "uxAptAptTimeCB";
            this.uxAptAptTimeCB.Size = new System.Drawing.Size(121, 28);
            this.uxAptAptTimeCB.TabIndex = 11;
            // 
            // uxAptAptDateLabel
            // 
            this.uxAptAptDateLabel.AutoSize = true;
            this.uxAptAptDateLabel.Location = new System.Drawing.Point(421, 70);
            this.uxAptAptDateLabel.Name = "uxAptAptDateLabel";
            this.uxAptAptDateLabel.Size = new System.Drawing.Size(138, 20);
            this.uxAptAptDateLabel.TabIndex = 10;
            this.uxAptAptDateLabel.Text = "Appointment Time";
            // 
            // uxAptDatePicker
            // 
            this.uxAptDatePicker.Location = new System.Drawing.Point(566, 17);
            this.uxAptDatePicker.Name = "uxAptDatePicker";
            this.uxAptDatePicker.Size = new System.Drawing.Size(200, 26);
            this.uxAptDatePicker.TabIndex = 9;
            // 
            // uxAptDateLabel
            // 
            this.uxAptDateLabel.AutoSize = true;
            this.uxAptDateLabel.Location = new System.Drawing.Point(421, 22);
            this.uxAptDateLabel.Name = "uxAptDateLabel";
            this.uxAptDateLabel.Size = new System.Drawing.Size(139, 20);
            this.uxAptDateLabel.TabIndex = 8;
            this.uxAptDateLabel.Text = "Appointment Date";
            // 
            // uxAptOwnerNameTB
            // 
            this.uxAptOwnerNameTB.Location = new System.Drawing.Point(128, 71);
            this.uxAptOwnerNameTB.Name = "uxAptOwnerNameTB";
            this.uxAptOwnerNameTB.Size = new System.Drawing.Size(100, 26);
            this.uxAptOwnerNameTB.TabIndex = 7;
            // 
            // uxAptVetCB
            // 
            this.uxAptVetCB.FormattingEnabled = true;
            this.uxAptVetCB.Location = new System.Drawing.Point(61, 118);
            this.uxAptVetCB.Name = "uxAptVetCB";
            this.uxAptVetCB.Size = new System.Drawing.Size(121, 28);
            this.uxAptVetCB.TabIndex = 6;
            // 
            // uxAptVetLabel
            // 
            this.uxAptVetLabel.AutoSize = true;
            this.uxAptVetLabel.Location = new System.Drawing.Point(21, 121);
            this.uxAptVetLabel.Name = "uxAptVetLabel";
            this.uxAptVetLabel.Size = new System.Drawing.Size(34, 20);
            this.uxAptVetLabel.TabIndex = 5;
            this.uxAptVetLabel.Text = "Vet";
            // 
            // uxAptOwnerNameLabel
            // 
            this.uxAptOwnerNameLabel.AutoSize = true;
            this.uxAptOwnerNameLabel.Location = new System.Drawing.Point(21, 74);
            this.uxAptOwnerNameLabel.Name = "uxAptOwnerNameLabel";
            this.uxAptOwnerNameLabel.Size = new System.Drawing.Size(101, 20);
            this.uxAptOwnerNameLabel.TabIndex = 3;
            this.uxAptOwnerNameLabel.Text = "Owner Name";
            // 
            // uxAptPetNameLabel
            // 
            this.uxAptPetNameLabel.AutoSize = true;
            this.uxAptPetNameLabel.Location = new System.Drawing.Point(21, 29);
            this.uxAptPetNameLabel.Name = "uxAptPetNameLabel";
            this.uxAptPetNameLabel.Size = new System.Drawing.Size(79, 20);
            this.uxAptPetNameLabel.TabIndex = 1;
            this.uxAptPetNameLabel.Text = "Pet Name";
            // 
            // uxAptPetNameTB
            // 
            this.uxAptPetNameTB.Location = new System.Drawing.Point(106, 25);
            this.uxAptPetNameTB.Name = "uxAptPetNameTB";
            this.uxAptPetNameTB.Size = new System.Drawing.Size(100, 26);
            this.uxAptPetNameTB.TabIndex = 0;
            // 
            // uxPCPetLastNameLabel
            // 
            this.uxPCPetLastNameLabel.AutoSize = true;
            this.uxPCPetLastNameLabel.Location = new System.Drawing.Point(21, 61);
            this.uxPCPetLastNameLabel.Name = "uxPCPetLastNameLabel";
            this.uxPCPetLastNameLabel.Size = new System.Drawing.Size(114, 20);
            this.uxPCPetLastNameLabel.TabIndex = 8;
            this.uxPCPetLastNameLabel.Text = "Pet Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 26);
            this.textBox1.TabIndex = 7;
            // 
            // uxPCOwnerLastNameLabel
            // 
            this.uxPCOwnerLastNameLabel.AutoSize = true;
            this.uxPCOwnerLastNameLabel.Location = new System.Drawing.Point(321, 61);
            this.uxPCOwnerLastNameLabel.Name = "uxPCOwnerLastNameLabel";
            this.uxPCOwnerLastNameLabel.Size = new System.Drawing.Size(136, 20);
            this.uxPCOwnerLastNameLabel.TabIndex = 12;
            this.uxPCOwnerLastNameLabel.Text = "Owner Last Name";
            // 
            // uxPCOwnerLastNameTB
            // 
            this.uxPCOwnerLastNameTB.Location = new System.Drawing.Point(463, 55);
            this.uxPCOwnerLastNameTB.Name = "uxPCOwnerLastNameTB";
            this.uxPCOwnerLastNameTB.Size = new System.Drawing.Size(174, 26);
            this.uxPCOwnerLastNameTB.TabIndex = 11;
            // 
            // uxPCOwnerFirstNameLabel
            // 
            this.uxPCOwnerFirstNameLabel.AutoSize = true;
            this.uxPCOwnerFirstNameLabel.Location = new System.Drawing.Point(321, 29);
            this.uxPCOwnerFirstNameLabel.Name = "uxPCOwnerFirstNameLabel";
            this.uxPCOwnerFirstNameLabel.Size = new System.Drawing.Size(136, 20);
            this.uxPCOwnerFirstNameLabel.TabIndex = 10;
            this.uxPCOwnerFirstNameLabel.Text = "Owner First Name";
            // 
            // uxPCOwnerFirstNameTB
            // 
            this.uxPCOwnerFirstNameTB.Location = new System.Drawing.Point(463, 23);
            this.uxPCOwnerFirstNameTB.Name = "uxPCOwnerFirstNameTB";
            this.uxPCOwnerFirstNameTB.Size = new System.Drawing.Size(174, 26);
            this.uxPCOwnerFirstNameTB.TabIndex = 9;
            // 
            // uxPCOwnerEmailLabel
            // 
            this.uxPCOwnerEmailLabel.AutoSize = true;
            this.uxPCOwnerEmailLabel.Location = new System.Drawing.Point(321, 96);
            this.uxPCOwnerEmailLabel.Name = "uxPCOwnerEmailLabel";
            this.uxPCOwnerEmailLabel.Size = new System.Drawing.Size(98, 20);
            this.uxPCOwnerEmailLabel.TabIndex = 14;
            this.uxPCOwnerEmailLabel.Text = "Owner Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 26);
            this.textBox2.TabIndex = 13;
            // 
            // uxPCPetDescriptionLabel
            // 
            this.uxPCPetDescriptionLabel.AutoSize = true;
            this.uxPCPetDescriptionLabel.Location = new System.Drawing.Point(26, 153);
            this.uxPCPetDescriptionLabel.Name = "uxPCPetDescriptionLabel";
            this.uxPCPetDescriptionLabel.Size = new System.Drawing.Size(117, 20);
            this.uxPCPetDescriptionLabel.TabIndex = 15;
            this.uxPCPetDescriptionLabel.Text = "Pet Description";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 176);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 122);
            this.textBox3.TabIndex = 16;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.uxAddPetControls);
            this.Controls.Add(this.uxCreateAptControls);
            this.Controls.Add(this.uxQueryControls);
            this.Controls.Add(this.uxConnectDB);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Application";
            this.Text = "Form1";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.uxAddPetControls.ResumeLayout(false);
            this.uxAddPetControls.PerformLayout();
            this.uxQueryControls.ResumeLayout(false);
            this.uxQueryControls.PerformLayout();
            this.uxCreateAptControls.ResumeLayout(false);
            this.uxCreateAptControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxConnectDB;
        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxMenuAddPet;
        private System.Windows.Forms.ToolStripMenuItem uxMenuCreateApt;
        private System.Windows.Forms.ToolStripMenuItem uxMenuViewQueries;
        private System.Windows.Forms.GroupBox uxAddPetControls;
        private System.Windows.Forms.Label uxPCFirstNameLabel;
        private System.Windows.Forms.TextBox uxPCPetFirstNameTB;
        private System.Windows.Forms.Label uxPetSpeciesLabel;
        private System.Windows.Forms.ComboBox uxPetBreedCB;
        private System.Windows.Forms.Label uxPetBreedLabel;
        private System.Windows.Forms.ComboBox uxPetSpeciesCB;
        private System.Windows.Forms.GroupBox uxCreateAptControls;
        private System.Windows.Forms.DateTimePicker uxAptDatePicker;
        private System.Windows.Forms.Label uxAptDateLabel;
        private System.Windows.Forms.TextBox uxAptOwnerNameTB;
        private System.Windows.Forms.ComboBox uxAptVetCB;
        private System.Windows.Forms.Label uxAptVetLabel;
        private System.Windows.Forms.Label uxAptOwnerNameLabel;
        private System.Windows.Forms.Label uxAptPetNameLabel;
        private System.Windows.Forms.TextBox uxAptPetNameTB;
        private System.Windows.Forms.GroupBox uxQueryControls;
        private System.Windows.Forms.ComboBox uxQuerySelectQueryCB;
        private System.Windows.Forms.Label uxQuerySelectQueryLabel;
        private System.Windows.Forms.Label uxAptAptDateLabel;
        private System.Windows.Forms.ComboBox uxAptAptTimeCB;
        private System.Windows.Forms.Label uxPCOwnerLastNameLabel;
        private System.Windows.Forms.TextBox uxPCOwnerLastNameTB;
        private System.Windows.Forms.Label uxPCOwnerFirstNameLabel;
        private System.Windows.Forms.TextBox uxPCOwnerFirstNameTB;
        private System.Windows.Forms.Label uxPCPetLastNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label uxPCPetDescriptionLabel;
        private System.Windows.Forms.Label uxPCOwnerEmailLabel;
        private System.Windows.Forms.TextBox textBox2;
    }
}

