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
        private static MenuItemDAO instance;

        public static MenuItemDAO Instance 
        {
            get { if (instance == null) instance = new MenuItemDAO(); return instance; }
            private set => instance = value; 
        }

        private MenuItemDAO() { }

        public List<MenuItem> getListOfMenuItemByCategoryID(int categoryID)
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

        public List<MenuItem> getListOfMenuItems()
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
    }
}
