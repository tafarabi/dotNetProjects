using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSearch
{
    public partial class StudentSearch : Form
    {
        List <string> name = new List<string>();
        List <string> regno = new List<string>();
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            name.Add(nameTextBox.Text);
            nameTextBox.Text = String.Empty;
            regno.Add(regTextBox.Text);
            regTextBox.Text = String.Empty;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            showListView.Clear();

            

            foreach (string str in name)
            {
                if (name.Contains(nameTextBox.Text))
                {
                    showListView.Items.Add("ok");
                }
            }


            
                
                
          
            
        }
    }
}
