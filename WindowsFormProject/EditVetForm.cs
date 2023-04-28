using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormProject.Database_Objects;

namespace WindowsFormProject
{
    public partial class EditVetForm : Form
    {
        private SqlConnection _connection;
        private Vets _vet;
        public EditVetForm(Vets vet, SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _vet = vet;
            uxEVFirstNameTB.Text = _vet.FirstName;
            uxEVLastNameTB.Text = _vet.LastName;
            uxEVHireDateTB.Text = _vet.HireDate.ToString();
        }

        /// <summary>
        /// Fires Vet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEVFireButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmnd = new SqlCommand("FireVet", _connection);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@VetFirstname", SqlDbType.NVarChar).Value = _vet.FirstName;
            cmnd.Parameters.AddWithValue("@VetLastname", SqlDbType.NVarChar).Value = _vet.LastName;

            cmnd.ExecuteNonQuery();

            MessageBox.Show($"Sayonara {_vet.FirstName} {_vet.LastName}!");
        }

        private void uxEVSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
