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
        BindingSource listAccount = new BindingSource();
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            dtgvUser.DataSource = listAccount;
            LoadAccountList();
            AddUserBinding();
        }

        void LoadAccountList()
        {
            List<Account> list = AccountDAO.Instance.GetAccountList();
            List<string> listTypeAccount = new List<string>() { "Admin", "User" };
            listAccount.DataSource = list;
            dtgvUser.ReadOnly = true;
            dtgvUser.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvUser.Columns[1].HeaderText = "Tên hiển thị";
            dtgvUser.Columns[2].Visible = false;
            dtgvUser.Columns[3].HeaderText = "Loại tài khoản";
            cboLoaiTK.DataSource = listTypeAccount;
            cboLoaiTK.DisplayMember = "Type";
            dtgvUser.Tag = list;
        }

        void AddUserBinding()
        {
            txbTenDangNhap.DataBindings.Add(new Binding("Text",dtgvUser.DataSource, "UserName",true, DataSourceUpdateMode.Never));
            txbTenHienThi.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
        }

        List<Account> SreachAccountByName(string name)
        {
            List<Account> list = AccountDAO.Instance.SreachAccoutByName(name);

            return list;
        }

        bool checkName(string name)
        {
            List<Account> list = dtgvUser.Tag as List<Account>;
            foreach (Account item in list)
                if (item.UserName == name) return true;
            return false;
        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            cboLoaiTK.Text = dtgvUser.SelectedCells[0].OwningRow.Cells["Type"].Value.ToString();
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            dtgvUser.DataSource = SreachAccountByName(txbFindAccount.Text);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string ten = txbTenDangNhap.Text;
            string tenHT = txbTenHienThi.Text;
            int type = 0;
            if (cboLoaiTK.Text == "Admin")
                type = 1;
            if (ten != "" && !checkName(ten))
                if (AccountDAO.Instance.CreateNewAccount(ten, tenHT, type))
                    MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Tạo tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTenDangNhap.Focus();
            }
            LoadAccountList();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            //Update thông tin mới
            int type = 0;
            if (cboLoaiTK.Text == "Admin")
                type = 1;
            //push to database
            if (txbTenDangNhap.Text != "")
                if (AccountDAO.Instance.EditAccountInfo(txbTenDangNhap.Text, txbTenHienThi.Text, type))
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Tên đăng nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTenHienThi.Focus();
            }
            LoadAccountList();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đặt lại mật khẩu mặc định?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                if (AccountDAO.Instance.ResetPassWord(txbTenDangNhap.Text))
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (DataGridViewCell item in dtgvUser.SelectedCells)
            {
                list.Add(item.OwningRow.Cells[0].Value.ToString());
            }
            if (MessageBox.Show("Xác nhận xoá tài khoản?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK && list.Count > 0)
                foreach (string item in list)
                {
                    AccountDAO.Instance.DeleteAccountByUserName(item);        
                }
            LoadAccountList();
        }
    }
}
