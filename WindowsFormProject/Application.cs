using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormProject
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void uxConnectDB_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=msbuchanan;User Id=msbuchanan;Password=JAs-tNh-5V8-uU4";

            using (SqlConnection sqlClient = new SqlConnection(connectionString))
            {
                try
                {
                    sqlClient.Open();
                    SqlCommand cmnd = new SqlCommand("PROCEDURE NAME", sqlClient);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("@TEST_PARAM", SqlDbType.NVarChar).Value = "Test Value";
                    cmnd.ExecuteNonQuery();
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
            uxKillPetControls.Visible = false;
            uxFireVetControls.Visible = false;
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
            uxKillPetControls.Visible = false;
            uxFireVetControls.Visible = false;
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
            uxPrescribeMedsControls.Visible = false; uxKillPetControls.Visible = false;
            uxFireVetControls.Visible = false;
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
            uxKillPetControls.Visible = false;
            uxFireVetControls.Visible = false;
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
            uxKillPetControls.Visible = false;
            uxFireVetControls.Visible = false;
        }

        /// <summary>
        /// switches control view to kill pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void killPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxKillPetControls.Visible = true;
            uxAddPetControls.Visible = false;
            uxCreateAptControls.Visible = false;
            uxQueryControls.Visible = false;
            uxAddVetControls.Visible = false;
            uxPrescribeMedsControls.Visible = false;
            uxFireVetControls.Visible = false;
        }

        /// <summary>
        /// switches control view to fire vet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fireVetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxFireVetControls.Visible = true;
            uxAddPetControls.Visible = false;
            uxCreateAptControls.Visible = false;
            uxQueryControls.Visible = false;
            uxAddVetControls.Visible = false;
            uxPrescribeMedsControls.Visible = false;
            uxKillPetControls.Visible = false;
        }
    }
}
