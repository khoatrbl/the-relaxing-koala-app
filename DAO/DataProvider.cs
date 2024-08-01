using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RestaurantIS.DAO
{
    public class DataProvider
    {
        private static DataProvider? instanceOfDataProvider; 

        // insert your connection string here
        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=TheRelaxingKoala;Integrated Security=True";

        public static DataProvider InstanceOfDataProvider 
        { 
            get {
                if (instanceOfDataProvider == null)
                {
                    instanceOfDataProvider = new DataProvider(); 
                }
                return DataProvider.instanceOfDataProvider;
            }
            private set { DataProvider.instanceOfDataProvider = value; } 
        }

        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] param = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (param != null)
                {
                    int i = 0;
                    string[] listOfParam = query.Split(' ');
                    foreach (string item in listOfParam)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (param != null)
                {
                    int i = 0;
                    string[] listOfParam = query.Split(' ');
                    foreach (string item in listOfParam)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] param = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (param != null)
                {
                    int i = 0;
                    string[] listOfParam = query.Split(' ');
                    foreach (string item in listOfParam)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
    }
}
