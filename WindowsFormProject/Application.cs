using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormProject.Database_Objects;
using System.Configuration;

namespace WindowsFormProject
{
    public partial class Application : Form
    {
        private List<Medications> _medications;
        private List<Breed> _breeds;
        private List<Species> _species;
        private List<string> _queries;
        private SqlConnection _sqlClient;
        private List<Vets> _vets;

        public Application()
        {
            InitializeComponent(); uxConnectDB_Click(null, null);
            GetMedications();
            GetSpecies();
            GetVetsAndTimes();
            FillAggregatedQueries();
        }

        #region Get functions and Connect DB

        private void GetVetsAndTimes()
        {
            //get vets
            uxAptVetCB.Items.Clear();
            SqlCommand cmnd = new SqlCommand("SelectVet", _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@Search", SqlDbType.NVarChar).Value = "";
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                List<Vets> list = new List<Vets>();
                while(data.Read() != false)
                {
                    list.Add(new Vets { VetID = data.GetFieldValue<int>(0), FirstName = data.GetFieldValue<string>(1), LastName = data.GetFieldValue<string>(2), HireDate = data.GetFieldValue<DateTime>(3) });
                }
                _vets = list;
            }
            uxAptVetCB.Items.AddRange(_vets.ToArray());

            //AddTimes
            DateTime time = DateTime.Today.AddHours(8); //8:00 am
            while(time <= DateTime.Today.AddHours(17)) //5 pm (17:00)
            {
                uxAptAptTimeCB.Items.Add(time.TimeOfDay.ToString(@"hh\:mm"));
                time = time.AddMinutes(30);
            }
        }
        private void FillAggregatedQueries()
        {
            List<string> queryList = new List<string>() { "CommonMedicationByBreed", "CommonNamesByBreed", "MonthlyAppointmentsByVet", "QuarterlyAppointments" };
            _queries = queryList;
            uxQuerySelectQueryCB.Items.AddRange(_queries.ToArray());
        }

        private void GetMedications()
        {
            uxMedsMedicationCB.Items.Clear();
            SqlCommand cmnd = new SqlCommand("SelectMedication", _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@MedicationName", SqlDbType.NVarChar).Value = "";
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                List<Medications> list = new List<Medications>();
                while(data.Read() != false)
                {
      
                    list.Add(new Medications { MedicationID = data.GetFieldValue<int>(0), MedicationName = data.GetFieldValue<string>(1), Purpose= data.GetFieldValue<string>(2) });
                    
                }
                _medications = list;
            }
            uxMedsMedicationCB.Items.AddRange(_medications.ToArray());
        }

        private void GetBreeds(int SpeciesID)
        {
            uxPetBreedCB.Items.Clear();
            SqlCommand cmnd = new SqlCommand("SelectBreed", _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@BreedName", SqlDbType.NVarChar).Value = "";
            cmnd.Parameters.AddWithValue("@SpeciesID", SqlDbType.Int).Value = SpeciesID;
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                List<Breed> list = new List<Breed>();
                while (data.Read() != false)
                {
                    list.Add(new Breed { BreedID = data.GetFieldValue<int>(0), BreedName = data.GetFieldValue<string>(2), SpeciesID = data.GetFieldValue<int>(1) });
                }
                _breeds = list;
            }
            uxPetBreedCB.Items.AddRange(_breeds.ToArray());
       
        }

        private void GetSpecies()
        {
            uxPetSpeciesCB.Items.Clear();
            SqlCommand cmnd = new SqlCommand("SelectSpecies", _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@SpeciesName", SqlDbType.NVarChar).Value = "";
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                List<Species> list = new List<Species>();
                while (data.Read() != false)
                {
                    list.Add(new Species { SpeciesID = (int)data[0], SpeciesName=(string)data[1]});
                }
                _species = list;
            }
            uxPetSpeciesCB.Items.AddRange(_species.ToArray());
        }

        private void uxConnectDB_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationSettings.AppSettings["databaseConnection"];

            _sqlClient = new SqlConnection(connectionString);

