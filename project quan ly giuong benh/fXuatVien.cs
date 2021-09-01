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
    public partial class fXuatVien : Form
    {
        private Member member;
        public fXuatVien(Member member)
        {
            InitializeComponent();
            this.Member = member;
            txbHoTen.Text = this.Member.HT;
            dtpNgayXetNghiem.Value = (DateTime)this.Member.NXN;
        }

        public Member Member { get => member; set => member = value; }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool check = false;
            double ctValue = 0;
            string kq = cboKq.Text;
            if(kq == "Dương tính")
            {
                check = txbCTValue.Text == null ? true : false;
                check = double.TryParse(txbCTValue.Text, out ctValue);
                check = ctValue < 30 ? true : false;
            }
            check = this.Member.Slxn == 2 && cboKTXN.Text != "PCR" ? true : false;
            if (check)
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MemberDAO.Instance.UpdateXuatVien(this.Member.ID, txbMaBN.Text.Trim(' ', ',', '-'), txbSoLT.Text.Trim(' ', ',', '-'), dtpNgayXuatVien.Value, dtpNgayXetNghiem.Value, cboKTXN.Text, kq, ctValue);
                this.Close();

            }
        }
    }
}
