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
            txtTeam.Visible = false;
            cmbCompany.Visible = false;
            Account account = data as Account;
            txtFName.Text =  account.getFname();
            txtLname.Text = account.getLname();
            txtEmail.Text = account.getEmail();
            txtPassword.Text = "";
            txtAddress.Text = account.getAddress();
            txtGender.Text = account.getGender();
            txtTown.Text = account.getTown();
            if (1 > 0)
            {
                txtTeam.Visible = true;
                Player player = data as Player;
                txtTeam.Text = player.getTeam();
            }
            else
            {
                cmbCompany.Items.Add(new company("none", "none"));
                cmbCompany.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
