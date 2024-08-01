using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class ReservationDAO
    {
        private static ReservationDAO? instance;

        public static ReservationDAO Instance 
        {
            get { if (instance == null) instance = new ReservationDAO(); return instance; } 
            private set => instance = value; 
        
        }

        private ReservationDAO() { }

        public bool ReserveTableById(int tableId, string name, string phone, string date, string time, int seats, string email = "")
        {
            string query = String.Format("INSERT Reservations (idTable, customerName, customerPhone, date, time, seats, email) " +
                "VALUES ({0}, N'{1}', N'{2}', '{3}', N'{4}', {5}, N'{6}')", tableId, name, phone, date, time, seats, email);

            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }

        public List<Reservation> GetListOfReservations()
        {
            List<Reservation> listOfReservation = new List<Reservation>();

            string query = "SELECT * FROM Reservations";

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Reservation r = new Reservation(row);
                listOfReservation.Add(r);
            }

            return listOfReservation;
        }

        public bool UpdateReservation(int id, string name, string phone, string date, string time, int seats, string email)
        {
            string query = String.Format("UPDATE Reservations SET customerName = N'{0}', " +
                                                                    "customerPhone = N'{1}', " +
                                                                    "date = N'{2}', " +
                                                                    "time = N'{3}', " +
                                                                    "seats = {4}, " +
                                                                    "email = N'{5}' " +
                                                                    "WHERE id = {6}", name, phone, date, time, seats, email, id);

            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteReservation(int id)
        {
            string query = String.Format("DELETE Reservations WHERE id = {0}", id);
            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery(query) > 0;
        }
    }
}
