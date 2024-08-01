using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class MenuItemDAO
    {
        private static MenuItemDAO? instance;

        public static MenuItemDAO Instance
        {
            get { if (instance == null) instance = new MenuItemDAO(); return instance; }
            private set => instance = value;
        }

        private MenuItemDAO() { }

        // Returns a list of menu item by category
        public List<MenuItem> GetListOfMenuItemByCategoryID(int categoryID)
        {
            List<MenuItem> listOfMenuItemsByCategory = new List<MenuItem>();

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM MenuItems WHERE idCategory = " + categoryID);

            foreach (DataRow row in data.Rows)
            {
                MenuItem menuItem = new MenuItem(row);

                listOfMenuItemsByCategory.Add(menuItem);
            }
            return listOfMenuItemsByCategory;
        }

        // Returns a list of all the menu items
        public List<MenuItem> GetListOfMenuItems()
        {
            List<MenuItem> listOfMenuItems = new List<MenuItem>();

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM MenuItems");

            foreach (DataRow row in data.Rows)
            {
                MenuItem menuItem = new MenuItem(row);
                listOfMenuItems.Add(menuItem);
            }

            return listOfMenuItems;
        }

        // Returns a list of all the menu items, but in different names for display purpose
        public DataTable GetListOfMenuItemsWithAlternativeColumnNames()
        {
            return DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_GetListOfMenuItems");
        }

        // This method inserts a new menu item into the database
        public bool InsertMenuItem(string name, int categoryId, float price, string keyword)
        {
            string query = string.Format("INSERT MenuItems (name, idCategory, price, keyword) VALUES (N'{0}', {1}, {2}, N'{3}')", name, categoryId, price, keyword);

            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }

        // This method update an existing menu item
        public bool UpdateMenuItem(int id, string name, int categoryId, float price, string keyword)
        {
            string query = String.Format("UPDATE MenuItems SET name = N'{0}', idCategory = {1}, price = {2}, keyword = N'{3}' WHERE id = {4}", name, categoryId, price, keyword, id);
            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }

        // this method deletes an existing item in the database
        public bool DeleteMenuItem(int menuItemId) 
        {
            OrderItemDAO.Instance.DeleteOrderItemByItemID(menuItemId);

            string query = String.Format("DELETE MenuItems WHERE id = {0}", menuItemId);
            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }
    }
}
