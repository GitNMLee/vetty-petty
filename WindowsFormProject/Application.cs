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
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

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
        }
    }
}
