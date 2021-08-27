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
    }
}
