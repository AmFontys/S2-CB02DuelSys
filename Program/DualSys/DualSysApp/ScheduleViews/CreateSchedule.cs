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
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
