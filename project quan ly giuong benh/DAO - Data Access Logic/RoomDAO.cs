using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DAO___Data_Access_Logic
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get => instance == null ? instance = new RoomDAO() : instance;
            private set => instance = value;
        }

        public static int RoomWidth = 120;

        public static int RoomHeight = 120;

        private RoomDAO() { }

        public List<Room> GetListRoomByIdFloor(int id)
        {
            List<Room> listRoom = new List<Room>();

            string query = "SELECT * FROM dbo.Phong WHERE idTang = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Room room = new Room(item);
                listRoom.Add(room);
            }

            return listRoom;
        }

        public void UpdateCountMember(int count, int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateCountMember @count , @idPhong", new object[] { count, id });
        }
        
        public void UpdateStatusRoom(int status, int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateStatusRoom @status , @id", new object[] { status, id });
        }

        public List<Room> GetRoomList()
        {
            string query = "SELECT * FROM Phong";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Room> listRoom = new List<Room>();
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                listRoom.Add(room);
            }
            return listRoom;
        }

        public List<Room> GetRoomListByStatus(int status)
        {
            string query = "SELECT * FROM Phong WHERE trangThai = " + status;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Room> listRoom = new List<Room>();
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                listRoom.Add(room);
            }
            return listRoom;
        }

        public Room GetRoomById(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phong WHERE id = " + id);
            Room room = new Room(data.Rows[0]);
            return room;
        }

        public void InsertRoom(string name, int idTang, int max, int status)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertRoom @ten , @idTang , @gioiHan , @trangThai", new object[] { name, idTang, max, status });
        }

        public void UpdateRoomInfo(int id, string name, int idTang, int max, int status)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateRoomInfo @id , @ten , @idTang , @gioiHan, @trangThai ", new object[] { id, name, idTang, max, status });
        }

        public void DeleteRoom(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.Phong WHERE id = " + id);
        }
    }
}
