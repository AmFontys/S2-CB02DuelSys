using DualSysApp;
using DuelSysApp.AccountViews;
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
    public partial class MainForm : Form
    {
        private static MainForm _instance=null;
        public static MainForm Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            
        }

        
        public void BringNewAccountToFront()
        {
            if (!panelContentHolder.Controls.Contains(AccountNew.Instance))
            {
                panelContentHolder.Controls.Add(AccountNew.Instance);
                AccountNew.Instance.Dock = DockStyle.Fill;                
            }
            AccountNew.Instance.BringToFront();
            AccountNew.Instance.emptyForm();
        }
        public void BringUpdateAccountToFront(object data)
        {
            if (!panelContentHolder.Controls.Contains(AccountUpdate.Instance))
            {
                panelContentHolder.Controls.Add(AccountUpdate.Instance);
                AccountUpdate.Instance.Dock = DockStyle.Fill;
            }
            AccountUpdate.Instance.BringToFront();
            AccountUpdate.Instance.LoadData(data);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(AccountOverview.Instance))
            {
                panelContentHolder.Controls.Add(AccountOverview.Instance);
                AccountOverview.Instance.Dock = DockStyle.Fill;

            }
            AccountOverview.Instance.BringToFront();
        }

        public void BringNewTournamentToFront()
        {
            if (!panelContentHolder.Controls.Contains(TournamentNew.Instance))
            {
                panelContentHolder.Controls.Add(TournamentNew.Instance);
                AccountNew.Instance.Dock = DockStyle.Fill;
            }
            TournamentNew.Instance.BringToFront();
            TournamentNew.Instance.emptyForm();
        }
        public void BringUpdateTournamentToFront(object data)
        {
            if (!panelContentHolder.Controls.Contains(TournamentUpdate.Instance))
            {
                panelContentHolder.Controls.Add(TournamentUpdate.Instance);
                TournamentUpdate.Instance.Dock = DockStyle.Fill;
            }
            TournamentUpdate.Instance.BringToFront();
            TournamentUpdate.Instance.LoadData(data);
        }

        private void btnTournament_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(TournamentOverview.Instance))
            {
                panelContentHolder.Controls.Add(TournamentOverview.Instance);
                TournamentOverview.Instance.Dock = DockStyle.Fill;

            }
            TournamentOverview.Instance.BringToFront();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(CreateSchedule.Instance))
            {
                panelContentHolder.Controls.Add(CreateSchedule.Instance);
                CreateSchedule.Instance.Dock = DockStyle.Fill;

            }
            CreateSchedule.Instance.reloadTournaments();
            CreateSchedule.Instance.BringToFront();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (!panelContentHolder.Controls.Contains(MatchesOverview.Instance))
            {
                panelContentHolder.Controls.Add(MatchesOverview.Instance);
                MatchesOverview.Instance.Dock = DockStyle.Fill;

            }
            MatchesOverview.Instance.reloadTournaments();
            MatchesOverview.Instance.BringToFront();
        }
    }
}
