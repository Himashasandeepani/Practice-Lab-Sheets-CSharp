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
    public partial class Form2 : Form
    {
        private User _user;
        public Form2(User user)
        {
            InitializeComponent();
            _user = user;
        }

        //loading form
        private void Form2_Load(object sender, EventArgs e)
        {
            txtName1.Text = $"{_user.FirstName} {_user.LastName}";
            txtUname1.Text = _user.Username;
            txtEmail1.Text = _user.Email;
        }
    }
}
