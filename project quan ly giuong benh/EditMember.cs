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
            txbTenNguoiThan.Text = this.Member.HtNT;
            txbMqh.Text = this.Member.Mqh;
            txbSdtNguoiThan.Text = this.Member.SdtNT;
            chkF0.Checked = this.Member.PL == "f0" ? true : false;
            chkF0.Checked = this.Member.PL == "f1" ? true : false;
            if(this.Member.NXN == null)
            {
                cboXN.Text = "Chưa xét nghiệm";
                dtpNgayXetNghiem.Enabled = false;
            }    
            else
            {
                dtpNgayXetNghiem.Value = (DateTime)this.Member.NXN;
                cboXN.Text = "Đã xét nghiệm";
                dtpNgayXetNghiem.Enabled = true;

            }
            lbTenPhong.Text += this.Member.Phong;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int ns = 0;
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
            px = px.Trim(' ', ',', '-');
            if (!txbPhuongXa.Text.ToUpper().Contains("Phường".ToUpper()))
                if (txbPhuongXa.Text.ToUpper().Contains("P.".ToUpper()))
                    px = txbPhuongXa.Text.ToUpper().Replace("P.", " ");
                else if (txbPhuongXa.Text.ToUpper().Contains("P ".ToUpper())&& txbPhuongXa.Text.ToUpper().IndexOf("P ".ToUpper())==0)
                    px = txbPhuongXa.Text.ToUpper().Remove(0,1);
                else
                    px = txbPhuongXa.Text;
            else
                px = txbPhuongXa.Text.ToUpper().Replace("Phường".ToUpper(), " ");
            px = px.Trim(' ',',','-');
            if (px.Length < 4) px = px.ToUpper().Replace("P".ToUpper(), string.Empty);
            qh = qh.Trim(' ', ',', '-');
            if (!txbQuanHuyen.Text.ToUpper().Contains("Quận".ToUpper()))
                if (txbQuanHuyen.Text.ToUpper().Contains("Q.".ToUpper()))
                    qh = txbQuanHuyen.Text.ToUpper().Replace("Q.", " ");
                else if (txbQuanHuyen.Text.ToUpper().Contains("Q ".ToUpper())&& txbQuanHuyen.Text.ToUpper().IndexOf("Q ".ToUpper())==0)
                    qh = txbQuanHuyen.Text.ToUpper().Remove(0, 1);
                else
                    qh = txbQuanHuyen.Text;
            else
                qh = txbQuanHuyen.Text.ToUpper().Replace("Quận".ToUpper(), " ");
            qh = qh.Trim(' ', ',', '-');
            if (qh.Length < 4) qh = qh.ToUpper().Replace("Q".ToUpper(), string.Empty);
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
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                int gt = chkNam.Checked ? 0 : 1;
                int pl = chkF1.Checked ? 1 : 0;
                DateTime ngayXNnext = this.Member.Slxn > 1 ? this.Member.NXN.Value.AddDays(2) : this.Member.NXN.Value.AddDays(7);
                if (cboXN.Text == "Đã xét nghiệm")
                    if(this.Member.Slxn == 0 || dtpNgayXetNghiem.Value < ngayXNnext)
                        MemberDAO.Instance.EditMemberBasic(this.Member.ID, txbHoTen.Text.Trim(' ', ',', '-'), ns, gt, dantoc.Trim(' ', ',', '-'), txbDiaChi.Text, px, qh, tp, txbSdt.Text.Trim(' ', ',', '-'), txbCccd.Text.Trim(' ', ',', '-'), txbNoiChuyen.Text.Trim(' ', ',', '-'), khoa, dtpNgayNhapVien.Value, dtpNgayXetNghiem.Value, txbTenNguoiThan.Text.Trim(' ', ',', '-'), txbMqh.Text.Trim(' ', ',', '-'), txbSdtNguoiThan.Text.Trim(' ', ',', '-'), pl, this.member.TT,1);
                    else
                        MemberDAO.Instance.EditMemberBasic(this.Member.ID, txbHoTen.Text.Trim(' ', ',', '-'), ns, gt, dantoc.Trim(' ', ',', '-'), txbDiaChi.Text, px, qh, tp, txbSdt.Text.Trim(' ', ',', '-'), txbCccd.Text.Trim(' ', ',', '-'), txbNoiChuyen.Text.Trim(' ', ',', '-'), khoa, dtpNgayNhapVien.Value, dtpNgayXetNghiem.Value, txbTenNguoiThan.Text.Trim(' ', ',', '-'), txbMqh.Text.Trim(' ', ',', '-'), txbSdtNguoiThan.Text.Trim(' ', ',', '-'), pl, this.member.TT, 0);
                else
                    MemberDAO.Instance.EditMemberBasicChuaXetNghiem(this.Member.ID, txbHoTen.Text.Trim(' ', ',', '-'), ns, gt, dantoc.Trim(' ', ',', '-'), txbDiaChi.Text, px, qh, tp, txbSdt.Text.Trim(' ', ',', '-'), txbCccd.Text.Trim(' ', ',', '-'), txbNoiChuyen.Text.Trim(' ', ',', '-'), khoa, dtpNgayNhapVien.Value, txbTenNguoiThan.Text.Trim(' ', ',', '-'), txbMqh.Text.Trim(' ', ',', '-'), txbSdtNguoiThan.Text.Trim(' ', ',', '-'), pl, this.member.TT);

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

        private void cboXN_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpNgayXetNghiem.Enabled = cboXN.Text == "Đã xét nghiệm" ? true : false;

        }
    }
}
