using project_quan_ly_giuong_benh.DAO___Data_Access_Logic;
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
    public partial class fReportThongKe : Form
    {
        public fReportThongKe()
        {
            InitializeComponent();
            string header ="Khoa E xin báo cáo ngày " + DateTime.Now.Day.ToString("d2") + "/" + DateTime.Now.Month.ToString("d2") + " lúc " + DateTime.Now.Hour.ToString() + "h" + DateTime.Now.Minute.ToString() + ":";
            int TongF0 = DataProvider.Instance.ExecuteQuery("SELECT id FROM dbo.BenhNhan WHERE trangThai = 0").Rows.Count;
            int TongNhapVien = DataProvider.Instance.ExecuteQuery("SELECT id FROM dbo.BenhNhan WHERE trangThai = 0 AND ngayNhapVien = GETDATE()").Rows.Count;
            int TongCC = DataProvider.Instance.ExecuteQuery("SELECT id FROM dbo.BenhNhan WHERE trangThai = 0 AND idPhong IN (58,59,60)").Rows.Count;
            int TongChuyenVien = DataProvider.Instance.ExecuteQuery("SELECT id FROM dbo.BenhNhan WHERE trangThai = 2 AND ngayXuatVien = GETDATE()").Rows.Count;
            txbReport.Text = header;
            txbReport.AppendText("\r\nTổng F0 hiện tại: " + TongF0);
            txbReport.AppendText("\r\nĐã tiếp nhận thêm: " + TongNhapVien);
            txbReport.AppendText("\r\nTổng F0 cbi nhận: ");
            txbReport.AppendText("\r\nTổng F0 đã chuyển viện: " + TongChuyenVien);
            txbReport.AppendText("\r\nTổng số CC: " + TongCC);
            txbReport.AppendText("\r\nOxy: ");
            txbReport.AppendText("\r\nKT: ");
            txbReport.AppendText("\r\nMask: ");
            txbReport.AppendText("\r\nHFNC: ");
            txbReport.AppendText("\r\nNKQ: ");
            txbReport.AppendText("\r\nTử Vong: ");
        }

    }
}
