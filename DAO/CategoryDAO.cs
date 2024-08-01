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

        // This method returns a list of the categories available in the database
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

        // This method returns a category object with a specified ID
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM MenuItemCategory WHERE id = " + id);

            foreach (DataRow row in data.Rows)
            {
                category = new Category(row);
                return category;
            }

            return category;
        }

        // This method adds a category into the database
        public bool AddCategory(string name)
        {
            string query = String.Format("INSERT MenuItemCategory (name) VALUES (N'{0}')", name);
            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }
         
        // this method updates a category into the database
        public bool UpdateCategory(int id, string name)
        {
            string query = String.Format("UPDATE MenuItemCategory SET name = N'{0}' WHERE id = {1}", name, id);
            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }
    }
}
