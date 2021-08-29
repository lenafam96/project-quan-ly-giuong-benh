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
            DateTime date = DateTime.Now;
            DateTime date1 = date.AddDays(-7);
            string query = "SELECT *, idPhong AS ten FROM dbo.BenhNhan WHERE trangThai = 0 AND idPhong = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Member member = new Member(item);
                while(date1 >= member.NXN.Value )
                {
                    member.NXN = member.NXN.Value.AddDays(7);
                    UpdateNgayXetNghiem(member.ID);
                }
                listMember.Add(member);
            }
            return listMember;
        }

        public void InsertMember(int id, string ht, int gt, int ns, string sdt, string dc, string cccd, string nc, DateTime nnv, DateTime nxn, string tennt, string mqh, string sdtnt, int pl)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBenhNhan @idPhong , @hoTen , @gioiTinh , @namSinh , @sdt , @diaChi , @cccd , @noiChuyen , @ngayNhapVien , @ngayXetNghiem , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai ", new object[] { id, ht, gt, ns, sdt, dc, cccd, nc, nnv, nxn, tennt, mqh, sdtnt, pl});
        }

        public void UpdateNgayXetNghiem(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateNgayXetNghiem " + id);
        }

        public void ChangeRoom(int id, int idPhong)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_ChangeRoom @id , @idPhong", new object[] { id, idPhong });
        }

        public void UpdateStatus(int id, int status)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateStatusMember @id , @trangThai", new object[] { id, status });
        }
        
        public void EditMember(int id, int idPhong, string ht, int gt, int ns, string sdt, string dc, string cccd, string nc, DateTime nnv, DateTime nxn, string tennt, string mqh, string sdtnt, int pl)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_EditBenhNhan @id , @idPhong , @hoTen , @gioiTinh , @namSinh , @sdt , @diaChi , @cccd , @noiChuyen , @ngayNhapVien , @ngayXetNghiem , @tenNguoiThan , @mqh , @sdtNguoiThan , @phanLoai ", new object[] { id, idPhong, ht, gt, ns, sdt, dc, cccd, nc, nnv, nxn, tennt, mqh, sdtnt, pl });
        }

        public List<Member> GetMemberList(int status)
        {
            string query = "EXEC dbo.USP_GetListMember " + status;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<Member> listMember = new List<Member>();
            foreach (DataRow item in data.Rows)
            {
                Member member = new Member(item);
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

        public List<Member> SreachMemberByName(string name, int status)
        {
            string query = "EXEC dbo.USP_SreachMemberByName @name , @trangthai ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name, status});

            List<Member> listMember = new List<Member>();
            foreach (DataRow item in data.Rows)
            {
                Member member = new Member(item);
                listMember.Add(member);
            }
            return listMember;
        }
    }
}
