using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class MenuItem
    {
        private int id;
        private string name;
        private int idCategory; 
        private float price;
        private string keyword;

        public MenuItem(int id, string name, int idCategory, float price, string keyword) 
        {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
            this.Keyword = keyword;
        }

        public MenuItem(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.idCategory = (int)row["idCategory"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.Keyword = row["keyword"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
        public string Keyword { get => keyword; set => keyword = value; }
    }
}
