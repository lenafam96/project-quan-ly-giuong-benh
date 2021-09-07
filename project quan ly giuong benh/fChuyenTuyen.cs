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
    public partial class fChuyenTuyen : Form
    {
        private Member member;
        public fChuyenTuyen(Member member)
        {
            InitializeComponent();
            this.Member = member;
            txbHoTen.Text = this.Member.HT;
            txbMaBN.Text = this.Member.MaBN;
            dtpNgayXuatVien.MaxDate = DateTime.Now;
        }

        public Member Member { get => member; set => member = value; }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MemberDAO.Instance.UpdateChuyenTuyen(this.Member.ID, txbMaBN.Text.Trim(' ', ',', '-'), dtpNgayXuatVien.Value, txbCTValue.Text.Trim(' ', ',', '-'));
            this.Close();
        }
    }
}
