using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate button
        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(textBox1.Text, out number) && number > 0)
            {
                long result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                label2.Text = $"Factorial of {number} is: {result}";
            }
            else
            {
                label2.Text = "Invalid input.\nPlease enter a positive integer.";
            }
        }

        // Reset button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}
