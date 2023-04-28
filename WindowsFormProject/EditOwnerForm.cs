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

namespace WindowsFormProject
{
    public partial class EditOwnerForm : Form
    {
        public EditOwnerForm(Owners owner)
        {
            InitializeComponent();
            uxEOFirstNameTB.Text = owner.FirstName;
            uxEOLastNameTB.Text = owner.LastName;
            uxEOEmailTB.Text = owner.EMail;
        }

        //on field change, updates table
        private void FieldChange(object sender, EventArgs e)
        {

        }

        private void uxEOSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
