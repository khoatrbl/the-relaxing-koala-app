using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO? instance;
        public static int btnWidth = 160;
        public static int btnHeight = 70;

        public static CategoryDAO Instance 
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set => instance = value; 
        
        }

        private CategoryDAO() { }

        public List<Category> LoadCategory()
        {
            List<Category> categoryList = new List<Category>();

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM MenuItemCategory");

            foreach (DataRow row in data.Rows) 
            {
                Category category = new Category(row);
                categoryList.Add(category);
            }

            return categoryList;
        }
    }
}
