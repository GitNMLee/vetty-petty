using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormProject.Database_Objects;

namespace WindowsFormProject
{
    public partial class EditOwnerForm : Form
    {
        private SqlConnection _connection;
        private Owners _owner;
        public EditOwnerForm(Owners owner, SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _owner = owner;
            uxEOFirstNameTB.Text = _owner.FirstName;
            uxEOLastNameTB.Text = _owner.LastName;
            uxEOEmailTB.Text = _owner.EMail;
        }

        /// <summary>
        /// updates owner information to match filled form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEOSubmitButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmnd = new SqlCommand("UpdateOwner", _connection);
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.AddWithValue("@OwnerID", SqlDbType.Int).Value = _owner.OwnerID;
            cmnd.Parameters.AddWithValue("@EMail", SqlDbType.Int).Value = uxEOEmailTB.Text;
            cmnd.Parameters.AddWithValue("@FirstName", SqlDbType.Int).Value = uxEOFirstNameTB.Text;
            cmnd.Parameters.AddWithValue("@LastName", SqlDbType.Int).Value = uxEOLastNameTB.Text;

            cmnd.ExecuteNonQuery();
            MessageBox.Show("Successfully upated.");
        }
    }
}
