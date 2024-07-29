using RestaurantIS.DAO;
using RestaurantIS.DTO;
using RestaurantIS.Properties;
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
    public partial class fOrder : Form
    {
        private int tableID;

        public int TableID { get => tableID; set => tableID = value; }

        public fOrder(int tableID)
        {
            this.tableID = tableID;
            InitializeComponent();
            LoadCategory();
            LoadMenuItems();
        }

        private void LoadCategory()
        {
            List<Category> categoryList = CategoryDAO.Instance.LoadCategory();
            Button showAllMenuItemsButton = new Button() { Width = CategoryDAO.btnWidth, Height = CategoryDAO.btnHeight, Text = "All"};
            showAllMenuItemsButton.Click += ShowAllMenuItemsButton_Click;
            flpCategory.Controls.Add(showAllMenuItemsButton);
            
            foreach (Category category in categoryList)
            {
                Button btn = new Button() { Width = CategoryDAO.btnWidth, Height = CategoryDAO.btnHeight };
                btn.Text = category.Name;

                btn.Click += btn_Click;
                btn.Tag = category;

                flpCategory.Controls.Add(btn);
            }
        }

        private void ShowAllMenuItemsButton_Click(object? sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            flpMenuItem.Controls.Clear();

            List<MenuItem> listOfMenuItems = MenuItemDAO.Instance.getListOfMenuItems();

            foreach (MenuItem menuItem in listOfMenuItems)
            {
                ucMenuItemLayout menuItemLayout = new ucMenuItemLayout() { ItemId = menuItem.Id, ItemName = menuItem.Name, ItemPrice = "$" + menuItem.Price.ToString() };

                switch (menuItem.Keyword)
                {
                    case "cheese pizza":
                        menuItemLayout.ItemImage = Resources.cheese_pizza; break;
                    case "pepperoni pizza":
                        menuItemLayout.ItemImage = Resources.pizza_with_drink; break;
                    case "bolognese":
                        menuItemLayout.ItemImage = Resources.tomato_sauce_pasta; break;
                    case "latte":
                        menuItemLayout.ItemImage = Resources.latte; break;
                    case "cappuccino":
                        menuItemLayout.ItemImage = Resources.cappuccino; break;
                    case "espresso":
                        menuItemLayout.ItemImage = Resources.espresso_3; break;
                }

                flpMenuItem.Controls.Add(menuItemLayout);
            }
        }

        private void LoadMenuItemsByCategory(int categoryID)
        {
            flpMenuItem.Controls.Clear();
            List<MenuItem> menuItemList = MenuItemDAO.Instance.getListOfMenuItemByCategoryID(categoryID);
            foreach (MenuItem item in menuItemList)
            {
                ucMenuItemLayout menuItemLayout = new ucMenuItemLayout() { ItemId = item.Id, ItemName = item.Name, ItemPrice = "$" + item.Price.ToString() };

                switch (item.Keyword)
                {
                    case "cheese pizza":
                        menuItemLayout.ItemImage = Resources.cheese_pizza; break;
                    case "pepperoni pizza":
                        menuItemLayout.ItemImage = Resources.pizza_with_drink; break;
                    case "bolognese":
                        menuItemLayout.ItemImage = Resources.tomato_sauce_pasta; break;
                    case "latte":
                        menuItemLayout.ItemImage = Resources.latte; break;
                    case "cappuccino":
                        menuItemLayout.ItemImage = Resources.cappuccino; break;
                    case "espresso":
                        menuItemLayout.ItemImage = Resources.espresso_3; break;
                }

                flpMenuItem.Controls.Add(menuItemLayout);
            }

        }

        private void btn_Click(object? sender, EventArgs e)
        {
            int categoryID = ((sender as Button).Tag as Category).CategoryID;
            LoadMenuItemsByCategory(categoryID);
        }

        private void OrderAddBtn_Click(object sender, EventArgs e)
        {
            int invoiceID = InvoiceDAO.Instance.GetUnpaidInvoiceIDByTableID(TableID);

            if (invoiceID == -1)
            {
                InvoiceDAO.Instance.AddInvoice(TableID);
                foreach (ucMenuItemLayout item in flpMenuItem.Controls)
                {
                    if (item.Quantity > 0)
                    {
                        InvoiceItemDAO.Instance.AddInvoiceItem(InvoiceDAO.Instance.GetMaxInvoiceID(), item.ItemId, item.Quantity);
                    }
                }
            }
            else
            {
                foreach (ucMenuItemLayout item in flpMenuItem.Controls)
                {
                    if (item.Quantity != 0)
                    {
                        InvoiceItemDAO.Instance.AddInvoiceItem(invoiceID, item.ItemId, item.Quantity);
                    }
                }
            }

            MessageBox.Show("Order is updated!");
        }

        private void OrderBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
