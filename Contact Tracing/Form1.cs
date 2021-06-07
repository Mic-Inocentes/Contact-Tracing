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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            saveInfo(txtboxFirstName.Text, txtboxLastName.Text, txtboxAddress.Text, byte.Parse(txtboxAge.Text), txtboxPronouns.Text);
        }

        private void saveInfo(String FirstName, String LastName, String Address, byte Age, String Pronouns)
        {
            StreamWriter outputfile = File.AppendText("output.txt");
            outputfile.WriteLine(FirstName);
            outputfile.WriteLine(LastName);
            outputfile.WriteLine(Address);
            outputfile.WriteLine(Age.ToString());
            outputfile.WriteLine(Pronouns);
            outputfile.Close();
        }
    }
}
