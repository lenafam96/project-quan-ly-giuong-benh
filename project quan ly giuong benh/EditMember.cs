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
            txbDanToc.Text = this.Member.DanToc;
            txbSdt.Text = this.Member.Sdt;
            txbDiaChi.Text = this.Member.DC;
            txbPhuongXa.Text = this.Member.PX;
            txbQuanHuyen.Text = this.Member.QH;
            txbTiTh.Text = this.Member.TiTh;
            cboKhoa.Text = this.Member.Khoa;
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
            string px = txbPhuongXa.Text;
            string qh = txbQuanHuyen.Text;
            bool check = false;
            check = txbHoTen.Text == null ? true : false;
            check = txbNamSinh.Text == null ? true : false;
            check = txbSdt.Text == null ? true : false;
            check = txbDiaChi.Text == null ? true : false;
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
            px = px.Trim(' ',',','-');
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
                MemberDAO.Instance.EditMemberBasic(this.Member.ID, txbHoTen.Text, ns, gt, dantoc, txbDiaChi.Text, px, qh, tp, txbSdt.Text, txbCccd.Text, txbNoiChuyen.Text, khoa, dtpNgayNhapVien.Value, dtpNgayXetNghiem.Value, txbTenNguoiThan.Text, txbMqh.Text, txbSdtNguoiThan.Text, pl, this.member.TT);
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
