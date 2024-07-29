using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class TableDAO
    {
        private static TableDAO? instance;
        public static int TableWidth = 120;
        public static int TableHeight = 120;

        public static TableDAO Instance 
        { 
            get { if (instance == null) instance = new TableDAO(); return instance; } 
            private set => instance = value; 
        }

        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_GetTableList");

            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
