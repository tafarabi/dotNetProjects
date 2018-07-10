using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateInterestCalculatorUI
{
    public partial class InterestCalculator : Form
    {
        string _principleAmmount;
        string _interestRate;
        string _compoundInterest;
        string _years;
        public InterestCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _principleAmmount = principleAmmountTextBox.Text;
                _interestRate = interestTextBox.Text;
                _compoundInterest = compoundInterestTextBox.Text;
                _years = yearsTextBox.Text;

                totalTextBox.Text = InterestCalculate();

                principleAmmountTextBox.Text = String.Empty;
                interestTextBox.Text = String.Empty;
                compoundInterestTextBox.Text = String.Empty;
                yearsTextBox.Text = String.Empty;
            }
            catch (Exception)
            {
                MessageBox.Show("Input Invalid");

                principleAmmountTextBox.Text = String.Empty;
                interestTextBox.Text = String.Empty;
                compoundInterestTextBox.Text = String.Empty;
                yearsTextBox.Text = String.Empty;
            }

            

        }

        public string InterestCalculate()
        {
            double pammount = Convert.ToDouble(_principleAmmount);
            double rate = Convert.ToDouble(_interestRate) / 100;
            double compound = Convert.ToDouble(_compoundInterest);
            double years = Convert.ToDouble(_years) * compound;
            double r2 = pammount * Math.Pow((1 + (rate / compound)), years);
            string result = r2.ToString("N");
            return result;
        }
    }
}
