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
            Tournament account = data as Tournament;
            id = account.getID();
            txtName.Text = account.getTournamentName();
            txtDescription.Text = account.getTournamentDescription();
            nudMin.Value = account.getMinPlayers();
            nudMax.Value=account.getMaxPlayers();
            dtpStart.Value = account.getStartDate();
            dtpEnd.Value = account.getEndDate();
            cmbStatus.Text = account.getStatus();
            cmbSport.Text = account.getSport().getName();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TournamentManager manager = new TournamentManager(new TournamentDAL());

            manager.UpdateTournament(id, txtName.Text, txtDescription.Text, Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value), cmbStatus.Text, dtpStart.Value, dtpEnd.Value);

        }
    }
}
