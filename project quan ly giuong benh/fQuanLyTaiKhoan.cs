using project_quan_ly_giuong_benh.DAO___Data_Access_Logic;
using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_quan_ly_giuong_benh
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            List<Account> listAcooutnt = AccountDAO.Instance.GetAccountList();

            dtgvUser.DataSource = listAcooutnt;
            dtgvUser.ReadOnly = true;
            dtgvUser.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvUser.Columns[1].HeaderText = "Tên hiển thị";
            dtgvUser.Columns[2].HeaderText = "Mật khẩu";
            dtgvUser.Columns[3].HeaderText = "Loại tài khoản";
        }
    }
}
