using project_quan_ly_giuong_benh.DAO___Data_Access_Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object
{
    public class Member
    {
        public Member(int iD, string phong, string maBN, string soLT, string hT, int nS, string gT, string danToc, string dC, string pX, string qH, string tiTh, string sdt, string cccd, string nC, string khoa, DateTime? nNV, DateTime? nXV, int sndt, DateTime? nXN, string ktxn, string kq, double ctValue, string htNT, string mqh, string sdtNT, string pL, int tT, int slxn)
        {
            this.ID = iD;
            this.Phong = phong;
            this.MaBN = maBN;
            this.SoLT = soLT;
            this.HT = hT;
            this.NS = nS;
            this.GT = gT;
            this.DanToc = danToc;
            this.DC = dC;
            this.PX = pX;
            this.QH = qH;
            this.TiTh = tiTh;
            this.Sdt = sdt;
            this.Cccd = cccd;
            this.NC = nC;
            this.Khoa = khoa;
            this.NNV = nNV;
            this.NXV = nXN;
            this.Sndt = sndt;
            this.NXN = nXN;
            this.Ktxn = ktxn;
            this.Kq = kq;
            this.CtValue = ctValue;
            this.HtNT = htNT;
            this.Mqh = mqh;
            this.SdtNT = sdtNT;
            this.PL = pL;
            this.TT = tT;
            this.slxn = slxn;
        }

        public Member(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Phong = row["ten"].ToString();
            this.MaBN = row["maBenhNhan"].ToString();
            this.SoLT = row["soLuuTru"].ToString();
            this.HT = row["hoTen"].ToString();
            this.NS = (int)row["namSinh"];
            if ((int)row["gioiTinh"] == 0)
                this.GT = "Nam";
            else
                this.GT = "Nữ";
            this.DanToc = row["danToc"].ToString();
            this.DC = row["diaChi"].ToString();
            this.PX = row["phuongXa"].ToString();
            this.QH = row["quanHuyen"].ToString();
            this.TiTh = row["tinhThanh"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Cccd = row["cccd"].ToString();
            this.NC = row["noiChuyen"].ToString();
            this.Khoa = row["khoa"].ToString();
            var ngayNhapVienTemp = row["ngayNhapVien"];
            if (ngayNhapVienTemp.ToString() != "")
                this.NNV = (DateTime?)ngayNhapVienTemp;
            var ngayXuatVienTemp = row["ngayXuatVien"];
            if (ngayXuatVienTemp.ToString() != "")
                this.NXV = (DateTime?)ngayXuatVienTemp;
            if (this.NXV != null)
                this.Sndt = this.NXV.Value.Subtract(this.nNV.Value).Days;
            else
                this.Sndt = DateTime.Now.Subtract(this.nNV.Value).Days;
            var ngayXetNghiemTemp = row["ngayXetNghiem"];
            if (ngayXetNghiemTemp.ToString() != "")
                this.NXN = (DateTime?)ngayXetNghiemTemp;
            this.Ktxn = row["kyThuatXN"].ToString();
            this.Kq = row["ketQua"].ToString();
            this.CtValue = (double)row["ctValue"];
            this.HtNT = row["tenNguoiThan"].ToString();
            this.Mqh = row["mqh"].ToString();
            this.SdtNT = row["sdtNguoiThan"].ToString();
            this.PL = "f"+ (int)row["phanLoai"];
            this.TT = (int)row["trangThai"];
            this.slxn = (int)row["slxn"];
        }

        private int iD;
        private string phong;
        private string maBN;
        private string soLT;
        private string hT;
        private int nS;
        private string gT;
        private string danToc;
        private string dC;
        private string pX;
        private string qH;
        private string tiTh;
        private string sdt;
        private string cccd;
        private string nC;
        private string khoa;
        private DateTime? nNV;
        private DateTime? nXV;
        private int sndt;
        private DateTime? nXN;
        private string ktxn;
        private string kq;
        private double ctValue;
        private string htNT;
        private string mqh;
        private string sdtNT;
        private string pL;
        private int tT;
        private int slxn;

        public int ID { get => iD; set => iD = value; }
        public string Phong { get => phong; set => phong = value; }
        public string MaBN { get => maBN; set => maBN = value; }
        public string SoLT { get => soLT; set => soLT = value; }
        public string HT { get => hT; set => hT = value; }
        public int NS { get => nS; set => nS = value; }
        public string GT { get => gT; set => gT = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string DC { get => dC; set => dC = value; }
        public string PX { get => pX; set => pX = value; }
        public string QH { get => qH; set => qH = value; }
        public string TiTh { get => tiTh; set => tiTh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string NC { get => nC; set => nC = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public DateTime? NNV { get => nNV; set => nNV = value; }
        public DateTime? NXV { get => nXV; set => nXV = value; }
        public int Sndt { get => sndt; set => sndt = value; }
        public DateTime? NXN { get => nXN; set => nXN = value; }
        public string Ktxn { get => ktxn; set => ktxn = value; }
        public string Kq { get => kq; set => kq = value; }
        public double CtValue { get => ctValue; set => ctValue = value; }
        public string HtNT { get => htNT; set => htNT = value; }
        public string Mqh { get => mqh; set => mqh = value; }
        public string SdtNT { get => sdtNT; set => sdtNT = value; }
        public string PL { get => pL; set => pL = value; }
        public int TT { get => tT; set => tT = value; }
        public int Slxn { get => slxn; set => slxn = value; }
    }
}
