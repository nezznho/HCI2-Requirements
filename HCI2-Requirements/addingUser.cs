using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace HCI2_Requirements
{
    public partial class addingUser : Form
    {
        public addingUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            userr newUser = new userr 
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                confirmPass = txtconfirmpassword.Text.Trim()
            };

            // Validation
            if (newUser.Username == "" || newUser == null)
            {
                //lblStatus.Text = "Please fill out all fields.";
                //lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else if (newUser.Password != newUser.confirmPass)
            {
                //lblStatus.Text = "Passwords do not match.";
                //lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
