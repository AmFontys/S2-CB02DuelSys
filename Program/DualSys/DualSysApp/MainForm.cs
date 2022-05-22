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
    }
}
