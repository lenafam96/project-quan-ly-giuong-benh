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
    public partial class InsertMember : Form
    {
        int idRoom;
        public InsertMember(int id)
        {
            this.idRoom = id;
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
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
                MemberDAO.Instance.InsertMember(this.idRoom, txbHoTen.Text, gt, ns, txbSdt.Text, txbDiaChi.Text, txbCccd.Text, txbNoiChuyen.Text, dtpNgayNhapVien.Value, dtpNgayXetNghiem.Value, txbTenNguoiThan.Text, txbMqh.Text, txbSdtNguoiThan.Text, pl);
                this.Close();
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbHoTen.Clear();
            txbNamSinh.Clear();
            txbSdt.Clear();
            txbDiaChi.Clear();
            txbCccd.Clear();
            txbTenNguoiThan.Clear();
            txbMqh.Clear();
            txbSdtNguoiThan.Clear();
            txbNoiChuyen.Clear();
            chkNam.Checked = false;
            chkNu.Checked = false;
            chkF0.Checked = false;
            chkF1.Checked = false;
            txbHoTen.Focus();
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
