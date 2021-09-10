using ADGV;
using project_quan_ly_giuong_benh.DAO___Data_Access_Logic;
using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace project_quan_ly_giuong_benh
{
    public partial class fQuanLyBenhNhan : Form
    {
        BindingSource listDangDieuTri = new BindingSource();
        BindingSource listXuatVien = new BindingSource();
        BindingSource listChuyenTuyen = new BindingSource();
        BindingSource listBack = new BindingSource();
        BindingSource listXetNghiem = new BindingSource();
        private List<Member> ListMemberEdit = new List<Member>();

        private int status;

        public int Status { get => status; set => status = value; }

        public fQuanLyBenhNhan()
        {
            DateTime today = DateTime.Now;
            InitializeComponent();
            dtgvMember.DataSource = listDangDieuTri;
            dtgvXuatVien.DataSource = listXuatVien;
            dtgvChuyenTuyen.DataSource = listChuyenTuyen;
            dtgvBack.DataSource = listBack;
            dtgvXN.DataSource = listXetNghiem;
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpStop.Format = DateTimePickerFormat.Custom;
            dtpStop.CustomFormat = "dd/MM/yyyy";
            dtpStart.Value = new DateTime(today.Year, today.AddMonths(-3).Month, 1);
            dtpStop.Value = dtpStart.Value.AddMonths(4).AddDays(-1);
            txbPage.Text = "1";
            LoadMemberListDangDieuTri();
        }

        #region Method

        private HashSet<Member> GetSelectedMember()
        {
            HashSet<Member> listMember = new HashSet<Member>();
            switch (this.Status)
            {
                case 1:
                    foreach (DataGridViewCell item in dtgvXuatVien.SelectedCells)
                    {
                        listMember.Add(MemberDAO.Instance.GetMemberById((int)item.OwningRow.Cells["ID"].Value));
                    }
                    return listMember;
                case 2:
                    foreach (DataGridViewCell item in dtgvChuyenTuyen.SelectedCells)
                    {
                        listMember.Add(MemberDAO.Instance.GetMemberById((int)item.OwningRow.Cells["ID"].Value));
                    }
                    return listMember;
                case 3:
                    foreach (DataGridViewCell item in dtgvBack.SelectedCells)
                    {
                        listMember.Add(MemberDAO.Instance.GetMemberById((int)item.OwningRow.Cells["ID"].Value));
                    }
                    return listMember;
                case 5:
                    foreach (DataGridViewCell item in dtgvXN.SelectedCells)
                    {
                        listMember.Add(MemberDAO.Instance.GetMemberById((int)item.OwningRow.Cells["ID"].Value));
                    }
                    return listMember;
                default:
                    foreach (DataGridViewCell item in dtgvMember.SelectedCells)
                    {
                        listMember.Add(MemberDAO.Instance.GetMemberById((int)item.OwningRow.Cells["ID"].Value));
                    }
                    return listMember;
            }
        }

        private void EnableEIButton()
        {
            switch (this.Status)
            {
                case 0:
                    btnExport.Enabled = xoáBệnhNhânToolStripMenuItem.Enabled = sửaThôngTinToolStripMenuItem.Enabled = xuấtViệnToolStripMenuItem.Enabled = chuyểnTuyếnToolStripMenuItem.Enabled = true;
                    btnImport.Enabled = quayLạiViệnToolStripMenuItem.Enabled = thêmBệnhNhânToolStripMenuItem.Enabled = false;
                    break;
                case 1:
                    btnExport.Enabled = xoáBệnhNhânToolStripMenuItem.Enabled = sửaThôngTinToolStripMenuItem.Enabled = quayLạiViệnToolStripMenuItem.Enabled = true;
                    btnImport.Enabled = xuấtViệnToolStripMenuItem.Enabled = chuyểnTuyếnToolStripMenuItem.Enabled = thêmBệnhNhânToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    xoáBệnhNhânToolStripMenuItem.Enabled = sửaThôngTinToolStripMenuItem.Enabled = quayLạiViệnToolStripMenuItem.Enabled = true;
                    btnExport.Enabled = btnImport.Enabled = xuấtViệnToolStripMenuItem.Enabled = chuyểnTuyếnToolStripMenuItem.Enabled = thêmBệnhNhânToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    xoáBệnhNhânToolStripMenuItem.Enabled = sửaThôngTinToolStripMenuItem.Enabled = xuấtViệnToolStripMenuItem.Enabled = chuyểnTuyếnToolStripMenuItem.Enabled = true;
                    btnExport.Enabled = btnImport.Enabled = quayLạiViệnToolStripMenuItem.Enabled = thêmBệnhNhânToolStripMenuItem.Enabled = false;
                    break;
                case 4:
                    btnImport.Enabled = xuấtViệnToolStripMenuItem.Enabled = chuyểnTuyếnToolStripMenuItem.Enabled = thêmBệnhNhânToolStripMenuItem.Enabled = true;
                    btnExport.Enabled = xoáBệnhNhânToolStripMenuItem.Enabled = sửaThôngTinToolStripMenuItem.Enabled = quayLạiViệnToolStripMenuItem.Enabled = false;
                    break;
                case 5:
                    btnExport.Enabled = xoáBệnhNhânToolStripMenuItem.Enabled = sửaThôngTinToolStripMenuItem.Enabled = xuấtViệnToolStripMenuItem.Enabled = chuyểnTuyếnToolStripMenuItem.Enabled = true;
                    btnImport.Enabled = quayLạiViệnToolStripMenuItem.Enabled = thêmBệnhNhânToolStripMenuItem.Enabled = false;
                    break;
            }
        }


        void EditMember(int index)
        {
            double ctValue;
            DateTime ngayXN;
            Member member = MemberDAO.Instance.GetMemberById((int)SwitchDtgv().Rows[index].Cells[0].Value);
            if(this.Status == 1)
            {
                member.SoLT = dtgvXuatVien.Rows[index].Cells[3].Value.ToString();
                member.NXN = DateTime.TryParse(dtgvXuatVien.Rows[index].Cells[15].Value.ToString(), out ngayXN) ? ngayXN : member.NXN;
                member.Ktxn = dtgvXuatVien.Rows[index].Cells[16].Value.ToString();
                member.Kq = dtgvXuatVien.Rows[index].Cells[17].Value.ToString();
                member.CtValue = double.TryParse(dtgvXuatVien.Rows[index].Cells[18].Value.ToString(), out ctValue) ? ctValue : 0;
            }    
            if(this.Status == 2)
                member.NoiDen = dtgvChuyenTuyen.Rows[index].Cells[16].Value.ToString();
            ListMemberEdit.Add(member);
        }

        private int LastPage()
        {
            int sumRecord = MemberDAO.Instance.GetNumMember(dtpStart.Value, dtpStop.Value, this.Status);
            int pageRows = (int)nUDPageRows.Value;
            int lastPage = sumRecord / pageRows;
            if (sumRecord % pageRows != 0) 
                lastPage++;
            return lastPage;
        }

        private void SreachMemberByName(string name)
        {
            switch (this.Status)
            {
                case 0:
                    listDangDieuTri.DataSource = MemberDAO.Instance.SreachMemberByName(name, 0, dtpStart.Value, dtpStop.Value);
                    break;
                case 1:
                    listXuatVien.DataSource = MemberDAO.Instance.SreachMemberByName(name, 1, dtpStart.Value, dtpStop.Value);
                    break;
                case 2:
                    listChuyenTuyen.DataSource = MemberDAO.Instance.SreachMemberByName(name, 2, dtpStart.Value, dtpStop.Value);
                    break;
                case 3:
                    listBack.DataSource = MemberDAO.Instance.SreachMemberByName(name, 3, dtpStart.Value, dtpStop.Value);
                    break;
            }
        }

        private void FormatColumnDangDieuTri()
        {
            dtgvMember.Columns[0].HeaderText = "STT";
            dtgvMember.Columns[0].Width = 30;
            dtgvMember.Columns[1].HeaderText = "Phòng";
            dtgvMember.Columns[1].Width = 40;
            dtgvMember.Columns[2].HeaderText = "Mã BN\n(nếu có)";
            dtgvMember.Columns[2].Width = 60;
            dtgvMember.Columns[3].HeaderText = "Họ và tên";
            dtgvMember.Columns[3].Width = 150;
            dtgvMember.Columns[4].HeaderText = "Năm sinh";
            dtgvMember.Columns[4].Width = 40;
            dtgvMember.Columns[5].HeaderText = "Giới tính";
            dtgvMember.Columns[5].Width = 40;
            dtgvMember.Columns[6].HeaderText = "Dân Tộc";
            dtgvMember.Columns[6].Width = 40;
            dtgvMember.Columns[7].HeaderText = "SĐT";
            dtgvMember.Columns[7].Width = 80;
            dtgvMember.Columns[8].HeaderText = "Địa chỉ";
            dtgvMember.Columns[8].Width = 300;
            dtgvMember.Columns[9].HeaderText = "CMND/CCCD";
            dtgvMember.Columns[9].Width = 100;
            dtgvMember.Columns[10].HeaderText = "Nơi chuyển";
            dtgvMember.Columns[10].Width = 180;
            dtgvMember.Columns[11].HeaderText = "Khoa\n(nếu có)";
            dtgvMember.Columns[11].Width = 40;
            dtgvMember.Columns[12].HeaderText = "Nhập viện";
            dtgvMember.Columns[12].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvMember.Columns[12].Width = 80;
            dtgvMember.Columns[13].HeaderText = "XN lần cuối";
            dtgvMember.Columns[13].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvMember.Columns[13].Width = 70;
            dtgvMember.Columns[14].HeaderText = "Họ tên người thân";
            dtgvMember.Columns[14].Width = 160;
            dtgvMember.Columns[15].HeaderText = "Mối quan hệ";
            dtgvMember.Columns[15].Width = 80;
            dtgvMember.Columns[16].HeaderText = "SĐT người thân";
            dtgvMember.Columns[16].Width = 80;
            dtgvMember.Columns[17].HeaderText = "Phân loại";
            dtgvMember.Columns[17].Width = 40;
            int[] arr = { 0, 1, 2, 4, 5, 6, 7, 11, 12, 13, 16, 17 };
            foreach (int i in arr)
            {
                dtgvMember.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void FormatColumnXuatVien()
        {
            dtgvXuatVien.Columns[0].HeaderText = "STT";
            dtgvXuatVien.Columns[0].Width = 30;
            dtgvXuatVien.Columns[1].HeaderText = "PHÒNG";
            dtgvXuatVien.Columns[1].Width = 40;
            dtgvXuatVien.Columns[2].HeaderText = "Mã BN\n(nếu có)";
            dtgvXuatVien.Columns[2].Width = 100;
            dtgvXuatVien.Columns[3].HeaderText = "Số lưu trữ";
            dtgvXuatVien.Columns[3].Width = 100;
            dtgvXuatVien.Columns[4].HeaderText = "HỌ TÊN BỆNH NHÂN";
            dtgvXuatVien.Columns[4].Width = 150;
            dtgvXuatVien.Columns[5].HeaderText = "Năm sinh";
            dtgvXuatVien.Columns[5].Width = 40;
            dtgvXuatVien.Columns[6].HeaderText = "Giới tính";
            dtgvXuatVien.Columns[6].Width = 40;
            dtgvXuatVien.Columns[7].HeaderText = "Dân Tộc";
            dtgvXuatVien.Columns[7].Width = 40;
            dtgvXuatVien.Columns[8].HeaderText = "ĐỊA CHỈ THƯỜNG TRÚ";
            dtgvXuatVien.Columns[8].Width = 210;
            dtgvXuatVien.Columns[9].HeaderText = "Quận/\nHuyện";
            dtgvXuatVien.Columns[9].Width = 80;
            dtgvXuatVien.Columns[10].HeaderText = "SĐT";
            dtgvXuatVien.Columns[10].Width = 80;
            dtgvXuatVien.Columns[11].HeaderText = "KHOA (nếu có)";
            dtgvXuatVien.Columns[11].Width = 40;
            dtgvXuatVien.Columns[12].HeaderText = "NGÀY NHẬP VIỆN (Format dd/MM/yyyy)";
            dtgvXuatVien.Columns[12].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvXuatVien.Columns[12].Width = 80;
            dtgvXuatVien.Columns[13].HeaderText = "NGÀY XUẤT VIỆN (Format dd/MM/yyyy)";
            dtgvXuatVien.Columns[13].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvXuatVien.Columns[13].Width = 80;
            dtgvXuatVien.Columns[14].HeaderText = "SỐ\nNGÀY\nĐIỀU TRỊ";
            dtgvXuatVien.Columns[14].Width = 40;
            dtgvXuatVien.Columns[15].HeaderText = "NGÀY LÀM XÉT NGHIỆM (Format dd/MM/yyyy)";
            dtgvXuatVien.Columns[15].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvXuatVien.Columns[15].Width = 80;
            dtgvXuatVien.Columns[16].HeaderText = "KỸ THUẬT XÉT NGHIỆM RA VIỆN";
            dtgvXuatVien.Columns[16].Width = 80;
            dtgvXuatVien.Columns[17].HeaderText = "KẾT QUẢ";
            dtgvXuatVien.Columns[17].Width = 80;
            dtgvXuatVien.Columns[18].HeaderText = "CT\nVALUE\n≥30";
            dtgvXuatVien.Columns[18].Width = 80;
            int[] arr = { 0, 1, 2, 3, 5, 6, 7, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            foreach (int i in arr)
            {
                dtgvXuatVien.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void FormatColumnChuyenTuyen()
        {
            dtgvChuyenTuyen.Columns[0].HeaderText = "STT";
            dtgvChuyenTuyen.Columns[0].Width = 30;
            dtgvChuyenTuyen.Columns[1].HeaderText = "Phòng";
            dtgvChuyenTuyen.Columns[1].Width = 40;
            dtgvChuyenTuyen.Columns[2].HeaderText = "Mã BN\n(nếu có)";
            dtgvChuyenTuyen.Columns[2].Width = 60;
            dtgvChuyenTuyen.Columns[3].HeaderText = "Họ và tên";
            dtgvChuyenTuyen.Columns[3].Width = 150;
            dtgvChuyenTuyen.Columns[4].HeaderText = "Năm sinh";
            dtgvChuyenTuyen.Columns[4].Width = 40;
            dtgvChuyenTuyen.Columns[5].HeaderText = "Giới tính";
            dtgvChuyenTuyen.Columns[5].Width = 40;
            dtgvChuyenTuyen.Columns[6].HeaderText = "Dân Tộc";
            dtgvChuyenTuyen.Columns[6].Width = 40;
            dtgvChuyenTuyen.Columns[7].HeaderText = "SĐT";
            dtgvChuyenTuyen.Columns[7].Width = 80;
            dtgvChuyenTuyen.Columns[8].HeaderText = "Địa chỉ";
            dtgvChuyenTuyen.Columns[8].Width = 300;
            dtgvChuyenTuyen.Columns[9].HeaderText = "CMND/CCCD";
            dtgvChuyenTuyen.Columns[9].Width = 100;
            dtgvChuyenTuyen.Columns[10].HeaderText = "Nơi chuyển";
            dtgvChuyenTuyen.Columns[10].Width = 180;
            dtgvChuyenTuyen.Columns[11].HeaderText = "Khoa\n(nếu có)";
            dtgvChuyenTuyen.Columns[11].Width = 40;
            dtgvChuyenTuyen.Columns[12].HeaderText = "Ngày nhập viện";
            dtgvChuyenTuyen.Columns[12].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvChuyenTuyen.Columns[12].Width = 80;
            dtgvChuyenTuyen.Columns[13].HeaderText = "Ngày chuyển tuyến";
            dtgvChuyenTuyen.Columns[13].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvChuyenTuyen.Columns[13].Width = 80;
            dtgvChuyenTuyen.Columns[14].HeaderText = "XN lần cuối";
            dtgvChuyenTuyen.Columns[14].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvChuyenTuyen.Columns[14].Width = 70;
            dtgvChuyenTuyen.Columns[15].HeaderText = "Phân loại";
            dtgvChuyenTuyen.Columns[15].Width = 40;
            dtgvChuyenTuyen.Columns[16].HeaderText = "Chuyển đến";
            dtgvChuyenTuyen.Columns[16].Width = 100;
            int[] arr = { 0, 1, 2, 4, 5, 6, 7, 11, 12, 13, 14, 15 };
            foreach (int i in arr)
            {
                dtgvChuyenTuyen.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void FormatColumnQuayLai()
        {
            dtgvBack.Columns[0].HeaderText = "STT";
            dtgvBack.Columns[0].Width = 30;
            dtgvBack.Columns[1].HeaderText = "Phòng";
            dtgvBack.Columns[1].Width = 40;
            dtgvBack.Columns[2].HeaderText = "Mã BN\n(nếu có)";
            dtgvBack.Columns[2].Width = 60;
            dtgvBack.Columns[3].HeaderText = "Họ và tên";
            dtgvBack.Columns[3].Width = 150;
            dtgvBack.Columns[4].HeaderText = "Năm sinh";
            dtgvBack.Columns[4].Width = 40;
            dtgvBack.Columns[5].HeaderText = "Giới tính";
            dtgvBack.Columns[5].Width = 40;
            dtgvBack.Columns[6].HeaderText = "Dân Tộc";
            dtgvBack.Columns[6].Width = 40;
            dtgvBack.Columns[7].HeaderText = "SĐT";
            dtgvBack.Columns[7].Width = 80;
            dtgvBack.Columns[8].HeaderText = "Địa chỉ";
            dtgvBack.Columns[8].Width = 300;
            dtgvBack.Columns[9].HeaderText = "CMND/CCCD";
            dtgvBack.Columns[9].Width = 100;
            dtgvBack.Columns[10].HeaderText = "Nơi chuyển";
            dtgvBack.Columns[10].Width = 180;
            dtgvBack.Columns[11].HeaderText = "Khoa\n(nếu có)";
            dtgvBack.Columns[11].Width = 40;
            dtgvBack.Columns[12].HeaderText = "Ngày quay lại";
            dtgvBack.Columns[12].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvBack.Columns[12].Width = 80;
            dtgvBack.Columns[13].HeaderText = "Số ngày ở thêm";
            dtgvBack.Columns[13].Width = 40;
            dtgvBack.Columns[14].HeaderText = "Phân loại";
            dtgvBack.Columns[14].Width = 40;
            int[] arr = { 0, 1, 2, 4, 5, 6, 7, 11, 12, 13, 14 };
            foreach (int i in arr)
            {
                dtgvBack.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void FormatColumnXetNghiem()
        {
            dtgvXN.Columns[0].HeaderText = "STT";
            dtgvXN.Columns[0].Width = 30;
            dtgvXN.Columns[1].HeaderText = "Phòng";
            dtgvXN.Columns[1].Width = 40;
            dtgvXN.Columns[2].HeaderText = "Mã BN\n(nếu có)";
            dtgvXN.Columns[2].Width = 60;
            dtgvXN.Columns[3].HeaderText = "Họ và tên";
            dtgvXN.Columns[3].Width = 150;
            dtgvXN.Columns[4].HeaderText = "Năm sinh";
            dtgvXN.Columns[4].Width = 40;
            dtgvXN.Columns[5].HeaderText = "Giới tính";
            dtgvXN.Columns[5].Width = 40;
            dtgvXN.Columns[6].HeaderText = "Dân Tộc";
            dtgvXN.Columns[6].Width = 40;
            dtgvXN.Columns[7].HeaderText = "SĐT";
            dtgvXN.Columns[7].Width = 80;
            dtgvXN.Columns[8].HeaderText = "Địa chỉ";
            dtgvXN.Columns[8].Width = 300;
            dtgvXN.Columns[9].HeaderText = "CMND/CCCD";
            dtgvXN.Columns[9].Width = 100;
            dtgvXN.Columns[10].HeaderText = "Nơi chuyển";
            dtgvXN.Columns[10].Width = 180;
            dtgvXN.Columns[11].HeaderText = "Khoa\n(nếu có)";
            dtgvXN.Columns[11].Width = 40;
            dtgvXN.Columns[12].HeaderText = "Ngày nhập viện";
            dtgvXN.Columns[12].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvXN.Columns[12].Width = 80;
            dtgvXN.Columns[13].HeaderText = "Ngày xét nghiệm";
            dtgvXN.Columns[13].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvXN.Columns[13].Width = 80;
            dtgvXN.Columns[14].HeaderText = "Loại xét nghiệm";
            dtgvXN.Columns[14].Width = 80;
            int[] arr = { 0, 1, 2, 4, 5, 6, 7, 11, 12, 13, 14 };
            foreach (int i in arr)
            {
                dtgvXN.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void FormatColumn()
        {
            switch (this.Status)
            {
                case 0:
                    FormatColumnDangDieuTri();
                    break;
                case 1:
                    FormatColumnXuatVien();
                    break;
                case 2:
                    FormatColumnChuyenTuyen();
                    break;
                case 3:
                    FormatColumnQuayLai();
                    break;
                case 5:
                    FormatColumnXetNghiem();
                    break;
            }
        }

        private AdvancedDataGridView SwitchDtgv()
        {
            switch (this.Status)
            {
                case 1:
                    return dtgvXuatVien;
                case 2:
                    return dtgvChuyenTuyen;
                case 3:
                    return dtgvBack;
                case 5:
                    return dtgvXN;
                default:
                    return dtgvMember;
            }
        }

        private void LoadTotalMember()
        {
            if (this.Status == 0 || this.Status == 1 || this.Status == 2)
                lbTongSoBN.Text = "Tổng số: " + DataProvider.Instance.ExecuteQuery("SELECT id FROM dbo.BenhNhan WHERE trangThai = " + this.Status).Rows.Count.ToString();
            if(this.Status == 3)
                lbTongSoBN.Text = "Tổng số: " + DataProvider.Instance.ExecuteQuery("SELECT id FROM dbo.BenhNhan WHERE trangThai = 0 AND ngayXuatVien IS NOT NULL").Rows.Count.ToString();
            if (this.Status == 4)
                lbTongSoBN.Text = "Tổng số: " + dtgvInput.Rows.Count.ToString();
            if (this.Status == 5)
                lbTongSoBN.Text = "Tổng số: " + DataProvider.Instance.ExecuteQuery("SELECT id FROM dbo.BenhNhan WHERE trangThai = 0").Rows.Count.ToString();
        }

        void LoadSTT()
        {
            for (int i = 0; i < SwitchDtgv().RowCount; i++)
                SwitchDtgv().Rows[i].Cells[0].Value = i + 1;
        }

        private void LoadMemberListDangDieuTri()
        {
            if(ListMemberEdit.Count > 0)
                ListMemberEdit.Clear();
            int page = 1;
            int pageRow = (int)nUDPageRows.Value;
            if (this.Status == 4)
                lbTotalPage.Text = "/1";
            else 
                lbTotalPage.Text = "/" + LastPage().ToString();
            if (int.TryParse(txbPage.Text,out page))
            {
                switch (this.Status)
                {
                    case 0:
                        listDangDieuTri.DataSource = MemberDAO.Instance.GetListBenhNhanDangDieuTri(dtpStart.Value, dtpStop.Value, 0, page, pageRow);
                        break;
                    case 1:
                        listXuatVien.DataSource = MemberDAO.Instance.GetListBenhNhanDangDieuTri(dtpStart.Value, dtpStop.Value, 1, page, pageRow);
                        break;
                    case 2:
                        listChuyenTuyen.DataSource = MemberDAO.Instance.GetListBenhNhanDangDieuTri(dtpStart.Value, dtpStop.Value, 2, page, pageRow);
                        break;
                    case 3:
                        listBack.DataSource = MemberDAO.Instance.GetListBenhNhanDangDieuTri(dtpStart.Value, dtpStop.Value, 3, page, pageRow);
                        break;
                    case 5:
                        listXetNghiem.DataSource = MemberDAO.Instance.GetListBenhNhanDangDieuTri(dtpStart.Value, dtpStop.Value, 5, page, pageRow);
                        break;
                }
            }
            LoadSTT();
            FormatColumn();
            EnableEIButton();
            LoadTotalMember();
        }
        private void SetWidthColumn(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            if(this.Status == 1)
            {
                worksheet.Columns[1].ColumnWidth = 5;
                worksheet.Columns[2].ColumnWidth = 6.29;
                worksheet.Columns[3].ColumnWidth = 15.86;
                worksheet.Columns[4].ColumnWidth = 16.29;
                worksheet.Columns[5].ColumnWidth = 34.71;
                worksheet.Columns[6].ColumnWidth = 12;
                worksheet.Columns[7].ColumnWidth = 11.71;
                worksheet.Columns[8].ColumnWidth = 10.57;
                worksheet.Columns[9].ColumnWidth = 62.71;
                worksheet.Columns[10].ColumnWidth = 17.29;
                worksheet.Columns[11].ColumnWidth = 17.71;
                worksheet.Columns[12].ColumnWidth = 8;
                worksheet.Columns[13].ColumnWidth = 15.86;
                worksheet.Columns[14].ColumnWidth = 15.86;
                worksheet.Columns[15].ColumnWidth = 10.43;
                worksheet.Columns[16].ColumnWidth = 15.86;
                worksheet.Columns[17].ColumnWidth = 17.43;
                worksheet.Columns[18].ColumnWidth = 17.71;
                worksheet.Columns[19].ColumnWidth = 8.57;
                worksheet.Columns[20].ColumnWidth = 10;
                worksheet.Range["a5", "v5"].RowHeight = 54;
            }

            if (this.Status == 0)
            {
                worksheet.Columns[1].ColumnWidth = 5;
                worksheet.Columns[2].ColumnWidth = 6.29;
                worksheet.Columns[3].ColumnWidth = 15.86;
                worksheet.Columns[4].ColumnWidth = 34.71;
                worksheet.Columns[5].ColumnWidth = 12;
                worksheet.Columns[6].ColumnWidth = 11.71;
                worksheet.Columns[7].ColumnWidth = 10.57;
                worksheet.Columns[8].ColumnWidth = 17.71;
                worksheet.Columns[9].ColumnWidth = 65;
                worksheet.Columns[10].ColumnWidth = 16.5;
                worksheet.Columns[11].ColumnWidth = 40;
                worksheet.Columns[12].ColumnWidth = 8;
                worksheet.Columns[13].ColumnWidth = 15.86;
                worksheet.Columns[14].ColumnWidth = 15.86;
                worksheet.Columns[15].ColumnWidth = 30;
                worksheet.Columns[16].ColumnWidth = 19;
                worksheet.Columns[17].ColumnWidth = 17.71;
                worksheet.Columns[18].ColumnWidth = 8;
                worksheet.Columns[19].ColumnWidth = 10;
                worksheet.Range["a5", "v5"].RowHeight = 54;
            }

            if (this.Status == 5)
            {
                worksheet.Columns[1].ColumnWidth = 5;
                worksheet.Columns[2].ColumnWidth = 6.29;
                worksheet.Columns[3].ColumnWidth = 15.86;
                worksheet.Columns[4].ColumnWidth = 34.71;
                worksheet.Columns[5].ColumnWidth = 12;
                worksheet.Columns[6].ColumnWidth = 11.71;
                worksheet.Columns[7].ColumnWidth = 10.57;
                worksheet.Columns[8].ColumnWidth = 17.71;
                worksheet.Columns[9].ColumnWidth = 65;
                worksheet.Columns[10].ColumnWidth = 16.5;
                worksheet.Columns[11].ColumnWidth = 40;
                worksheet.Columns[12].ColumnWidth = 8;
                worksheet.Columns[13].ColumnWidth = 15.86;
                worksheet.Columns[14].ColumnWidth = 15.86;
                worksheet.Columns[15].ColumnWidth = 15.86;
                worksheet.Columns[16].ColumnWidth = 15.86;
                worksheet.Range["a5", "v5"].RowHeight = 54;
            }
        }
        private void SetColorCell(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            if(this.Status == 1)
            {
                worksheet.Cells[5, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFFF00"));
                worksheet.Cells[5, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFFF00"));
                worksheet.Cells[5, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#9BC2E6"));
                worksheet.Cells[5, 7].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#9BC2E6"));
                worksheet.Cells[5, 8].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#9BC2E6"));
                worksheet.Cells[5, 17].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFE699"));
                worksheet.Cells[5, 19].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#C6EFCE"));
            }
        }
        private void SetRowsHeight(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            for (int i = 1; i < 5; i++)
                worksheet.Rows[i].RowHeight = 19.5;
            worksheet.Rows[5].RowHeight = 27;
            worksheet.Rows[6].RowHeight = 27;

        }
        private void SetMergeCell(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            if(this.Status == 1)
            {
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 10]].Merge();
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 10]].Merge();
                worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 18]].Merge();
                worksheet.Range[worksheet.Cells[1, 13], worksheet.Cells[1, 16]].Merge();
                worksheet.Range[worksheet.Cells[2, 13], worksheet.Cells[2, 16]].Merge();
                for (int i = 1; i < 23; i++)
                {
                    if (i == 9)
                        continue;
                    worksheet.Range[worksheet.Cells[5, i], worksheet.Cells[6, i]].Merge();
                }
            }
            if (this.Status == 0 || this.Status == 5)
            {
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 10]].Merge();
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 10]].Merge();
                worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, 18]].Merge();
                worksheet.Range[worksheet.Cells[1, 13], worksheet.Cells[1, 16]].Merge();
                worksheet.Range[worksheet.Cells[2, 13], worksheet.Cells[2, 16]].Merge();
                for (int i = 1; i < 23; i++)
                {
                    worksheet.Range[worksheet.Cells[5, i], worksheet.Cells[6, i]].Merge();
                }
            }
        }
        private void SetFormatColumn(Microsoft.Office.Interop.Excel.Worksheet worksheet, DataGridView dataGridView1)
        {
            if(this.Status == 1)
            {
                worksheet.Columns[11].NumberFormat = "@";
                worksheet.Rows[5].WrapText = true;
                worksheet.Rows[6].WrapText = true;
                worksheet.Columns.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                worksheet.Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Columns[5].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[9].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[10].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                worksheet.Columns[11].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                worksheet.Rows[5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Rows[6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
            if(this.Status == 0)
            {
                worksheet.Columns[8].NumberFormat = "@";
                worksheet.Columns[10].NumberFormat = "@";
                worksheet.Columns[17].NumberFormat = "@";
                worksheet.Rows[5].WrapText = true;
                worksheet.Rows[6].WrapText = true;
                worksheet.Columns.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                worksheet.Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Columns[4].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[9].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[10].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                worksheet.Columns[11].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[15].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[16].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Rows[5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Rows[6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
            if (this.Status == 5)
            {
                worksheet.Columns[8].NumberFormat = "@";
                worksheet.Columns[10].NumberFormat = "@";
                worksheet.Rows[5].WrapText = true;
                worksheet.Rows[6].WrapText = true;
                worksheet.Columns.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                worksheet.Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Columns[4].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[9].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[10].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                worksheet.Columns[11].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Columns[15].HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral;
                worksheet.Rows[5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Rows[6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
        }
        private void SetFontStye(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            worksheet.Rows.RowHeight = 38.25;
            worksheet.Rows.Font.Name = "Times New Roman";
            worksheet.Rows.Font.Size = 14;
        }
        private void SetTitle(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            if(this.Status == 1)
            {
                DateTime date = DateTime.Now;
                worksheet.Cells[1, 1] = "BỆNH VIỆN DÃ CHIẾN THU DUNG ĐIỀU TRỊ COVID SỐ 11";
                worksheet.Cells[1, 1].Font.FontStyle = "Bold";
                worksheet.Cells[1, 1].Font.Size = 16;
                worksheet.Cells[1, 1].Font.Name = "Times New Roman";
                worksheet.Cells[2, 1] = "Số:          / BC-BVLVV";
                worksheet.Cells[2, 1].Font.FontStyle = "Bold";
                worksheet.Cells[2, 1].Font.Size = 16;
                worksheet.Cells[2, 1].Font.Name = "Times New Roman";
                worksheet.Cells[3, 1] = "DANH SÁCH BỆNH NHÂN NHIỄM COVID-19 XUẤT VIỆN ";
                worksheet.Cells[3, 1].Font.FontStyle = "Bold";
                worksheet.Cells[3, 1].Font.Size = 16;
                worksheet.Cells[3, 1].Font.Name = "Times New Roman";
                worksheet.Cells[1, 13] = "Độc lập - Tự do - Hạnh phúc";
                worksheet.Cells[1, 13].Font.FontStyle = "Bold";
                worksheet.Cells[1, 13].Font.Size = 16;
                worksheet.Cells[1, 13].Font.Name = "Times New Roman";
                worksheet.Cells[2, 13] = "Tp Hồ Chí Minh, ngày " + date.Day.ToString() + " tháng " + date.Month.ToString("d2") + " năm " + date.Year.ToString();
                worksheet.Cells[2, 13].Font.FontStyle = "Bold Italic";
                worksheet.Cells[2, 13].Font.Size = 16;
                worksheet.Cells[2, 13].Font.Name = "Times New Roman";
            }
            if (this.Status == 0)
            {
                DateTime date = DateTime.Now;
                worksheet.Cells[1, 1] = "BỆNH VIỆN DÃ CHIẾN THU DUNG ĐIỀU TRỊ COVID SỐ 11";
                worksheet.Cells[1, 1].Font.FontStyle = "Bold";
                worksheet.Cells[1, 1].Font.Size = 16;
                worksheet.Cells[1, 1].Font.Name = "Times New Roman";
                worksheet.Cells[2, 1] = "Số:          / BC-BVLVV";
                worksheet.Cells[2, 1].Font.FontStyle = "Bold";
                worksheet.Cells[2, 1].Font.Size = 16;
                worksheet.Cells[2, 1].Font.Name = "Times New Roman";
                worksheet.Cells[3, 1] = "DANH SÁCH BỆNH NHÂN NHIỄM COVID-19 NHẬP VIỆN ";
                worksheet.Cells[3, 1].Font.FontStyle = "Bold";
                worksheet.Cells[3, 1].Font.Size = 16;
                worksheet.Cells[3, 1].Font.Name = "Times New Roman";
                worksheet.Cells[1, 13] = "Độc lập - Tự do - Hạnh phúc";
                worksheet.Cells[1, 13].Font.FontStyle = "Bold";
                worksheet.Cells[1, 13].Font.Size = 16;
                worksheet.Cells[1, 13].Font.Name = "Times New Roman";
                worksheet.Cells[2, 13] = "Tp Hồ Chí Minh, ngày " + date.Day.ToString() + " tháng " + date.Month.ToString("d2") + " năm " + date.Year.ToString();
                worksheet.Cells[2, 13].Font.FontStyle = "Bold Italic";
                worksheet.Cells[2, 13].Font.Size = 16;
                worksheet.Cells[2, 13].Font.Name = "Times New Roman";
            }
            if (this.Status == 5)
            {
                DateTime date = DateTime.Now;
                worksheet.Cells[1, 1] = "BỆNH VIỆN DÃ CHIẾN THU DUNG ĐIỀU TRỊ COVID SỐ 11";
                worksheet.Cells[1, 1].Font.FontStyle = "Bold";
                worksheet.Cells[1, 1].Font.Size = 16;
                worksheet.Cells[1, 1].Font.Name = "Times New Roman";
                worksheet.Cells[2, 1] = "Số:          / BC-BVLVV";
                worksheet.Cells[2, 1].Font.FontStyle = "Bold";
                worksheet.Cells[2, 1].Font.Size = 16;
                worksheet.Cells[2, 1].Font.Name = "Times New Roman";
                worksheet.Cells[3, 1] = "DANH SÁCH BỆNH NHÂN NHIỄM COVID-19 XÉT NGHIỆM ";
                worksheet.Cells[3, 1].Font.FontStyle = "Bold";
                worksheet.Cells[3, 1].Font.Size = 16;
                worksheet.Cells[3, 1].Font.Name = "Times New Roman";
                worksheet.Cells[1, 13] = "Độc lập - Tự do - Hạnh phúc";
                worksheet.Cells[1, 13].Font.FontStyle = "Bold";
                worksheet.Cells[1, 13].Font.Size = 16;
                worksheet.Cells[1, 13].Font.Name = "Times New Roman";
                worksheet.Cells[2, 13] = "Tp Hồ Chí Minh, ngày " + date.Day.ToString() + " tháng " + date.Month.ToString("d2") + " năm " + date.Year.ToString();
                worksheet.Cells[2, 13].Font.FontStyle = "Bold Italic";
                worksheet.Cells[2, 13].Font.Size = 16;
                worksheet.Cells[2, 13].Font.Name = "Times New Roman";
            }
        }
        private void ExportHeader(Microsoft.Office.Interop.Excel.Worksheet worksheet, DataGridView dataGridView1)
        {
            if(this.Status == 1)
            {
                int count = dataGridView1.ColumnCount;
                int index = 0;
                worksheet.Cells[5, 1] = "STT";
                worksheet.Cells[5, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[5, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[5, 1].Borders.Weight = 2d;
                worksheet.Cells[5, 1].Font.FontStyle = "Bold";
                worksheet.Cells[5, 1].Font.Size = 12;
                worksheet.Cells[5, 1].Font.Name = "Times New Roman";
                worksheet.Cells[5, 20] = "GHI CHÚ";
                worksheet.Cells[5, 20].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[5, 20].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[5, 20].Borders.Weight = 2d;
                worksheet.Cells[6, 20].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[6, 20].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[6, 20].Borders.Weight = 2d;
                worksheet.Cells[5, 20].Font.FontStyle = "Bold";
                worksheet.Cells[5, 20].Font.Size = 12;
                worksheet.Cells[5, 20].Font.Name = "Times New Roman";
                for (int i = 1; i < count; i++)
                {
                    index++;
                    if (index > 1 && dataGridView1.Columns[index].Visible == false)
                    {
                        count--;
                        i--;
                        continue;
                    }
                    worksheet.Cells[5, i + 1] = dataGridView1.Columns[index].HeaderText;
                    worksheet.Cells[5, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                    worksheet.Cells[5, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[5, i + 1].Borders.Weight = 2d;
                    worksheet.Cells[6, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                    worksheet.Cells[6, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[6, i + 1].Borders.Weight = 2d;
                    worksheet.Cells[5, i + 1].Font.FontStyle = "Bold";
                    worksheet.Cells[5, i + 1].Font.Size = 12;
                    worksheet.Cells[5, i + 1].Font.Name = "Times New Roman";
                }
                worksheet.Cells[6, 9] = "Số nhà, đường, khu phố, ấp, phường, xã";
                worksheet.Cells[6, 9].Font.FontStyle = "Bold";
                worksheet.Cells[6, 9].Font.Size = 12;
                worksheet.Cells[6, 9].Font.Name = "Times New Roman";
            }

            if (this.Status == 0)
            {
                int count = dataGridView1.ColumnCount;
                int index = 0;
                worksheet.Cells[5, 1] = "STT";
                worksheet.Cells[5, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[5, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[5, 1].Borders.Weight = 2d;
                worksheet.Cells[5, 1].Font.FontStyle = "Bold";
                worksheet.Cells[5, 1].Font.Size = 12;
                worksheet.Cells[5, 1].Font.Name = "Times New Roman";
                worksheet.Cells[5, 19] = "GHI CHÚ";
                worksheet.Cells[5, 19].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[5, 19].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[5, 19].Borders.Weight = 2d;
                worksheet.Cells[6, 19].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[6, 19].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[6, 19].Borders.Weight = 2d;
                worksheet.Cells[5, 19].Font.FontStyle = "Bold";
                worksheet.Cells[5, 19].Font.Size = 12;
                worksheet.Cells[5, 19].Font.Name = "Times New Roman";
                for (int i = 1; i < count; i++)
                {
                    index++;
                    if (index > 1 && dataGridView1.Columns[index].Visible == false)
                    {
                        count--;
                        i--;
                        continue;
                    }
                    worksheet.Cells[5, i + 1] = dataGridView1.Columns[index].HeaderText;
                    worksheet.Cells[5, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                    worksheet.Cells[5, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[5, i + 1].Borders.Weight = 2d;
                    worksheet.Cells[6, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                    worksheet.Cells[6, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[6, i + 1].Borders.Weight = 2d;
                    worksheet.Cells[5, i + 1].Font.FontStyle = "Bold";
                    worksheet.Cells[5, i + 1].Font.Size = 12;
                    worksheet.Cells[5, i + 1].Font.Name = "Times New Roman";
                }
            }

            if (this.Status == 5)
            {
                int count = dataGridView1.ColumnCount;
                int index = 0;
                worksheet.Cells[5, 1] = "STT";
                worksheet.Cells[5, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[5, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[5, 1].Borders.Weight = 2d;
                worksheet.Cells[5, 1].Font.FontStyle = "Bold";
                worksheet.Cells[5, 1].Font.Size = 12;
                worksheet.Cells[5, 1].Font.Name = "Times New Roman";
                worksheet.Cells[5, 16] = "KẾT QUẢ";
                worksheet.Cells[5, 16].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[5, 16].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[5, 16].Borders.Weight = 2d;
                worksheet.Cells[6, 16].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                worksheet.Cells[6, 16].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[6, 16].Borders.Weight = 2d;
                worksheet.Cells[5, 16].Font.FontStyle = "Bold";
                worksheet.Cells[5, 16].Font.Size = 12;
                worksheet.Cells[5, 16].Font.Name = "Times New Roman";
                for (int i = 1; i < count; i++)
                {
                    index++;
                    if (index > 1 && dataGridView1.Columns[index].Visible == false)
                    {
                        count--;
                        i--;
                        continue;
                    }
                    worksheet.Cells[5, i + 1] = dataGridView1.Columns[index].HeaderText;
                    worksheet.Cells[5, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                    worksheet.Cells[5, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[5, i + 1].Borders.Weight = 2d;
                    worksheet.Cells[6, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#F6B26B"));
                    worksheet.Cells[6, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[6, i + 1].Borders.Weight = 2d;
                    worksheet.Cells[5, i + 1].Font.FontStyle = "Bold";
                    worksheet.Cells[5, i + 1].Font.Size = 12;
                    worksheet.Cells[5, i + 1].Font.Name = "Times New Roman";
                }
            }
        }
        private void ExportCell(Microsoft.Office.Interop.Excel.Worksheet worksheet, DataGridView dataGridView1)
        {
            DateTime date;
            if (this.Status == 1)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int count = dataGridView1.ColumnCount;
                    int index = 0;
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 7, 1].Borders.Weight = 2d;
                    worksheet.Cells[i + 7, 20].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 7, 20].Borders.Weight = 2d;
                    for (int j = 1; j < count; j++)
                    {
                        index++;
                        if (index > 1 && dataGridView1.Columns[index].Visible == false)
                        {
                            count--;
                            j--;
                            continue;
                        }
                        if (j == 18 && dataGridView1.Rows[i].Cells[index].Value.ToString() == "0")
                            worksheet.Cells[i + 7, j + 1] = "";
                        else
                            if (j == 12 || j == 13 || j == 15)
                            {
                                date = (DateTime)dataGridView1.Rows[i].Cells[index].Value;
                                worksheet.Cells[i + 7, j + 1] = date.ToString("dd/MM/yyyy");
                            }        
                            else
                                worksheet.Cells[i + 7, j + 1] = dataGridView1.Rows[i].Cells[index].Value == null ? "" : dataGridView1.Rows[i].Cells[index].Value.ToString().ToUpper();
                        worksheet.Cells[i + 7, j + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[i + 7, j + 1].Borders.Weight = 2d;
                    }

                }
            }
            if (this.Status == 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int count = dataGridView1.ColumnCount;
                    int index = 0;
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 7, 1].Borders.Weight = 2d;
                    worksheet.Cells[i + 7, 18].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 7, 18].Borders.Weight = 2d;
                    for (int j = 1; j < count; j++)
                    {
                        index++;
                        if (index > 1 && dataGridView1.Columns[index].Visible == false)
                        {
                            count--;
                            j--;
                            continue;
                        }
                        if ((j == 12 || j == 13) && DateTime.TryParse(dataGridView1.Rows[i].Cells[index].Value.ToString(),out date))
                        {
                            worksheet.Cells[i + 7, j + 1] = date.ToString("dd/MM/yyyy");
                        }
                        else
                            worksheet.Cells[i + 7, j + 1] = dataGridView1.Rows[i].Cells[index].Value == null ? "" : dataGridView1.Rows[i].Cells[index].Value.ToString().ToUpper();
                        worksheet.Cells[i + 7, j + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[i + 7, j + 1].Borders.Weight = 2d;
                    }

                }
            }
            if (this.Status == 5)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int count = dataGridView1.ColumnCount;
                    int index = 0;
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 7, 1].Borders.Weight = 2d;
                    worksheet.Cells[i + 7, 16].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 7, 16].Borders.Weight = 2d;
                    for (int j = 1; j < count; j++)
                    {
                        index++;
                        if (index > 1 && dataGridView1.Columns[index].Visible == false)
                        {
                            count--;
                            j--;
                            continue;
                        }
                        if ((j == 12 || j == 13) && DateTime.TryParse(dataGridView1.Rows[i].Cells[index].Value.ToString(), out date))
                        {
                            worksheet.Cells[i + 7, j + 1] = date.ToString("dd/MM/yyyy");
                        }
                        else
                            worksheet.Cells[i + 7, j + 1] = dataGridView1.Rows[i].Cells[index].Value == null ? "" : dataGridView1.Rows[i].Cells[index].Value.ToString().ToUpper();
                        worksheet.Cells[i + 7, j + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[i + 7, j + 1].Borders.Weight = 2d;
                    }

                }
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;


            try
            {
                // contructor
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Sheet1";
                //SetWidth-Height-Merge

                SetWidthColumn(worksheet);
                SetFontStye(worksheet);
                SetRowsHeight(worksheet);
                SetFormatColumn(worksheet,dataGridView1);
                SetMergeCell(worksheet);
                SetColorCell(worksheet);
                // export Title
                SetTitle(worksheet);

                // export header
                ExportHeader(worksheet, dataGridView1);
                SetColorCell(worksheet);

                // export content
                ExportCell(worksheet, dataGridView1);

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excel thành công.!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        #endregion


        #region Event

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count == 1)
            {
                foreach(Member item in listMember)
                {
                    if(this.Status == 1)
                    {
                        fEditMemberXuatVien f = new fEditMemberXuatVien(item);
                        f.ShowDialog();
                        break;
                    }
                    if (this.Status == 0 || this.Status == 3 || this.Status == 5 || this.Status == 4)
                    {
                        EditMember f = new EditMember(item);
                        f.ShowDialog();
                        break;
                    }
                    if (this.Status == 2)
                    {
                        fEditMemberChuyenTuyen f = new fEditMemberChuyenTuyen(item);
                        f.ShowDialog();
                        break;
                    }
                }
            }
            LoadMemberListDangDieuTri();
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (txbFindMember.Text != "")
                SreachMemberByName(txbFindMember.Text);
            else
                LoadMemberListDangDieuTri();
        }

        private void btnDelPerson_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count > 0)
                if(MessageBox.Show("Xác nhận xoá những bệnh nhân này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    foreach (Member item in listMember)
                        MemberDAO.Instance.UpdateStatus(item.ID, -1);
            LoadMemberListDangDieuTri();
        }

        private void dtgvMember_FilterStringChanged(object sender, EventArgs e)
        {
            listDangDieuTri.Filter = SwitchDtgv().FilterString;
        }

        private void dtgvMember_SortStringChanged(object sender, EventArgs e)
        {
            listDangDieuTri.Sort = SwitchDtgv().SortString;
            
        }

        private void dtgvXuatVien_FilterStringChanged(object sender, EventArgs e)
        {
            listXuatVien.Filter = SwitchDtgv().FilterString;
        }

        private void dtgvXuatVien_SortStringChanged(object sender, EventArgs e)
        {
            listXuatVien.Sort = SwitchDtgv().SortString;
        }

        private void dtgvChuyenTuyen_SortStringChanged(object sender, EventArgs e)
        {
            listChuyenTuyen.Sort = SwitchDtgv().SortString;
        }

        private void dtgvChuyenTuyen_FilterStringChanged(object sender, EventArgs e)
        {
            listChuyenTuyen.Filter = SwitchDtgv().FilterString;
        }

        private void dtgvXN_SortStringChanged(object sender, EventArgs e)
        {
            listXetNghiem.Sort = SwitchDtgv().SortString;
        }

        private void dtgvXN_FilterStringChanged(object sender, EventArgs e)
        {
            listXetNghiem.Filter = SwitchDtgv().FilterString;
        }


        private void dtgvBack_SortStringChanged(object sender, EventArgs e)
        {
            listBack.Sort = SwitchDtgv().SortString;
        }

        private void dtgvBack_FilterStringChanged(object sender, EventArgs e)
        {
            listBack.Filter = SwitchDtgv().FilterString;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txbPage.Text = "1";
        }


        private void dtgvInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                dtgvInput.SelectAll();
            }
        }

        private void txbFindMember_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFindPerson_Click(sender, e);
            if (txbFindMember.Text == "")
                LoadMemberListDangDieuTri();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txbPage.Text = LastPage().ToString();
        }

        private void txbPage_TextChanged(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri();
        }

        private void nUDPageRows_ValueChanged(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txbPage.Text);
            if(page<LastPage())
                txbPage.Text = (++page).ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txbPage.Text);
            if(page>1)
                txbPage.Text = (--page).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count > 0)
                if (MessageBox.Show("Xác nhận chuyển những bệnh nhân này trở lại viện?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    foreach (Member item in listMember)
                        MemberDAO.Instance.UpdateStatus(item.ID, 0);
            LoadMemberListDangDieuTri();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Status = TabControl.SelectedIndex;
            LoadMemberListDangDieuTri();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".xlsx";
            if(this.Status == 1)
            {
                saveFileDialog1.FileName = "XUATVIEN_E_" + DateTime.Now.Day.ToString("d2") + DateTime.Now.Month.ToString("d2");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ToExcel(dtgvXuatVien, saveFileDialog1.FileName);
                }
            }
            if(this.Status == 0)
            {
                saveFileDialog1.FileName = "NHAPVIEN_E_" + DateTime.Now.Day.ToString("d2") + DateTime.Now.Month.ToString("d2");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ToExcel(dtgvMember, saveFileDialog1.FileName);
                }
            }
            if (this.Status == 5)
            {
                saveFileDialog1.FileName = "XETNGHIEM_E_" + DateTime.Now.Day.ToString("d2") + DateTime.Now.Month.ToString("d2");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ToExcel(dtgvXN, saveFileDialog1.FileName);
                }
            }

            LoadMemberListDangDieuTri();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (OleDbConnection myConnect = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0;", openFileDialog1.FileName)))
                    {
                        DataTable data = new DataTable();
                        OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT * from [Sheet1$]", myConnect);
                        cmd.Fill(data);
                        dtgvInput.DataSource = data;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                lbTongSoBN.Text = "Tổng số: " + dtgvInput.Rows.Count.ToString();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtgvInput.SelectedRows.Count > 0)
            {
                int count = 0;
                for(int i = dtgvInput.SelectedRows.Count-1;i>=0;i--)
                {
                    string roomName = dtgvInput.SelectedRows[i].Cells[1].Value.ToString();
                    Room room = RoomDAO.Instance.GetRoomByName(roomName);
                    if (room != null && room.Member < room.Maximum)
                    {
                        int idPhong = room.ID;
                        string maBN = "";
                        string ht = dtgvInput.SelectedRows[i].Cells[2].Value.ToString();
                        int gt = dtgvInput.SelectedRows[i].Cells[3].Value.ToString().ToUpper() == "Nam".ToUpper() ? 0 : 1;
                        int ns = int.Parse(dtgvInput.SelectedRows[i].Cells[4].Value.ToString());
                        string danToc = dtgvInput.SelectedRows[i].Cells[5].Value == null || dtgvInput.SelectedRows[i].Cells[5].Value.ToString() == "" ? "Kinh" : dtgvInput.SelectedRows[i].Cells[5].Value.ToString();
                        string dc = dtgvInput.SelectedRows[i].Cells[6].Value.ToString();
                        string tiTh = dtgvInput.SelectedRows[i].Cells[7].Value.ToString() == "HCM" ? "Hồ Chí Minh" : dtgvInput.SelectedRows[i].Cells[7].Value.ToString();
                        string qHuyen = dtgvInput.SelectedRows[i].Cells[8].Value.ToString();
                        string phuongXa = dtgvInput.SelectedRows[i].Cells[9].Value.ToString();
                        string sdt = dtgvInput.SelectedRows[i].Cells[10].Value.ToString();
                        string cccd = dtgvInput.SelectedRows[i].Cells[11].Value.ToString();
                        string tenNT = dtgvInput.SelectedRows[i].Cells[12].Value.ToString();
                        string mqh = dtgvInput.SelectedRows[i].Cells[13].Value.ToString();
                        string sdtNT = dtgvInput.SelectedRows[i].Cells[14].Value.ToString();
                        string noiChuyen = dtgvInput.SelectedRows[i].Cells[15].Value.ToString();
                        string ngayNV = dtgvInput.SelectedRows[i].Cells[16].Value.ToString();
                        DateTime nnv = DateTime.Parse(ngayNV);
                        DateTime nxn;
                        string ngayXN = dtgvInput.SelectedRows[i].Cells[17].Value.ToString();
                        if (!DateTime.TryParse(ngayXN, out nxn))
                        {
                            MemberDAO.Instance.InsertMemberChuaXetNghiem(idPhong, maBN, ht, ns, gt, danToc, dc, phuongXa, qHuyen, tiTh, sdt, cccd, noiChuyen.Trim(' ', ',', '-'), "E", nnv, tenNT, mqh, sdtNT, 0);
                        }
                        else
                        {
                            MemberDAO.Instance.InsertMember(idPhong, maBN, ht, ns, gt, danToc, dc, phuongXa, qHuyen, tiTh, sdt, cccd, noiChuyen.Trim(' ', ',', '-'), "E", nnv, nxn, tenNT, mqh, sdtNT, 0);

                        }
                        count++;
                        room.Member++;
                        for(int j = 0; j < 18; j++)
                        {
                            dtgvInput.SelectedRows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                }
                MessageBox.Show("Thêm thành công " + count + " người vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
        }



        private void chuyểnTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count > 0)
                foreach (Member item in listMember)
                {
                    MemberDAO.Instance.UpdateStatus(item.ID, 2);
                }    
            MessageBox.Show("Chuyển tuyến thành công!", "Thông báo", MessageBoxButtons.OK);
            LoadMemberListDangDieuTri();
        }

        private void xuấtViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count > 0)
                foreach (Member item in listMember)
                {
                    MemberDAO.Instance.UpdateStatus(item.ID, 1);
                }
            MessageBox.Show("Xuất viện thành công!", "Thông báo", MessageBoxButtons.OK);
            LoadMemberListDangDieuTri();
        }


        private void dtgvXuatVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EditMember(e.RowIndex);
        }

        private void dtgvChuyenTuyen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EditMember(e.RowIndex);
        }

        private void cậpNhậtBảngTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ListMemberEdit.Count > 0)
            {
                if(this.Status == 1)
                    foreach (Member item in ListMemberEdit)
                        MemberDAO.Instance.UpdateXuatVien(item.ID, item.MaBN, item.SoLT, (DateTime)item.NXV, (DateTime)item.NXN, item.Ktxn, item.Kq, item.CtValue);
                if (this.Status == 2)
                    foreach (Member item in ListMemberEdit)
                        MemberDAO.Instance.UpdateChuyenTuyen(item.ID, item.MaBN, (DateTime)item.NXV, item.NoiDen);
                ListMemberEdit.Clear();
            }
        }
        
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = Clipboard.GetText();
            foreach (DataGridViewCell item in SwitchDtgv().SelectedCells)
            {
                item.Value = s;
                EditMember(item.RowIndex);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SwitchDtgv().SelectedCells[0].Value.ToString() != ""?SwitchDtgv().SelectedCells[0].Value.ToString():" ");
        }
        #endregion


    }
}
