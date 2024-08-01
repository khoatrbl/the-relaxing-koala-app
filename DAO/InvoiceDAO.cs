using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class InvoiceDAO
    {
        private static InvoiceDAO? instance;

        public static InvoiceDAO Instance 
        {
            get { if (instance == null) instance = new InvoiceDAO(); return instance; } 
            private set => instance = value; 
        
        }

        private InvoiceDAO() { }

        // This method returns the invoice id that associated with a table
        // Successful (there is an invoice with that table): returns the invoice id
        // Unsuccessful (there is no invoice with that table): returns -1
        public int GetUnpaidInvoiceIDByTableID(int tableID)
        {
            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_GetInvoice @idTable , @stats", new object[] {tableID, 0});

            if (data.Rows.Count > 0)
            {
                Invoice invoice = new Invoice(data.Rows[0]);
                return invoice.ID;
            }
            return -1;
        }

        // This methods add an invoice into the database
        public void AddInvoice(int tableID)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_InsertInvoice @idTable", new object[] {tableID});
        }

        // This method returns the largest id in the Invoice table in the database
        public int GetMaxInvoiceID()
        {
            try
            {
                return (int)DataProvider.InstanceOfDataProvider.ExecuteScalar("SELECT MAX(id) FROM Invoice");
            }
            catch { return 1; }
            
        }

        // This method returns a list of invoice within a specific time range
        public DataTable GetListOfInvoicesByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_GetListOfInvoiceByDate @dateCheckIn , @dateCheckOut", new object[] { checkIn, checkOut });
        }

        // This method handles making payment
        public void MakePayment(int invoiceID, float totalPrice)
        {
            string query = "UPDATE Invoice SET dateCheckOut = GETDATE(), stats = 1, totalPrice = " + totalPrice +  "WHERE id = " + invoiceID;
            DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query);
        }
    }
}
