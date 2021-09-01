using project_quan_ly_giuong_benh.DAO___Data_Access_Logic;
using project_quan_ly_giuong_benh.DTO___Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace project_quan_ly_giuong_benh
{
    public partial class fQuanLyBenhNhan : Form
    {
        public fQuanLyBenhNhan()
        {
            InitializeComponent();
            LoadMemberListDangDieuTri(0);
        }

        HashSet<Member> GetSelectedMember()
        {
            HashSet<Member> listMember = new HashSet<Member>();
            foreach(DataGridViewCell item in dtgvMember.SelectedCells)
            {
                listMember.Add(MemberDAO.Instance.GetMemberById((int)item.OwningRow.Cells["ID"].Value));
            }
            return listMember;
        }

        List<Member> SreachMemberByName(string name, int status)
        {
            List<Member> listMember = MemberDAO.Instance.SreachMemberByName(name, status);

            return listMember;
        }

        void FormatColumnDangDieuTri()
        {
            dtgvMember.Columns[0].Visible = false;
            dtgvMember.Columns[0].Tag = true;
            dtgvMember.Columns[1].HeaderText = "Phòng";
            dtgvMember.Columns[1].Width = 40;
            dtgvMember.Columns[1].Tag = "p.ten";
            dtgvMember.Columns[2].Visible = false;
            dtgvMember.Columns[3].Visible = false;
            dtgvMember.Columns[4].HeaderText = "Họ và tên";
            dtgvMember.Columns[4].Width = 150;
            dtgvMember.Columns[4].Tag = "b.hoTen";
            dtgvMember.Columns[5].HeaderText = "Năm sinh";
            dtgvMember.Columns[5].Width = 40;
            dtgvMember.Columns[5].Tag = "b.namSinh";
            dtgvMember.Columns[6].HeaderText = "Giới tính";
            dtgvMember.Columns[6].Width = 40;
            dtgvMember.Columns[6].Tag = "b.gioiTinh";
            dtgvMember.Columns[7].HeaderText = "Dân Tộc";
            dtgvMember.Columns[7].Width = 40;
            dtgvMember.Columns[7].Tag = "b.danToc";
            dtgvMember.Columns[8].HeaderText = "Địa chỉ";
            dtgvMember.Columns[8].Width = 150;
            dtgvMember.Columns[8].Tag = "b.diaChi";
            dtgvMember.Columns[9].HeaderText = "Phường/Xã";
            dtgvMember.Columns[9].Width = 110;
            dtgvMember.Columns[9].Tag = "b.phuongXa";
            dtgvMember.Columns[10].HeaderText = "Quận/Huyện";
            dtgvMember.Columns[10].Width = 80;
            dtgvMember.Columns[10].Tag = "b.quanHuyen";
            dtgvMember.Columns[11].HeaderText = "Tỉnh/TP";
            dtgvMember.Columns[11].Width = 70;
            dtgvMember.Columns[11].Tag = "b.tinhThanh";
            dtgvMember.Columns[12].HeaderText = "SĐT";
            dtgvMember.Columns[12].Width = 80;
            dtgvMember.Columns[12].Tag = "b.sdt";
            dtgvMember.Columns[13].HeaderText = "CMND/CCCD";
            dtgvMember.Columns[13].Width = 100;
            dtgvMember.Columns[13].Tag = "b.cccd";
            dtgvMember.Columns[14].HeaderText = "Nơi chuyển";
            dtgvMember.Columns[14].Width = 180;
            dtgvMember.Columns[14].Tag = "b.noiChuyen";
            dtgvMember.Columns[15].Visible = false;
            dtgvMember.Columns[16].HeaderText = "Nhập viện";
            dtgvMember.Columns[16].Width = 80;
            dtgvMember.Columns[16].Tag = "b.ngayNhapVien";
            dtgvMember.Columns[17].Visible = false;
            dtgvMember.Columns[18].Visible = false;
            dtgvMember.Columns[19].HeaderText = "XN lần cuối";
            dtgvMember.Columns[19].Width = 70;
            dtgvMember.Columns[19].Tag = "b.ngayXetNghiem";
            dtgvMember.Columns[20].Visible = false;
            dtgvMember.Columns[21].Visible = false;
            dtgvMember.Columns[22].Visible = false;
            dtgvMember.Columns[23].HeaderText = "Họ tên người thân";
            dtgvMember.Columns[23].Width = 160;
            dtgvMember.Columns[23].Tag = "b.tenNguoiThan";
            dtgvMember.Columns[24].HeaderText = "Mối quan hệ";
            dtgvMember.Columns[24].Width = 80;
            dtgvMember.Columns[24].Tag = "b.mqh";
            dtgvMember.Columns[25].HeaderText = "SĐT người thân";
            dtgvMember.Columns[25].Width = 80;
            dtgvMember.Columns[25].Tag = "b.sdtNguoiThan";
            dtgvMember.Columns[26].HeaderText = "Phân loại";
            dtgvMember.Columns[26].Width = 40;
            dtgvMember.Columns[26].Tag = "b.phanLoai";
            dtgvMember.Columns[27].Visible = false;
            dtgvMember.Columns[27].Tag = 0;
            dtgvMember.Columns[28].Visible = false;
            int[] arr = { 5, 6, 12, 13, 16, 19, 25, 26 };
            foreach (int i in arr)
            {
                dtgvMember.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        void FormatColumnXuatVien()
        {
            dtgvMember.Columns[0].Visible = false;
            dtgvMember.Columns[0].Tag = true;
            dtgvMember.Columns[1].HeaderText = "PHÒNG";
            dtgvMember.Columns[1].Width = 40;
            dtgvMember.Columns[1].Tag = "p.ten";
            dtgvMember.Columns[2].HeaderText = "Mã BN\n(nếu có)";
            dtgvMember.Columns[2].Width = 40;
            dtgvMember.Columns[2].Tag = "b.maBenhNhan";
            dtgvMember.Columns[3].HeaderText = "Số lưu trữ";
            dtgvMember.Columns[3].Width = 40;
            dtgvMember.Columns[3].Tag = "b.soLuuTru";
            dtgvMember.Columns[4].HeaderText = "HỌ TÊN BỆNH NHÂN";
            dtgvMember.Columns[4].Width = 150;
            dtgvMember.Columns[4].Tag = "b.hoTen";
            dtgvMember.Columns[5].HeaderText = "Năm sinh";
            dtgvMember.Columns[5].Width = 40;
            dtgvMember.Columns[5].Tag = "b.namSinh";
            dtgvMember.Columns[6].HeaderText = "Giới tính";
            dtgvMember.Columns[6].Width = 40;
            dtgvMember.Columns[6].Tag = "b.gioiTinh";
            dtgvMember.Columns[7].HeaderText = "Dân Tộc";
            dtgvMember.Columns[7].Width = 40;
            dtgvMember.Columns[7].Tag = "b.danToc";
            dtgvMember.Columns[8].HeaderText = "ĐỊA CHỈ THƯỜNG TRÚ";
            dtgvMember.Columns[8].Width = 210;
            dtgvMember.Columns[8].Tag = "b.diaChi";
            dtgvMember.Columns[9].Visible = false;
            dtgvMember.Columns[10].HeaderText = "Quận/\nHuyện";
            dtgvMember.Columns[10].Width = 80;
            dtgvMember.Columns[10].Tag = "b.quanHuyen";
            dtgvMember.Columns[11].Visible = false;
            dtgvMember.Columns[12].HeaderText = "SĐT";
            dtgvMember.Columns[12].Width = 80;
            dtgvMember.Columns[12].Tag = "b.sdt";
            dtgvMember.Columns[13].Visible = false;
            dtgvMember.Columns[14].Visible = false;
            dtgvMember.Columns[15].HeaderText = "KHOA (nếu có)";
            dtgvMember.Columns[15].Width = 40;
            dtgvMember.Columns[15].Tag = "b.khoa";
            dtgvMember.Columns[16].HeaderText = "NGÀY NHẬP VIỆN (Format dd/MM/yyyy)";
            dtgvMember.Columns[16].Width = 80;
            dtgvMember.Columns[16].Tag = "b.ngayNhapVien";
            dtgvMember.Columns[17].HeaderText = "NGÀY XUẤT VIỆN (Format dd/MM/yyyy)";
            dtgvMember.Columns[17].Width = 80;
            dtgvMember.Columns[17].Tag = "b.ngayXuatVien";
            dtgvMember.Columns[18].HeaderText = "SỐ\nNGÀY\nĐIỀU TRỊ";
            dtgvMember.Columns[18].Width = 40;
            dtgvMember.Columns[18].Tag = "b.ngayNhapVien";
            dtgvMember.Columns[19].HeaderText = "NGÀY LÀM XÉT NGHIỆM (Format dd/MM/yyyy)";
            dtgvMember.Columns[19].Width = 80;
            dtgvMember.Columns[19].Tag = "b.ngayXetNghiem";
            dtgvMember.Columns[20].HeaderText = "KỸ THUẬT XÉT NGHIỆM RA VIỆN";
            dtgvMember.Columns[20].Width = 80;
            dtgvMember.Columns[20].Tag = "b.kyThuatXN";
            dtgvMember.Columns[21].HeaderText = "KẾT QUẢ";
            dtgvMember.Columns[21].Width = 80;
            dtgvMember.Columns[21].Tag = "b.ketQua";
            dtgvMember.Columns[22].HeaderText = "CT\nVALUE\n≥30";
            dtgvMember.Columns[22].Width = 80;
            dtgvMember.Columns[22].Tag = "b.ctValue";
            dtgvMember.Columns[23].Visible = false;
            dtgvMember.Columns[24].Visible = false;
            dtgvMember.Columns[25].Visible = false;
            dtgvMember.Columns[26].Visible = false;
            dtgvMember.Columns[27].Visible = false;
            dtgvMember.Columns[27].Tag = 1;
            dtgvMember.Columns[28].Visible = false;
            int[] arr = { 1, 2, 3, 5, 6, 7, 12, 15, 16, 17, 18, 19, 20, 21, 22 };
            foreach (int i in arr)
            {
                dtgvMember.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        void FormatColumn(int status)
        {
            for (int i = 0; i < 29; i++)
            {
                dtgvMember.Columns[i].Visible = true;
                dtgvMember.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dtgvMember.ReadOnly = true;
            dtgvMember.Tag = status;
            if (status == 0)
            {
                FormatColumnDangDieuTri();
                dtgvMember.Columns[28].Tag = dtgvMember.DataSource;
            }    
            if (status == 1)
            {
                FormatColumnXuatVien();
                dtgvMember.Columns[28].Tag = dtgvMember.DataSource;
            }
        }

        void GhepDiaChi(int status)
        {
            if (status == 1)
            {
                foreach (DataGridViewRow item in dtgvMember.Rows)
                {
                    item.Cells[8].Value += ", Phường " + item.Cells[9].Value;
                }
            }
        }

        void LoadMemberListDangDieuTri(int status)
        {
            List<Member> listMember = MemberDAO.Instance.GetMemberList(status);
            dtgvMember.DataSource = listMember;

            FormatColumn(status);
        }
        void SetWidthColumn(Microsoft.Office.Interop.Excel.Worksheet worksheet)
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
        void SetColorCell(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            worksheet.Cells[5, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFFF00"));
            worksheet.Cells[5, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFFF00"));
            worksheet.Cells[5, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#9BC2E6"));
            worksheet.Cells[5, 7].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#9BC2E6"));
            worksheet.Cells[5, 8].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#9BC2E6"));
            worksheet.Cells[5, 17].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFE699"));
            worksheet.Cells[5, 19].Interior.Color = System.Drawing.ColorTranslator.ToOle(ColorTranslator.FromHtml("#C6EFCE"));
        }
        void SetRowsHeight(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            for (int i = 1; i < 5; i++)
                worksheet.Rows[i].RowHeight = 19.5;
            worksheet.Rows[5].RowHeight = 27;
            worksheet.Rows[6].RowHeight = 27;
            

        }
        void SetMergeCell(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            worksheet.Range[worksheet.Cells[1,1],worksheet.Cells[1,10]].Merge();
            worksheet.Range[worksheet.Cells[2,1],worksheet.Cells[2,10]].Merge();
            worksheet.Range[worksheet.Cells[3,1],worksheet.Cells[3,18]].Merge();
            worksheet.Range[worksheet.Cells[1,13],worksheet.Cells[1,16]].Merge();
            worksheet.Range[worksheet.Cells[2,13],worksheet.Cells[2,16]].Merge();
            for(int i = 1; i < 23; i++)
            {
                if (i == 9)
                    continue;
                worksheet.Range[worksheet.Cells[5, i], worksheet.Cells[6, i]].Merge();
            }
        }
        void SetFormatColumn(Microsoft.Office.Interop.Excel.Worksheet worksheet, DataGridView dataGridView1)
        {
            worksheet.Columns[11].NumberFormat = "@";
            worksheet.Columns[13].NumberFormat = "DD/MM/YYYY";
            worksheet.Columns[14].NumberFormat = "DD/MM/YYYY";
            worksheet.Columns[16].NumberFormat = "DD/MM/YYYY";
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
        void SetFontStye(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            worksheet.Rows.RowHeight = 38.25;
            worksheet.Rows.Font.Name = "Times New Roman";
            worksheet.Rows.Font.Size = 14;
        }
        void SetTitle(Microsoft.Office.Interop.Excel.Worksheet worksheet)
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
        void ExportHeader(Microsoft.Office.Interop.Excel.Worksheet worksheet, DataGridView dataGridView1)
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
                if (index>1 && dataGridView1.Columns[index].Visible == false)
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
        void ExportCell(Microsoft.Office.Interop.Excel.Worksheet worksheet, DataGridView dataGridView1)
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
                    else worksheet.Cells[i + 7, j + 1] = dataGridView1.Rows[i].Cells[index].Value==null?"":dataGridView1.Rows[i].Cells[index].Value.ToString().ToUpper();
                    worksheet.Cells[i + 7, j + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 7, j + 1].Borders.Weight = 2d;
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

        private void btnDangDieuTri_Click(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri(0);
            dtgvMember.Columns[27].Tag = 0;
        }

        private void btnXuatVien_Click(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri(1);
            dtgvMember.Columns[27].Tag = 1;
        }

        private void btnChuyenTuyen_Click(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri(2);
            dtgvMember.Columns[27].Tag = 2;
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count == 1)
            {
                foreach(Member item in listMember)
                {
                    if((int)dtgvMember.Columns[27].Tag == 1)
                    {
                        fAdminEditMember f = new fAdminEditMember(item);
                        f.ShowDialog();
                        dtgvMember.Columns[27].Tag = 1;
                        break;
                    }
                    if ((int)dtgvMember.Columns[27].Tag == 0)
                    {
                        EditMember f = new EditMember(item);
                        f.ShowDialog();
                        dtgvMember.Columns[27].Tag = 0;
                        break;
                    }
                    
                }
            }
            LoadMemberListDangDieuTri((int)dtgvMember.Columns[27].Tag);
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(txbFindMember.Text != "")
                dtgvMember.DataSource = SreachMemberByName(txbFindMember.Text, (int)dtgvMember.Columns[27].Tag);
        }

        private void btnDelPerson_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count > 0)
                if(MessageBox.Show("Xác nhận xoá những bệnh nhân này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    foreach (Member item in listMember)
                        MemberDAO.Instance.UpdateStatus(item.ID, -1);
            LoadMemberListDangDieuTri((int)dtgvMember.Columns[27].Tag);
        }

        private void dtgvMember_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sort = (bool)dtgvMember.Columns[0].Tag ? "ASC" : "DESC";
            string columnName = dtgvMember.Columns[e.ColumnIndex].Tag != null ? dtgvMember.Columns[e.ColumnIndex].Tag.ToString() : "2";
            int status = dtgvMember.Columns[27].Tag != null ? (int)dtgvMember.Columns[27].Tag : 0;
            dtgvMember.DataSource = MemberDAO.Instance.GetMemberList(status, columnName, sort);
            dtgvMember.Columns[0].Tag = !(bool)dtgvMember.Columns[0].Tag;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".xlsx";
            saveFileDialog1.FileName = "XUATVIEN_E_" + DateTime.Now.Day.ToString("d2") + DateTime.Now.Month.ToString("d2");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dtgvMember.DataSource = dtgvMember.Columns[28].Tag;
                GhepDiaChi((int)dtgvMember.Columns[27].Tag);
                ToExcel(dtgvMember, saveFileDialog1.FileName);
            }
            LoadMemberListDangDieuTri((int)dtgvMember.Columns[27].Tag);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
