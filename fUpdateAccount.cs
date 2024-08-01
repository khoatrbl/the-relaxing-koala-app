using RestaurantIS.DAO;
using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIS
{
    public partial class fUpdateAccount : Form
    {
        private string username;

        public string Username { get => username; set => username = value; }

        public fUpdateAccount(string username)
        {
            this.username = username;
            InitializeComponent();

        }

        #region Methods
        private void UpdateAccount()
        {
            string oldPassword = txbOldPassword.Text;
            string newPassword = txbNewPassword.Text;
            string reEnterPassword = txbReEnterPassword.Text;

            if (AccountDAO.InstanceOfAccountDAO.CheckAccountByUsername(this.username))
            {
                if (AccountDAO.InstanceOfAccountDAO.CheckOldPasswordOfUsername(this.username, oldPassword))
                {
                    if (newPassword != "")
                    {
                        if (newPassword == reEnterPassword)
                        {
                            AccountDAO.InstanceOfAccountDAO.ChangePassword(this.username, newPassword);
                            MessageBox.Show("Password is successfully updated");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password don't match!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password can't be empty");
                    }
                }
                else
                {
                    MessageBox.Show("Old password is wrong!");
                }
            }
            else
            {
                MessageBox.Show("Username does not exist!");
            }
        }

        #endregion

        #region Events
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        #endregion
    }
}
