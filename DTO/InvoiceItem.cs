using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class InvoiceItem
    {
        private int id;
        private int idInvoice;
        private int idMenuItem;
        private int quantity;

        public InvoiceItem(int id, int idInvoice, int idMenuItem, int count) 
        { 
            this.id = id;
            this.idInvoice = idInvoice;
            this.idMenuItem = idMenuItem;
            this.quantity = count; 
        }

        public InvoiceItem(DataRow row) 
        {
            this.id = (int)row["id"];
            this.idInvoice = (int)row["idInvoice"];
            this.idMenuItem = (int)row["idMenuItem"];
            this.quantity = (int)row["count"];
        }

        public int IdInvoice { get => idInvoice; set => idInvoice = value; }
        public int IdMenuItem { get => idMenuItem; set => idMenuItem = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Id { get => id; set => id = value; }
    }
}
