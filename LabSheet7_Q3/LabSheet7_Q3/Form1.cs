using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabSheet7_Q3
{
    public partial class Form1 : Form
    {
        //connection 
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Documents\NSBM\1 year\3 Semester\Notes\C#\Practise C#\Lab Sheets\Lab Sheet 7\LabSheet7_Q3\LabSheet7_Q3\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        // buton click add
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int enteredID))
            {
                conn.Open();
                int Empid = int.Parse(txtId.Text);
                //query
                string query = $"INSERT INTO Employee (EmpId) VALUES ({Empid})";

                MessageBox.Show("Successfully added");

                //command
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
