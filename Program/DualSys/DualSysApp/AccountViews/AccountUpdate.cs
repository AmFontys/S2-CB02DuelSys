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
    public partial class AccountUpdate : UserControl
    {
        private int id;
        private static AccountUpdate _instance;
        public static AccountUpdate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountUpdate();
                }
                return _instance;
            }
        }
        public AccountUpdate()
        {
            InitializeComponent();
        }

        internal void LoadData(object data)
        {
            
            txtTeam.Visible = true;
            cmbCompany.Visible = true;
            if (data is Player)
            {
                cmbCompany.Visible = false;
                txtTeam.Visible = true;
                Player player = data as Player;
                txtTeam.Text = player.getTeam();
            }
            else if(data is Staff)
            {
                txtTeam.Visible = false;
                cmbCompany.Items.Add(new company("none", "none"));
                cmbCompany.Visible = true;
            }
            Account account = data as Account;
            id = account.getID();
            txtFName.Text =  account.getFname();
            txtLname.Text = account.getLname();
            txtEmail.Text = account.getEmail();
            txtPassword.Text = "";
            txtAddress.Text = account.getAddress();
            txtGender.Text = account.getGender();
            txtTown.Text = account.getTown();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AccountManager manager = new AccountManager(new AccountDAL());
            if (txtTeam.Text != "")
                manager.UpdateAccount(id, txtFName.Text, txtLname.Text, txtEmail.Text, txtTeam.Text, dtpBirth.Value, Convert.ToChar(txtGender.Text), txtAddress.Text, txtTown.Text, txtPassword.Text);
            else manager.UpdateAccount(id, txtFName.Text, txtLname.Text, txtEmail.Text, dtpBirth.Value, Convert.ToChar(txtGender.Text), txtAddress.Text, txtTown.Text, txtPassword.Text, "", (company)cmbCompany.SelectedItem);


                    }

    }
}
