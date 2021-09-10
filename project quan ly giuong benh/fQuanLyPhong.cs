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
        BindingSource listRoom = new BindingSource();
        public fQuanLyPhong()
        {
            InitializeComponent();
            Load1();
            
        }

        void Load1()
        {
            dtgvRoom.DataSource = listRoom;
            LoadRoomList();
            LoadcboTang();
            AddRoomBinding();
        }

        void LoadcboTang()
        {
            List<Floor> floorList = FloorDAO.Instance.LoadFloorList();
            cboTang.DataSource = floorList;
            cboTang.DisplayMember = "Name";
        }
        void LoadRoomList()
        {
            List<Room> list = RoomDAO.Instance.GetRoomList();
            if (list.Count <= 0)
                list.Add(new Room(0, "NaN", 1, 0, 0, "NaN"));
            listRoom.DataSource = list;
            RoomDisplayFormat();
            dtgvRoom.Tag = list;
        }

        void LoadRoomByStatus(int status)
        {
            List<Room> list = RoomDAO.Instance.GetRoomListByStatus(status);
            if (list.Count <= 0)
                list.Add(new Room(0, "NaN", 1, 0, 0, "NaN"));
            listRoom.DataSource = list;
            RoomDisplayFormat();
        }

        void AddRoomBinding()
        {
            txbTenPhong.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "Name", true, DataSourceUpdateMode.Never));
            maxMember.DataBindings.Add(new Binding("Value", dtgvRoom.DataSource, "Maximum", true, DataSourceUpdateMode.Never));
        }

        void RoomDisplayFormat()
        {
            dtgvRoom.ReadOnly = true;
            dtgvRoom.Columns[0].Visible = false;
            dtgvRoom.Columns[0].Tag = true;
            dtgvRoom.Columns[1].HeaderText = "Tên phòng";
            dtgvRoom.Columns[1].Tag = "ten";
            dtgvRoom.Columns[2].HeaderText = "Số người hiện tại";
            dtgvRoom.Columns[2].Tag = "soNguoi";
            dtgvRoom.Columns[3].HeaderText = "Số người tối đa";
            dtgvRoom.Columns[3].Tag = "gioiHan";
            dtgvRoom.Columns[4].HeaderText = "Trạng thái";
            dtgvRoom.Columns[4].Tag = "trangThai";
            dtgvRoom.Columns[5].Visible = false;
            dtgvRoom.Columns[5].Tag = -1;

        }

        bool checkName(string name)
        {
            List<Room> list = dtgvRoom.Tag as List<Room>;
            foreach (Room item in list)
                if (item.Name == name) return true;
            return false;
        }

        private void chkThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThuong.Checked)
                chkCapCuu.Checked = chkSuaChua.Checked = chkBusy.Checked = chkKhoa.Checked = false;
        }

        private void chkCapCuu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapCuu.Checked)
                chkThuong.Checked = chkSuaChua.Checked = chkBusy.Checked = chkKhoa.Checked = false;
        }

        private void chkSuaChua_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuaChua.Checked)
                chkCapCuu.Checked = chkThuong.Checked = chkBusy.Checked = chkKhoa.Checked = false;
        }

        private void chkBusy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBusy.Checked)
                chkSuaChua.Checked = chkCapCuu.Checked = chkThuong.Checked = chkKhoa.Checked = false;
        }


        private void chkKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhoa.Checked)
                chkSuaChua.Checked = chkCapCuu.Checked = chkThuong.Checked = chkBusy.Checked = false;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LoadRoomList();
            dtgvRoom.Columns[5].Tag = -1;
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(0);
            dtgvRoom.Columns[5].Tag = 0;
        }

        private void btnPhongDay_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(1);
            dtgvRoom.Columns[5].Tag = 1;
        }

        private void btnPhongCapCuu_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(3);
            dtgvRoom.Columns[5].Tag = 3;
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(6);
            dtgvRoom.Columns[6].Tag = 5;
        }

        private void btnDangSua_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(4);
            dtgvRoom.Columns[5].Tag = 4;
        }

        private void btnBusy_Click(object sender, EventArgs e)
        {
            LoadRoomByStatus(5);
            dtgvRoom.Columns[5].Tag = 5;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int soPhong;
            string ten = txbTenPhong.Text;
            int status = 0;
            int max = (int)maxMember.Value;
            if (chkCapCuu.Checked) status = 3;
            else if (chkSuaChua.Checked) status = 4;
            else if (chkBusy.Checked) status = 5;
            else if (chkKhoa.Checked) status = 6;
            Floor floor = cboTang.Tag as Floor;
            if (ten != "" && !checkName(ten) && int.TryParse(ten,out soPhong))
                if(RoomDAO.Instance.InsertRoom(ten, floor.ID, max, status))
                    MessageBox.Show("Tạo phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Tạo phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                {
                MessageBox.Show("Bạn chưa nhập tên phòng hoặc thông tin không đúng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTenPhong.Focus();
            }
            LoadRoomList();
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

            //Load date cũ
            int soPhong;
            int id = (int)dtgvRoom.SelectedCells[0].OwningRow.Cells["ID"].Value;
            int member = (int)dtgvRoom.SelectedCells[0].OwningRow.Cells["Member"].Value;
            string statusText = dtgvRoom.SelectedCells[0].OwningRow.Cells["Status"].Value.ToString();
            //Update thông tin mới
            Floor floorNew = cboTang.Tag as Floor;
            int status = 0;
            if (statusText == "Sắp khỏi hết")
                status = 2;
            if (chkCapCuu.Checked == true)
                status = 3;
            if (chkSuaChua.Checked == true)
                status = 4;
            if (chkBusy.Checked == true)
                status = 5;
            if (chkKhoa.Checked == true)
                status = 6;
            //push to database
            if (txbTenPhong.Text != "" && int.TryParse(txbTenPhong.Text,out soPhong))
                if ((status == 4 || status == 6) && member > 0)
                    MessageBox.Show("Chưa chuyển hết bệnh nhân đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    if (RoomDAO.Instance.UpdateRoomInfo(id, txbTenPhong.Text, floorNew.ID, (int)maxMember.Value, status))
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                {
                    MessageBox.Show("Bạn chưa nhập tên phòng hoặc thông tin không đúng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbTenPhong.Focus();
                }
            LoadRoomList();
        }


        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            List<Room> listRoom = new List<Room>();
            foreach(DataGridViewCell item in dtgvRoom.SelectedCells)
            {
                listRoom.Add(RoomDAO.Instance.GetRoomById((int)item.OwningRow.Cells[0].Value));
            }
            if (MessageBox.Show("Xác nhận xoá phòng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                foreach (Room item in listRoom)
                {
                    if (item.Member != 0)
                        MessageBox.Show("Phòng " + item.Name + " đang có người, không thể xoá!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        RoomDAO.Instance.DeleteRoom(item.ID);
                    }
                    LoadRoomList();
                }
        }

        private void txbTenPhong_TextChanged(object sender, EventArgs e)
        {
            string status = "";
            if (dtgvRoom.SelectedCells[0].OwningRow.Cells["IDTang"].Value != null)
            {
                int id = (int)dtgvRoom.SelectedCells[0].OwningRow.Cells["IDTang"].Value;
                Floor floor = FloorDAO.Instance.GetFloorById(id);
                cboTang.Text = floor.Name;
                status = dtgvRoom.SelectedCells[0].OwningRow.Cells["Status"].Value.ToString(); 
            }
            if (status == "Cấp cứu")
                chkCapCuu.Checked = true;
            else if (status == "Hỏng")
                chkSuaChua.Checked = true;
            else if (status == "Bận")
                chkBusy.Checked = true;
            else if (status == "Khoá")
                chkKhoa.Checked = true;
            else 
                chkThuong.Checked = true;
        }

        private void dtgvRoom_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sort = (bool)dtgvRoom.Columns[0].Tag ? "ASC" : "DESC";
            string columnName = dtgvRoom.Columns[e.ColumnIndex].Tag != null ? dtgvRoom.Columns[e.ColumnIndex].Tag.ToString() : "2";
            int status = dtgvRoom.Columns[5].Tag != null ? (int)dtgvRoom.Columns[5].Tag : -1;
            listRoom.DataSource = status == -1 ? RoomDAO.Instance.GetRoomList(columnName, sort) : listRoom.DataSource = RoomDAO.Instance.GetRoomListByStatus(status, columnName, sort);
            dtgvRoom.Columns[0].Tag = !(bool)dtgvRoom.Columns[0].Tag;
        }

    }
}
