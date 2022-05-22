using DuelSysClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelSysApp.AccountViews
{
    public partial class AccountNew : UserControl
    {
        private static AccountNew _instance;
        public static AccountNew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountNew();
                }
                return _instance;
            }
        }

        public AccountNew()
        {
            InitializeComponent();
        }

        internal void emptyForm()
        {
            txtAddress.Text = "";
            txtGender.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLname.Text = "";
            txtPassword.Text = "";
            txtTeam.Text = "";
            txtTown.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountManager manager = new AccountManager(new AccountDAL());
            if (txtTeam.Text == "" | txtTeam.Text == null)
                manager.AddAccount(txtFName.Text, txtLname.Text, txtEmail.Text, dtpBirth.Value,Convert.ToChar( txtGender.Text), txtAddress.Text, txtTown.Text, txtPassword.Text, new company("none","none"));
            else manager.AddAccount(txtFName.Text, txtLname.Text, txtEmail.Text, txtTeam.Text, dtpBirth.Value, Convert.ToChar(txtGender.Text), txtAddress.Text, txtTown.Text, txtPassword.Text);
        }
    }
}
