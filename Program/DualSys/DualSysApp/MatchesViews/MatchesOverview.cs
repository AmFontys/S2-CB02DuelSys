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

namespace DualSysApp
{
    public partial class MatchesOverview : UserControl
    {
        private TournamentManager _manager = new TournamentManager(new TournamentDAL());
        private MatchManager _matchManager = new MatchManager(new MatchDAL(),new TournamentManager(new TournamentDAL()));

        Match storage;

        private static MatchesOverview _instance;
        public static MatchesOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MatchesOverview();
                }
                return _instance;
            }
        }

        public void reloadTournaments()
        {
            cmbTournaments.Items.Clear();
            foreach (var l in _manager.GetTournaments("On going"))
            {
                cmbTournaments.Items.Add(l);
            }
        }

        public void loadMatches(int tournamentId)
        {
            lbView.Items.Clear();
            foreach (var l in _matchManager.GetMatches(tournamentId)) 
            {
                lbView.Items.Add((Match)l);
            }
        }

        public MatchesOverview()
        {
            InitializeComponent();
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbView.SelectedIndex != -1)
            {
                storage = (Match)lbView.SelectedItem;
                MatchForm match = new MatchForm(storage);
                match.ShowDialog();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbTournaments.SelectedIndex < 0) return;

            loadMatches(1);

        }
    }
}
