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
    public partial class CreateSchedule : UserControl
    {
        public TournamentManager _manager = new TournamentManager(new TournamentDAL()); 
        private static CreateSchedule _instance;
        public static CreateSchedule Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CreateSchedule();
                }
                return _instance;
            }
        }

        public CreateSchedule()
        {
            InitializeComponent();
        }

        internal void reloadTournaments()
        {
            cmbTournament.Items.Clear();
            foreach (var l in _manager.GetTournaments("Available"))
            {
                cmbTournament.Items.Add(l);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tournament tournament = (Tournament)cmbTournament.SelectedItem;
            if (cmbTournament.SelectedIndex < 0 | tournament == null | tournament.getID() <= 0) {
                MessageBox.Show("No valid tournament selected");
                return;
            }
            int[] players = _manager.GetSignUps(tournament.getID());
            if (players == null | players.Length <= tournament.getMinPlayers()) {
                MessageBox.Show("Not enough players in this tournament");
                return;
            }

            ScheduleManager scheduleManager = new ScheduleManager(new ScheduleDAL(), new MatchDAL());
            bool succes = scheduleManager.StartTournament(tournament,players);
            if (succes)
            {
                _manager.UpdateTournament(tournament.getID(),"On going");
                MessageBox.Show("Schedule created");
            }
            else
            {
                MessageBox.Show("Schedule not created");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTournament.SelectedIndex < 0 || (Tournament)cmbTournament.SelectedItem ==null) return ;
            Tournament tournament = (Tournament)cmbTournament.SelectedItem;
            if (tournament.getID()<=0) return ;

            lblTournamentInfo.Text = $"{tournament.getTournamentName()} \n\r" +
                $"The start date is {tournament.getStartDate()}  \n\r" +
                $"The end date is {tournament.getEndDate()} \n\r"+
                $"The sport of this tournament is {tournament.getSport().getName()} \n\r" +
                $"The minium amount of people is {tournament.getMinPlayers()} and the max is {tournament.getMaxPlayers()} \n\r" +
                $" \n\r \n\r {tournament.getTournamentDescription()}";
            lblTournamentInfo.Visible = true;
        }
    }
}
