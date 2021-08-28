
namespace project_quan_ly_giuong_benh
{
    partial class fQuanLyBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbFindMember = new System.Windows.Forms.TextBox();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnDelPerson = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnChuyenTuyen = new System.Windows.Forms.Button();
            this.btnXuatVien = new System.Windows.Forms.Button();
            this.btnDangDieuTri = new System.Windows.Forms.Button();
            this.dtgvMember = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txbFindMember);
            this.panel3.Controls.Add(this.btnFindPerson);
            this.panel3.Controls.Add(this.btnDelPerson);
            this.panel3.Controls.Add(this.btnEditPerson);
            this.panel3.Controls.Add(this.btnChuyenTuyen);
            this.panel3.Controls.Add(this.btnXuatVien);
            this.panel3.Controls.Add(this.btnDangDieuTri);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1512, 42);
            this.panel3.TabIndex = 3;
            // 
            // txbFindMember
            // 
            this.txbFindMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFindMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFindMember.Location = new System.Drawing.Point(1146, 7);
            this.txbFindMember.Name = "txbFindMember";
            this.txbFindMember.Size = new System.Drawing.Size(263, 26);
            this.txbFindMember.TabIndex = 1;
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindPerson.Location = new System.Drawing.Point(1415, 3);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(97, 36);
            this.btnFindPerson.TabIndex = 0;
            this.btnFindPerson.Text = "Tìm kiếm";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnDelPerson
            // 
            this.btnDelPerson.Location = new System.Drawing.Point(415, 3);
            this.btnDelPerson.Name = "btnDelPerson";
            this.btnDelPerson.Size = new System.Drawing.Size(97, 36);
            this.btnDelPerson.TabIndex = 0;
            this.btnDelPerson.Text = "Xoá bệnh nhân";
            this.btnDelPerson.UseVisualStyleBackColor = true;
            this.btnDelPerson.Click += new System.EventHandler(this.btnDelPerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(312, 3);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(97, 36);
            this.btnEditPerson.TabIndex = 0;
            this.btnEditPerson.Text = "Sửa thông tin";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnChuyenTuyen
            // 
            this.btnChuyenTuyen.Location = new System.Drawing.Point(209, 3);
            this.btnChuyenTuyen.Name = "btnChuyenTuyen";
            this.btnChuyenTuyen.Size = new System.Drawing.Size(97, 36);
            this.btnChuyenTuyen.TabIndex = 0;
            this.btnChuyenTuyen.Text = "Đã chuyển tuyến";
            this.btnChuyenTuyen.UseVisualStyleBackColor = true;
            this.btnChuyenTuyen.Click += new System.EventHandler(this.btnChuyenTuyen_Click);
            // 
            // btnXuatVien
            // 
            this.btnXuatVien.Location = new System.Drawing.Point(106, 3);
            this.btnXuatVien.Name = "btnXuatVien";
            this.btnXuatVien.Size = new System.Drawing.Size(97, 36);
            this.btnXuatVien.TabIndex = 0;
            this.btnXuatVien.Text = "Đã xuất viện";
            this.btnXuatVien.UseVisualStyleBackColor = true;
            this.btnXuatVien.Click += new System.EventHandler(this.btnXuatVien_Click);
            // 
            // btnDangDieuTri
            // 
            this.btnDangDieuTri.Location = new System.Drawing.Point(3, 3);
            this.btnDangDieuTri.Name = "btnDangDieuTri";
            this.btnDangDieuTri.Size = new System.Drawing.Size(97, 36);
            this.btnDangDieuTri.TabIndex = 0;
            this.btnDangDieuTri.Text = "Đang điều trị";
            this.btnDangDieuTri.UseVisualStyleBackColor = true;
            this.btnDangDieuTri.Click += new System.EventHandler(this.btnDangDieuTri_Click);
            // 
            // dtgvMember
            // 
            this.dtgvMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMember.Location = new System.Drawing.Point(42, 60);
            this.dtgvMember.Name = "dtgvMember";
            this.dtgvMember.Size = new System.Drawing.Size(1482, 603);
            this.dtgvMember.TabIndex = 4;
            // 
            // fQuanLyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgvMember);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1550, 712);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1550, 712);
            this.Name = "fQuanLyBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bệnh nhân";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbFindMember;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnDelPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnDangDieuTri;
        private System.Windows.Forms.DataGridView dtgvMember;
        private System.Windows.Forms.Button btnXuatVien;
        private System.Windows.Forms.Button btnChuyenTuyen;
    }
}