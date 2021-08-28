using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DAO___Data_Access_Logic
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get => instance == null ? instance = new AccountDAO() : instance; 
            private set => instance = value; 
        }

        private AccountDAO()
        {

        }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord});
            return result.Rows.Count > 0;
        }

        public List<Account> GetAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Account> listAccount = new List<Account>();
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }
            return listAccount;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE tenDangNhap = '" + userName + "' ");
            foreach(DataRow item in data.Rows)
            {
                Account account = new Account(item);
                return account;
            }
            return null;
        }

        public bool UpdateAccountInfo(string userName, string displayName, string passWord, string newPassWord, int type)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateAccoutInfo @userName , @displayName , @passWord , @newPassWord ", new object[] { userName, displayName, passWord, newPassWord, type });
            return count > 0;
        }

        public bool CreateNewAccount(string userName, string displayName, int type)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertNewAccount @userName , @displayName , @type ", new object[] { userName, displayName, type });
            return count > 0;
        }

        public bool EditAccountInfo(string userName, string displayName, int type)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.Account SET tenHienThi = N'" + displayName + "', Type = " + type + " WHERE tenDangNhap = N'" + userName + "' ");
            return count > 0;
        }

        public List<Account> SreachAccoutByName(string name)
        {
            string query = "EXEC dbo.USP_SreachUserByName @name ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name, name });

            List<Account> listAccount = new List<Account>();
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }
            return listAccount;
        }
        public bool DeleteAccountByUserName(string userName)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.Account WHERE tenDangNhap = '" + userName + "' ");
            return count > 0;
        }
    }
}
