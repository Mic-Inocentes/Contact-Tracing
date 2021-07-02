using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            saveInfo(txtboxFirstName.Text, txtboxLastName.Text, txtboxAddress.Text, txtboxContactNumber.Text, txtboxAge.Text , txtboxTemperature.Text);
        }

        private void saveInfo(String FirstName, String LastName, String Address, String ContactNumber, String Age, String Temperature)
        {
            StreamWriter outputfile = File.AppendText("output.txt");
            outputfile.WriteLine(FirstName);
            outputfile.WriteLine(LastName);
            outputfile.WriteLine(Address);
            outputfile.WriteLine(ContactNumber);
            outputfile.WriteLine(Age);
            outputfile.WriteLine(Temperature);
            outputfile.Close();
        }

        private void txtboxContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtboxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtboxTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
