using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class OrderItemDAO
    {
        private static OrderItemDAO? instance;

        public static OrderItemDAO Instance 
        {
            get { if (instance == null) instance = new OrderItemDAO(); return instance; } 
            private set => instance = value; 
        }

        private OrderItemDAO() { }

        public List<OrderItem> getListOfOrderItemsByTableID(int tableID)
        {
            List<OrderItem> listOfOrderItems = new List<OrderItem>();

            string query = "SELECT mItems.name, iItems.count, mItems.price, mItems.price * iItems.count as total FROM InvoiceItems as iItems, Invoice as i, MenuItems as mItems \r\nWHERE iItems.idInvoice = i.id AND iItems.idMenuItem = mItems.id AND i.stats = 0 AND i.idTable = " + tableID;
            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery(query);   

            foreach (DataRow row in data.Rows) 
            {
                OrderItem orderItem = new OrderItem(row);
                listOfOrderItems.Add(orderItem);
            }

            return listOfOrderItems;
        }

        public void DeleteOrderItemByItemID(int id)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("DELETE InvoiceItems WHERE idMenuItem = " + id);
        }
    }
}
