using project_quan_ly_giuong_benh.DAO___Data_Access_Logic;
using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_quan_ly_giuong_benh
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; LoadAccoutInfor(LoginAccount); } }

        public fAccountProfile(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;

        }

        //Load data cũ
        void LoadAccoutInfor(Account account)
        {
            txbUserName.Text = account.UserName;
            txbDisplayName.Text = account.DisplayName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (LoginAccount.Type == "Admin")
                type = 1;
            if (txbNewPassword.Text == txbNewPassword2.Text)
                if (AccountDAO.Instance.UpdateAccountInfo(txbUserName.Text, txbDisplayName.Text, txbPassword.Text, txbNewPassword.Text, type))
                {
                    MessageBox.Show("Cập nhập thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginAccount.DisplayName = txbDisplayName.Text;
                    if (updateDisplayName != null)
                        updateDisplayName(this, new AccountEvent(txbDisplayName.Text));
                    this.Close();
                }    
                else
                    MessageBox.Show("Mật khẩu không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Mật khẩu mới nhập lại không trùng mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private event EventHandler<AccountEvent> updateDisplayName;
        public event EventHandler<AccountEvent> UpdateDisplayName
        {
            add { updateDisplayName += value; }
            remove { updateDisplayName -= value; }
        }

    }
    public class AccountEvent : EventArgs
    {
        private string displayName;

        public string DisplayName { get => displayName; set => displayName = value; }

        public AccountEvent(string txt)
        {
            this.DisplayName = txt;
        }
    }
}
