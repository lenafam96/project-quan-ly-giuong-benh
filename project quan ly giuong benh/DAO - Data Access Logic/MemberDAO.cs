using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DAO___Data_Access_Logic
{
    public class MemberDAO
    {
        private static MemberDAO instance;

        public static MemberDAO Instance 
        {
            get => instance == null ? instance = new MemberDAO() : instance; 
            private set => instance = value; 
        }

        private MemberDAO() { }

        public List<Member> GetIdMemberByIdRoom(int id)
        {
            List<Member> listMember = new List<Member>();
            string query = "SELECT *, p.ten AS ten FROM dbo.BenhNhan, dbo.Phong AS p WHERE dbo.BenhNhan.idphong = p.id AND dbo.BenhNhan.trangThai = 0 AND idPhong = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Member member = new Member(item);
                //member = AutoUpdateNgayXetNghiem(member);
                listMember.Add(member);
            }
            return listMember;
        }
        /* Chuyển cho Sever làm
        private Member AutoUpdateNgayXetNghiem(Member member)
        {
            DateTime date = DateTime.Now;
            DateTime date1 = date.AddDays(-7);
            DateTime date2 = date.AddDays(-2);
            if(member.NXN != null)
            {
                if (date1 > member.NXN.Value && member.Slxn == 1)
                {
                    member.NXN = member.NXN.Value.AddDays(7);
                    member.Slxn++;
                    UpdateNgayXetNghiem(member.ID, 7, 1);
                }
                if (date2 > member.NXN.Value && member.Slxn > 1)
                {
                    member.NXN = member.NXN.Value.AddDays(2);
                    member.Slxn++;
                    UpdateNgayXetNghiem(member.ID, 2, 1);
                }
            }
            return member;
        }
        */
        public bool InsertMember(int idPhong, string maBenhNhan, string hoTen, int namSinh, int gioiTinh, string danToc, string diaChi, string phuongXa, string quanHuyen, string tinhThanh, string sdt, string cccd, string noiChuyen, string khoa, DateTime ngayNhapVien, DateTime ngayXetNghiem, string tenNguoiThan, string mqh, string sdtNguoiThan, int phanLoai)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertBenhNhan @idPhong , @maBenhNhan , @hoTen , @namSinh , @gioiTinh , @danToc , @diaChi , @phuongXa , @quanHuyen , @tinhThanh , @sdt , @cccd , @noiChuyen , @khoa , @ngayNhapVien , @ngayXetNghiem , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai , @slxn ", new object[] { idPhong , maBenhNhan, hoTen , namSinh , gioiTinh , danToc , diaChi , phuongXa ,
quanHuyen , tinhThanh , sdt , cccd , noiChuyen , khoa , ngayNhapVien , ngayXetNghiem , tenNguoiThan , mqh , sdtNguoiThan , phanLoai, 1});
            return count > 0;
        }


        public bool InsertMemberChuaXetNghiem(int idPhong, string maBenhNhan, string hoTen, int namSinh, int gioiTinh, string danToc, string diaChi, string phuongXa, string quanHuyen, string tinhThanh, string sdt, string cccd, string noiChuyen, string khoa, DateTime ngayNhapVien, string tenNguoiThan, string mqh, string sdtNguoiThan, int phanLoai)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertBenhNhanChuaXetNghiem @idPhong , @maBenhNhan , @hoTen , @namSinh , @gioiTinh , @danToc , @diaChi , @phuongXa , @quanHuyen , @tinhThanh , @sdt , @cccd , @noiChuyen , @khoa , @ngayNhapVien , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai , @slxn ", new object[] { idPhong , maBenhNhan, hoTen , namSinh , gioiTinh , danToc , diaChi , phuongXa ,