            try
            {
                _sqlClient.Open();
                MessageBox.Show("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Control view code
        /// <summary>
        /// switches control view to add pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMenuAddPet_Click(object sender, EventArgs e)
        {
            uxAddPetControls.Visible = true;
            uxCreateAptControls.Visible = false;
            uxQueryControls.Visible = false;
            uxAddVetControls.Visible = false;
            uxPrescribeMedsControls.Visible = false;
            uxSearchControls.Visible = false;
        }

        /// <summary>
        /// Switches control view to create an appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMenuCreateApt_Click(object sender, EventArgs e)
        {

            uxCreateAptControls.Visible = true;
            uxAddPetControls.Visible = false;
            uxQueryControls.Visible = false;
            uxAddVetControls.Visible = false;
            uxPrescribeMedsControls.Visible = false;
            uxSearchControls.Visible = false;
        }

        /// <summary>
        /// switches control view to view queries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMenuViewQueries_Click(object sender, EventArgs e)
        {
            uxQueryControls.Visible = true;
            uxAddPetControls.Visible = false;
            uxCreateAptControls.Visible = false;
            uxAddVetControls.Visible = false;
            uxPrescribeMedsControls.Visible = false;
            uxSearchControls.Visible = false;
        }

        /// <summary>
        /// switches control view to add vet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addVetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxAddVetControls.Visible = true;
            uxQueryControls.Visible = false;
            uxAddPetControls.Visible = false;
            uxCreateAptControls.Visible = false;
            uxPrescribeMedsControls.Visible = false;
            uxSearchControls.Visible = false;
        }

        /// <summary>
        /// switches control view to prescribe medication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prescribeMedicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxPrescribeMedsControls.Visible = true;
            uxQueryControls.Visible = false;
            uxAddPetControls.Visible = false;
            uxCreateAptControls.Visible = false;
            uxAddVetControls.Visible = false;
            uxSearchControls.Visible = false;
        }

        /// <summary>
        /// switches control view to search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxSearchControls.Visible = true;
            uxAddPetControls.Visible = false;
            uxCreateAptControls.Visible = false;
            uxQueryControls.Visible = false;
            uxAddVetControls.Visible = false;
            uxPrescribeMedsControls.Visible = false;
        }
        #endregion

        #region Search functions
        /// <summary>
        /// Search control search pet button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchPetsButton_Click(object sender, EventArgs e)
        {
            //Search pets
            SqlCommand cmnd = new SqlCommand("SelectPet", _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@PetName", SqlDbType.NVarChar).Value = uxSearchTB.Text;
            
            //Populate listbox
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                List<Pets> list = new List<Pets>();
                while (data.Read() != false)
                {

                    list.Add(new Pets { PetID = data.GetFieldValue<int>(0), OwnerID = data.GetFieldValue<int>(1), BreedID = data.GetFieldValue<int>(2), 
                        PetFirstName = data.GetFieldValue<string>(3), PetLastName = data.GetFieldValue<string>(4), 
                        Description = data.GetFieldValue<string>(5) });

                }
                uxSearchListBox.DataSource = list;
                if (list.Count >= 1) uxSearchEditButton.Visible = true;
            }
            
        }

        /// <summary>
        /// search control search owner button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchOwnersButton_Click(object sender, EventArgs e)
        {
            //search Owners
            SqlCommand cmnd = new SqlCommand("SelectOwner", _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@Search", SqlDbType.NVarChar).Value = uxSearchTB.Text;

            //Populate listbox
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                List<Owners> list = new List<Owners>();
                while (data.Read() != false)
                {

                    list.Add(new Owners { OwnerID = data.GetFieldValue<int>(0), FirstName = data.GetFieldValue<string>(1), LastName = data.GetFieldValue<string>(2), EMail = data.GetFieldValue<string>(3) });

                }
                uxSearchListBox.DataSource = list;
                if (list.Count >= 1) uxSearchEditButton.Visible = true;
            }

        }

        /// <summary>
        /// search control search vet button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchVetsButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmnd = new SqlCommand("SelectVet", _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@Search", SqlDbType.NVarChar).Value = uxSearchTB.Text;

