using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class Category
    {
        private int categoryID;
        private string name;

        public Category(int categoryID, string name)
        {
            this.categoryID = categoryID;
            this.name = name;
        }

        public Category(DataRow row)
        {
            this.categoryID = (int)row["id"];
            this.name = row["name"].ToString();
        }

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string Name { get => name; set => name = value; }
    }
}
