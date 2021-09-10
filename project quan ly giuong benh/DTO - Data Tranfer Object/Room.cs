using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object
{
    public class Room
    {
        public Room(int id, string name, int idTang, int member, int maximum, string status)
        {
            this.ID = id;
            this.Name = name;
            this.IDTang = idTang;
            this.Member = member;
            this.Maximum = maximum;
            this.Status = status;
        }

        public Room(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["ten"].ToString();
            this.IDTang = (int)row["idTang"];
            this.Member = (int)row["soNguoi"];
            this.Maximum = (int)row["gioiHan"];
            switch ((int)row["trangThai"])
            {
                case 0:
                    this.Status = "Trống";
                    break;
                case 1:
                    this.Status = "Đầy";
                    break;
                case 6:
                    this.Status = "Khoá";
                    break;
                case 3:
                    this.Status = "Cấp cứu";
                    break;
                case 4:
                    this.Status = "Hỏng";
                    break;
                case 5:
                    this.Status = "Bận";
                    break;
            }
        }


        private int iD;
        private string name;
        private int iDTang;
        private int member;
        private int maximum;
        private string status;


        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Member { get => member; set => member = value; }
        public int Maximum { get => maximum; set => maximum = value; }
        public string Status { get => status; set => status = value; }
        public int IDTang { get => iDTang; set => iDTang = value; }
    }
}
