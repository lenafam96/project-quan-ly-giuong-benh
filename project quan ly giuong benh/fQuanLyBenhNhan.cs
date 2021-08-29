﻿using project_quan_ly_giuong_benh.DAO___Data_Access_Logic;
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

        void LoadMemberListDangDieuTri(int status)
        {
            List<Member> listMember = MemberDAO.Instance.GetMemberList(status);
            int[] arr = { 3, 4, 5, 7, 9, 10, 13, 14 };
            dtgvMember.DataSource = listMember;
            foreach(int i in arr)
            {
                dtgvMember.Columns[i].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            dtgvMember.ReadOnly = true;
            dtgvMember.Columns[0].Visible = false;
            dtgvMember.Columns[0].Tag = true;
            dtgvMember.Columns[1].HeaderText = "Phòng";
            dtgvMember.Columns[1].Width = 40;
            dtgvMember.Columns[1].Tag = "p.ten";
            dtgvMember.Columns[2].HeaderText = "Họ và tên";
            dtgvMember.Columns[2].Width = 140;
            dtgvMember.Columns[2].Tag = "b.hoTen";
            dtgvMember.Columns[3].HeaderText = "Giới tính";
            dtgvMember.Columns[3].Width = 40;
            dtgvMember.Columns[3].Tag = "b.gioiTinh";
            dtgvMember.Columns[4].HeaderText = "Năm sinh";
            dtgvMember.Columns[4].Width = 40;
            dtgvMember.Columns[4].Tag = "b.namSinh";
            dtgvMember.Columns[5].HeaderText = "SĐT";
            dtgvMember.Columns[5].Width = 80;
            dtgvMember.Columns[5].Tag = "b.sdt";
            dtgvMember.Columns[6].HeaderText = "Địa chỉ";
            dtgvMember.Columns[6].Width = 300;
            dtgvMember.Columns[6].Tag = "b.diaChi";
            dtgvMember.Columns[7].HeaderText = "CMND/CCCD";
            dtgvMember.Columns[7].Width = 100;
            dtgvMember.Columns[7].Tag = "b.cccd";
            dtgvMember.Columns[8].HeaderText = "Nơi chuyển";
            dtgvMember.Columns[8].Width = 180;
            dtgvMember.Columns[8].Tag = "b.noiChuyen";
            dtgvMember.Columns[9].HeaderText = "Nhập viện";
            dtgvMember.Columns[9].Width = 80;
            dtgvMember.Columns[9].Tag = "b.ngayNhapVien";
            dtgvMember.Columns[10].HeaderText = "XN lần cuối";
            dtgvMember.Columns[10].Width = 70;
            dtgvMember.Columns[10].Tag = "b.ngayXetNghiem";
            dtgvMember.Columns[11].HeaderText = "Họ tên người thân";
            dtgvMember.Columns[11].Width = 160;
            dtgvMember.Columns[11].Tag = "b.tenNguoiThan";
            dtgvMember.Columns[12].HeaderText = "Mối quan hệ";
            dtgvMember.Columns[12].Width = 80;
            dtgvMember.Columns[12].Tag = "b.mqh";
            dtgvMember.Columns[13].HeaderText = "SĐT người thân";
            dtgvMember.Columns[13].Width = 80;
            dtgvMember.Columns[13].Tag = "b.sdtNguoiThan";
            dtgvMember.Columns[14].HeaderText = "Phân loại";
            dtgvMember.Columns[14].Width = 40;
            dtgvMember.Columns[14].Tag = "b.phanLoai";
            dtgvMember.Columns[15].Visible = false;
            dtgvMember.Columns[15].Tag = 0;
            dtgvMember.Tag = status;
        }

        private void btnDangDieuTri_Click(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri(0);
            dtgvMember.Columns[15].Tag = 0;
        }

        private void btnXuatVien_Click(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri(1);
            dtgvMember.Columns[15].Tag = 1;
        }

        private void btnChuyenTuyen_Click(object sender, EventArgs e)
        {
            LoadMemberListDangDieuTri(2);
            dtgvMember.Columns[15].Tag = 2;
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count == 1)
            {
                foreach(Member item in listMember)
                {
                    EditMember f = new EditMember(item);
                    f.ShowDialog();
                    break;
                }
            }
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(txbFindMember.Text != "")
                dtgvMember.DataSource = SreachMemberByName(txbFindMember.Text, (int)dtgvMember.Columns[15].Tag);
        }

        private void btnDelPerson_Click(object sender, EventArgs e)
        {
            HashSet<Member> listMember = GetSelectedMember();
            if (listMember.Count > 0)
                if(MessageBox.Show("Xác nhận xoá những bệnh nhân này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    foreach (Member item in listMember)
                        MemberDAO.Instance.UpdateStatus(item.ID, -1);
            LoadMemberListDangDieuTri((int)dtgvMember.Columns[15].Tag);
        }

        private void dtgvMember_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sort = (bool)dtgvMember.Columns[0].Tag ? "ASC" : "DESC";
            string columnName = dtgvMember.Columns[e.ColumnIndex].Tag != null ? dtgvMember.Columns[e.ColumnIndex].Tag.ToString() : "2";
            int status = dtgvMember.Columns[15].Tag != null ? (int)dtgvMember.Columns[15].Tag : 0;
            dtgvMember.DataSource = MemberDAO.Instance.GetMemberList(status, columnName, sort);
            dtgvMember.Columns[0].Tag = !(bool)dtgvMember.Columns[0].Tag;
        }
    }
}
