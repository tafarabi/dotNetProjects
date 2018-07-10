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
        private string _firstNumber;
        private string _secondNumber;
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _firstNumber = firstTextBox.Text;
            _secondNumber = secondTextBox.Text;
          
            label.Text = Add(_firstNumber,_secondNumber).ToString();
        }
        private void SubButton_Click(object sender, EventArgs e)
        {
            _firstNumber = firstTextBox.Text;
            _secondNumber = secondTextBox.Text;

            label.Text = Sub(_firstNumber, _secondNumber).ToString();
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            _firstNumber = firstTextBox.Text;
            _secondNumber = secondTextBox.Text;

            label.Text = Mul(_firstNumber, _secondNumber).ToString();
        }

        private void Divbutton_Click(object sender, EventArgs e)
        {
            _firstNumber = firstTextBox.Text;
            _secondNumber = secondTextBox.Text;

            label.Text = Div(_firstNumber, _secondNumber).ToString();
        }

        private void Modbutton_Click(object sender, EventArgs e)
        {

            _firstNumber = firstTextBox.Text;
            _secondNumber = secondTextBox.Text;

            label.Text = Mod(_firstNumber, _secondNumber).ToString();
        }

        public double Add(string firstNumber, string secondNumber)
        {
            double x = Double.Parse(_firstNumber) + Double.Parse(_secondNumber);
            return x;
        }
        public double Sub(string firstNumber, string secondNumber)
        {
            double x = Double.Parse(_firstNumber) - Double.Parse(_secondNumber);
            return x;
        }
        public double Mul(string firstNumber, string secondNumber)
        {
            double x = Double.Parse(_firstNumber) * Double.Parse(_secondNumber);
            return x;
        }
        public double Div(string firstNumber, string secondNumber)
        {
            double x = Double.Parse(_firstNumber) / Double.Parse(_secondNumber);
            return x;
        }
        public double Mod(string firstNumber, string secondNumber)
        {
            double x = Double.Parse(_firstNumber) % Double.Parse(_secondNumber);
            return x;
        }
    }
}
