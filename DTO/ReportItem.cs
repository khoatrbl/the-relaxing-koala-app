using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class ReportItem
    {
        private int menuItemId;
        private string menuItemName;
        private string categoryName;
        private int orderedQuantity;
        private DateTime firstOrderedDate;
        private DateTime lastOrderedDate;

        public ReportItem(int menuItemId, string menuItemName, string categoryName, int orderedQuantity, DateTime firstOrderedDate, DateTime lastOrderedDate)
        {
            this.MenuItemName = menuItemName;
            this.CategoryName = categoryName;
            this.OrderedQuantity = orderedQuantity;
            this.FirstOrderedDate = firstOrderedDate;
            this.LastOrderedDate = lastOrderedDate; 
        }

        public ReportItem(DataRow row)
        {
            this.MenuItemId = (int)row["Item ID"];
            this.MenuItemName = row["Item Name"].ToString();
            this.CategoryName = row["Category"].ToString();
            this.OrderedQuantity = (int)row["Total Quantity Ordered"];
            this.FirstOrderedDate = (DateTime)row["First Ordered Date"];
            this.LastOrderedDate = (DateTime)row["Last Ordered Date"];
        }

        public int MenuItemId { get => menuItemId; set => menuItemId = value; }
        public string MenuItemName { get => menuItemName; set => menuItemName = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int OrderedQuantity { get => orderedQuantity; set => orderedQuantity = value; }
        public DateTime FirstOrderedDate { get => firstOrderedDate; set => firstOrderedDate = value; }
        public DateTime LastOrderedDate { get => lastOrderedDate; set => lastOrderedDate = value; }
    }
}
