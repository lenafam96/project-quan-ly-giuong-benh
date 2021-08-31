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
    public partial class fMapBlock : Form
    {
        private List<Floor> listFloor;
        private List<Room> listRoom;
        public fMapBlock()
        {
            InitializeComponent();
            lbDateNow.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LoadFloorList();
            LoadDataGridView();
            CustomCell();
            LoadChuThich();
        }

        public List<Floor> ListFloor { get => listFloor; set => listFloor = value; }
        public List<Room> ListRoom { get => listRoom; set => listRoom = value; }

        void LoadFloorList()
        {
            ListFloor = FloorDAO.Instance.LoadFloorList();

        }

        void LoadDataGridView()
        {
            for (int i = 1; i < 16; i++)
            {
                if (i < 10)
                    dtgvMap.Columns.Add("Column" + i.ToString(), ".0" + i.ToString());
                else
                    dtgvMap.Columns.Add("Column" + i.ToString(), "." + i.ToString());
            }
            dtgvMap.Columns.Add("Sum", "Tổng");
            dtgvMap.Rows.Add(14);
            dtgvMap.RowHeadersWidth = 80;
            for (int i = 0; i < 13; i++)
            {
                dtgvMap.Rows[i].HeaderCell.Value = "Tầng " + (i + 2).ToString();
                dtgvMap.Rows[i].Height = 30;
            }
            dtgvMap.Rows[13].HeaderCell.Value = "TỔNG";
            dtgvMap.Columns[15].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dtgvMap.Columns[15].DefaultCellStyle.ForeColor = Color.Red;
        }

        Color checkStatus(string status)
        {
            if (status == "Trống")
                return Color.Azure;
            if (status == "Đầy")
                return Color.OrangeRed;
            if (status == "Cấp cứu")
                return Color.Plum;
            if (status == "Hỏng")
                return Color.Yellow;
            if (status == "Sắp khỏi hết")
                return Color.DodgerBlue;
            if (status == "Bận")
                return Color.Crimson;
            return Color.White;
        }
        void CustomCell()
        {
            dtgvMap.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            int i = 1, bigSum = 0;
            foreach(Floor item in ListFloor)
            {
                ListRoom = RoomDAO.Instance.GetListRoomByIdFloor(item.ID);
                int j = 0, sum = 0;
                foreach(Room room in ListRoom)
                {
                    dtgvMap.Rows[i].Cells[j].Style.BackColor = checkStatus(room.Status);
                    if(room.Status == "Hỏng")
                        dtgvMap.Rows[i].Cells[j].Value = "Hỏng";
                    else
                        dtgvMap.Rows[i].Cells[j].Value = room.Member;
                    sum += room.Member;
                    j++;
                }
                dtgvMap.Rows[i].Cells[15].Value = sum;
                bigSum += sum;
                i++;
            }
            dtgvMap.Rows[i].Cells[15].Value = bigSum;
        }

        void LoadChuThich()
        {
            dtgvChuThich.Rows.Add(1);
            dtgvChuThich.Rows[0].Cells[0].Style.BackColor = Color.Azure;
            dtgvChuThich.Rows[0].Cells[1].Style.BackColor = Color.DodgerBlue;
            dtgvChuThich.Rows[0].Cells[2].Style.BackColor = Color.OrangeRed;
            dtgvChuThich.Rows[0].Cells[3].Style.BackColor = Color.Plum;
            dtgvChuThich.Rows[0].Cells[4].Style.BackColor = Color.Yellow;
            dtgvChuThich.Rows[0].Cells[5].Style.BackColor = Color.Crimson;
        }
    }
}
