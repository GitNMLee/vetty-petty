﻿namespace WindowsFormProject
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
            this.uxAptOwnerEmailTB = new System.Windows.Forms.TextBox();
            this.uxAptVetCB = new System.Windows.Forms.ComboBox();
            this.uxAptVetLabel = new System.Windows.Forms.Label();
            this.uxAptOwnerEmailLabel = new System.Windows.Forms.Label();
            this.uxAptPetNameLabel = new System.Windows.Forms.Label();
            this.uxAptPetNameTB = new System.Windows.Forms.TextBox();
            this.uxPCPetLastNameLabel = new System.Windows.Forms.Label();
            this.uxPCPetLastNameTB = new System.Windows.Forms.TextBox();
            this.uxPCOwnerLastNameLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerLastNameTB = new System.Windows.Forms.TextBox();
            this.uxPCOwnerFirstNameLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxPCOwnerEmailLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerEmailTB = new System.Windows.Forms.TextBox();
            this.uxPCPetDescriptionLabel = new System.Windows.Forms.Label();
            this.uxPCPetDescriptionTB = new System.Windows.Forms.TextBox();
            this.uxAptReasonLabel = new System.Windows.Forms.Label();
            this.uxAptReasonTB = new System.Windows.Forms.TextBox();
            this.addVetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescribeMedicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireVetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddVetControls = new System.Windows.Forms.GroupBox();
            this.uxVetLastNameTB = new System.Windows.Forms.TextBox();
            this.uxVetLastNameLabel = new System.Windows.Forms.Label();
            this.uxVetFirstNameLabel = new System.Windows.Forms.Label();
            this.uxVetFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxPrescribeMedsControls = new System.Windows.Forms.GroupBox();
            this.uxMedsOwnerEmailTB = new System.Windows.Forms.TextBox();
            this.uxMedsOwnerEmailLabel = new System.Windows.Forms.Label();
            this.uxMedsPetNameLabel = new System.Windows.Forms.Label();
            this.uxMedsPetNameTB = new System.Windows.Forms.TextBox();
            this.uxMedsMedicationLabel = new System.Windows.Forms.Label();
            this.uxMedsMedicationCB = new System.Windows.Forms.ComboBox();
            this.uxMedsSubmitButton = new System.Windows.Forms.Button();
            this.uxPCSubmitButton = new System.Windows.Forms.Button();
            this.uxAptSubmitButton = new System.Windows.Forms.Button();
            this.uxVetSubmitButton = new System.Windows.Forms.Button();
            this.uxKillPetControls = new System.Windows.Forms.GroupBox();
            this.uxKPSubmitButton = new System.Windows.Forms.Button();
            this.uxKPOwnerEmailTB = new System.Windows.Forms.TextBox();
            this.uxKPOwnerEmailLabel = new System.Windows.Forms.Label();
            this.uxKPPetNameLabel = new System.Windows.Forms.Label();
            this.uxKPPetNameTB = new System.Windows.Forms.TextBox();
            this.uxFireVetControls = new System.Windows.Forms.GroupBox();
            this.uxFVSubmitButton = new System.Windows.Forms.Button();
            this.uxFVLastNameTB = new System.Windows.Forms.TextBox();
            this.uxFVLastNameLabel = new System.Windows.Forms.Label();
            this.uxFVVetFirstNameLabel = new System.Windows.Forms.Label();
            this.uxFVFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxMenuStrip.SuspendLayout();
            this.uxAddPetControls.SuspendLayout();
            this.uxQueryControls.SuspendLayout();
            this.uxCreateAptControls.SuspendLayout();
            this.uxAddVetControls.SuspendLayout();
            this.uxPrescribeMedsControls.SuspendLayout();
            this.uxKillPetControls.SuspendLayout();
            this.uxFireVetControls.SuspendLayout();
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
            this.uxMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuAddPet,
            this.uxMenuCreateApt,
            this.uxMenuViewQueries,
            this.addVetToolStripMenuItem,
            this.prescribeMedicationToolStripMenuItem,
            this.editToolStripMenuItem});
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
            this.uxAddPetControls.Controls.Add(this.uxPCSubmitButton);
            this.uxAddPetControls.Controls.Add(this.uxPCPetDescriptionTB);
            this.uxAddPetControls.Controls.Add(this.uxPCPetDescriptionLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerEmailLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerEmailTB);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerLastNameLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerLastNameTB);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerFirstNameLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCOwnerFirstNameTB);
            this.uxAddPetControls.Controls.Add(this.uxPCPetLastNameLabel);
            this.uxAddPetControls.Controls.Add(this.uxPCPetLastNameTB);
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
            this.uxAddPetControls.Enter += new System.EventHandler(this.uxMenuViewQueries_Click);
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
            this.uxCreateAptControls.Controls.Add(this.uxAptSubmitButton);
            this.uxCreateAptControls.Controls.Add(this.uxAptReasonTB);
            this.uxCreateAptControls.Controls.Add(this.uxAptReasonLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptAptTimeCB);
            this.uxCreateAptControls.Controls.Add(this.uxAptAptDateLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptDatePicker);
            this.uxCreateAptControls.Controls.Add(this.uxAptDateLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptOwnerEmailTB);
            this.uxCreateAptControls.Controls.Add(this.uxAptVetCB);
            this.uxCreateAptControls.Controls.Add(this.uxAptVetLabel);
            this.uxCreateAptControls.Controls.Add(this.uxAptOwnerEmailLabel);
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
            this.uxAptAptTimeCB.Location = new System.Drawing.Point(462, 50);
            this.uxAptAptTimeCB.Name = "uxAptAptTimeCB";
            this.uxAptAptTimeCB.Size = new System.Drawing.Size(121, 28);
            this.uxAptAptTimeCB.TabIndex = 11;
            // 
            // uxAptAptDateLabel
            // 
            this.uxAptAptDateLabel.AutoSize = true;
            this.uxAptAptDateLabel.Location = new System.Drawing.Point(317, 51);
            this.uxAptAptDateLabel.Name = "uxAptAptDateLabel";
            this.uxAptAptDateLabel.Size = new System.Drawing.Size(138, 20);
            this.uxAptAptDateLabel.TabIndex = 10;
            this.uxAptAptDateLabel.Text = "Appointment Time";
            // 
            // uxAptDatePicker
            // 
            this.uxAptDatePicker.Location = new System.Drawing.Point(461, 16);
            this.uxAptDatePicker.Name = "uxAptDatePicker";
            this.uxAptDatePicker.Size = new System.Drawing.Size(200, 26);
            this.uxAptDatePicker.TabIndex = 9;
            // 
            // uxAptDateLabel
            // 
            this.uxAptDateLabel.AutoSize = true;
            this.uxAptDateLabel.Location = new System.Drawing.Point(316, 21);
            this.uxAptDateLabel.Name = "uxAptDateLabel";
            this.uxAptDateLabel.Size = new System.Drawing.Size(139, 20);
            this.uxAptDateLabel.TabIndex = 8;
            this.uxAptDateLabel.Text = "Appointment Date";
            // 
            // uxAptOwnerEmailTB
            // 
            this.uxAptOwnerEmailTB.Location = new System.Drawing.Point(128, 57);
            this.uxAptOwnerEmailTB.Name = "uxAptOwnerEmailTB";
            this.uxAptOwnerEmailTB.Size = new System.Drawing.Size(100, 26);
            this.uxAptOwnerEmailTB.TabIndex = 7;
            // 
            // uxAptVetCB
            // 
            this.uxAptVetCB.FormattingEnabled = true;
            this.uxAptVetCB.Location = new System.Drawing.Point(64, 89);
            this.uxAptVetCB.Name = "uxAptVetCB";
            this.uxAptVetCB.Size = new System.Drawing.Size(121, 28);
            this.uxAptVetCB.TabIndex = 6;
            // 
            // uxAptVetLabel
            // 
            this.uxAptVetLabel.AutoSize = true;
            this.uxAptVetLabel.Location = new System.Drawing.Point(24, 92);
            this.uxAptVetLabel.Name = "uxAptVetLabel";
            this.uxAptVetLabel.Size = new System.Drawing.Size(34, 20);
            this.uxAptVetLabel.TabIndex = 5;
            this.uxAptVetLabel.Text = "Vet";
            // 
            // uxAptOwnerEmailLabel
            // 
            this.uxAptOwnerEmailLabel.AutoSize = true;
            this.uxAptOwnerEmailLabel.Location = new System.Drawing.Point(21, 60);
            this.uxAptOwnerEmailLabel.Name = "uxAptOwnerEmailLabel";
            this.uxAptOwnerEmailLabel.Size = new System.Drawing.Size(98, 20);
            this.uxAptOwnerEmailLabel.TabIndex = 3;
            this.uxAptOwnerEmailLabel.Text = "Owner Email";
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
            // uxPCPetLastNameTB
            // 
            this.uxPCPetLastNameTB.Location = new System.Drawing.Point(141, 56);
            this.uxPCPetLastNameTB.Name = "uxPCPetLastNameTB";
            this.uxPCPetLastNameTB.Size = new System.Drawing.Size(174, 26);
            this.uxPCPetLastNameTB.TabIndex = 7;
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
            // uxPCOwnerEmailTB
            // 
            this.uxPCOwnerEmailTB.Location = new System.Drawing.Point(425, 93);
            this.uxPCOwnerEmailTB.Name = "uxPCOwnerEmailTB";
            this.uxPCOwnerEmailTB.Size = new System.Drawing.Size(174, 26);
            this.uxPCOwnerEmailTB.TabIndex = 13;
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
            // uxPCPetDescriptionTB
            // 
            this.uxPCPetDescriptionTB.Location = new System.Drawing.Point(30, 176);
            this.uxPCPetDescriptionTB.Multiline = true;
            this.uxPCPetDescriptionTB.Name = "uxPCPetDescriptionTB";
            this.uxPCPetDescriptionTB.Size = new System.Drawing.Size(285, 122);
            this.uxPCPetDescriptionTB.TabIndex = 16;
            // 
            // uxAptReasonLabel
            // 
            this.uxAptReasonLabel.AutoSize = true;
            this.uxAptReasonLabel.Location = new System.Drawing.Point(21, 129);
            this.uxAptReasonLabel.Name = "uxAptReasonLabel";
            this.uxAptReasonLabel.Size = new System.Drawing.Size(65, 20);
            this.uxAptReasonLabel.TabIndex = 12;
            this.uxAptReasonLabel.Text = "Reason";
            // 
            // uxAptReasonTB
            // 
            this.uxAptReasonTB.Location = new System.Drawing.Point(24, 155);
            this.uxAptReasonTB.Multiline = true;
            this.uxAptReasonTB.Name = "uxAptReasonTB";
            this.uxAptReasonTB.Size = new System.Drawing.Size(300, 150);
            this.uxAptReasonTB.TabIndex = 13;
            // 
            // addVetToolStripMenuItem
            // 
            this.addVetToolStripMenuItem.Name = "addVetToolStripMenuItem";
            this.addVetToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.addVetToolStripMenuItem.Text = "Add Vet";
            this.addVetToolStripMenuItem.Click += new System.EventHandler(this.addVetToolStripMenuItem_Click);
            // 
            // prescribeMedicationToolStripMenuItem
            // 
            this.prescribeMedicationToolStripMenuItem.Name = "prescribeMedicationToolStripMenuItem";
            this.prescribeMedicationToolStripMenuItem.Size = new System.Drawing.Size(192, 29);
            this.prescribeMedicationToolStripMenuItem.Text = "Prescribe Medication";
            this.prescribeMedicationToolStripMenuItem.Click += new System.EventHandler(this.prescribeMedicationToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killPetToolStripMenuItem,
            this.fireVetToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // killPetToolStripMenuItem
            // 
            this.killPetToolStripMenuItem.Name = "killPetToolStripMenuItem";
            this.killPetToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.killPetToolStripMenuItem.Text = "Kill Pet";
            this.killPetToolStripMenuItem.Click += new System.EventHandler(this.killPetToolStripMenuItem_Click);
            // 
            // fireVetToolStripMenuItem
            // 
            this.fireVetToolStripMenuItem.Name = "fireVetToolStripMenuItem";
            this.fireVetToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fireVetToolStripMenuItem.Text = "Fire Vet";
            this.fireVetToolStripMenuItem.Click += new System.EventHandler(this.fireVetToolStripMenuItem_Click);
            // 
            // uxAddVetControls
            // 
            this.uxAddVetControls.Controls.Add(this.uxVetSubmitButton);
            this.uxAddVetControls.Controls.Add(this.uxVetLastNameTB);
            this.uxAddVetControls.Controls.Add(this.uxVetLastNameLabel);
            this.uxAddVetControls.Controls.Add(this.uxVetFirstNameLabel);
            this.uxAddVetControls.Controls.Add(this.uxVetFirstNameTB);
            this.uxAddVetControls.Location = new System.Drawing.Point(3, 37);
            this.uxAddVetControls.Name = "uxAddVetControls";
            this.uxAddVetControls.Size = new System.Drawing.Size(859, 404);
            this.uxAddVetControls.TabIndex = 14;
            this.uxAddVetControls.TabStop = false;
            this.uxAddVetControls.Text = "Add Vet";
            this.uxAddVetControls.Visible = false;
            // 
            // uxVetLastNameTB
            // 
            this.uxVetLastNameTB.Location = new System.Drawing.Point(106, 57);
            this.uxVetLastNameTB.Name = "uxVetLastNameTB";
            this.uxVetLastNameTB.Size = new System.Drawing.Size(100, 26);
            this.uxVetLastNameTB.TabIndex = 7;
            // 
            // uxVetLastNameLabel
            // 
            this.uxVetLastNameLabel.AutoSize = true;
            this.uxVetLastNameLabel.Location = new System.Drawing.Point(21, 60);
            this.uxVetLastNameLabel.Name = "uxVetLastNameLabel";
            this.uxVetLastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxVetLastNameLabel.TabIndex = 3;
            this.uxVetLastNameLabel.Text = "Last Name";
            // 
            // uxVetFirstNameLabel
            // 
            this.uxVetFirstNameLabel.AutoSize = true;
            this.uxVetFirstNameLabel.Location = new System.Drawing.Point(21, 29);
            this.uxVetFirstNameLabel.Name = "uxVetFirstNameLabel";
            this.uxVetFirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxVetFirstNameLabel.TabIndex = 1;
            this.uxVetFirstNameLabel.Text = "First Name";
            // 
            // uxVetFirstNameTB
            // 
            this.uxVetFirstNameTB.Location = new System.Drawing.Point(106, 25);
            this.uxVetFirstNameTB.Name = "uxVetFirstNameTB";
            this.uxVetFirstNameTB.Size = new System.Drawing.Size(100, 26);
            this.uxVetFirstNameTB.TabIndex = 0;
            // 
            // uxPrescribeMedsControls
            // 
            this.uxPrescribeMedsControls.Controls.Add(this.uxMedsSubmitButton);
            this.uxPrescribeMedsControls.Controls.Add(this.uxMedsMedicationCB);
            this.uxPrescribeMedsControls.Controls.Add(this.uxMedsMedicationLabel);
            this.uxPrescribeMedsControls.Controls.Add(this.uxMedsOwnerEmailTB);
            this.uxPrescribeMedsControls.Controls.Add(this.uxMedsOwnerEmailLabel);
            this.uxPrescribeMedsControls.Controls.Add(this.uxMedsPetNameLabel);
            this.uxPrescribeMedsControls.Controls.Add(this.uxMedsPetNameTB);
            this.uxPrescribeMedsControls.Location = new System.Drawing.Point(3, 37);
            this.uxPrescribeMedsControls.Name = "uxPrescribeMedsControls";
            this.uxPrescribeMedsControls.Size = new System.Drawing.Size(859, 404);
            this.uxPrescribeMedsControls.TabIndex = 15;
            this.uxPrescribeMedsControls.TabStop = false;
            this.uxPrescribeMedsControls.Text = "Prescribe Medication";
            this.uxPrescribeMedsControls.Visible = false;
            // 
            // uxMedsOwnerEmailTB
            // 
            this.uxMedsOwnerEmailTB.Location = new System.Drawing.Point(125, 56);
            this.uxMedsOwnerEmailTB.Name = "uxMedsOwnerEmailTB";
            this.uxMedsOwnerEmailTB.Size = new System.Drawing.Size(159, 26);
            this.uxMedsOwnerEmailTB.TabIndex = 7;
            // 
            // uxMedsOwnerEmailLabel
            // 
            this.uxMedsOwnerEmailLabel.AutoSize = true;
            this.uxMedsOwnerEmailLabel.Location = new System.Drawing.Point(21, 59);
            this.uxMedsOwnerEmailLabel.Name = "uxMedsOwnerEmailLabel";
            this.uxMedsOwnerEmailLabel.Size = new System.Drawing.Size(98, 20);
            this.uxMedsOwnerEmailLabel.TabIndex = 3;
            this.uxMedsOwnerEmailLabel.Text = "Owner Email";
            // 
            // uxMedsPetNameLabel
            // 
            this.uxMedsPetNameLabel.AutoSize = true;
            this.uxMedsPetNameLabel.Location = new System.Drawing.Point(21, 29);
            this.uxMedsPetNameLabel.Name = "uxMedsPetNameLabel";
            this.uxMedsPetNameLabel.Size = new System.Drawing.Size(79, 20);
            this.uxMedsPetNameLabel.TabIndex = 1;
            this.uxMedsPetNameLabel.Text = "Pet Name";
            // 
            // uxMedsPetNameTB
            // 
            this.uxMedsPetNameTB.Location = new System.Drawing.Point(106, 25);
            this.uxMedsPetNameTB.Name = "uxMedsPetNameTB";
            this.uxMedsPetNameTB.Size = new System.Drawing.Size(100, 26);
            this.uxMedsPetNameTB.TabIndex = 0;
            // 
            // uxMedsMedicationLabel
            // 
            this.uxMedsMedicationLabel.AutoSize = true;
            this.uxMedsMedicationLabel.Location = new System.Drawing.Point(22, 90);
            this.uxMedsMedicationLabel.Name = "uxMedsMedicationLabel";
            this.uxMedsMedicationLabel.Size = new System.Drawing.Size(86, 20);
            this.uxMedsMedicationLabel.TabIndex = 8;
            this.uxMedsMedicationLabel.Text = "Medication";
            // 
            // uxMedsMedicationCB
            // 
            this.uxMedsMedicationCB.FormattingEnabled = true;
            this.uxMedsMedicationCB.Location = new System.Drawing.Point(115, 87);
            this.uxMedsMedicationCB.Name = "uxMedsMedicationCB";
            this.uxMedsMedicationCB.Size = new System.Drawing.Size(121, 28);
            this.uxMedsMedicationCB.TabIndex = 9;
            // 
            // uxMedsSubmitButton
            // 
            this.uxMedsSubmitButton.Location = new System.Drawing.Point(27, 244);
            this.uxMedsSubmitButton.Name = "uxMedsSubmitButton";
            this.uxMedsSubmitButton.Size = new System.Drawing.Size(114, 41);
            this.uxMedsSubmitButton.TabIndex = 10;
            this.uxMedsSubmitButton.Text = "Submit";
            this.uxMedsSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxPCSubmitButton
            // 
            this.uxPCSubmitButton.Location = new System.Drawing.Point(523, 265);
            this.uxPCSubmitButton.Name = "uxPCSubmitButton";
            this.uxPCSubmitButton.Size = new System.Drawing.Size(114, 41);
            this.uxPCSubmitButton.TabIndex = 17;
            this.uxPCSubmitButton.Text = "Submit";
            this.uxPCSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxAptSubmitButton
            // 
            this.uxAptSubmitButton.Location = new System.Drawing.Point(547, 256);
            this.uxAptSubmitButton.Name = "uxAptSubmitButton";
            this.uxAptSubmitButton.Size = new System.Drawing.Size(114, 41);
            this.uxAptSubmitButton.TabIndex = 14;
            this.uxAptSubmitButton.Text = "Submit";
            this.uxAptSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxVetSubmitButton
            // 
            this.uxVetSubmitButton.Location = new System.Drawing.Point(27, 131);
            this.uxVetSubmitButton.Name = "uxVetSubmitButton";
            this.uxVetSubmitButton.Size = new System.Drawing.Size(114, 41);
            this.uxVetSubmitButton.TabIndex = 11;
            this.uxVetSubmitButton.Text = "Submit";
            this.uxVetSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxKillPetControls
            // 
            this.uxKillPetControls.Controls.Add(this.uxKPSubmitButton);
            this.uxKillPetControls.Controls.Add(this.uxKPOwnerEmailTB);
            this.uxKillPetControls.Controls.Add(this.uxKPOwnerEmailLabel);
            this.uxKillPetControls.Controls.Add(this.uxKPPetNameLabel);
            this.uxKillPetControls.Controls.Add(this.uxKPPetNameTB);
            this.uxKillPetControls.Location = new System.Drawing.Point(1, 37);
            this.uxKillPetControls.Name = "uxKillPetControls";
            this.uxKillPetControls.Size = new System.Drawing.Size(859, 404);
            this.uxKillPetControls.TabIndex = 16;
            this.uxKillPetControls.TabStop = false;
            this.uxKillPetControls.Text = "Kill Pet";
            this.uxKillPetControls.Visible = false;
            // 
            // uxKPSubmitButton
            // 
            this.uxKPSubmitButton.Location = new System.Drawing.Point(27, 244);
            this.uxKPSubmitButton.Name = "uxKPSubmitButton";
            this.uxKPSubmitButton.Size = new System.Drawing.Size(114, 41);
            this.uxKPSubmitButton.TabIndex = 10;
            this.uxKPSubmitButton.Text = "Submit";
            this.uxKPSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxKPOwnerEmailTB
            // 
            this.uxKPOwnerEmailTB.Location = new System.Drawing.Point(125, 56);
            this.uxKPOwnerEmailTB.Name = "uxKPOwnerEmailTB";
            this.uxKPOwnerEmailTB.Size = new System.Drawing.Size(159, 26);
            this.uxKPOwnerEmailTB.TabIndex = 7;
            // 
            // uxKPOwnerEmailLabel
            // 
            this.uxKPOwnerEmailLabel.AutoSize = true;
            this.uxKPOwnerEmailLabel.Location = new System.Drawing.Point(21, 59);
            this.uxKPOwnerEmailLabel.Name = "uxKPOwnerEmailLabel";
            this.uxKPOwnerEmailLabel.Size = new System.Drawing.Size(98, 20);
            this.uxKPOwnerEmailLabel.TabIndex = 3;
            this.uxKPOwnerEmailLabel.Text = "Owner Email";
            // 
            // uxKPPetNameLabel
            // 
            this.uxKPPetNameLabel.AutoSize = true;
            this.uxKPPetNameLabel.Location = new System.Drawing.Point(21, 29);
            this.uxKPPetNameLabel.Name = "uxKPPetNameLabel";
            this.uxKPPetNameLabel.Size = new System.Drawing.Size(79, 20);
            this.uxKPPetNameLabel.TabIndex = 1;
            this.uxKPPetNameLabel.Text = "Pet Name";
            // 
            // uxKPPetNameTB
            // 
            this.uxKPPetNameTB.Location = new System.Drawing.Point(106, 25);
            this.uxKPPetNameTB.Name = "uxKPPetNameTB";
            this.uxKPPetNameTB.Size = new System.Drawing.Size(100, 26);
            this.uxKPPetNameTB.TabIndex = 0;
            // 
            // uxFireVetControls
            // 
            this.uxFireVetControls.Controls.Add(this.uxFVSubmitButton);
            this.uxFireVetControls.Controls.Add(this.uxFVLastNameTB);
            this.uxFireVetControls.Controls.Add(this.uxFVLastNameLabel);
            this.uxFireVetControls.Controls.Add(this.uxFVVetFirstNameLabel);
            this.uxFireVetControls.Controls.Add(this.uxFVFirstNameTB);
            this.uxFireVetControls.Location = new System.Drawing.Point(0, 37);
            this.uxFireVetControls.Name = "uxFireVetControls";
            this.uxFireVetControls.Size = new System.Drawing.Size(859, 404);
            this.uxFireVetControls.TabIndex = 17;
            this.uxFireVetControls.TabStop = false;
            this.uxFireVetControls.Text = "Fire Vet";
            this.uxFireVetControls.Visible = false;
            // 
            // uxFVSubmitButton
            // 
            this.uxFVSubmitButton.Location = new System.Drawing.Point(27, 244);
            this.uxFVSubmitButton.Name = "uxFVSubmitButton";
            this.uxFVSubmitButton.Size = new System.Drawing.Size(114, 41);
            this.uxFVSubmitButton.TabIndex = 10;
            this.uxFVSubmitButton.Text = "Submit";
            this.uxFVSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxFVLastNameTB
            // 
            this.uxFVLastNameTB.Location = new System.Drawing.Point(107, 56);
            this.uxFVLastNameTB.Name = "uxFVLastNameTB";
            this.uxFVLastNameTB.Size = new System.Drawing.Size(144, 26);
            this.uxFVLastNameTB.TabIndex = 7;
            // 
            // uxFVLastNameLabel
            // 
            this.uxFVLastNameLabel.AutoSize = true;
            this.uxFVLastNameLabel.Location = new System.Drawing.Point(21, 59);
            this.uxFVLastNameLabel.Name = "uxFVLastNameLabel";
            this.uxFVLastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxFVLastNameLabel.TabIndex = 3;
            this.uxFVLastNameLabel.Text = "Last Name";
            // 
            // uxFVVetFirstNameLabel
            // 
            this.uxFVVetFirstNameLabel.AutoSize = true;
            this.uxFVVetFirstNameLabel.Location = new System.Drawing.Point(21, 29);
            this.uxFVVetFirstNameLabel.Name = "uxFVVetFirstNameLabel";
            this.uxFVVetFirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.uxFVVetFirstNameLabel.TabIndex = 1;
            this.uxFVVetFirstNameLabel.Text = "First Name";
            // 
            // uxFVFirstNameTB
            // 
            this.uxFVFirstNameTB.Location = new System.Drawing.Point(109, 22);
            this.uxFVFirstNameTB.Name = "uxFVFirstNameTB";
            this.uxFVFirstNameTB.Size = new System.Drawing.Size(142, 26);
            this.uxFVFirstNameTB.TabIndex = 0;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.uxFireVetControls);
            this.Controls.Add(this.uxKillPetControls);
            this.Controls.Add(this.uxPrescribeMedsControls);
            this.Controls.Add(this.uxAddVetControls);
            this.Controls.Add(this.uxCreateAptControls);
            this.Controls.Add(this.uxAddPetControls);
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
            this.uxAddVetControls.ResumeLayout(false);
            this.uxAddVetControls.PerformLayout();
            this.uxPrescribeMedsControls.ResumeLayout(false);
            this.uxPrescribeMedsControls.PerformLayout();
            this.uxKillPetControls.ResumeLayout(false);
            this.uxKillPetControls.PerformLayout();
            this.uxFireVetControls.ResumeLayout(false);
            this.uxFireVetControls.PerformLayout();
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
        private System.Windows.Forms.TextBox uxAptOwnerEmailTB;
        private System.Windows.Forms.ComboBox uxAptVetCB;
        private System.Windows.Forms.Label uxAptVetLabel;
        private System.Windows.Forms.Label uxAptOwnerEmailLabel;
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
        private System.Windows.Forms.TextBox uxPCPetLastNameTB;
        private System.Windows.Forms.TextBox uxPCPetDescriptionTB;
        private System.Windows.Forms.Label uxPCPetDescriptionLabel;
        private System.Windows.Forms.Label uxPCOwnerEmailLabel;
        private System.Windows.Forms.TextBox uxPCOwnerEmailTB;
        private System.Windows.Forms.TextBox uxAptReasonTB;
        private System.Windows.Forms.Label uxAptReasonLabel;
        private System.Windows.Forms.ToolStripMenuItem addVetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescribeMedicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireVetToolStripMenuItem;
        private System.Windows.Forms.GroupBox uxAddVetControls;
        private System.Windows.Forms.TextBox uxVetLastNameTB;
        private System.Windows.Forms.Label uxVetLastNameLabel;
        private System.Windows.Forms.Label uxVetFirstNameLabel;
        private System.Windows.Forms.TextBox uxVetFirstNameTB;
        private System.Windows.Forms.GroupBox uxPrescribeMedsControls;
        private System.Windows.Forms.ComboBox uxMedsMedicationCB;
        private System.Windows.Forms.Label uxMedsMedicationLabel;
        private System.Windows.Forms.TextBox uxMedsOwnerEmailTB;
        private System.Windows.Forms.Label uxMedsOwnerEmailLabel;
        private System.Windows.Forms.Label uxMedsPetNameLabel;
        private System.Windows.Forms.TextBox uxMedsPetNameTB;
        private System.Windows.Forms.Button uxMedsSubmitButton;
        private System.Windows.Forms.Button uxPCSubmitButton;
        private System.Windows.Forms.Button uxAptSubmitButton;
        private System.Windows.Forms.Button uxVetSubmitButton;
        private System.Windows.Forms.GroupBox uxKillPetControls;
        private System.Windows.Forms.Button uxKPSubmitButton;
        private System.Windows.Forms.TextBox uxKPOwnerEmailTB;
        private System.Windows.Forms.Label uxKPOwnerEmailLabel;
        private System.Windows.Forms.Label uxKPPetNameLabel;
        private System.Windows.Forms.TextBox uxKPPetNameTB;
        private System.Windows.Forms.GroupBox uxFireVetControls;
        private System.Windows.Forms.Button uxFVSubmitButton;
        private System.Windows.Forms.TextBox uxFVLastNameTB;
        private System.Windows.Forms.Label uxFVLastNameLabel;
        private System.Windows.Forms.Label uxFVVetFirstNameLabel;
        private System.Windows.Forms.TextBox uxFVFirstNameTB;
    }
}
