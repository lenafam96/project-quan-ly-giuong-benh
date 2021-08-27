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
    public partial class fQuanLyPhong : Form
    {
        public fQuanLyPhong()
        {
            InitializeComponent();
            LoadRoomList();
        }

        List<Room> GetSelectedMember()
        {
            var count = dtgvRoom.SelectedRows.Count;
            List<Room> listRoom = new List<Room>();
            List<int> listIndex = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int index = (int)dtgvRoom[0, dtgvRoom.SelectedRows[i].Index].Value;
                listIndex.Add(index);
            }
            foreach (int index in listIndex)
            {
                Room room = RoomDAO.Instance.GetRoomById(index);
                listRoom.Add(room);
            }
            return listRoom;
        }

        void LoadRoomList()
        {
            List<Room> listRoom = RoomDAO.Instance.GetRoomList();
            dtgvRoom.DataSource = listRoom;
            RoomDisplayFormat();
        }

        void LoadRoomByStatus(int status)
        {
            List<Room> listRoom = RoomDAO.Instance.GetRoomListByStatus(status);
            dtgvRoom.DataSource = listRoom;
            RoomDisplayFormat();
        }

        void RoomDisplayFormat()
        {
            dtgvRoom.ReadOnly = true;
            dtgvRoom.Columns[0].Visible = false;
            dtgvRoom.Columns[1].HeaderText = "Tên phòng";
            dtgvRoom.Columns[2].HeaderText = "Số người hiện tại";
            dtgvRoom.Columns[3].HeaderText = "Số người tối đa";
            dtgvRoom.Columns[4].HeaderText = "Trạng thái";
            dtgvRoom.Columns[5].Visible = false;
        }

        private void chkThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThuong.Checked)
                chkCapCuu.Checked = chkSuaChua.Checked = false;
        }

        private void chkCapCuu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapCuu.Checked)
                chkThuong.Checked = chkSuaChua.Checked = false;
        }

        private void chkSuaChua_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuaChua.Checked)
                chkCapCuu.Checked = chkThuong.Checked = false;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LoadRoomList();
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(0);
        }

        private void btnPhongDay_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(1);
        }

        private void btnPhongCapCuu_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(3);
        }

        private void btnPhongSapKhoi_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(1);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string ten = "";
        }

    }
}
