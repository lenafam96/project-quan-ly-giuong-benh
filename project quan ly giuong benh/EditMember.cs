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
    public partial class EditMember : Form
    {
        private Member member;

        public Member Member { get => member; set => member = value; }

        public EditMember(Member member)
        {
            this.Member = member;
            InitializeComponent();
            txbHoTen.Text = this.Member.HT;
            chkNam.Checked = this.Member.GT == "Nam" ? true : false;
            chkNu.Checked = this.Member.GT == "Nữ" ? true : false;
            txbNamSinh.Text = this.Member.NS.ToString();
            txbSdt.Text = this.Member.Sdt;
            txbDiaChi.Text = this.Member.DC;
            txbCccd.Text = this.Member.Cccd;
            txbNoiChuyen.Text = this.Member.NC;
            dtpNgayNhapVien.Value = (DateTime)this.Member.NNV;
            dtpNgayXetNghiem.Value = (DateTime)this.Member.NXN;
            txbTenNguoiThan.Text = this.Member.HtNT;
            txbMqh.Text = this.Member.Mqh;
            txbSdtNguoiThan.Text = this.Member.SdtNT;
            chkF0.Checked = this.Member.PL == "f0" ? true : false;
            chkF0.Checked = this.Member.PL == "f1" ? true : false;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int ns;
            bool check = false;
            check = txbHoTen.Text == null ? true : false;
            check = txbNamSinh.Text == null ? true : false;
            check = txbSdt.Text == null ? true : false;
            check = txbDiaChi.Text == null ? true : false;
            check = chkNam.Checked == false && chkNu.Checked == false ? true : false;
            check = int.TryParse(txbNamSinh.Text, out ns) ? false : true;
            if (check)
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!!");
            else
            {
                int gt = chkNam.Checked ? 0 : 1;
                int pl = chkF1.Checked ? 1 : 0;
                MemberDAO.Instance.EditMember(this.Member.ID, int.Parse(this.Member.Phong), txbHoTen.Text, gt, ns, txbSdt.Text, txbDiaChi.Text, txbCccd.Text, txbNoiChuyen.Text, dtpNgayNhapVien.Value, dtpNgayXetNghiem.Value, txbTenNguoiThan.Text, txbMqh.Text, txbSdtNguoiThan.Text, pl);
                this.Close();

            }
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            chkNu.Checked = chkNam.Checked ? false : true;

        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            chkNam.Checked = chkNu.Checked ? false : true;

        }

        private void chkF0_CheckedChanged(object sender, EventArgs e)
        {
            chkF1.Checked = chkF0.Checked ? false : true;
        }

        private void chkF1_CheckedChanged(object sender, EventArgs e)
        {
            chkF0.Checked = chkF1.Checked ? false : true;
        }

    }
}
