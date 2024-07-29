using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class OrderItem
    {
        private string item;
        private int quantity;
        private float price;
        private float total;

        public OrderItem(string item, int quantity, float price, float total = 0) 
        { 
            this.item = item;
            this.quantity = quantity;
            this.price = price;
            this.total = total;
        }

        public OrderItem(DataRow row)
        {
            this.item = row["name"].ToString();
            this.quantity = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.total = (float)Convert.ToDouble(row["total"].ToString());
        }

        public string Item { get => item; set => item = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public float Total { get => total; set => total = value; }
    }
}