            //Populate listbox
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                List<Vets> list = new List<Vets>();
                while (data.Read() != false)
                {

                    list.Add(new Vets { VetID = data.GetFieldValue<int>(0), FirstName = data.GetFieldValue<string>(1), LastName = data.GetFieldValue<string>(2), HireDate = data.GetFieldValue<DateTime>(3) });

                }
                uxSearchListBox.DataSource = list;
                if (list.Count >= 1) uxSearchEditButton.Visible = true;
            }
            
        }

        /// <summary>
        /// Edit search index button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchEditButton_Click(object sender, EventArgs e)
        {
            // pops out selected index info in the correct form for editing
            if (uxSearchListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select something.");
            }
            else
            {
                //pets
                if (uxSearchListBox.SelectedItem is Pets pet)
                {
                    EditPetForm form = new EditPetForm(pet, _species, _sqlClient);
                    form.Show();
                }
                //vets
                else if (uxSearchListBox.SelectedItem is Vets vet)
                {
                    EditVetForm form = new EditVetForm(vet, _sqlClient);
                    form.Show();
                }
                //owners
                else if (uxSearchListBox.SelectedItem is Owners owner)
                {
                    EditOwnerForm form = new EditOwnerForm(owner, _sqlClient);
                    form.Show();
                }
            }
        }
        #endregion

        /// <summary>
        /// Index changed on the Species ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPetSpeciesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxPetSpeciesCB.SelectedItem is Species item)
            {
                GetBreeds(item.SpeciesID);
            }
        }

        #region Submit button functions
        /// <summary>
        /// Event handler for Adding Pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPCSubmitButton_Click(object sender, EventArgs e)
        {
            // Check that each text box is filled
            foreach (TextBox tb in uxAddPetControls.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            // Check that each combo box has a selection
            foreach (ComboBox cb in uxAddPetControls.Controls.OfType<ComboBox>())
            {
                if (cb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            // Run Sql stored procedure
            try
            {
                SqlCommand cmnd = new SqlCommand("InsertPet", _sqlClient);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.Parameters.AddWithValue("@OwnerFirstName", SqlDbType.NVarChar).Value = uxPCOwnerFirstNameTB.Text;
                cmnd.Parameters.AddWithValue("@OwnerLastName", SqlDbType.NVarChar).Value = uxPCOwnerLastNameTB.Text;
                cmnd.Parameters.AddWithValue("@OwnerEMail", SqlDbType.NVarChar).Value = uxPCOwnerEmailTB.Text;

                cmnd.Parameters.AddWithValue("@PetFirstName", SqlDbType.NVarChar).Value = uxPCPetFirstNameTB.Text;
                cmnd.Parameters.AddWithValue("@PetLastName", SqlDbType.NVarChar).Value = uxPCPetLastNameTB.Text;
                cmnd.Parameters.AddWithValue("@PetSpecies", SqlDbType.NVarChar).Value = uxPetSpeciesCB.SelectedItem.ToString();
                cmnd.Parameters.AddWithValue("@PetBreed", SqlDbType.NVarChar).Value = uxPetBreedCB.SelectedItem.ToString();
                cmnd.Parameters.AddWithValue("@PetDescription", SqlDbType.NVarChar).Value = uxPCPetDescriptionTB.Text;

                int n = cmnd.ExecuteNonQuery();

                MessageBox.Show($"{uxPCPetFirstNameTB.Text} {uxPCPetLastNameTB.Text} added successfully");
                ClearForm();
                
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        /// <summary>
        /// Event Handler for Adding Vet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxVetSubmitButton_Click(object sender, EventArgs e)
        {
            // Check that each text box is filled
            foreach (TextBox tb in uxAddVetControls.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            // Run Sql stored procedure
            try
            {
                SqlCommand cmnd = new SqlCommand("InsertVet", _sqlClient);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.Parameters.AddWithValue("@VetFirstName", SqlDbType.NVarChar).Value = uxVetFirstNameTB.Text;
                cmnd.Parameters.AddWithValue("@VetLastName", SqlDbType.NVarChar).Value = uxVetLastNameTB.Text;

                cmnd.ExecuteNonQuery();
                GetVetsAndTimes();

                MessageBox.Show($"{uxVetFirstNameTB.Text} {uxVetLastNameTB.Text} added successfully");
                ClearForm();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        /// <summary>
        /// Event handler Create Appointment button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAptSubmitButton_Click(object sender, EventArgs e)
        {
            // Check that each text box is filled
            foreach (TextBox tb in uxCreateAptControls.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            // Check that each combo box has a selection
            foreach (ComboBox cb in uxCreateAptControls.Controls.OfType<ComboBox>())
            {
                if (cb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            // Check that each datetimepicker has a selection
            foreach (DateTimePicker dtp in uxCreateAptControls.Controls.OfType<DateTimePicker>())
            {
                if (string.IsNullOrEmpty(dtp.Text))
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            try
            {
                SqlCommand cmnd = new SqlCommand("InsertAppointment", _sqlClient);
                cmnd.CommandType = CommandType.StoredProcedure;
                string[] nameSplit = uxAptPetNameTB.Text.Split(' ');
                if (nameSplit.Length != 2) throw new Exception("Please enter first and last name of pet");
                Vets vet = uxAptVetCB.SelectedItem as Vets;
                cmnd.Parameters.AddWithValue("@PetFirstName", SqlDbType.NVarChar).Value = nameSplit[0];
                cmnd.Parameters.AddWithValue("@PetLastName", SqlDbType.NVarChar).Value = nameSplit[1];
                cmnd.Parameters.AddWithValue("@OwnerEMail", SqlDbType.NVarChar).Value = uxAptOwnerEmailTB.Text;
                cmnd.Parameters.AddWithValue("@VetID", SqlDbType.Int).Value = vet.VetID;
                cmnd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = DateTime.Parse(uxAptDatePicker.Text);
                cmnd.Parameters.AddWithValue("@Time", SqlDbType.DateTime).Value = DateTime.Parse(uxAptAptTimeCB.SelectedItem.ToString());
                cmnd.Parameters.AddWithValue("@Reason", SqlDbType.NVarChar).Value = uxAptReasonTB.Text;

                cmnd.ExecuteNonQuery();

                MessageBox.Show($"Appointment successfully created for {nameSplit[0]} {nameSplit[1]} for {uxAptDatePicker.Text} at {uxAptAptTimeCB.SelectedItem}");
                ClearForm();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>
        /// Insert medication submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMedsSubmitButton_Click(object sender, EventArgs e)
        {
            // Check that each text box is filled
            foreach (TextBox tb in uxPrescribeMedsControls.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            // Check that each combo box has a selection
            foreach (ComboBox cb in uxPrescribeMedsControls.Controls.OfType<ComboBox>())
            {
                if (cb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all information.");
                    return;
                }
            }

            try
            {
                SqlCommand cmnd = new SqlCommand("InsertPetMed", _sqlClient);
                cmnd.CommandType = CommandType.StoredProcedure;
                string[] nameSplit = uxMedsPetNameTB.Text.Split(' ');
                if (nameSplit.Length != 2) throw new Exception("Please enter first and last name of pet");
                Medications medication = uxMedsMedicationCB.SelectedItem as Medications;
                cmnd.Parameters.AddWithValue("@PetFirstName", SqlDbType.NVarChar).Value = nameSplit[0];
                cmnd.Parameters.AddWithValue("@PetLastName", SqlDbType.NVarChar).Value = nameSplit[1];
                cmnd.Parameters.AddWithValue("@OwnerEMail", SqlDbType.NVarChar).Value = uxMedsOwnerEmailTB.Text;
                cmnd.Parameters.AddWithValue("@MedicationID", SqlDbType.Int).Value = medication.MedicationID;
                cmnd.Parameters.AddWithValue("@Instructions", SqlDbType.NVarChar).Value = uxMedsInstructionsTB.Text;

                cmnd.ExecuteNonQuery();

                MessageBox.Show($"{uxMedsPetNameTB.Text} has been prescribed {medication.MedicationName}");
                ClearForm();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>
        /// Clears form
        /// </summary>
        private void ClearForm()
        {
            //AddPetControls
            foreach (TextBox tb in uxAddPetControls.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            foreach (ComboBox cb in uxAddPetControls.Controls.OfType<ComboBox>())
            {
                cb.SelectedIndex = -1;
            }

            //AddVetControls
            foreach (TextBox tb in uxAddVetControls.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }

            //CreateAptControls
            foreach (TextBox tb in uxCreateAptControls.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            foreach (ComboBox cb in uxCreateAptControls.Controls.OfType<ComboBox>())
            {
                cb.SelectedIndex = -1;
            }

            //PrescribeMedsControls
            foreach (TextBox tb in uxPrescribeMedsControls.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            foreach (ComboBox cb in uxPrescribeMedsControls.Controls.OfType<ComboBox>())
            {
                cb.SelectedIndex = -1;
            }

        }

        private void OpenDataTable(string procedureName)
        {
            DataTable dt = new DataTable();

            SqlCommand cmnd = new SqlCommand(procedureName, _sqlClient);
            cmnd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmnd);
            dataAdapter.Fill(dt);

            DataPopup window = new DataPopup();
            window.uxDataGrid.DataSource = dt;
            window.Show();
        }

        private void uxQuerySelectQueryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryName = uxQuerySelectQueryCB.SelectedItem as string;
            OpenDataTable(queryName);
        }
        #endregion
    }
}
