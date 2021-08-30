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
        private int idRoom;

        public int IdRoom { get => idRoom; set => idRoom = value; }

        public InsertMember(int id)
        {
            this.IdRoom = id;
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int ns;
            string px=txbPhuongXa.Text;
            string qh = txbQuanHuyen.Text;
            bool check = false;
            check = txbHoTen.Text == null ? true : false;
            check = txbNamSinh.Text == null ? true : false;
            check = txbSdt.Text == null ? true : false;
            check = txbDiaChi.Text == null ? true : false;
            check = txbPhuongXa.Text == null ? true : false;
            check = txbQuanHuyen.Text == null ? true : false;
            check = chkNam.Checked == false && chkNu.Checked == false ? true : false;
            check = int.TryParse(txbNamSinh.Text, out ns) ? false : true;
            string dantoc = txbDanToc.Text == null || txbDanToc.Text == "null" ? "Kinh" : txbDanToc.Text;
            string tp = txbTiTh.Text == null || txbTiTh.Text == "null" || txbTiTh.Text == "" ? "Hồ Chí Minh" : txbTiTh.Text;
            string khoa = cboKhoa.Text == null ? "E" : cboKhoa.Text;
            if (!txbPhuongXa.Text.ToUpper().Contains("Phường".ToUpper()))
                if (txbPhuongXa.Text.ToUpper().Contains("P.".ToUpper()))
                    px = txbPhuongXa.Text.ToUpper().Replace("P.", " ");
                else if (txbPhuongXa.Text.ToUpper().Contains(" P ".ToUpper()))
                    px = txbPhuongXa.Text.ToUpper().Replace(" P ", " ");
                else
                    px = txbPhuongXa.Text;
            else
                px = txbPhuongXa.Text.ToUpper().Replace("Phường".ToUpper(), " ");
            px = px.Trim(' ', ',', '-');
            if (!txbQuanHuyen.Text.ToUpper().Contains("Quận".ToUpper()))
                if (txbQuanHuyen.Text.ToUpper().Contains("Q.".ToUpper()))
                    qh = txbQuanHuyen.Text.ToUpper().Replace("Q.", " ");
                else if (txbQuanHuyen.Text.ToUpper().Contains("Q ".ToUpper()))
                    qh = txbQuanHuyen.Text.ToUpper().Replace("Q ", " ");
                else
                    qh = txbQuanHuyen.Text;
            else
                qh = txbQuanHuyen.Text.ToUpper().Replace("Quận".ToUpper(), " ");
            qh = qh.Trim(' ', ',', '-');
            if (!txbTiTh.Text.ToUpper().Contains("Thành phố".ToUpper()))
                if (txbTiTh.Text.ToUpper().Contains("TP.".ToUpper()))
                    tp = txbTiTh.Text.ToUpper().Replace("TP.", " ");
                else if (txbTiTh.Text.ToUpper().Contains("TP".ToUpper()))
                    tp = txbTiTh.Text.ToUpper().Replace("TP", " ");
                else
                    ;
            else
                tp = txbTiTh.Text.ToUpper().Replace("Thành phố".ToUpper(), " ");
            tp = tp.Trim(' ', ',', '-');
            if (check)
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!!");
            else
            {
                int gt = chkNam.Checked ? 0 : 1;
                int pl = chkF1.Checked ? 1 : 0;
                MemberDAO.Instance.InsertMember(this.IdRoom, txbHoTen.Text, ns, gt, dantoc, txbDiaChi.Text,px,qh,tp, txbSdt.Text, txbCccd.Text, txbNoiChuyen.Text, khoa, dtpNgayNhapVien.Value, dtpNgayXetNghiem.Value, txbTenNguoiThan.Text, txbMqh.Text, txbSdtNguoiThan.Text, pl);
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
            txbPhuongXa.Clear();
            txbQuanHuyen.Clear();
            txbTiTh.Clear();
            txbDanToc.Clear();
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
