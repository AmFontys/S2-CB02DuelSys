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
    public partial class MatchForm : Form
    {
        private int _id;
        Player Player;
        Player Player2;
        private MatchManager _manager = new MatchManager(new MatchDAL(),new TournamentManager(new TournamentDAL()));
        public MatchForm(Match storage)
        {
            InitializeComponent();

            loadData(storage);
        }

        private void loadData(Match data)
        {
            _id = data.GetTourId();
            Player = data.GetPlayer1();
            Player2 = data.GetPlayer2();

            lblPlayer1.Text = $"{Player.getFname()} {Player.getLname()}";            
            lblPlayer2.Text = $"{Player2.getFname()} {Player2.getLname()}";

            nudPlayer1.Value = data.GetScore1();
            nudPlayer2.Value = data.GetScore2();
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            _manager.UpdateMatch(_id,Player.getID(),Player2.getID(), (int)nudPlayer1.Value, (int)nudPlayer2.Value,out string message);
            if (message.Length > 0) MessageBox.Show(message);
        }
    }
}
