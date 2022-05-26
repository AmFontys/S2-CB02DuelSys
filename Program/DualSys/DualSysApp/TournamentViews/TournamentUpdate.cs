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
    public partial class TournamentUpdate : UserControl
    {
        int id;
        private static TournamentUpdate _instance;
        public static TournamentUpdate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TournamentUpdate();
                }
                return _instance;
            }
        }
        public TournamentUpdate()
        {
            InitializeComponent();
        }

        internal void LoadData(object data)
        {
            Tournament tournament = data as Tournament;
            id = tournament.getID();
            txtName.Text = tournament.getTournamentName();
            txtDescription.Text = tournament.getTournamentDescription();
            nudMin.Value = tournament.getMinPlayers();
            nudMax.Value=tournament.getMaxPlayers();
            dtpStart.Value = tournament.getStartDate();
            dtpEnd.Value = tournament.getEndDate();
            cmbStatus.Text = tournament.getStatus();
            cmbSport.Text = tournament.getSport().getName();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TournamentManager manager = new TournamentManager(new TournamentDAL());

            bool succes= manager.UpdateTournament(id, txtName.Text, txtDescription.Text, Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value), cmbStatus.Text, dtpStart.Value, dtpEnd.Value);

            if (!succes) MessageBox.Show("You haven't filled the form in correctly");
            else MessageBox.Show("Tournament Updated");
        }
    }
}
