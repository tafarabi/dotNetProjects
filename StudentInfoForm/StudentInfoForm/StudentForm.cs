using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoForm
{
    public partial class studentForm : Form
    {
        string _name;
        string _email;
        string _contact;
        string _address;

        
        public studentForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _name = nameTextBox.Text;
            _contact = contactTextBox.Text;
            _email = emailTextBox.Text;
            _address = addressTextBox.Text;
            string s = _contact.Substring(0,1);
            if (_name.Length >50  || _name.Length < 3)
            {
                MessageBox.Show("Invalid");
       
                return;
            }
            else if (_contact.Length != 11 || s != "0")
            {
                MessageBox.Show("Invalid Contact");
                return;
            }
            else if (_email == "")
            {
                MessageBox.Show("Invalid email");
                return;
            }
            MessageBox.Show("Saved successfully");

            nameTextBox.Text = String.Empty;
            contactTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            addressTextBox.Text = String.Empty;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show(_name + Environment.NewLine + _contact + Environment.NewLine + _email + Environment.NewLine + _address);

            

        }
    }
}
