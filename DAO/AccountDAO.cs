using RestaurantIS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIS.DAO
{
    public class AccountDAO
    {
        private static AccountDAO? instanceOfAccountDAO;

        public static AccountDAO InstanceOfAccountDAO 
        {
            get 
            { 
                if (instanceOfAccountDAO == null)
                {
                    instanceOfAccountDAO = new AccountDAO();
                }
                return instanceOfAccountDAO;
            }   
            private set => instanceOfAccountDAO = value; 
        
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashedPassword = "";

            foreach(byte item in hashData)
            {
                hashedPassword += item;
            }



            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.InstanceOfDataProvider.ExecuteQuery(query, new object[] {username, hashedPassword});

            return result.Rows.Count > 0;
        }

        public List<Account> GetListOfAccounts()
        {
            List<Account> listOfAccounts = new List<Account>();

            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM Account");
            foreach (DataRow row in data.Rows)
            {
                Account account = new Account(row);
                listOfAccounts.Add(account);
            }

            return listOfAccounts;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM Account WHERE username = '" + username + "'");

            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }

            return null;
        }

        public bool CheckAccountByUsername(string username)
        {
            return (int)(DataProvider.InstanceOfDataProvider.ExecuteScalar("SELECT COUNT(*) FROM Account WHERE username = '" + username + "'")) == 1;
        }

        public bool CheckOldPasswordOfUsername(string username, string password)
        {
            bool result = false;
            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_CheckPasswordByUsername @username", new object[] { username });
            foreach (DataRow row in data.Rows)
            {
                result = row["password"].ToString() == password;
            }
            return result;
        }

        public void ChangePassword(string username, string password) 
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_UpdatePassword @username , @newPassword", new object[] { username, password });
        }

        public void ChangeDisplayName(string username, string newDisplayName) 
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_ChangeDisplayName @username , @displayName", new object[] {username, newDisplayName});
        }

        public void AddNewAccount(string username, string displayName)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_AddAccount @username , @displayName", new object[] {username, displayName});
        }

        public void DeleteAccount(string username)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_DeleteAccount @username", new object[] {username});
        }

        public void UpdateAccount(string username, string displayName)
        {
            ChangeDisplayName(username, displayName);
        }

        public bool ResetPassword(string username)
        {
            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery("UPDATE Account SET password = '1962026656160185351301320480154111117132155' WHERE username = '" + username + "'") > 0;
        }
    }
}
