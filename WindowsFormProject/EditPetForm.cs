using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormProject.Database_Objects;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormProject
{
    public partial class EditPetForm : Form
    {
        private SqlConnection _connection;
        private Pets _pet;
        private List<Species> _species;
        private List<Breed> _breeds;
        public EditPetForm(Pets pet, List<Species> species, SqlConnection sqlConnection)
        {
            InitializeComponent();
            _connection = sqlConnection;
            _pet = pet;
            _species = species;
            uxEPFirstNameTB.Text = _pet.PetFirstName;
            uxEPLastNameTB.Text = _pet.PetLastName;
            //populate species box
            uxEPPetSpeciesCB.Items.AddRange(_species.ToArray());
            PopulateComboBoxes();
            uxEPPetDescTB.Text = _pet.Description;
        }

        /// <summary>
        /// kills pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEPKillPetButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmnd = new SqlCommand("KillPet", _connection);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@PetFirstname", SqlDbType.NVarChar).Value = _pet.PetFirstName;
            cmnd.Parameters.AddWithValue("@PetLastname", SqlDbType.NVarChar).Value = _pet.PetLastName;
            cmnd.Parameters.AddWithValue("@OwnerID", SqlDbType.Int).Value = _pet.OwnerID;

            cmnd.ExecuteNonQuery();

            MessageBox.Show($"RIP {_pet.PetFirstName} :(");
            this.Close();
        }

        /// <summary>
        /// Populates the species Combobox by calling GetBreeds
        /// </summary>
        private void PopulateComboBoxes()
        {
            SqlCommand cmnd = new SqlCommand("SelectSpeciesWithBreed", _connection);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@BreedID", SqlDbType.Int).Value = _pet.BreedID;
            Species currentSpecies;
            using (SqlDataReader data = cmnd.ExecuteReader())
            {
                data.Read();
                currentSpecies = new Species { SpeciesID = data.GetFieldValue<int>(0), SpeciesName = data.GetFieldValue<string>(1) };
                // sets current index
                for(int i = 0; i < _species.Count; i++)
                {
                    if (_species[i].SpeciesName == currentSpecies.SpeciesName) uxEPPetSpeciesCB.SelectedIndex = i;
                }
            }
            //sets breed combo box
            GetBreeds(currentSpecies.SpeciesID);
        }

        /// <summary>
        /// populates breed combo box 
        /// </summary>
        /// <param name="SpeciesID"></param>
        private void GetBreeds(int SpeciesID)
        {
            uxEPPetBreedCB.Items.Clear();
            SqlCommand cmnd = new SqlCommand("SelectBreed", _connection);
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
            uxEPPetBreedCB.Items.AddRange(_breeds.ToArray());
            for (int i = 0; i < _breeds.Count; i++)
            {
                if (_breeds[i].BreedID == _pet.BreedID) uxEPPetBreedCB.SelectedIndex = i;
            }

        }

        private void uxEPSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
