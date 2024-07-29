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
    public partial class fManager : Form
    {
        private Account account;

        public Account Account { get => account; set => account = value; }

        public fManager(Account account)
        {
            this.Account = account;
            InitializeComponent();
            LoadAccountDisplayName();
            LoadDataPickerInvoice();
            LoadListOfAccounts();
            LoadListOfInvoicesByDate(dtpkFromDate.Value, dtpkToDate.Value);

        }

        private void LoadAccountDisplayName()
        {
            updateAccountToolStripMenuItem.Text = "Account: ";
            updateAccountToolStripMenuItem.Text += Account.DisplayName;
        }

        private void UpdateAccountInstance()
        {
            Account updatedAccount = AccountDAO.InstanceOfAccountDAO.GetAccountByUsername(Account.UserName);
            this.Account = updatedAccount;
        }
        private void LoadDataPickerInvoice()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void showInvoiceBtn_Click(object sender, EventArgs e)
        {
            LoadListOfInvoicesByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void LoadListOfInvoicesByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvInvoice.DataSource = InvoiceDAO.Instance.GetListOfInvoicesByDate(checkIn, checkOut);

        }

        private void LoadListOfAccounts()
        {
            dtgvAccount.DataSource = AccountDAO.InstanceOfAccountDAO.GetListOfAccounts();
            dtgvAccount.Columns[2].Visible = false;
        }

        private void tableManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTableManager fTableManager = new fTableManager();

            fTableManager.ShowDialog();
            this.Show();
        }

        private void changeCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUpdateAccount fUpdateAccount = new fUpdateAccount();
            this.Hide();
            fUpdateAccount.ShowDialog();
            this.Show();
        }

        private void changeDisplayNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangeDisplayName fChangeDisplayName = new fChangeDisplayName(Account.UserName);
            this.Hide();
            fChangeDisplayName.ShowDialog();
            UpdateAccountInstance();
            LoadAccountDisplayName();
            this.Show();

        }

        private void accountAddBtn_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string displayName = txbDisplayName.Text;

            addAccount(username, displayName);
        }

        private void addAccount(string username, string displayName)
        {
            if (username != "")
            {
                if (!AccountDAO.InstanceOfAccountDAO.CheckAccountByUsername(username))
                {
                    AccountDAO.InstanceOfAccountDAO.AddNewAccount(username, displayName);
                    MessageBox.Show("User added successfully!");
                    LoadListOfAccounts();
                }
                else
                {
                    MessageBox.Show("Username already exists.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the wished username.");
            }


        }

        private void accountDeleteBtn_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            deleteAccount(username);
        }

        private void deleteAccount(string username)
        {


            if (AccountDAO.InstanceOfAccountDAO.CheckAccountByUsername(username))
            {
                AccountDAO.InstanceOfAccountDAO.DeleteAccount(username);
                MessageBox.Show("Account deleted!");
                LoadListOfAccounts();
            }
            else
            {
                MessageBox.Show("Username does not exist!");
            }
        }

        private void resetPwdBtn_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            ResetPassword(username);
        }

        private void accountUpdateBtn_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string displayName = txbDisplayName.Text;

            UpdateAccount(username, displayName);
            LoadListOfAccounts();
        }

        private void UpdateAccount(string username, string displayName)
        {
            if (AccountDAO.InstanceOfAccountDAO.CheckAccountByUsername(username))
            {
                if (displayName != "")
                {
                    AccountDAO.InstanceOfAccountDAO.UpdateAccount(username, displayName);
                    MessageBox.Show("Account is successfully updated");
                } else
                {
                    MessageBox.Show("Please enter a new display name to update");
                }
                
            } else
            {
                MessageBox.Show("Username does not exist.");
            }
        }

        private bool ResetPassword(string username)
        {
            // do something

            if (AccountDAO.InstanceOfAccountDAO.CheckAccountByUsername(username))
            {
                if (AccountDAO.InstanceOfAccountDAO.ResetPassword(username))
                {
                    MessageBox.Show("Password is successfully reset");
                    return true;
                }
                return false;
            } else
            {
                MessageBox.Show("Username does not exist.");
                return false;
            }
        } 
    }
}
