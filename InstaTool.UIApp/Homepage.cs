using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InstaTool.DataAccess.DatabaseConn;
using InstaTool.DataAccess.DbModels;

namespace InstaTool.UIApp
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            LoadInstaAccountsFromDB();
        }

        private void LoadInstaAccountsFromDB()
        {
            var instagramAccountsList = SQLiteDatabaseAccess.GetInstagramAccount(SQLiteDatabaseAccess.GetLoggedUser().Id);

            foreach (var acc in instagramAccountsList)
            {
                ListViewItem lvi = new ListViewItem(acc.EmailPhone);
                listOfInstagramAccounts.Items.Add(lvi);
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void UseSelectedAccount_Click(object sender, EventArgs e)
        {
            var selectedAccountEmailPhone = SQLiteDatabaseAccess.GetInstagramAccount(listOfInstagramAccounts.SelectedItems[0].Text);

            if (selectedAccountEmailPhone != null)
            {
                InstaToolFeatures itf = new InstaToolFeatures(selectedAccountEmailPhone);
                itf.Show();
                this.Hide();
            }
        }

        private void ListOfInstagramAccounts_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddInstagramAccount_Click(object sender, EventArgs e)
        {
            var instagramAccount = new InstagramAccount()
            {
                EmailPhone = instaEmailPhone.Text,
                Password = instaPassword.Text,
                UserId = SQLiteDatabaseAccess.GetLoggedUser().Id,
                FollowedPersonLinkString = Guid.NewGuid().ToString(),
                LikedPersonLinkString = Guid.NewGuid().ToString(),
            };
            try
            {
                var succes = SQLiteDatabaseAccess.AddInstagramAccount(instagramAccount);

                if (succes)
                {
                    MessageBox.Show("Added account with success", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    // clear listview and display new list

                    listOfInstagramAccounts.Clear();
                    LoadInstaAccountsFromDB();
                }
                else
                {
                    MessageBox.Show("Problems occured adding the account", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    instaEmailPhone.Clear();
                    instaPassword.Clear();
                }
            }
            catch (Exception ex) { }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void instaPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadAccsFromDB_Click(object sender, EventArgs e)
        {

        }
    }
}
