using InstaTool.DataAccess.DatabaseConn;
using InstaTool.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InstaTool.UIApp
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = usernameTextbox.Text,
                Password = passwordTextbox.Text,
            };

            SQLiteDatabaseAccess.AddUser(user);

            MessageBox.Show("Register Success", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
