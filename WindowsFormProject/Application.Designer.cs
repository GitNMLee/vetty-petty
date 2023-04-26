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
            this.addVetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuCreateApt = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuViewQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.prescribeMedicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddPetControls = new System.Windows.Forms.GroupBox();
            this.uxPCSubmitButton = new System.Windows.Forms.Button();
            this.uxPCPetDescriptionTB = new System.Windows.Forms.TextBox();
            this.uxPCPetDescriptionLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerEmailLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerEmailTB = new System.Windows.Forms.TextBox();
            this.uxPCOwnerLastNameLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerLastNameTB = new System.Windows.Forms.TextBox();
            this.uxPCOwnerFirstNameLabel = new System.Windows.Forms.Label();
            this.uxPCOwnerFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxPCPetLastNameLabel = new System.Windows.Forms.Label();
            this.uxPCPetLastNameTB = new System.Windows.Forms.TextBox();
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
            this.uxAptSubmitButton = new System.Windows.Forms.Button();
            this.uxAptReasonTB = new System.Windows.Forms.TextBox();
            this.uxAptReasonLabel = new System.Windows.Forms.Label();
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
            this.uxAddVetControls = new System.Windows.Forms.GroupBox();
            this.uxVetSubmitButton = new System.Windows.Forms.Button();
            this.uxVetLastNameTB = new System.Windows.Forms.TextBox();
            this.uxVetLastNameLabel = new System.Windows.Forms.Label();
            this.uxVetFirstNameLabel = new System.Windows.Forms.Label();
            this.uxVetFirstNameTB = new System.Windows.Forms.TextBox();
            this.uxPrescribeMedsControls = new System.Windows.Forms.GroupBox();
            this.uxMedsSubmitButton = new System.Windows.Forms.Button();
            this.uxMedsMedicationCB = new System.Windows.Forms.ComboBox();
            this.uxMedsMedicationLabel = new System.Windows.Forms.Label();
            this.uxMedsOwnerEmailTB = new System.Windows.Forms.TextBox();
            this.uxMedsOwnerEmailLabel = new System.Windows.Forms.Label();
            this.uxMedsPetNameLabel = new System.Windows.Forms.Label();
            this.uxMedsPetNameTB = new System.Windows.Forms.TextBox();
            this.uxSearchTB = new System.Windows.Forms.TextBox();
            this.uxSearchControls = new System.Windows.Forms.GroupBox();
            this.uxSearchVetsButton = new System.Windows.Forms.Button();
            this.uxSearchOwnersButton = new System.Windows.Forms.Button();
            this.uxSearchPetsButton = new System.Windows.Forms.Button();
            this.uxSearchListBox = new System.Windows.Forms.ListBox();
            this.uxMenuStrip.SuspendLayout();
            this.uxAddPetControls.SuspendLayout();
            this.uxQueryControls.SuspendLayout();
            this.uxCreateAptControls.SuspendLayout();
            this.uxAddVetControls.SuspendLayout();
            this.uxPrescribeMedsControls.SuspendLayout();
            this.uxSearchControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxConnectDB
            // 
            this.uxConnectDB.Location = new System.Drawing.Point(654, 0);
            this.uxConnectDB.Name = "uxConnectDB";
            this.uxConnectDB.Size = new System.Drawing.Size(146, 23);
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
            this.addVetToolStripMenuItem,
            this.uxMenuCreateApt,
            this.uxMenuViewQueries,
            this.prescribeMedicationToolStripMenuItem,
            this.editToolStripMenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(1200, 36);
            this.uxMenuStrip.TabIndex = 1;
            this.uxMenuStrip.Text = "MenuStrip";
            // 
            // uxMenuAddPet
            // 
            this.uxMenuAddPet.Name = "uxMenuAddPet";
            this.uxMenuAddPet.Size = new System.Drawing.Size(61, 22);
            this.uxMenuAddPet.Text = "Add Pet";
            this.uxMenuAddPet.Click += new System.EventHandler(this.uxMenuAddPet_Click);
            // 
            // addVetToolStripMenuItem
            // 
            this.addVetToolStripMenuItem.Name = "addVetToolStripMenuItem";
            this.addVetToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.addVetToolStripMenuItem.Text = "Add Vet";
            this.addVetToolStripMenuItem.Click += new System.EventHandler(this.addVetToolStripMenuItem_Click);
            // 
            // uxMenuCreateApt
            // 
            this.uxMenuCreateApt.Name = "uxMenuCreateApt";
            this.uxMenuCreateApt.Size = new System.Drawing.Size(127, 22);
            this.uxMenuCreateApt.Text = "Create Appointment";
            this.uxMenuCreateApt.Click += new System.EventHandler(this.uxMenuCreateApt_Click);
            // 
            // uxMenuViewQueries
            // 
            this.uxMenuViewQueries.Name = "uxMenuViewQueries";
            this.uxMenuViewQueries.Size = new System.Drawing.Size(152, 22);
            this.uxMenuViewQueries.Text = "View Aggregated Queries";
            this.uxMenuViewQueries.Click += new System.EventHandler(this.uxMenuViewQueries_Click);
            // 
            // prescribeMedicationToolStripMenuItem
            // 
            this.prescribeMedicationToolStripMenuItem.Name = "prescribeMedicationToolStripMenuItem";
            this.prescribeMedicationToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.prescribeMedicationToolStripMenuItem.Text = "Prescribe Medication";
            this.prescribeMedicationToolStripMenuItem.Click += new System.EventHandler(this.prescribeMedicationToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.editToolStripMenuItem.Text = "Search";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            this.uxAddPetControls.Location = new System.Drawing.Point(0, 23);
            this.uxAddPetControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAddPetControls.Name = "uxAddPetControls";
            this.uxAddPetControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAddPetControls.Size = new System.Drawing.Size(434, 263);
            this.uxAddPetControls.TabIndex = 2;
            this.uxAddPetControls.TabStop = false;
            this.uxAddPetControls.Text = "AddPet";
            this.uxAddPetControls.Visible = false;
            this.uxAddPetControls.Enter += new System.EventHandler(this.uxMenuViewQueries_Click);
            // 
            // uxPCSubmitButton
            // 
            this.uxPCSubmitButton.Location = new System.Drawing.Point(349, 172);
            this.uxPCSubmitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPCSubmitButton.Name = "uxPCSubmitButton";
            this.uxPCSubmitButton.Size = new System.Drawing.Size(76, 27);
            this.uxPCSubmitButton.TabIndex = 17;
            this.uxPCSubmitButton.Text = "Submit";
            this.uxPCSubmitButton.UseVisualStyleBackColor = true;
            this.uxPCSubmitButton.Click += new System.EventHandler(this.uxPCSubmitButton_Click);
            // 
            // uxPCPetDescriptionTB
            // 
            this.uxPCPetDescriptionTB.Location = new System.Drawing.Point(20, 114);
            this.uxPCPetDescriptionTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPCPetDescriptionTB.Multiline = true;
            this.uxPCPetDescriptionTB.Name = "uxPCPetDescriptionTB";
            this.uxPCPetDescriptionTB.Size = new System.Drawing.Size(191, 81);
            this.uxPCPetDescriptionTB.TabIndex = 16;
            // 
            // uxPCPetDescriptionLabel
            // 
            this.uxPCPetDescriptionLabel.AutoSize = true;
            this.uxPCPetDescriptionLabel.Location = new System.Drawing.Point(17, 99);
            this.uxPCPetDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPCPetDescriptionLabel.Name = "uxPCPetDescriptionLabel";
            this.uxPCPetDescriptionLabel.Size = new System.Drawing.Size(79, 13);
            this.uxPCPetDescriptionLabel.TabIndex = 15;
            this.uxPCPetDescriptionLabel.Text = "Pet Description";
            // 
            // uxPCOwnerEmailLabel
            // 
            this.uxPCOwnerEmailLabel.AutoSize = true;
            this.uxPCOwnerEmailLabel.Location = new System.Drawing.Point(214, 62);
            this.uxPCOwnerEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPCOwnerEmailLabel.Name = "uxPCOwnerEmailLabel";
            this.uxPCOwnerEmailLabel.Size = new System.Drawing.Size(66, 13);
            this.uxPCOwnerEmailLabel.TabIndex = 14;
            this.uxPCOwnerEmailLabel.Text = "Owner Email";
            // 
            // uxPCOwnerEmailTB
            // 
            this.uxPCOwnerEmailTB.Location = new System.Drawing.Point(283, 60);
            this.uxPCOwnerEmailTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPCOwnerEmailTB.Name = "uxPCOwnerEmailTB";
            this.uxPCOwnerEmailTB.Size = new System.Drawing.Size(117, 20);
            this.uxPCOwnerEmailTB.TabIndex = 13;
            // 
            // uxPCOwnerLastNameLabel
            // 
            this.uxPCOwnerLastNameLabel.AutoSize = true;
            this.uxPCOwnerLastNameLabel.Location = new System.Drawing.Point(214, 40);
            this.uxPCOwnerLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPCOwnerLastNameLabel.Name = "uxPCOwnerLastNameLabel";
            this.uxPCOwnerLastNameLabel.Size = new System.Drawing.Size(92, 13);
            this.uxPCOwnerLastNameLabel.TabIndex = 12;
            this.uxPCOwnerLastNameLabel.Text = "Owner Last Name";
            // 
            // uxPCOwnerLastNameTB
            // 
            this.uxPCOwnerLastNameTB.Location = new System.Drawing.Point(309, 36);
            this.uxPCOwnerLastNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPCOwnerLastNameTB.Name = "uxPCOwnerLastNameTB";
            this.uxPCOwnerLastNameTB.Size = new System.Drawing.Size(117, 20);
            this.uxPCOwnerLastNameTB.TabIndex = 11;
            // 
            // uxPCOwnerFirstNameLabel
            // 
            this.uxPCOwnerFirstNameLabel.AutoSize = true;
            this.uxPCOwnerFirstNameLabel.Location = new System.Drawing.Point(214, 19);
            this.uxPCOwnerFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPCOwnerFirstNameLabel.Name = "uxPCOwnerFirstNameLabel";
            this.uxPCOwnerFirstNameLabel.Size = new System.Drawing.Size(91, 13);
            this.uxPCOwnerFirstNameLabel.TabIndex = 10;
            this.uxPCOwnerFirstNameLabel.Text = "Owner First Name";
            // 
            // uxPCOwnerFirstNameTB
            // 
            this.uxPCOwnerFirstNameTB.Location = new System.Drawing.Point(309, 15);
            this.uxPCOwnerFirstNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPCOwnerFirstNameTB.Name = "uxPCOwnerFirstNameTB";
            this.uxPCOwnerFirstNameTB.Size = new System.Drawing.Size(117, 20);
            this.uxPCOwnerFirstNameTB.TabIndex = 9;
            // 
            // uxPCPetLastNameLabel
            // 
            this.uxPCPetLastNameLabel.AutoSize = true;
            this.uxPCPetLastNameLabel.Location = new System.Drawing.Point(14, 40);
            this.uxPCPetLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPCPetLastNameLabel.Name = "uxPCPetLastNameLabel";
            this.uxPCPetLastNameLabel.Size = new System.Drawing.Size(77, 13);
            this.uxPCPetLastNameLabel.TabIndex = 8;
            this.uxPCPetLastNameLabel.Text = "Pet Last Name";
            // 
            // uxPCPetLastNameTB
            // 
            this.uxPCPetLastNameTB.Location = new System.Drawing.Point(94, 36);
            this.uxPCPetLastNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPCPetLastNameTB.Name = "uxPCPetLastNameTB";
            this.uxPCPetLastNameTB.Size = new System.Drawing.Size(117, 20);
            this.uxPCPetLastNameTB.TabIndex = 7;
            // 
            // uxPetBreedCB
            // 
            this.uxPetBreedCB.FormattingEnabled = true;
            this.uxPetBreedCB.Location = new System.Drawing.Point(83, 79);
            this.uxPetBreedCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPetBreedCB.Name = "uxPetBreedCB";
            this.uxPetBreedCB.Size = new System.Drawing.Size(82, 21);
            this.uxPetBreedCB.TabIndex = 6;
            // 
            // uxPetBreedLabel
            // 
            this.uxPetBreedLabel.AutoSize = true;
            this.uxPetBreedLabel.Location = new System.Drawing.Point(17, 81);
            this.uxPetBreedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPetBreedLabel.Name = "uxPetBreedLabel";
            this.uxPetBreedLabel.Size = new System.Drawing.Size(54, 13);
            this.uxPetBreedLabel.TabIndex = 5;
            this.uxPetBreedLabel.Text = "Pet Breed";
            // 
            // uxPetSpeciesCB
            // 
            this.uxPetSpeciesCB.FormattingEnabled = true;
            this.uxPetSpeciesCB.Location = new System.Drawing.Point(83, 57);
            this.uxPetSpeciesCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPetSpeciesCB.Name = "uxPetSpeciesCB";
            this.uxPetSpeciesCB.Size = new System.Drawing.Size(82, 21);
            this.uxPetSpeciesCB.TabIndex = 4;
            this.uxPetSpeciesCB.SelectedIndexChanged += new System.EventHandler(this.uxPetSpeciesCB_SelectedIndexChanged);
            // 
            // uxPetSpeciesLabel
            // 
            this.uxPetSpeciesLabel.AutoSize = true;
            this.uxPetSpeciesLabel.Location = new System.Drawing.Point(17, 59);
            this.uxPetSpeciesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPetSpeciesLabel.Name = "uxPetSpeciesLabel";
            this.uxPetSpeciesLabel.Size = new System.Drawing.Size(64, 13);
            this.uxPetSpeciesLabel.TabIndex = 3;
            this.uxPetSpeciesLabel.Text = "Pet Species";
            // 
            // uxPCFirstNameLabel
            // 
            this.uxPCFirstNameLabel.AutoSize = true;
            this.uxPCFirstNameLabel.Location = new System.Drawing.Point(14, 19);
            this.uxPCFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPCFirstNameLabel.Name = "uxPCFirstNameLabel";
            this.uxPCFirstNameLabel.Size = new System.Drawing.Size(76, 13);
            this.uxPCFirstNameLabel.TabIndex = 1;
            this.uxPCFirstNameLabel.Text = "Pet First Name";
            // 
            // uxPCPetFirstNameTB
            // 
            this.uxPCPetFirstNameTB.Location = new System.Drawing.Point(94, 16);
            this.uxPCPetFirstNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPCPetFirstNameTB.Name = "uxPCPetFirstNameTB";
            this.uxPCPetFirstNameTB.Size = new System.Drawing.Size(117, 20);
            this.uxPCPetFirstNameTB.TabIndex = 0;
            // 
            // uxQueryControls
            // 
            this.uxQueryControls.Controls.Add(this.uxQuerySelectQueryCB);
            this.uxQueryControls.Controls.Add(this.uxQuerySelectQueryLabel);
            this.uxQueryControls.Location = new System.Drawing.Point(3, 24);
            this.uxQueryControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxQueryControls.Name = "uxQueryControls";
            this.uxQueryControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxQueryControls.Size = new System.Drawing.Size(606, 263);
            this.uxQueryControls.TabIndex = 11;
            this.uxQueryControls.TabStop = false;
            this.uxQueryControls.Text = "View AggregatedQueries";
            this.uxQueryControls.Visible = false;
            // 
            // uxQuerySelectQueryCB
            // 
            this.uxQuerySelectQueryCB.FormattingEnabled = true;
            this.uxQuerySelectQueryCB.Location = new System.Drawing.Point(81, 19);
            this.uxQuerySelectQueryCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxQuerySelectQueryCB.Name = "uxQuerySelectQueryCB";
            this.uxQuerySelectQueryCB.Size = new System.Drawing.Size(82, 21);
            this.uxQuerySelectQueryCB.TabIndex = 6;
            // 
            // uxQuerySelectQueryLabel
            // 
            this.uxQuerySelectQueryLabel.AutoSize = true;
            this.uxQuerySelectQueryLabel.Location = new System.Drawing.Point(10, 21);
            this.uxQuerySelectQueryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxQuerySelectQueryLabel.Name = "uxQuerySelectQueryLabel";
            this.uxQuerySelectQueryLabel.Size = new System.Drawing.Size(68, 13);
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
            this.uxCreateAptControls.Location = new System.Drawing.Point(3, 24);
            this.uxCreateAptControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxCreateAptControls.Name = "uxCreateAptControls";
            this.uxCreateAptControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxCreateAptControls.Size = new System.Drawing.Size(573, 263);
            this.uxCreateAptControls.TabIndex = 8;
            this.uxCreateAptControls.TabStop = false;
            this.uxCreateAptControls.Text = "Create Appointment";
            this.uxCreateAptControls.Visible = false;
            // 
            // uxAptSubmitButton
            // 
            this.uxAptSubmitButton.Location = new System.Drawing.Point(365, 166);
            this.uxAptSubmitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAptSubmitButton.Name = "uxAptSubmitButton";
            this.uxAptSubmitButton.Size = new System.Drawing.Size(76, 27);
            this.uxAptSubmitButton.TabIndex = 14;
            this.uxAptSubmitButton.Text = "Submit";
            this.uxAptSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxAptReasonTB
            // 
            this.uxAptReasonTB.Location = new System.Drawing.Point(16, 101);
            this.uxAptReasonTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAptReasonTB.Multiline = true;
            this.uxAptReasonTB.Name = "uxAptReasonTB";
            this.uxAptReasonTB.Size = new System.Drawing.Size(201, 99);
            this.uxAptReasonTB.TabIndex = 13;
            // 
            // uxAptReasonLabel
            // 
            this.uxAptReasonLabel.AutoSize = true;
            this.uxAptReasonLabel.Location = new System.Drawing.Point(14, 84);
            this.uxAptReasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAptReasonLabel.Name = "uxAptReasonLabel";
            this.uxAptReasonLabel.Size = new System.Drawing.Size(44, 13);
            this.uxAptReasonLabel.TabIndex = 12;
            this.uxAptReasonLabel.Text = "Reason";
            // 
            // uxAptAptTimeCB
            // 
            this.uxAptAptTimeCB.FormattingEnabled = true;
            this.uxAptAptTimeCB.Location = new System.Drawing.Point(308, 32);
            this.uxAptAptTimeCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAptAptTimeCB.Name = "uxAptAptTimeCB";
            this.uxAptAptTimeCB.Size = new System.Drawing.Size(82, 21);
            this.uxAptAptTimeCB.TabIndex = 11;
            // 
            // uxAptAptDateLabel
            // 
            this.uxAptAptDateLabel.AutoSize = true;
            this.uxAptAptDateLabel.Location = new System.Drawing.Point(211, 33);
            this.uxAptAptDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAptAptDateLabel.Name = "uxAptAptDateLabel";
            this.uxAptAptDateLabel.Size = new System.Drawing.Size(92, 13);
            this.uxAptAptDateLabel.TabIndex = 10;
            this.uxAptAptDateLabel.Text = "Appointment Time";
            // 
            // uxAptDatePicker
            // 
            this.uxAptDatePicker.Location = new System.Drawing.Point(307, 10);
            this.uxAptDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAptDatePicker.Name = "uxAptDatePicker";
            this.uxAptDatePicker.Size = new System.Drawing.Size(135, 20);
            this.uxAptDatePicker.TabIndex = 9;
            // 
            // uxAptDateLabel
            // 
            this.uxAptDateLabel.AutoSize = true;
            this.uxAptDateLabel.Location = new System.Drawing.Point(211, 14);
            this.uxAptDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAptDateLabel.Name = "uxAptDateLabel";
            this.uxAptDateLabel.Size = new System.Drawing.Size(92, 13);
            this.uxAptDateLabel.TabIndex = 8;
            this.uxAptDateLabel.Text = "Appointment Date";
            // 
            // uxAptOwnerEmailTB
            // 
            this.uxAptOwnerEmailTB.Location = new System.Drawing.Point(85, 37);
            this.uxAptOwnerEmailTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAptOwnerEmailTB.Name = "uxAptOwnerEmailTB";
            this.uxAptOwnerEmailTB.Size = new System.Drawing.Size(68, 20);
            this.uxAptOwnerEmailTB.TabIndex = 7;
            // 
            // uxAptVetCB
            // 
            this.uxAptVetCB.FormattingEnabled = true;
            this.uxAptVetCB.Location = new System.Drawing.Point(43, 58);
            this.uxAptVetCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAptVetCB.Name = "uxAptVetCB";
            this.uxAptVetCB.Size = new System.Drawing.Size(82, 21);
            this.uxAptVetCB.TabIndex = 6;
            // 
            // uxAptVetLabel
            // 
            this.uxAptVetLabel.AutoSize = true;
            this.uxAptVetLabel.Location = new System.Drawing.Point(16, 60);
            this.uxAptVetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAptVetLabel.Name = "uxAptVetLabel";
            this.uxAptVetLabel.Size = new System.Drawing.Size(23, 13);
            this.uxAptVetLabel.TabIndex = 5;
            this.uxAptVetLabel.Text = "Vet";
            // 
            // uxAptOwnerEmailLabel
            // 
            this.uxAptOwnerEmailLabel.AutoSize = true;
            this.uxAptOwnerEmailLabel.Location = new System.Drawing.Point(14, 39);
            this.uxAptOwnerEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAptOwnerEmailLabel.Name = "uxAptOwnerEmailLabel";
            this.uxAptOwnerEmailLabel.Size = new System.Drawing.Size(66, 13);
            this.uxAptOwnerEmailLabel.TabIndex = 3;
            this.uxAptOwnerEmailLabel.Text = "Owner Email";
            // 
            // uxAptPetNameLabel
            // 
            this.uxAptPetNameLabel.AutoSize = true;
            this.uxAptPetNameLabel.Location = new System.Drawing.Point(14, 19);
            this.uxAptPetNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAptPetNameLabel.Name = "uxAptPetNameLabel";
            this.uxAptPetNameLabel.Size = new System.Drawing.Size(54, 13);
            this.uxAptPetNameLabel.TabIndex = 1;
            this.uxAptPetNameLabel.Text = "Pet Name";
            // 
            // uxAptPetNameTB
            // 
            this.uxAptPetNameTB.Location = new System.Drawing.Point(71, 16);
            this.uxAptPetNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAptPetNameTB.Name = "uxAptPetNameTB";
            this.uxAptPetNameTB.Size = new System.Drawing.Size(68, 20);
            this.uxAptPetNameTB.TabIndex = 0;
            // 
            // uxAddVetControls
            // 
            this.uxAddVetControls.Controls.Add(this.uxVetSubmitButton);
            this.uxAddVetControls.Controls.Add(this.uxVetLastNameTB);
            this.uxAddVetControls.Controls.Add(this.uxVetLastNameLabel);
            this.uxAddVetControls.Controls.Add(this.uxVetFirstNameLabel);
            this.uxAddVetControls.Controls.Add(this.uxVetFirstNameTB);
            this.uxAddVetControls.Location = new System.Drawing.Point(2, 24);
            this.uxAddVetControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAddVetControls.Name = "uxAddVetControls";
            this.uxAddVetControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAddVetControls.Size = new System.Drawing.Size(573, 263);
            this.uxAddVetControls.TabIndex = 14;
            this.uxAddVetControls.TabStop = false;
            this.uxAddVetControls.Text = "Add Vet";
            this.uxAddVetControls.Visible = false;
            // 
            // uxVetSubmitButton
            // 
            this.uxVetSubmitButton.Location = new System.Drawing.Point(18, 85);
            this.uxVetSubmitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxVetSubmitButton.Name = "uxVetSubmitButton";
            this.uxVetSubmitButton.Size = new System.Drawing.Size(76, 27);
            this.uxVetSubmitButton.TabIndex = 11;
            this.uxVetSubmitButton.Text = "Submit";
            this.uxVetSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxVetLastNameTB
            // 
            this.uxVetLastNameTB.Location = new System.Drawing.Point(71, 37);
            this.uxVetLastNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxVetLastNameTB.Name = "uxVetLastNameTB";
            this.uxVetLastNameTB.Size = new System.Drawing.Size(68, 20);
            this.uxVetLastNameTB.TabIndex = 7;
            // 
            // uxVetLastNameLabel
            // 
            this.uxVetLastNameLabel.AutoSize = true;
            this.uxVetLastNameLabel.Location = new System.Drawing.Point(14, 39);
            this.uxVetLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxVetLastNameLabel.Name = "uxVetLastNameLabel";
            this.uxVetLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.uxVetLastNameLabel.TabIndex = 3;
            this.uxVetLastNameLabel.Text = "Last Name";
            // 
            // uxVetFirstNameLabel
            // 
            this.uxVetFirstNameLabel.AutoSize = true;
            this.uxVetFirstNameLabel.Location = new System.Drawing.Point(14, 19);
            this.uxVetFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxVetFirstNameLabel.Name = "uxVetFirstNameLabel";
            this.uxVetFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.uxVetFirstNameLabel.TabIndex = 1;
            this.uxVetFirstNameLabel.Text = "First Name";
            // 
            // uxVetFirstNameTB
            // 
            this.uxVetFirstNameTB.Location = new System.Drawing.Point(71, 16);
            this.uxVetFirstNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxVetFirstNameTB.Name = "uxVetFirstNameTB";
            this.uxVetFirstNameTB.Size = new System.Drawing.Size(68, 20);
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
            this.uxPrescribeMedsControls.Location = new System.Drawing.Point(2, 24);
            this.uxPrescribeMedsControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPrescribeMedsControls.Name = "uxPrescribeMedsControls";
            this.uxPrescribeMedsControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPrescribeMedsControls.Size = new System.Drawing.Size(573, 263);
            this.uxPrescribeMedsControls.TabIndex = 15;
            this.uxPrescribeMedsControls.TabStop = false;
            this.uxPrescribeMedsControls.Text = "Prescribe Medication";
            this.uxPrescribeMedsControls.Visible = false;
            // 
            // uxMedsSubmitButton
            // 
            this.uxMedsSubmitButton.Location = new System.Drawing.Point(18, 159);
            this.uxMedsSubmitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMedsSubmitButton.Name = "uxMedsSubmitButton";
            this.uxMedsSubmitButton.Size = new System.Drawing.Size(76, 27);
            this.uxMedsSubmitButton.TabIndex = 10;
            this.uxMedsSubmitButton.Text = "Submit";
            this.uxMedsSubmitButton.UseVisualStyleBackColor = true;
            // 
            // uxMedsMedicationCB
            // 
            this.uxMedsMedicationCB.FormattingEnabled = true;
            this.uxMedsMedicationCB.Location = new System.Drawing.Point(77, 57);
            this.uxMedsMedicationCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMedsMedicationCB.Name = "uxMedsMedicationCB";
            this.uxMedsMedicationCB.Size = new System.Drawing.Size(82, 21);
            this.uxMedsMedicationCB.TabIndex = 9;
            // 
            // uxMedsMedicationLabel
            // 
            this.uxMedsMedicationLabel.AutoSize = true;
            this.uxMedsMedicationLabel.Location = new System.Drawing.Point(15, 58);
            this.uxMedsMedicationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxMedsMedicationLabel.Name = "uxMedsMedicationLabel";
            this.uxMedsMedicationLabel.Size = new System.Drawing.Size(59, 13);
            this.uxMedsMedicationLabel.TabIndex = 8;
            this.uxMedsMedicationLabel.Text = "Medication";
            // 
            // uxMedsOwnerEmailTB
            // 
            this.uxMedsOwnerEmailTB.Location = new System.Drawing.Point(83, 36);
            this.uxMedsOwnerEmailTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMedsOwnerEmailTB.Name = "uxMedsOwnerEmailTB";
            this.uxMedsOwnerEmailTB.Size = new System.Drawing.Size(107, 20);
            this.uxMedsOwnerEmailTB.TabIndex = 7;
            // 
            // uxMedsOwnerEmailLabel
            // 
            this.uxMedsOwnerEmailLabel.AutoSize = true;
            this.uxMedsOwnerEmailLabel.Location = new System.Drawing.Point(14, 38);
            this.uxMedsOwnerEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxMedsOwnerEmailLabel.Name = "uxMedsOwnerEmailLabel";
            this.uxMedsOwnerEmailLabel.Size = new System.Drawing.Size(66, 13);
            this.uxMedsOwnerEmailLabel.TabIndex = 3;
            this.uxMedsOwnerEmailLabel.Text = "Owner Email";
            // 
            // uxMedsPetNameLabel
            // 
            this.uxMedsPetNameLabel.AutoSize = true;
            this.uxMedsPetNameLabel.Location = new System.Drawing.Point(14, 19);
            this.uxMedsPetNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxMedsPetNameLabel.Name = "uxMedsPetNameLabel";
            this.uxMedsPetNameLabel.Size = new System.Drawing.Size(54, 13);
            this.uxMedsPetNameLabel.TabIndex = 1;
            this.uxMedsPetNameLabel.Text = "Pet Name";
            // 
            // uxMedsPetNameTB
            // 
            this.uxMedsPetNameTB.Location = new System.Drawing.Point(71, 16);
            this.uxMedsPetNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMedsPetNameTB.Name = "uxMedsPetNameTB";
            this.uxMedsPetNameTB.Size = new System.Drawing.Size(68, 20);
            this.uxMedsPetNameTB.TabIndex = 0;
            // 
            // uxSearchTB
            // 
            this.uxSearchTB.Location = new System.Drawing.Point(16, 16);
            this.uxSearchTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchTB.Name = "uxSearchTB";
            this.uxSearchTB.Size = new System.Drawing.Size(175, 20);
            this.uxSearchTB.TabIndex = 0;
            // 
            // uxSearchControls
            // 
            this.uxSearchControls.Controls.Add(this.uxSearchVetsButton);
            this.uxSearchControls.Controls.Add(this.uxSearchOwnersButton);
            this.uxSearchControls.Controls.Add(this.uxSearchPetsButton);
            this.uxSearchControls.Controls.Add(this.uxSearchListBox);
            this.uxSearchControls.Controls.Add(this.uxSearchTB);
            this.uxSearchControls.Location = new System.Drawing.Point(1, 24);
            this.uxSearchControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchControls.Name = "uxSearchControls";
            this.uxSearchControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchControls.Size = new System.Drawing.Size(573, 263);
            this.uxSearchControls.TabIndex = 16;
            this.uxSearchControls.TabStop = false;
            this.uxSearchControls.Text = "Search";
            this.uxSearchControls.Visible = false;
            // 
            // uxSearchVetsButton
            // 
            this.uxSearchVetsButton.Location = new System.Drawing.Point(371, 15);
            this.uxSearchVetsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchVetsButton.Name = "uxSearchVetsButton";
            this.uxSearchVetsButton.Size = new System.Drawing.Size(85, 20);
            this.uxSearchVetsButton.TabIndex = 4;
            this.uxSearchVetsButton.Text = "Search Vets";
            this.uxSearchVetsButton.UseVisualStyleBackColor = true;
            // 
            // uxSearchOwnersButton
            // 
            this.uxSearchOwnersButton.Location = new System.Drawing.Point(282, 14);
            this.uxSearchOwnersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchOwnersButton.Name = "uxSearchOwnersButton";
            this.uxSearchOwnersButton.Size = new System.Drawing.Size(85, 20);
            this.uxSearchOwnersButton.TabIndex = 3;
            this.uxSearchOwnersButton.Text = "Search Owners";
            this.uxSearchOwnersButton.UseVisualStyleBackColor = true;
            // 
            // uxSearchPetsButton
            // 
            this.uxSearchPetsButton.Location = new System.Drawing.Point(193, 14);
            this.uxSearchPetsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchPetsButton.Name = "uxSearchPetsButton";
            this.uxSearchPetsButton.Size = new System.Drawing.Size(85, 20);
            this.uxSearchPetsButton.TabIndex = 2;
            this.uxSearchPetsButton.Text = "Search Pets";
            this.uxSearchPetsButton.UseVisualStyleBackColor = true;
            // 
            // uxSearchListBox
            // 
            this.uxSearchListBox.FormattingEnabled = true;
            this.uxSearchListBox.Location = new System.Drawing.Point(14, 39);
            this.uxSearchListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchListBox.Name = "uxSearchListBox";
            this.uxSearchListBox.Size = new System.Drawing.Size(205, 212);
            this.uxSearchListBox.TabIndex = 1;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.uxAddPetControls);
            this.Controls.Add(this.uxSearchControls);
            this.Controls.Add(this.uxPrescribeMedsControls);
            this.Controls.Add(this.uxAddVetControls);
            this.Controls.Add(this.uxCreateAptControls);
            this.Controls.Add(this.uxQueryControls);
            this.Controls.Add(this.uxConnectDB);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
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
            this.uxSearchControls.ResumeLayout(false);
            this.uxSearchControls.PerformLayout();
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
        private System.Windows.Forms.TextBox uxSearchTB;
        private System.Windows.Forms.GroupBox uxSearchControls;
        private System.Windows.Forms.Button uxSearchVetsButton;
        private System.Windows.Forms.Button uxSearchOwnersButton;
        private System.Windows.Forms.Button uxSearchPetsButton;
        private System.Windows.Forms.ListBox uxSearchListBox;
    }
}

