using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet4_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calculation
        private void Calculation(char operation)
        {
            string Cal = txtCal.Text;

            int operatorIndex = Cal.IndexOf(operation);

            // check
            if (operatorIndex > 0 && operatorIndex < Cal.Length - 1)
            {
                string part1 = Cal.Substring(0, operatorIndex);
                string part2 = Cal.Substring(operatorIndex + 1);

                // Convert - parts to integers
                int n1 = int.Parse(part1);
                int n2 = int.Parse(part2);

                //calculation
                int result = 0;
                switch (operation)
                {
                    case '+':
                        result = n1 + n2;
                        break;
                    case '-':
                        result = n1 - n2;
                        break;
                    case '/':
                        result = n1 / n2;
                        break;
                    case '*':
                        result = n1 * n2;
                        break;
                }

                // output
                label4.Text = $"Result - {result}";
            }
        }

        //add - click button
        private void button1_Click(object sender, EventArgs e)
        {
            Calculation('+');
        }

        //sub - click button
        private void button2_Click(object sender, EventArgs e)
        {
            Calculation('-');
        }

        //div - click button
        private void button3_Click(object sender, EventArgs e)
        {
            Calculation('/');
        }

        //mult - click button
        private void button4_Click(object sender, EventArgs e)
        {
            Calculation('*');
        }

        // clear form - click button
        private void button5_Click(object sender, EventArgs e)
        {
            txtCal.Clear();
            label4.Text = "Result - ";
        }
    }
}
