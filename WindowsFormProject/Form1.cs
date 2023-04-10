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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
