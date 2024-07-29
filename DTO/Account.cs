using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DTO
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string password;

        public Account(string userName, string displayName, string password = null)
        {
            this.userName = userName;
            this.displayName = displayName;
            this.password = password;
        }

        public Account(DataRow row)
        {
            this.userName = row["username"].ToString();
            this.displayName = row["displayName"].ToString();
            this.password = row["password"].ToString();
        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }


    }
}
