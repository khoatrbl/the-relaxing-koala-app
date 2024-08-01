using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class InvoiceItemDAO
    {
        private static InvoiceItemDAO? instance;

        public static InvoiceItemDAO Instance 
        {
            get { if (instance == null) instance = new InvoiceItemDAO(); return instance; }
            private set => instance = value; 
        
        }

        private InvoiceItemDAO() { }

        // This method returns a list of invoice items (food that is orded) from the database
        public List<InvoiceItem> GetListOfInvoiceItems(int invoiceID) 
        { 
            List<InvoiceItem> listOfInvoiceItems = new List<InvoiceItem>();

            DataTable table = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM InvoiceItems WHERE idInvoice = " + invoiceID);

            foreach (DataRow row in table.Rows)
            {
                InvoiceItem invoiceItem = new InvoiceItem(row);
                listOfInvoiceItems.Add(invoiceItem);
            }

            return listOfInvoiceItems;
        }

        // This method adds a new invoice item into the database, with its associated invoice
        public void AddInvoiceItem(int invoiceID, int menuItemID, int count)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_InsertInvoiceItem @idInvoice , @idMenuItem , @count", new object[] { invoiceID, menuItemID, count });
        }
    }
}
