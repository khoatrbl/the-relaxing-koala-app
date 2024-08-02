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
        BindingSource menuItemList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();

        public Account Account { get => account; set => account = value; }

        public fManager(Account account)
        {
            this.Account = account;
            InitializeComponent();
            InitializeViews();

        }

        #region Methods
        private void InitializeViews()
        {
            dtgvMenu.DataSource = menuItemList;
            dtgvCategory.DataSource = categoryList;
            dtgvTableList.DataSource = tableList;
            LoadAccountDisplayName();
            LoadDateTimePickerInvoice();
            LoadListOfInvoicesByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListOfAccounts();
            LoadListOfMenuItems();
            LoadCategoryIntoComboBox();
            AddMenuItemBinding();
            LoadListOfCategory();
            AddCategoryBinding();
            LoadListOfTables();
            LoadTableStatusIntoComboBox();
            AddTableBinding();
            LoadReport();
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

        private void LoadDateTimePickerInvoice()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
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

        private void LoadListOfMenuItems()
        {
            menuItemList.DataSource = MenuItemDAO.Instance.GetListOfMenuItemsWithAlternativeColumnNames();
        }

        private void AddMenuItemBinding()
        {
            txbItemName.DataBindings.Add(new Binding("Text", dtgvMenu.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbItemID.DataBindings.Add(new Binding("Text", dtgvMenu.DataSource, "ID", true, DataSourceUpdateMode.Never));
            numericMenuItemPrice.DataBindings.Add(new Binding("Value", dtgvMenu.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txbKeywords.DataBindings.Add(new Binding("Text", dtgvMenu.DataSource, "Keyword", true, DataSourceUpdateMode.Never));
        }

        private void LoadCategoryIntoComboBox()
        {
            cbItemCategory.DataSource = CategoryDAO.Instance.LoadCategory();
            cbItemCategory.DisplayMember = "Name";
        }

        private void LoadListOfCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.LoadCategory();
        }

        private void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        private void LoadListOfTables()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }

        private void LoadTableStatusIntoComboBox()
        {
            List<string> listOfStatus = new List<string>() { "Vacant", "Occupied", "Reserved" };

            cbTableStatus.DataSource = listOfStatus;
        }

        private void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTableList.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTableList.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        private void LoadReport()
        {
            dtgvReport.DataSource = ReportDAO.Instance.LoadReport();
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

        private void UpdateAccount(string username, string displayName)
        {
            if (AccountDAO.InstanceOfAccountDAO.CheckAccountByUsername(username))
            {
                if (displayName != "")
                {
                    AccountDAO.InstanceOfAccountDAO.UpdateAccount(username, displayName);
                    MessageBox.Show("Account is successfully updated");
                }
                else
                {
                    MessageBox.Show("Please enter a new display name to update");
                }

            }
            else
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
            }
            else
            {
                MessageBox.Show("Username does not exist.");
                return false;
            }
        }

        private bool AddMenuItem(string name, int categoryId, float price, string keyword)
        {
            return MenuItemDAO.Instance.InsertMenuItem(name, categoryId, price, keyword);
        }

        private bool UpdateMenuItem(int id, string name, int categoryId, float price, string keyword)
        {
            return MenuItemDAO.Instance.UpdateMenuItem(id, name, categoryId, price, keyword);
        }

        private bool DeleteMenuItem(int id)
        {
            return MenuItemDAO.Instance.DeleteMenuItem(id);
        }

        private bool AddCategory(string name)
        {
            return CategoryDAO.Instance.AddCategory(name);
        }

        private bool UpdateCategory(int id, string name)
        {
            return CategoryDAO.Instance.UpdateCategory(id, name);
        }

        private bool AddTable(string name, string status)
        {
            return TableDAO.Instance.AddTable(name, status);
        }

        private bool UpdateTable(int id, string name, string status)
        {
            return TableDAO.Instance.UpdateTable(id, name, status);
        }

        

        #endregion

        #region Events
        private void showInvoiceBtn_Click(object sender, EventArgs e)
        {
            LoadListOfInvoicesByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void tableManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTableManager fTableManager = new fTableManager();

            fTableManager.ShowDialog();
            this.Show();
        }

        private void changeCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUpdateAccount fUpdateAccount = new fUpdateAccount(Account.UserName);
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

        private void accountDeleteBtn_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            deleteAccount(username);
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

        private void viewMenuItemBtn_Click(object sender, EventArgs e)
        {
            LoadListOfMenuItems();
        }

        private void accountViewBtn_Click(object sender, EventArgs e)
        {
            LoadListOfAccounts();
        }

        private void txbItemID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvMenu.SelectedCells.Count > 0)
            {
                if (dtgvMenu.SelectedCells[0].OwningRow.Cells["Category"].Value != null)
                {
                    int id = (int)dtgvMenu.SelectedCells[0].OwningRow.Cells["Category"].Value;

                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbItemCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;

                    foreach (Category c in cbItemCategory.Items)
                    {
                        if (c.CategoryID == category.CategoryID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbItemCategory.SelectedIndex = index;
                }



            }


        }

        private void addMenuItemBtn_Click(object sender, EventArgs e)
        {
            string name = txbItemName.Text;
            int categoryId = (cbItemCategory.SelectedItem as Category).CategoryID;
            float price = (float)numericMenuItemPrice.Value;
            string keyword = txbKeywords.Text;

            if (AddMenuItem(name, categoryId, price, keyword))
            {
                MessageBox.Show("Menu item added successfully!");
                LoadListOfMenuItems();
            }
            else
            {
                MessageBox.Show("Failed to add menu item.");
            }

        }

        private void updateMenuItemBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbItemID.Text);
            string name = txbItemName.Text;
            int categoryId = (cbItemCategory.SelectedItem as Category).CategoryID;
            float price = (float)numericMenuItemPrice.Value;
            string keyword = txbKeywords.Text;

            if (UpdateMenuItem(id, name, categoryId, price, keyword))
            {
                MessageBox.Show("Menu item updated successfully!");
                LoadListOfMenuItems();
            }
            else
            {
                MessageBox.Show("Failed to update menu item.");
            }

        }

        private void deleteMenuItemBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbItemID.Text);

            if (DeleteMenuItem(id))
            {
                MessageBox.Show("Menu item deleted successfully!");
                LoadListOfMenuItems();
            }
            else
            {
                MessageBox.Show("Failed to delete menu item.");
            }
        }

        private void categoryAddBtn_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;

            if (AddCategory(name))
            {
                MessageBox.Show("Category added successfully!");
                LoadListOfCategory();
            }
            else
            {
                MessageBox.Show("Failed to add category.");
            }
        }

        private void categoryUpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            string name = txbCategoryName.Text;

            if (UpdateCategory(id, name))
            {
                MessageBox.Show("Category updated successfully");
                LoadListOfCategory();
            }
            else
            {
                MessageBox.Show("Failed to update category");
            }
        }

        private void categoryViewBtn_Click(object sender, EventArgs e)
        {
            LoadListOfCategory();
        }

        private void txbTableID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvTableList.SelectedCells.Count > 0)
            {
                if (dtgvTableList.SelectedCells[0].OwningRow.Cells["Status"].Value != null)
                {
                    string tableStatus = dtgvTableList.SelectedCells[0].OwningRow.Cells["Status"].Value.ToString();
                    List<string> listOfStatus = new List<string>() { "Vacant", "Occupied", "Reserved" };

                    int index = -1;
                    int i = 0;

                    foreach (string status in listOfStatus)
                    {
                        if (status == tableStatus)
                        {
                            index = i; break;
                        }
                        i++;
                    }
                    cbTableStatus.SelectedIndex = index;
                }
            }
        }

        private void tableViewBtn_Click(object sender, EventArgs e)
        {
            LoadListOfTables();
        }

        private void tableAddBtn_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            string status = cbTableStatus.SelectedItem.ToString();

            if (AddTable(name, status))
            {
                MessageBox.Show("Table added successfully!");
                LoadListOfTables();
            }
            else
            {
                MessageBox.Show("Failed to add table.");
            }
        }

        private void tableUpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            string name = txbTableName.Text;
            string status = cbTableStatus.SelectedItem.ToString();

            if (UpdateTable(id, name, status))
            {
                MessageBox.Show("Table updated successfully");
                LoadListOfTables();
            }
            else
            {
                MessageBox.Show("Failed to update table.");
            }


        }

        #endregion

    }
}
