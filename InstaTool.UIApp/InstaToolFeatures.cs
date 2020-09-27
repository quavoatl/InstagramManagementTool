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
    public partial class InstaToolFeatures : Form
    {
        private InstagramAccount _accountInUse = null;
        public InstaToolFeatures(InstagramAccount igAccount)
        {
            InitializeComponent();
            _accountInUse = igAccount;

            managedAccount.Text = _accountInUse.EmailPhone;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
