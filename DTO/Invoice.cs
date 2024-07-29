using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class Invoice
    {
        private int iD;
        private int status;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;

        public Invoice(int id, int status, DateTime? dateCheckIn, DateTime? dateCheckOut) 
        { 
            this.iD = id;
            this.status = status;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
        }

        public Invoice(DataRow row)
        {
            this.iD = (int)row["id"];
            this.status = (int)row["stats"];
            this.dateCheckIn = (DateTime?)row["dateCheckIn"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.dateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
