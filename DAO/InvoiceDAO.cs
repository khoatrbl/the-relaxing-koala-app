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

        /// <summary>
        /// Successful: Invoice ID
        /// Unsuccessful: -1
        /// </summary>
        /// <param name="tableID"></param>
        /// <returns></returns>
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

        public void AddInvoice(int tableID)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_InsertInvoice @idTable", new object[] {tableID});
        }

        public int GetMaxInvoiceID()
        {
            try
            {
                return (int)DataProvider.InstanceOfDataProvider.ExecuteScalar("SELECT MAX(id) FROM Invoice");
            }
            catch { return 1; }
            
        }

        public DataTable GetListOfInvoicesByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_GetListOfInvoiceByDate @dateCheckIn , @dateCheckOut", new object[] { checkIn, checkOut });
        }

        public void MakePayment(int invoiceID, float totalPrice)
        {
            string query = "UPDATE Invoice SET dateCheckOut = GETDATE(), stats = 1, totalPrice = " + totalPrice +  "WHERE id = " + invoiceID;
            DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query);
        }
    }
}
