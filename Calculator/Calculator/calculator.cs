using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            label.Text = (Double.Parse(firstTextBox.Text) + Double.Parse(secondTextBox.Text)).ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            label.Text = (Double.Parse(firstTextBox.Text) - Double.Parse(secondTextBox.Text)).ToString();
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            label.Text = (Double.Parse(firstTextBox.Text) * Double.Parse(secondTextBox.Text)).ToString();
        }

        private void Divbutton_Click(object sender, EventArgs e)
        {
            label.Text = (Double.Parse(firstTextBox.Text) / Double.Parse(secondTextBox.Text)).ToString();
        }

        private void Modbutton_Click(object sender, EventArgs e)
        {

            label.Text = (Double.Parse(firstTextBox.Text) % Double.Parse(secondTextBox.Text)).ToString();
        }
    }
}
