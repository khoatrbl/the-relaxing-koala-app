using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class ReportDAO
    {
        private static ReportDAO? instance;

        public static ReportDAO? Instance 
        {
            get { if (instance == null) instance = new ReportDAO(); return instance; }  
            private set => instance = value; 
        
        }

        private ReportDAO() { }

        public List<ReportItem> LoadReport()
        {
            string query = "USP_ReportOnSale";

            List<ReportItem> listOfReportItems = new List<ReportItem>();

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows) 
            {
                ReportItem reportItem = new ReportItem(row);
                listOfReportItems.Add(reportItem);
            }

            return listOfReportItems;
        }
    }
}
