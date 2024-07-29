using RestaurantIS.DAO;
using RestaurantIS.DTO;

namespace RestaurantIS
{
    public partial class fLogin : Form
    {
        private Account account;

        public Account Account { get => account; set => account = value; }

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void staffLoginBtn_Click(object sender, EventArgs e)
        {
            fTableManager fTableManager = new fTableManager();
            this.Hide();
            fTableManager.ShowDialog();
            this.Show();

        }

        private bool LogIn(string username, string password)
        {
            return AccountDAO.InstanceOfAccountDAO.Login(username, password);
        }

        private void managerLoginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (LogIn(username, password))
            {
                Account account = AccountDAO.InstanceOfAccountDAO.GetAccountByUsername(username);
                fManager fManager = new fManager(account);
                this.Hide();
                fManager.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Wrong username or password");
            }
            
        }
    }
}