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
        bool sortAscending = false;
        public fQuanLyPhong()
        {
            InitializeComponent();
            LoadRoomList();
            List<Floor> floorList = FloorDAO.Instance.LoadFloorList();
            cboTang.DataSource = floorList;
            cboTang.DisplayMember = "Name";
        }

        List<Room> GetSelectedRoom()
        {
            var count = dtgvRoom.SelectedRows.Count;
            List<Room> listRoom = new List<Room>();
            List<int> listIndex = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int index = (int)dtgvRoom[0, dtgvRoom.SelectedRows[i].Index].Value;
                listIndex.Add(index);
            }
            if(listIndex.Count > 0)
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
            foreach(DataGridViewColumn item in dtgvRoom.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dtgvRoom.Tag = listRoom;
            RoomDisplayFormat();
        }

        void LoadRoomByStatus(int status)
        {
            List<Room> listRoom = RoomDAO.Instance.GetRoomListByStatus(status);
            dtgvRoom.DataSource = listRoom;
            RoomDisplayFormat();
        }

        void LoadRoomFormEdit()
        {
            List<Room> listRoom = GetSelectedRoom();
            if (listRoom.Count == 1)
            {
                Room room = listRoom[0];
                txbTenPhong.Text = room.Name;
                Floor floor = FloorDAO.Instance.GetFloorById(room.IDTang);
                cboTang.Text = floor.Name;
                chkThuong.Checked = chkCapCuu.Checked == chkSuaChua.Checked ? true : false;
                chkCapCuu.Checked = room.Status == "Cấp cứu" ? true : false;
                chkSuaChua.Checked = room.Status == "Hỏng" ? true : false;
            }
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
            LoadRoomByStatus(2);
        }

        private void btnDangSua_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(4);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            List<Room> listRoom = GetSelectedRoom();
            if(listRoom.Count > 0)
            {
                MessageBox.Show("Kiểm tra lại thông tin!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txbTenPhong.Clear();
                cboTang.Text = "";
                chkThuong.Checked = true;
                chkThuong.Checked = false;
                txbTenPhong.Focus();
                LoadRoomList();
            }
            else
            {
                string ten = txbTenPhong.Text;
                int status = 0;
                int max = (int)maxMember.Value;
                if (chkCapCuu.Checked) status = 3;
                else if (chkSuaChua.Checked) status = 4;
                Floor floor = cboTang.Tag as Floor;
                if (ten != "")
                    RoomDAO.Instance.InsertRoom(ten, floor.ID, max, status);
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên phòng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbTenPhong.Focus();
                }
                LoadRoomList();
                txbTenPhong.Clear();
            }    
        }

        private void cboTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return ;
            Floor floor = cb.SelectedItem as Floor;
            cboTang.Tag = floor;
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            List<Room> listRoom = GetSelectedRoom();
            if(listRoom.Count == 1)
            {
                //Load date cũ
                Room room = listRoom[0];
                txbTenPhong.Text = room.Name;
                Floor floor = FloorDAO.Instance.GetFloorById(room.IDTang);
                cboTang.Text = floor.Name;
                chkThuong.Checked = room.Status == "Trống" || room.Status == "Đầy" || room.Status == "Sắp khỏi hết" ? true : false;
                chkCapCuu.Checked = room.Status == "Cấp cứu" ? true : false;
                chkSuaChua.Checked = room.Status == "Hỏng" ? true : false;

                //Update thông tin mới
                Floor floorNew = cboTang.Tag as Floor;
                int status = 0;
                if (room.Status == "Sắp khỏi hết")
                    status = 2;
                if (chkCapCuu.Checked == true)
                    status = 3;
                if (chkSuaChua.Checked == true)
                    status = 4;
                //push to database
                if (txbTenPhong.Text != "")
                    //RoomDAO.Instance.UpdateRoomInfo(room.ID, txbTenPhong.Text, floorNew.ID, (int)maxMember.Value, status);
                    MessageBox.Show(status.ToString());
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên phòng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbTenPhong.Focus();
                }
                LoadRoomList();
                txbTenPhong.Clear();
                cboTang.Text = "";
            }
        }

        private void dtgvRoom_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadRoomFormEdit();
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            List<Room> listRoom = GetSelectedRoom();
            if(listRoom.Count>0)
                if (MessageBox.Show("Xác nhận xoá phòng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    foreach (Room item in listRoom)
                    {
                        if (item.Member != 0)
                            MessageBox.Show("Phòng đang có người, không thể xoá!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            RoomDAO.Instance.DeleteRoom(item.ID);
                        }
                        LoadRoomList();
                    }
        }

        private void dtgvRoom_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.ColumnIndex;
            List<Room> listRoom = dtgvRoom.Tag as List<Room>;
            List<Room> newList = new List<Room>();
            switch (index)
            {
                case 1:
                    newList = listRoom.OrderBy(x => x.Name).ToList();
                    break;
                case 2:
                    newList = listRoom.OrderBy(x => x.Member).ToList();
                    break;
                case 3:
                    newList = listRoom.OrderBy(x => x.Maximum).ToList();
                    break;
                case 4:
                    newList = listRoom.OrderBy(x => x.Status).ToList();
                    break;
            }
                

            dtgvRoom.DataSource = newList;
        }
    }
}
