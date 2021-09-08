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
    public partial class fFloorManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount 
        { 
            get => loginAccount; 
            set { loginAccount = value; ChangeAccount(LoginAccount.Type); } 
        }

        public fFloorManager(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            LoadFloor();
            //LoadRoom(1);
            LoadRoomCapCuu();
            showMember(45);
            //btnChangeRoom.Enabled = false;
            Room room = RoomDAO.Instance.GetRoomById(58);
            cboTang.Tag = room;
            lsvChiaPhong.Tag = room;
        }
        #region Methods
        void LoadFloor()
        {
            flpFloor.Controls.Clear();
            List<Floor> floorList = FloorDAO.Instance.LoadFloorList();
            cboTang.DataSource = floorList;
            cboTang.DisplayMember = "Name";
            Button btnCapCuu = new Button() { Width = FloorDAO.FloorWidth, Height = FloorDAO.FloorHeight };
            btnCapCuu.Text = "Cấp Cứu";
            btnCapCuu.BackColor = ColorTranslator.FromHtml("#A9D08E");
            btnCapCuu.Click += btnCapCuu_Click;
            flpFloor.Controls.Add(btnCapCuu);
            foreach(Floor item in floorList)
            {
                Button btn = new Button() { Width = FloorDAO.FloorWidth, Height = FloorDAO.FloorHeight};
                btn.Text = item.Name;
                btn.Click += btnFloor_Click;
                btn.Tag = item;
                flpFloor.Controls.Add(btn);
            }
        }

        int ConverStatusToInt(string status)
        {
            switch (status)
            {
                case "Đầy":
                    return 1;
                case "Sắp khỏi hết":
                    return 2;
                case "Cấp cứu":
                    return 3;
                case "Hỏng":
                    return 4;
                case "Bận":
                    return 5;
                default:
                    return 0;
            }
            
        }

        void LoadRoomCapCuu()
        {
            flpRoom.Controls.Clear();
            List<Room> roomList = RoomDAO.Instance.GetRoomListByStatus(3);
            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                btn.Font = new Font(btn.Font.FontFamily, 14);
                btn.Text = item.Name + Environment.NewLine + Environment.NewLine + item.Member + "/" + item.Maximum;
                btn.Click += btnRoom_Click;
                btn.Tag = item;
                btn.BackColor = ColorTranslator.FromHtml("#A9D08E");
                flpRoom.Controls.Add(btn);
            }
        }

        void LoadRoom(int id)
        {
            flpRoom.Controls.Clear();
            List<Room> roomList = RoomDAO.Instance.GetListRoomByIdFloor(id);
            foreach (Room item in roomList)
            {
                if (item.Status == "Cấp cứu")
                    continue;
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                btn.Font = new Font(btn.Font.FontFamily, 14);
                /*
                 * Kiểm tra phòng sắp khỏi chuyển trạng thái
                 */
                #region Phòng sắp khỏi
                /*
                if (CheckPhongSapKhoi(item.ID) && item.Member>0 && item.Status!= "Cấp cứu" && item.Status != "Hỏng" && item.Status != "Bận")
                {
                    RoomDAO.Instance.UpdateStatusRoom(2, item.ID);
                    item.Status = "Sắp khỏi hết";
                }
                else
                {
                    if (item.Status != "Cấp cứu" && item.Status != "Hỏng" && item.Status != "Bận")
                        item.Status = item.Member == item.Maximum ? "Đầy" : "Trống";
                    RoomDAO.Instance.UpdateStatusRoom(ConverStatusToInt(item.Status), item.ID);
                }
                */
                #endregion


                if (item.Status == "Hỏng")
                {
                    btn.Text = item.Name + Environment.NewLine + Environment.NewLine + item.Status;
                    btn.Enabled = false;
                }
                else
                    btn.Text = item.Name + Environment.NewLine + Environment.NewLine + item.Member + "/" + item.Maximum;
                btn.Click += btnRoom_Click;
                btn.Tag = item;
                if (item.Status == "Trống")
                    btn.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                if(item.Status == "Đầy")
                    btn.BackColor = ColorTranslator.FromHtml("#FF0000");
                if (item.Status == "Cấp cứu")
                    btn.BackColor = ColorTranslator.FromHtml("#A9D08E");
                if (item.Status == "Hỏng")
                    btn.BackColor = ColorTranslator.FromHtml("#FFFF00");
                if (item.Status == "Sắp khỏi hết")
                    btn.BackColor = ColorTranslator.FromHtml("#CC66FF");
                if (item.Status == "Bận")
                    btn.BackColor = ColorTranslator.FromHtml("#00B0F0");
                flpRoom.Controls.Add(btn);
            }
            
        }

        bool CheckPhongSapKhoi(int id)
        {
            List<Member> listMember = MemberDAO.Instance.GetIdMemberByIdRoom(id);
            DateTime date = DateTime.Now;
            foreach(Member item in listMember)
                if (DateTime.Compare(date.AddDays(-7), (DateTime)item.NNV)<0)
                    return false;
            return true;
        }

        void LoadRoomComboBox(int id)
        {
            List<Room> roomList = RoomDAO.Instance.GetListRoomByIdFloor(id);
            cboPhong.DataSource = roomList;
            cboPhong.DisplayMember = "Name";
        }

        void showMember(int id)
        {
            int count = 0;
            lsvChiaPhong.Items.Clear();
            List<Member> listMember = MemberDAO.Instance.GetIdMemberByIdRoom(id);
            foreach(Member item in listMember)
            {
                ListViewItem lsvItem = new ListViewItem(item.HT.ToString());
                lsvItem.SubItems.Add(item.NS.ToString());
                lsvItem.SubItems.Add(item.Sdt.ToString());
                lsvItem.SubItems.Add(item.NNV.Value.ToString("dd/MM/yyyy"));
                if (item.NXN != null)
                {
                    lsvItem.SubItems.Add(item.NXN.Value.ToString("dd/MM/yyyy"));
                    if(item.Slxn<2)
                        lsvItem.SubItems.Add((item.NXN.Value.AddDays(7).ToString("dd/MM/yyyy")));
                    else
                        lsvItem.SubItems.Add((item.NXN.Value.AddDays(2).ToString("dd/MM/yyyy")));
                }
                else
                {
                    lsvItem.SubItems.Add("Chưa xét nghiệm");
                    lsvItem.SubItems.Add("Chưa xét nghiệm");
                }
                lsvItem.Tag = item;
                lsvChiaPhong.Items.Add(lsvItem);

                count++;
            }
            RoomDAO.Instance.UpdateCountMember(count, id);
        }

        void ChangeAccount(string type)
        {
            adminToolStripMenuItem.Enabled = type == "Admin";
            mnsThongTinTK.Text += " (" + LoginAccount.DisplayName + ")";
        }

        void ChoseRoomForLoad(Room room)
        {
            if (room.Status == "Cấp cứu")
                LoadRoomCapCuu();
            else LoadRoom(room.IDTang);
        }
        #endregion



        #region Events
        void btnCapCuu_Click(object sender, EventArgs e)
        {
            LoadRoomCapCuu();
        }

        void btnFloor_Click(object sender, EventArgs e)
        {
            Floor floor = (sender as Button).Tag as Floor;
            LoadRoom(floor.ID);
        }

        void btnRoom_Click(object sender, EventArgs e)
        {
            int roomID = ((sender as Button).Tag as Room).ID;
            lsvChiaPhong.Tag = (sender as Button).Tag;
            showMember(roomID);
            Room room = lsvChiaPhong.Tag as Room;
            btnAdd.Enabled = room.Member < room.Maximum;
            ChoseRoomForLoad(room);
            cboTang.Tag = room;
            Room roomNew = cboPhong.Tag as Room;
            if (roomNew != null)
            {
                btnChangeRoom.Enabled = room.ID != roomNew.ID;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsThongTinCN_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateDisplayName += f_updateDisplayName;
            f.ShowDialog();
        }

        void f_updateDisplayName(object sender, AccountEvent e)
        {
            mnsThongTinTK.Text = "Thông tin tài khoản (" + e.DisplayName + ")";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room room = lsvChiaPhong.Tag as Room;
            if (room != null && room.Name != "NaN")
            {
                if (room.Status == "Bận" || room.Status == "Sắp khỏi hết")
                {
                    if (MessageBox.Show("Xác nhận thêm người vào phòng " + room.Status + " không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                        return;
                }
                InsertMember f = new InsertMember(room);
                f.ShowDialog();
                ChoseRoomForLoad(room);
                showMember(room.ID);
            }
            else
                MessageBox.Show("Chưa có phòng. Hãy tạo thêm phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMap_click(object sender, EventArgs e)
        {
            fMapBlock f = new fMapBlock();
            f.ShowDialog();
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            if (lsvChiaPhong.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Xác nhận chuyển phòng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    List<Member> listMember = new List<Member>();
                    int count = 0;
                    foreach (int item in lsvChiaPhong.SelectedIndices)
                    {
                        Member member = lsvChiaPhong.Items[item].Tag as Member;
                        listMember.Add(member);
                        count++;
                    }
                    Room room = cboTang.Tag as Room;
                    Room roomDich = cboPhong.Tag as Room;
                    if (roomDich.Member + count > roomDich.Maximum)
                        MessageBox.Show("Phòng " + roomDich.Name + " không đủ giường trống!", "Lỗi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (roomDich.Status == "Bận" || roomDich.Status == "Sắp khỏi hết")
                            if (MessageBox.Show("Phòng " + roomDich.Name + " là phòng " + roomDich.Status + ". Bạn có chắc muốn chuyển thêm người vào phòng này không?!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
                            {
                                foreach (Member member in listMember)
                                {
                                    MemberDAO.Instance.ChangeRoom(member.ID, roomDich.ID);
                                    room.Member--;
                                    roomDich.Member++;
                                }
                            }
                            else
                                ;
                        else
                            foreach (Member member in listMember)
                            {
                                MemberDAO.Instance.ChangeRoom(member.ID, roomDich.ID);
                                room.Member--;
                                roomDich.Member++;
                            }


                    }
                    showMember(room.ID);
                    ChoseRoomForLoad(room);
                    cboPhong.Text = roomDich.Name;
                }
            }
        }


        private void cboTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Floor floor = cb.SelectedItem as Floor;

            LoadRoomComboBox(floor.ID);

        }


        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return ;
            Room room = cb.SelectedItem as Room;
            room = RoomDAO.Instance.GetRoomById(room.ID);
            cboPhong.Tag = room;
            Room roomOlder = cboTang.Tag as Room;
            if (roomOlder != null)
            {
                btnChangeRoom.Enabled = room.ID != roomOlder.ID;
            }
        }


        private void btnXuatVien_Click(object sender, EventArgs e)
        {
            if (lsvChiaPhong.SelectedIndices.Count == 1)
            {
                Member member = lsvChiaPhong.Items[lsvChiaPhong.SelectedIndices[0]].Tag as Member;
                if (member.Slxn > 1)
                {
                    if (MessageBox.Show("Xác nhận bệnh nhân xuất viện?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        fXuatVien f = new fXuatVien(member);
                        f.ShowDialog();
                        Room room = lsvChiaPhong.Tag as Room;
                        showMember(room.ID);
                        ChoseRoomForLoad(room);

                    }
                }
                else
                    MessageBox.Show("Bệnh nhân chưa đủ số lần xét nghiệm chưa thể xuất viện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChuyenTuyen_Click(object sender, EventArgs e)
        {

            if (lsvChiaPhong.SelectedIndices.Count == 1)
            {
                if (MessageBox.Show("Xác nhận bệnh nhân chuyển tuyến?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Member member = lsvChiaPhong.Items[lsvChiaPhong.SelectedIndices[0]].Tag as Member;
                    if (member.NXN != null)
                    {
                        fChuyenTuyen f = new fChuyenTuyen(member);
                        f.ShowDialog();
                        Room room = lsvChiaPhong.Tag as Room;
                        showMember(room.ID);
                        ChoseRoomForLoad(room);
                    }
                    else
                        MessageBox.Show("Bệnh nhân chưa xét nghiệm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (lsvChiaPhong.SelectedIndices.Count == 1)
            {
                Member member = lsvChiaPhong.Items[lsvChiaPhong.SelectedIndices[0]].Tag as Member;
                Room room = lsvChiaPhong.Tag as Room;
                EditMember f = new EditMember(member);
                f.ShowDialog();
                ChoseRoomForLoad(room);
                showMember(room.ID);
            }
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhong f = new fQuanLyPhong();
            f.ShowDialog();
            Room room = lsvChiaPhong.Tag as Room;
            ChoseRoomForLoad(room);
            LoadFloor();
            LoadRoomComboBox(room.IDTang);
            showMember(room.ID);
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyBenhNhan f = new fQuanLyBenhNhan();
            f.ShowDialog();
            Room room = lsvChiaPhong.Tag as Room;
            ChoseRoomForLoad(room);
            showMember(room.ID);
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan(LoginAccount);
            f.ShowDialog();
        }


        private void btnStatistic_Click(object sender, EventArgs e)
        {
            fReportThongKe f = new fReportThongKe();
            f.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox f = new AboutBox();
            f.ShowDialog();
        }
        #endregion


    }
}
