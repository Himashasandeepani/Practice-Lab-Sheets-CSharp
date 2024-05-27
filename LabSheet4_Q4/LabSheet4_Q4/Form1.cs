using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet4_Q4
{
    public partial class Form1 : Form
    {
        //variables
        private int number1 = 0;
        private int number2 = 0;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        //numbers button - click
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtcal.Text += button.Text;
        }

        //operation button - click
        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtcal.Text, out number1))
            {
                Button button = (Button)sender;
                operation = button.Text;
                txtcal.Clear();
            }
            else
            {
                txtcal.Text = "Error";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtcal.Text, out number1))
            {
                Button button = (Button)sender;
                operation = button.Text;
                txtcal.Clear();
            }
            else
            {
                txtcal.Text = "Error";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtcal.Text, out number1))
            {
                Button button = (Button)sender;
                operation = button.Text;
                txtcal.Clear();
            }
            else
            {
                txtcal.Text = "Error";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtcal.Text, out number1))
            {
                Button button = (Button)sender;
                operation = button.Text;
                txtcal.Clear();
            }
            else
            {
                txtcal.Text = "Error";
            }
        }

        //equal button - click
        private void button15_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtcal.Text, out number2))
            {
                bool validOperation = true;
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = (double)number1 / number2;
                        }
                        else
                        {
                            txtcal.Text = "Cannot divide by zero";
                            validOperation = false;
                        }
                        break;
                    default:
                        txtcal.Text = "Invalid Operation";
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    txtcal.Text = result.ToString();
                }
            }

            else
            {
                txtcal.Text = "Error";
            }
        }

        //clear form - button click
        private void button14_Click(object sender, EventArgs e)
        {
            txtcal.Clear();
            number1 = 0;
            number2 = 0;
            operation = "";
        }
    }
}