quanHuyen , tinhThanh , sdt , cccd , noiChuyen , khoa , ngayNhapVien , tenNguoiThan , mqh , sdtNguoiThan , phanLoai, 0});
            return count > 0;
        }

        public bool UpdateNgayXetNghiem(int id, int day, int slxn)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateNgayXetNghiem @id , @day , @slxn " ,new object[] { id, day , slxn});
            return count > 0;
        }

        public bool ChangeRoom(int id, int idPhong)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_ChangeRoom @id , @idPhong", new object[] { id, idPhong });
            return count > 0;
        }

        public bool UpdateStatus(int id, int status)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateStatusMember @id , @trangThai", new object[] { id, status });
            return count > 0;
        }

        public bool EditMemberXuatVien(int id, string maBenhNhan, string soLuuTru, string hoTen, int namSinh, int gioiTinh, string danToc, string diaChi, string phuongXa, string quanHuyen, string tinhThanh, string sdt, string cccd, string noiChuyen, string khoa, DateTime ngayNhapVien, DateTime ngayXuatVien, DateTime ngayXetNghiem, string kyThuatXN, string ketQua, double ctValue, string tenNguoiThan, string mqh, string sdtNguoiThan, int phanLoai, int trangThai, int slxn)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_EditBenhNhanXuatVien @id , @maBenhNhan , @soLuuTru , @hoTen , @namSinh , @gioiTinh , @danToc , @diaChi , @phuongXa , @quanHuyen , @tinhThanh , @sdt , @cccd , @noiChuyen , @khoa , @ngayNhapVien , @ngayXuatVien , @ngayXetNghiem , @kyThuatXN , @ketQua , @ctValue , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai , @trangThai , @slxn ", new object[] { id, maBenhNhan, soLuuTru, hoTen, namSinh, gioiTinh, danToc, diaChi, phuongXa, quanHuyen, tinhThanh, sdt, cccd, noiChuyen, khoa, ngayNhapVien, ngayXuatVien, ngayXetNghiem, kyThuatXN, ketQua, ctValue, tenNguoiThan, mqh, sdtNguoiThan, phanLoai, trangThai, slxn });
            return count > 0;
        }

        public bool EditMemberChuyenTuyen(int id, string maBenhNhan, string hoTen, int namSinh, int gioiTinh, string danToc, string diaChi, string phuongXa, string quanHuyen, string tinhThanh, string sdt, string cccd, string noiChuyen, string khoa, DateTime ngayNhapVien, DateTime ngayXuatVien, DateTime ngayXetNghiem, string noiDen, string tenNguoiThan, string mqh, string sdtNguoiThan, int phanLoai)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_EditBenhNhanChuyenTuyen @id , @maBenhNhan , @hoTen , @namSinh , @gioiTinh , @danToc , @diaChi , @phuongXa , @quanHuyen , @tinhThanh , @sdt , @cccd , @noiChuyen , @khoa , @ngayNhapVien , @ngayXuatVien , @ngayXetNghiem , @noiDen , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai ", new object[] { id, maBenhNhan, hoTen, namSinh, gioiTinh, danToc, diaChi, phuongXa, quanHuyen, tinhThanh, sdt, cccd, noiChuyen, khoa, ngayNhapVien, ngayXuatVien, ngayXetNghiem, noiDen, tenNguoiThan, mqh, sdtNguoiThan, phanLoai});
            return count > 0;
        }

        public bool EditMemberBasic(int id, string maBenhNhan, string hoTen, int namSinh, int gioiTinh, string danToc, string diaChi, string phuongXa, string quanHuyen, string tinhThanh, string sdt, string cccd, string noiChuyen, string khoa, DateTime ngayNhapVien, DateTime ngayXetNghiem, string tenNguoiThan, string mqh, string sdtNguoiThan, int phanLoai, int trangThai, int slxn)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_EditBenhNhanBasic @id , @maBenhNhan , @hoTen , @namSinh , @gioiTinh , @danToc , @diaChi , @phuongXa , @quanHuyen , @tinhThanh , @sdt , @cccd , @noiChuyen , @khoa , @ngayNhapVien , @ngayXetNghiem , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai , @trangThai , @slxn ", new object[] { id, maBenhNhan, hoTen, namSinh, gioiTinh, danToc, diaChi, phuongXa, quanHuyen, tinhThanh, sdt, cccd, noiChuyen, khoa, ngayNhapVien, ngayXetNghiem, tenNguoiThan, mqh, sdtNguoiThan, phanLoai, trangThai , slxn});
            return count > 0;
        }


        public bool EditMemberBasicChuaXetNghiem(int id, string maBenhNhan, string hoTen, int namSinh, int gioiTinh, string danToc, string diaChi, string phuongXa, string quanHuyen, string tinhThanh, string sdt, string cccd, string noiChuyen, string khoa, DateTime ngayNhapVien, string tenNguoiThan, string mqh, string sdtNguoiThan, int phanLoai, int trangThai)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_EditBenhNhanBasicChuaXetNghiem @id , @maBenhNhan , @hoTen , @namSinh , @gioiTinh , @danToc , @diaChi , @phuongXa , @quanHuyen , @tinhThanh , @sdt , @cccd , @noiChuyen , @khoa , @ngayNhapVien , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai , @trangThai ", new object[] { id, maBenhNhan, hoTen, namSinh, gioiTinh, danToc, diaChi, phuongXa, quanHuyen, tinhThanh, sdt, cccd, noiChuyen, khoa, ngayNhapVien, tenNguoiThan, mqh, sdtNguoiThan, phanLoai, trangThai });
            return count > 0;
        }


        public List<Member> GetMemberList(int status)
        {
            string query = "EXEC dbo.USP_GetListMember " + status;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<Member> listMember = new List<Member>();
            foreach (DataRow item in data.Rows)
            {
                Member member = new Member(item);
                //if(status == 0) member = AutoUpdateNgayXetNghiem(member);
                listMember.Add(member);
            }
            return listMember;
        }

        public List<Member> GetMemberList(int status, string name, string sort)
        {
            if (name == "p.ten")
                name = "CAST(p.ten AS INT)";
            string query = "SELECT * FROM dbo.BenhNhan AS b, dbo.Phong AS p WHERE b.idPhong = p.id AND b.trangThai = " + status + " ORDER BY " + name + " " + sort;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<Member> listMember = new List<Member>();
            foreach (DataRow item in data.Rows)
            {
                Member member = new Member(item);
                //if (status == 0) member = AutoUpdateNgayXetNghiem(member);
                listMember.Add(member);
            }
            return listMember;
        }

        public Member GetMemberById(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *, idPhong as [ten] FROM dbo.BenhNhan WHERE id = " + id);
            Member member = new Member(data.Rows[0]);
            return member;
        }

        public DataTable SreachMemberByName(string name, int status, DateTime date1, DateTime date2)
        {
            string query = "EXEC dbo.USP_SreachMemberByName @name , @trangthai , @datefrom , @dateto ";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { name, status, date1, date2});

        }

        public bool UpdateXuatVien(int id, string maBN, string soLT, DateTime ngayXV, DateTime ngayXN, string kyThuatXN, string kq, double ctValue)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateXuatVien @id , @maBN , @soLT , @ngayXV , @ngayXN , @kyThuatXN , @kq , @ctValue ", new object[] { id, maBN, soLT, ngayXV, ngayXN, kyThuatXN, kq, ctValue });
            return count > 0;
        }

        public bool UpdateChuyenTuyen(int id, string maBN, DateTime ngayXV, string noiDen)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateChuyenTuyen @id , @maBN , @ngayXV , @noiDen ", new object[] { id, maBN, ngayXV, noiDen });
            return count > 0;
        }

        public DataTable GetListBenhNhanDangDieuTri(DateTime dateFrom, DateTime DateTo, int status, int page, int pageRows)
        {
            return DataProvider.Instance.ExecuteQuery("EXECUTE dbo.USP_GetListMemberByDateAndPage @datefrom , @dateto , @trangthai , @page , @pageRows ", new object[] { dateFrom, DateTo, status, page, pageRows});
        }

        public int GetNumMember(DateTime dateFrom, DateTime DateTo, int status)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC dbo.USP_GetNumMemberByDate @datefrom , @dateto , @trangthai ", new object[] { dateFrom, DateTo, status});
        }
    }
}
