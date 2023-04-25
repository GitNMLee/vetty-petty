﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using WindowsFormProject.Database_Objects;

namespace WindowsFormProject
{
    public partial class Application : Form
    {
        private SqlConnection _sqlClient;
        public Application()
        {
            InitializeComponent();
        }

        private void uxConnectDB_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=nmlee;Persist Security Info=True;User ID=nmlee;Password=4e0Ytfa1!rBna6v;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

            using (_sqlClient = new SqlConnection(connectionString))
            {
                try
                {
                    _sqlClient.Open();
                    SqlCommand cmnd = new SqlCommand("SelectSpecies", _sqlClient);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@SpeciesName", SqlDbType.NVarChar).Value = "";
                    SqlDataReader data = cmnd.ExecuteReader();
                    List<Species> list = new List<Species>(data.Cast<Species>());
                    MessageBox.Show("Stored procedure successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
    }
}
