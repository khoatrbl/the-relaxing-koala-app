using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class Reservation
    {
        private int id;
        private int tableId;
        private string customerName;
        private string phone;
        private string date;
        private string time;
        private int seats;
        private string email;

        public Reservation(int id, int tableId, string customerName, string phone, string date, string time, int seats, string email) 
        {
            this.Id = id;
            this.TableId = tableId;
            this.CustomerName = customerName;
            this.Phone = phone;
            this.Date = date;
            this.Time = time;
            this.Seats = seats;
            this.Email = email;
        }
        
        public Reservation(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TableId = (int)row["idTable"];
            this.CustomerName = row["customerName"].ToString();
            this.Phone = row["customerPhone"].ToString();
            this.Date = row["date"].ToString();
            this.Time = row["time"].ToString();
            this.Seats = (int)row["seats"];
            this.Email = row["email"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public int Seats { get => seats; set => seats = value; }
        public string Email { get => email; set => email = value; }
    }
}
