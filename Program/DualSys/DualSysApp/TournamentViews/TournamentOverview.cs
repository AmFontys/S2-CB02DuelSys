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

namespace DuelSysApp
{
    public partial class TournamentOverview : UserControl
    {
        object storage;
        private TournamentManager manager = new TournamentManager(new TournamentDAL());
        private static TournamentOverview _instance;
        public static TournamentOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TournamentOverview();
                }
                return _instance;
            }
        }

        public TournamentOverview()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "";
                if (rbFinished.Checked)
                {
                    status = "finsished";
                }
                else if (rbOnGoing.Checked)
                {
                    status = "On going";
                }
                else if (rbAvaible.Checked)
                {
                    status = "Avaible";
                }
                List<Tournament> accounts = manager.GetTournaments(status);
                InsertToView(accounts.ToArray());

                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Please reload the list something whent wrong");
            }
        }

        private void InsertToView(object[] list)
        {
            lbView.Items.Clear();
            foreach (var l in list)
            {
                lbView.Items.Add((Tournament)l); 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MainForm.Instance.BringNewAccountToFront();
            makeButtonsDissapear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tournament account = (Tournament)storage;
            if (manager.DeleteTournament(account.getID())) MessageBox.Show("Item Deleted");
            else MessageBox.Show("This item is already deleted");
            lbView.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MainForm.Instance.BringUpdateAccountToFront(storage);
            makeButtonsDissapear();
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object currentRow = lbView.SelectedItem;

                storage = (Tournament)currentRow;
                
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void makeButtonsDissapear()
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
    }
}
