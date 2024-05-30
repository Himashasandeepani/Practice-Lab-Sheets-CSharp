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

namespace LabSheet7_Q3
{
    public partial class Form2 : Form
    {
        //connection 
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Documents\NSBM\1 year\3 Semester\Notes\C#\Practise C#\Lab Sheets\Lab Sheet 7\LabSheet7_Q3\LabSheet7_Q3\Database1.mdf"";Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        // buton click verify id
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId1.Text, out int enteredID))
            {
                conn.Open();
                int Empid = int.Parse(txtId1.Text);
                //query
                string query1 = "SELECT Empid FROM Employee WHERE Empid == {Empid}";

                //command
                SqlCommand cmd1 = new SqlCommand(query1, conn);

                if (Empid == enteredID)
                {
                    label2.Text = $"The person whose id number {enteredID} is an employee.";
                }
                else
                {
                    label2.Text= $"The person whose id number {enteredID} is not an employee.";
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId1.Clear();
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Close();
        }
    }
}
