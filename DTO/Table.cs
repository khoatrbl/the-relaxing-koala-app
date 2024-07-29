using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class Table
    {
        private int iD;
        private string name;
        private string status;
        private float totalOrderPrice;

        public Table(int iD, string name, string status)
        {
            this.iD = iD;
            this.status = status;
            this.name = name;   
        }   

        public Table(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = (string)row["Name"];
            this.Status = (string)row["stats"];
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }   
        }


        public string Status
        {
            get { return status; }
            set { status = value; } 
        }

        public float TotalOrderPrice { get => totalOrderPrice; set => totalOrderPrice = value; }
    }
}
