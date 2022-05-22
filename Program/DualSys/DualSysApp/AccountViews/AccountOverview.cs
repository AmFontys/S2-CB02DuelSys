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
    public partial class AccountOverview : UserControl
    {
        object storage;
        private AccountManager manager = new AccountManager(new AccountDAL());
        private static AccountOverview _instance;
        public static AccountOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountOverview();
                }
                return _instance;
            }
        }
        public AccountOverview()
        {
            InitializeComponent();
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object currentRow = lbView.SelectedItem;
                if (rbAll.Checked)
                {
                    storage = (DuelSysClassLibrary.Account)currentRow;
                }
                else if (rbPlayer.Checked)
                {
                    storage = (Player)currentRow;
                }
                else if (rbEmployees.Checked)
                {
                    storage = (Staff)currentRow;
                }
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MainForm.Instance.BringNewAccountToFront();
            makeButtonsDissapear();
        }

        private void makeButtonsDissapear()
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            Account account = (Account)storage;
            if (manager.DeleteAccount(account.getID())) MessageBox.Show("Item Deleted");
            else MessageBox.Show("This item is already deleted");
            lbView.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainForm.Instance.BringUpdateAccountToFront(storage);
            makeButtonsDissapear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAll.Checked)
                {
                    List<Account> accounts = manager.GetAccounts();
                    InsertToView(accounts.ToArray());
                }
                else if (rbPlayer.Checked)
                {
                    List<Player> players = manager.GetPlayers();
                    InsertToView(players.ToArray());
                }
                else if (rbEmployees.Checked)
                {
                    List<Staff> staffs = manager.GetStaff();
                    InsertToView(staffs.ToArray());
                }
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please reload the list something whent wrong");
            }
        }

        private void InsertToView(object[] list)
        {
            lbView.Items.Clear();
            foreach (var l in list)
            {
                if (rbAll.Checked)
                {
                    lbView.Items.Add((Account)l);
                }
                else if (rbPlayer.Checked)
                {
                    lbView.Items.Add((Player)l);
                }
                else if (rbEmployees.Checked)
                {
                    lbView.Items.Add((Staff)l);
                }
                
            }
        }
    }
}
