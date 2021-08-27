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
        public Member(int id, string phong, string ht, string gt, int ns, string sdt, string dc, string cccd, string nc, DateTime? nnv, DateTime? nxn, string htnt, string mqh, string sdtnt, string pl, int tt)
        {
            this.ID = id;
            this.Phong = phong;
            this.HT = ht;
            this.GT = gt;
            this.NS = ns;
            this.Sdt = sdt;
            this.DC = dc;
            this.Cccd = cccd;
            this.NC = nc;
            this.NNV = nnv;
            this.NXN = nxn;
            this.HtNT = htnt;
            this.Mqh = mqh;
            this.SdtNT = sdtnt;
            this.PL = pl;
            this.TT = tt;
        }

        public Member(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Phong = row["ten"].ToString();
            this.HT = row["hoTen"].ToString();
            if ((int)row["gioiTinh"] == 0)
                this.GT = "Nam";
            else
                this.GT = "Nữ";
            this.NS = (int)row["namSinh"];
            this.Sdt = row["sdt"].ToString();
            this.DC = row["diaChi"].ToString();
            this.Cccd = row["cccd"].ToString();
            this.NC = row["noiChuyen"].ToString();
            var ngayNhapVienTemp = row["ngayNhapVien"];
            if (ngayNhapVienTemp.ToString() != "")
                this.NNV = (DateTime?)ngayNhapVienTemp;
            var ngayXetNghiemTemp = row["ngayXetNghiem"];
            if (ngayXetNghiemTemp.ToString() != "")
                this.NXN = (DateTime?)ngayXetNghiemTemp;
            this.HtNT = row["tenNguoiThan"].ToString();
            this.Mqh = row["mqh"].ToString();
            this.SdtNT = row["sdtNguoiThan"].ToString();
            this.PL = "f"+ (int)row["phanLoai"];
            this.TT = (int)row["trangThai"];
        }

        private int iD;
        private string phong;
        private string hT;
        private string gT;
        private int nS;
        private string sdt;
        private string dC;
        private string cccd;
        private string nC;
        private DateTime? nNV;
        private DateTime? nXN;
        private string htNT;
        private string mqh;
        private string sdtNT;
        private string pL;
        private int tT;

        public int ID { get => iD; set => iD = value; }
        public string Phong { get => phong; set => phong = value; }
        public string HT { get => hT; set => hT = value; }
        public string GT { get => gT; set => gT = value; }
        public int NS { get => nS; set => nS = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DC { get => dC; set => dC = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string NC { get => nC; set => nC = value; }
        public DateTime? NNV { get => nNV; set => nNV = value; }
        public DateTime? NXN { get => nXN; set => nXN = value; }
        public string HtNT { get => htNT; set => htNT = value; }
        public string Mqh { get => mqh; set => mqh = value; }
        public string SdtNT { get => sdtNT; set => sdtNT = value; }
        public string PL { get => pL; set => pL = value; }
        public int TT { get => tT; set => tT = value; }
    }
}
