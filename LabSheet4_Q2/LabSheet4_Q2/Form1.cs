using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet4_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //add - button click
        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            //get output
            label4.Text = ($"Result - {(n1 + n2).ToString()}");
        }

        //sub - button click
        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            //get output
            label4.Text = ($"Result - {(n1 - n2).ToString()}");
        }

        //div - button click
        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            //get output
            label4.Text = ($"Result - {(n1 / n2).ToString()}");
        }

        //mult - button click
        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            //get output
            label4.Text = ($"Result - {(n1 * n2).ToString()}");
        }

        //Clear form - button click
        private void button5_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();

            //output
            label4.Text = "Result - ";
        }
    }
}
