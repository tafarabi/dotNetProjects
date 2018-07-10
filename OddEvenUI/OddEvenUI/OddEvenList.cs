using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddEvenUI
{

    public partial class OddEvenList : Form
    {
        private int[] input = new int[100];
        private string _input;
        private int i = 0;
        public OddEvenList()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            _input = inputTextBox.Text;
            Add();

        }

        public void Add()
        {
            input[i] = Convert.ToInt32(_input);
            i++;
            inputTextBox.Text = String.Empty;
        }

        private void OddButton_Click(object sender, EventArgs e)
        {

            Odd();


        }

        public void Odd()
        {
            ResultListView.Clear();
            for (int j = 0; j < i; j++)
            {
                int v = input[j];
                int x = (Convert.ToInt32(input[j])) % 2;
                if (x != 0 && v > 0)
                {
                    ResultListView.Items.Add(input[j].ToString());
                }
            }
        }

        private void EvenButton_Click(object sender, EventArgs e)
        {
            Even();
        }

        public void Even()
        {
            ResultListView.Clear();
            for (int j = 0; j < i; j++)
            {
                int v = input[j];
                int x = (Convert.ToInt32(input[j])) % 2;
                if (x == 0 && v > 0)
                {
                    ResultListView.Items.Add(input[j].ToString());
                }
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            
            Show();
        }
        public void Show()
        {
            ResultListView.Clear();
            Array.Sort(input);
            for (int j = 0; j < 100; j++)
            {
                int v = input[j];
                if (v > 0)
                {
                    ResultListView.Items.Add(Convert.ToString(input[j]));
                }
                
            }
        }
    }
}
