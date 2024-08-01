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

        // Login method that hash the password and compare the credentials with the entries in the database
        public bool Login(string username, string password)
        {

            string hashedPassword = GetHash(password);


            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.InstanceOfDataProvider.ExecuteQuery(query, new object[] {username, hashedPassword});

            return result.Rows.Count > 0;
        }

        // Return a list of Account object obtained from the database
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

        // Return an account associate with the passed in username from the database
        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("SELECT * FROM Account WHERE username = '" + username + "'");

            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }

            return null;
        }

        // This method checks to see if a username exists in the database
        public bool CheckAccountByUsername(string username)
        {
            return (int)(DataProvider.InstanceOfDataProvider.ExecuteScalar("SELECT COUNT(*) FROM Account WHERE username = '" + username + "'")) == 1;
        }

        // This method checks the old password of the associated username for the purpose of changing the password.
        public bool CheckOldPasswordOfUsername(string username, string password)
        {
            bool result = false;
            DataTable data = DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_CheckPasswordByUsername @username", new object[] { username });
            foreach (DataRow row in data.Rows)
            {
                string hashedPassword = GetHash(password);
               
                result = row["password"].ToString() == hashedPassword;
            }
            return result;
        }

        // This method changes the password associated with the username
        public void ChangePassword(string username, string password) 
        {
            string hashedPassword = GetHash(password);
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_UpdatePassword @username , @newPassword", new object[] { username, hashedPassword });
        }

        // This method changes the associated display name with a username
        public void ChangeDisplayName(string username, string newDisplayName) 
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_ChangeDisplayName @username , @displayName", new object[] {username, newDisplayName});
        }

        // This method adds a new account into the database
        public void AddNewAccount(string username, string displayName)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_AddAccount @username , @displayName", new object[] {username, displayName});
        }

        // This method deletes an account from the database
        public void DeleteAccount(string username)
        {
            DataProvider.InstanceOfDataProvider.ExecuteQuery("USP_DeleteAccount @username", new object[] {username});
        }

        // This method handles updating fields of an account.
        public void UpdateAccount(string username, string displayName)
        {
            ChangeDisplayName(username, displayName);
        }

        // This method resets the password of an account to the default value of "1"
        public bool ResetPassword(string username)
        {
            return DataProvider.InstanceOfDataProvider.ExecuteNonQuery("UPDATE Account SET password = '1962026656160185351301320480154111117132155' WHERE username = '" + username + "'") > 0;
        }

        // This method returns the hash of a passed in item
        private string GetHash(string item)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(item);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashedItem = "";

            foreach (byte data in hashData)
            {
                hashedItem += data;
            }

            return hashedItem;
        }
    }
}
