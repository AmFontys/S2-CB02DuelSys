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
    public partial class TournamentNew : UserControl
    {
        private static TournamentNew _instance;
        public static TournamentNew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TournamentNew();
                }
                return _instance;
            }
        }
        public TournamentNew()
        {
            InitializeComponent();
        }

        internal void emptyForm()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            nudMin.Value = 1;
            nudMax.Value = 1;
            dtpStart.Value = DateTime.UtcNow;
            dtpEnd.Value = DateTime.UtcNow;
            ReloadSports();
        }

        private void ReloadSports()
        {
            SportManager manager = new SportManager(new SportDAL());

            foreach (var l in manager.GetSports())
            {
                cmbSport.Items.Add(l);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool succes = false;
            TournamentManager manager = new TournamentManager(new TournamentDAL());
            ITournamentType tournamentType = new RoundRobin();
            Sport sport = (Sport)cmbSport.SelectedItem;
            succes = manager.CreateTournament(txtName.Text, txtDescription.Text, (int)nudMin.Value, (int)nudMax.Value, dtpStart.Value, dtpEnd.Value, tournamentType, sport);

            if (!succes) MessageBox.Show("You haven't filled the form in correctly");
            else MessageBox.Show("Tournament Added");
        }
    }
}
