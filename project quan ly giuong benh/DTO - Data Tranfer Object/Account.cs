using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object
{
    public class Account
    {
        public Account(string userName, string displayName, string type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["tenDangNhap"].ToString();
            this.DisplayName = row["tenHienThi"].ToString();
            this.Type = (int)row["Type"]==1?"Admin":"User";
            //this.Password = row["matKhau"].ToString();
        }

        private string userName;
        private string displayName;
        private string password;
        private string type;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
    }
}
