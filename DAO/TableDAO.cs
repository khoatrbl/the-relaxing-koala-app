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

        public bool AddTable(string name, string status)
        {
            string query = String.Format("INSERT TableList (name, stats) VALUES (N'{0}', N'{1}')", name, status);

            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0; 
        }

        public bool UpdateTable(int id, string name, string status)
        {
            string query = String.Format("UPDATE TableList SET name = N'{0}', stats = N'{1}' WHERE id = {2}", name, status, id);

            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }
    }
}
