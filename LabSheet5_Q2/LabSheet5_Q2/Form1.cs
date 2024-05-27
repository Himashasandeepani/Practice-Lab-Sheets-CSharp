using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSheet5_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sign up button click - add details
        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text;
            string lastName = txtLname.Text;
            string dob = txtDOB.Text;
            string email = txtEmail.Text;
            string username = txtUname.Text;
            string password = txtPass.Text;
            string confirmPassword = txtCpass.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(dob) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check password
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dob,
                Email = email,
                Username = username,
                Password = password
            };

            // Display the form2
            var userDetailsForm = new Form2(newUser);
            userDetailsForm.Show();
            this.Hide();
        }

        //reset button click - clear form
        private void button2_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtDOB.Clear();
            txtEmail.Clear();
            txtUname.Clear();
            txtPass.Clear();
            txtCpass.Clear();
        }
    }

    // User class to get and set user inputs
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
