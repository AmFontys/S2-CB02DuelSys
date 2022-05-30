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

        }

        public MatchesOverview()
        {
            InitializeComponent();
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
