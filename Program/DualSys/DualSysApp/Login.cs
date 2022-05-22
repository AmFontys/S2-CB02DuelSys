using DuelSysApp;
using DuelSysClassLibrary;

namespace DualSysApp
{
    public partial class Login : Form
    {
        private AccountManager management = new AccountManager(new AccountDAL());

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            bool loginsuccesfull = management.Login(email, pass,"");

            if (loginsuccesfull)
            {
                this.Hide();
                MainForm main = new MainForm();
                MainForm.Instance = main;
                main.ShowDialog();
                this.Show();
            }
            else
            {
                lblOutput.Text = "Login unsuccesfull check if you entered the correct credatianls";
            }
        }
    }
}