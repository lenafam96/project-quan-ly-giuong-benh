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
    public partial class test : Form
    {
        BindingSource list = new BindingSource();
        public test()
        {
            InitializeComponent();
            listBenhNhanDangDieuTriBindingSource.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ListBenhNhanDangDieuTri WHERE dbo.fuConvertToUnsign1(hoTen) like N'%'+ dbo.fuConvertToUnsign1('tuan') + N'%'");
        }

        private void dtgvTest_FilterStringChanged(object sender, EventArgs e)
        {
            listBenhNhanDangDieuTriBindingSource.Filter = advancedDataGridView1.FilterString;
        }
        
        private void dtgvTest_SortStringChanged(object sender, EventArgs e)
        {
            listBenhNhanDangDieuTriBindingSource.Sort = advancedDataGridView1.SortString;
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBenhNhanF0DataSet.ListBenhNhanDangDieuTri' table. You can move, or remove it, as needed.
            this.listBenhNhanDangDieuTriTableAdapter.Fill(this.quanLyBenhNhanF0DataSet.ListBenhNhanDangDieuTri);
        }

    }
}
