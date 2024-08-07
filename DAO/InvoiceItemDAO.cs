﻿using RestaurantIS.DTO;
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

        // This method adds a new invoice item into the database, with its associated invoice.
        public void AddInvoiceItem(int invoiceID, int menuItemID, int count)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_InsertInvoiceItem @idInvoice , @idMenuItem , @count", new object[] { invoiceID, menuItemID, count });
        }
    }
}
