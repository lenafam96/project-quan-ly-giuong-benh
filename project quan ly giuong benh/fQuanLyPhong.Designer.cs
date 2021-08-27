
namespace project_quan_ly_giuong_benh
{
    partial class fQuanLyPhong
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPhongSapKhoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPhongCapCuu = new System.Windows.Forms.Button();
            this.btnPhongDay = new System.Windows.Forms.Button();
            this.btnPhongTrong = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkThuong = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxMember = new System.Windows.Forms.NumericUpDown();
            this.chkCapCuu = new System.Windows.Forms.CheckBox();
            this.chkSuaChua = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMember)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvRoom);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 339);
            this.panel2.TabIndex = 3;
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvRoom.Location = new System.Drawing.Point(0, 0);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.Size = new System.Drawing.Size(480, 339);
            this.dtgvRoom.TabIndex = 0;
            this.dtgvRoom.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvRoom_ColumnHeaderMouseClick);
            this.dtgvRoom.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvRoom_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelRoom);
            this.panel1.Controls.Add(this.btnEditRoom);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(508, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 42);
            this.panel1.TabIndex = 2;
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.Location = new System.Drawing.Point(182, 3);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(82, 36);
            this.btnDelRoom.TabIndex = 0;
            this.btnDelRoom.Text = "Xoá phòng";
            this.btnDelRoom.UseVisualStyleBackColor = true;
            this.btnDelRoom.Click += new System.EventHandler(this.btnDelRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(91, 3);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(82, 36);
            this.btnEditRoom.TabIndex = 0;
            this.btnEditRoom.Text = "Sửa phòng";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(0, 3);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(82, 36);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPhongSapKhoi);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnPhongCapCuu);
            this.panel3.Controls.Add(this.btnPhongDay);
            this.panel3.Controls.Add(this.btnPhongTrong);
            this.panel3.Controls.Add(this.btnTatCa);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 42);
            this.panel3.TabIndex = 2;
            // 
            // btnPhongSapKhoi
            // 
            this.btnPhongSapKhoi.Location = new System.Drawing.Point(162, 3);
            this.btnPhongSapKhoi.Name = "btnPhongSapKhoi";
            this.btnPhongSapKhoi.Size = new System.Drawing.Size(75, 36);
            this.btnPhongSapKhoi.TabIndex = 0;
            this.btnPhongSapKhoi.Text = "Phòng sắp khỏi hết";
            this.btnPhongSapKhoi.UseVisualStyleBackColor = true;
            this.btnPhongSapKhoi.Click += new System.EventHandler(this.btnPhongSapKhoi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Phòng đang sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDangSua_Click);
            // 
            // btnPhongCapCuu
            // 
            this.btnPhongCapCuu.Location = new System.Drawing.Point(324, 3);
            this.btnPhongCapCuu.Name = "btnPhongCapCuu";
            this.btnPhongCapCuu.Size = new System.Drawing.Size(75, 36);
            this.btnPhongCapCuu.TabIndex = 0;
            this.btnPhongCapCuu.Text = "Phòng cấp cưu";
            this.btnPhongCapCuu.UseVisualStyleBackColor = true;
            this.btnPhongCapCuu.Click += new System.EventHandler(this.btnPhongCapCuu_Click);
            // 
            // btnPhongDay
            // 
            this.btnPhongDay.Location = new System.Drawing.Point(243, 3);
            this.btnPhongDay.Name = "btnPhongDay";
            this.btnPhongDay.Size = new System.Drawing.Size(75, 36);
            this.btnPhongDay.TabIndex = 0;
            this.btnPhongDay.Text = "Phòng đầy";
            this.btnPhongDay.UseVisualStyleBackColor = true;
            this.btnPhongDay.Click += new System.EventHandler(this.btnPhongDay_Click);
            // 
            // btnPhongTrong
            // 
            this.btnPhongTrong.Location = new System.Drawing.Point(81, 3);
            this.btnPhongTrong.Name = "btnPhongTrong";
            this.btnPhongTrong.Size = new System.Drawing.Size(75, 36);
            this.btnPhongTrong.TabIndex = 0;
            this.btnPhongTrong.Text = "Phòng trống";
            this.btnPhongTrong.UseVisualStyleBackColor = true;
            this.btnPhongTrong.Click += new System.EventHandler(this.btnPhongTrong_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.Location = new System.Drawing.Point(0, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(75, 36);
            this.btnTatCa.TabIndex = 0;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83721F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16279F));
            this.tableLayoutPanel1.Controls.Add(this.chkThuong, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.maxMember, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkCapCuu, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkSuaChua, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbTenPhong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboTang, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(508, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 231);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chkThuong
            // 
            this.chkThuong.AutoSize = true;
            this.chkThuong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuong.Location = new System.Drawing.Point(131, 135);
            this.chkThuong.Name = "chkThuong";
            this.chkThuong.Size = new System.Drawing.Size(97, 26);
            this.chkThuong.TabIndex = 14;
            this.chkThuong.Text = "Thường";
            this.chkThuong.UseVisualStyleBackColor = true;
            this.chkThuong.CheckedChanged += new System.EventHandler(this.chkThuong_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới hạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại phòng:";
            // 
            // maxMember
            // 
            this.maxMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxMember.Location = new System.Drawing.Point(131, 91);
            this.maxMember.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxMember.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxMember.Name = "maxMember";
            this.maxMember.Size = new System.Drawing.Size(130, 31);
            this.maxMember.TabIndex = 5;
            this.maxMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxMember.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chkCapCuu
            // 
            this.chkCapCuu.AutoSize = true;
            this.chkCapCuu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapCuu.Location = new System.Drawing.Point(131, 167);
            this.chkCapCuu.Name = "chkCapCuu";
            this.chkCapCuu.Size = new System.Drawing.Size(102, 26);
            this.chkCapCuu.TabIndex = 14;
            this.chkCapCuu.Text = "Cấp cứu";
            this.chkCapCuu.UseVisualStyleBackColor = true;
            this.chkCapCuu.CheckedChanged += new System.EventHandler(this.chkCapCuu_CheckedChanged);
            // 
            // chkSuaChua
            // 
            this.chkSuaChua.AutoSize = true;
            this.chkSuaChua.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuaChua.Location = new System.Drawing.Point(131, 199);
            this.chkSuaChua.Name = "chkSuaChua";
            this.chkSuaChua.Size = new System.Drawing.Size(113, 26);
            this.chkSuaChua.TabIndex = 14;
            this.chkSuaChua.Text = "Sửa chữa";
            this.chkSuaChua.UseVisualStyleBackColor = true;
            this.chkSuaChua.CheckedChanged += new System.EventHandler(this.chkSuaChua_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phòng:";
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTenPhong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenPhong.Location = new System.Drawing.Point(131, 3);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(130, 29);
            this.txbTenPhong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tầng:";
            // 
            // cboTang
            // 
            this.cboTang.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Location = new System.Drawing.Point(131, 47);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(130, 30);
            this.cboTang.TabIndex = 15;
            this.cboTang.SelectedIndexChanged += new System.EventHandler(this.cboTang_SelectedIndexChanged);
            // 
            // fQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 450);
            this.Name = "fQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng bệnh";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPhongSapKhoi;
        private System.Windows.Forms.Button btnPhongCapCuu;
        private System.Windows.Forms.Button btnPhongDay;
        private System.Windows.Forms.Button btnPhongTrong;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.NumericUpDown maxMember;
        private System.Windows.Forms.CheckBox chkThuong;
        private System.Windows.Forms.CheckBox chkCapCuu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSuaChua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTang;
    }
}