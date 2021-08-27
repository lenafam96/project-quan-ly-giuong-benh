using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object
{
    public class Floor
    {
        public Floor(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Floor(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["ten"].ToString();
        }


        private int iD;
        private string name;


        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
