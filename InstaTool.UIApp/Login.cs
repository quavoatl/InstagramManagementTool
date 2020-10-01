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
    public partial class Login : Form
    {
        public static User loggedUser = null;


        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var user = SQLiteDatabaseAccess.GetUser(usernameTextbox.Text, passwordTextbox.Text);

            if (user != null)
            {
                SQLiteDatabaseAccess.LoadUser(user);

                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to login", "Failed", MessageBoxButtons.OK,
              MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BackToRegister_Button(object sender, EventArgs e)
        {
            Register backToRegister = new Register();
            this.Hide();
            backToRegister.Show();
        }
    }
}
