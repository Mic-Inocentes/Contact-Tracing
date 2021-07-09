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
            Save();
            StreamReader inputfile;
            inputfile = File.OpenText("output.txt");
            MessageBox.Show(inputfile.ReadToEnd());
            inputfile.Close();
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

        private void Save()
        {
            StreamWriter outputfile = File.AppendText("output.txt");
            outputfile.WriteLine(txtboxFirstName.Text);
            outputfile.WriteLine(txtboxLastName.Text);
            outputfile.WriteLine(txtboxAddress.Text);
            outputfile.WriteLine(txtboxContactNumber.Text);
            outputfile.WriteLine(txtboxAge.Text);
            outputfile.WriteLine(txtboxTemperature.Text);
            outputfile.Close();
        }
    }
}
