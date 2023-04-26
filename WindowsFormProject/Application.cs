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
        private SqlConnection _sqlClient;

        public Application()
        {
            InitializeComponent(); uxConnectDB_Click(null, null);
            GetMedications();
            GetSpecies();
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

                cmnd.ExecuteNonQuery();
                //SqlDataReader test = cmnd.ExecuteReader();
                //List<Vets> testList = new List<Vets>(test.Cast<Vets>());
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        /// <summary>
        /// Search control search pet button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchPetsButton_Click(object sender, EventArgs e)
        {
            //if search box has terms
            if (!String.IsNullOrEmpty(uxSearchTB.Text))
            {
                SqlCommand cmnd = new SqlCommand("SelectPet", _sqlClient);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.Parameters.AddWithValue("@PetName", SqlDbType.NVarChar).Value = uxSearchTB.Text;

                cmnd.ExecuteNonQuery();
                
                using (SqlDataReader data = cmnd.ExecuteReader())
                {
                    List<Pets> list = new List<Pets>();
                    while (data.Read() != false)
                    {

                        list.Add(new Pets { PetID = data.GetFieldValue<int>(0), PetFirstName = data.GetFieldValue<string>(1), PetLastName = data.GetFieldValue<string>(2) });

                    }
                    uxSearchListBox.DataSource = list;
                }
            }
        }

        /// <summary>
        /// search control search owner button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchOwnersButton_Click(object sender, EventArgs e)
        {
            //if search box has terms
            if (!String.IsNullOrEmpty(uxSearchTB.Text))
            {
                SqlCommand cmnd = new SqlCommand("SelectOwner", _sqlClient);
                cmnd.CommandType = CommandType.StoredProcedure;
                cmnd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = uxSearchTB.Text;

                cmnd.ExecuteNonQuery();
                //test listbox
                /*using(SqlDataReader test = cmnd.ExecuteReader())
                {
                    uxSearchListBox.DataSource = test;
                }*/
            }
        }

        /// <summary>
        /// search control search vet button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchVetsButton_Click(object sender, EventArgs e)
        {
            //if search box has terms
            if (!String.IsNullOrEmpty(uxSearchTB.Text))
            {
                string[] terms = uxSearchTB.Text.Split(' ');
                SqlCommand cmnd = new SqlCommand("SelectVet", _sqlClient);
                cmnd.CommandType = CommandType.StoredProcedure;
                if(terms.Length == 1)
                {
                    cmnd.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = terms[0];
                    cmnd.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = terms[0];
                }
                else
                {
                    cmnd.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = terms[0];
                    cmnd.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = terms[1];
                }
                

                cmnd.ExecuteNonQuery();
                //test listbox
                /*using(SqlDataReader test = cmnd.ExecuteReader())
                {
                    uxSearchListBox.DataSource = test;
                }*/
            }
        }

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
    }
}
