using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DAO___Data_Access_Logic
{
    public class FloorDAO
    {
        private static FloorDAO instance;

        public static FloorDAO Instance 
        {
            get => instance == null ? instance = new FloorDAO() : instance; 
            private set => instance = value; 
        }

        public static int FloorWidth = 75;

        public static int FloorHeight = 35;

        private FloorDAO() { }

        public List<Floor> LoadFloorList()
        {
            List<Floor> floorList = new List<Floor>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetFloorList");

            foreach(DataRow item in data.Rows)
            {
                Floor floor = new Floor(item);
                floorList.Add(floor);
            }

            return floorList;
        }
    }
}
