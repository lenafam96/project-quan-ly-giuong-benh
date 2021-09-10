
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyPhong));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnPhongDangSua = new System.Windows.Forms.Button();
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
            this.chkBusy = new System.Windows.Forms.CheckBox();
            this.chkKhoa = new System.Windows.Forms.CheckBox();
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
            this.dtgvRoom.TabIndex = 15;
            this.dtgvRoom.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvRoom_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelRoom);
            this.panel1.Controls.Add(this.btnEditRoom);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(508, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 42);
            this.panel1.TabIndex = 2;
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.Location = new System.Drawing.Point(182, 3);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(82, 36);
            this.btnDelRoom.TabIndex = 14;
            this.btnDelRoom.Text = "Xoá phòng";
            this.btnDelRoom.UseVisualStyleBackColor = true;
            this.btnDelRoom.Click += new System.EventHandler(this.btnDelRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(91, 3);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(82, 36);
            this.btnEditRoom.TabIndex = 13;
            this.btnEditRoom.Text = "Sửa phòng";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(0, 3);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(82, 36);
            this.btnAddRoom.TabIndex = 12;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnKhoa);
            this.panel3.Controls.Add(this.btnBan);
            this.panel3.Controls.Add(this.btnPhongDangSua);
            this.panel3.Controls.Add(this.btnPhongCapCuu);
            this.panel3.Controls.Add(this.btnPhongDay);
            this.panel3.Controls.Add(this.btnPhongTrong);
            this.panel3.Controls.Add(this.btnTatCa);
            this.panel3.Location = new System.Drawing.Point(14, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 42);
            this.panel3.TabIndex = 0;
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(413, 3);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(67, 36);
            this.btnKhoa.TabIndex = 2;
            this.btnKhoa.Text = "Khoá";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(344, 3);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(67, 36);
            this.btnBan.TabIndex = 6;
            this.btnBan.Text = "Bận";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBusy_Click);
            // 
            // btnPhongDangSua
            // 
            this.btnPhongDangSua.Location = new System.Drawing.Point(275, 3);
            this.btnPhongDangSua.Name = "btnPhongDangSua";
            this.btnPhongDangSua.Size = new System.Drawing.Size(67, 36);
            this.btnPhongDangSua.TabIndex = 5;
            this.btnPhongDangSua.Text = "Đang sửa";
            this.btnPhongDangSua.UseVisualStyleBackColor = true;
            this.btnPhongDangSua.Click += new System.EventHandler(this.btnDangSua_Click);
            // 
            // btnPhongCapCuu
            // 
            this.btnPhongCapCuu.Location = new System.Drawing.Point(207, 3);
            this.btnPhongCapCuu.Name = "btnPhongCapCuu";
            this.btnPhongCapCuu.Size = new System.Drawing.Size(67, 36);
            this.btnPhongCapCuu.TabIndex = 4;
            this.btnPhongCapCuu.Text = "Cấp cứu";
            this.btnPhongCapCuu.UseVisualStyleBackColor = true;
            this.btnPhongCapCuu.Click += new System.EventHandler(this.btnPhongCapCuu_Click);
            // 
            // btnPhongDay
            // 
            this.btnPhongDay.Location = new System.Drawing.Point(138, 3);
            this.btnPhongDay.Name = "btnPhongDay";
            this.btnPhongDay.Size = new System.Drawing.Size(67, 36);
            this.btnPhongDay.TabIndex = 3;
            this.btnPhongDay.Text = "Đầy";
            this.btnPhongDay.UseVisualStyleBackColor = true;
            this.btnPhongDay.Click += new System.EventHandler(this.btnPhongDay_Click);
            // 
            // btnPhongTrong
            // 
            this.btnPhongTrong.Location = new System.Drawing.Point(69, 3);
            this.btnPhongTrong.Name = "btnPhongTrong";
            this.btnPhongTrong.Size = new System.Drawing.Size(67, 36);
            this.btnPhongTrong.TabIndex = 1;
            this.btnPhongTrong.Text = "Trống";
            this.btnPhongTrong.UseVisualStyleBackColor = true;
            this.btnPhongTrong.Click += new System.EventHandler(this.btnPhongTrong_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.Location = new System.Drawing.Point(0, 3);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(67, 36);
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
            this.tableLayoutPanel1.Controls.Add(this.chkBusy, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkKhoa, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(508, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.75421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.75421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.75421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74747F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 263);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chkThuong
            // 
            this.chkThuong.AutoSize = true;
            this.chkThuong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuong.Location = new System.Drawing.Point(131, 111);
            this.chkThuong.Name = "chkThuong";
            this.chkThuong.Size = new System.Drawing.Size(97, 24);
            this.chkThuong.TabIndex = 10;
            this.chkThuong.Text = "Thường";
            this.chkThuong.UseVisualStyleBackColor = true;
            this.chkThuong.CheckedChanged += new System.EventHandler(this.chkThuong_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới hạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại phòng:";
            // 
            // maxMember
            // 
            this.maxMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxMember.Location = new System.Drawing.Point(131, 75);
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
            this.maxMember.ReadOnly = true;
            this.maxMember.Size = new System.Drawing.Size(130, 31);
            this.maxMember.TabIndex = 9;
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
            this.chkCapCuu.Location = new System.Drawing.Point(131, 141);
            this.chkCapCuu.Name = "chkCapCuu";
            this.chkCapCuu.Size = new System.Drawing.Size(102, 24);
            this.chkCapCuu.TabIndex = 11;
            this.chkCapCuu.Text = "Cấp cứu";
            this.chkCapCuu.UseVisualStyleBackColor = true;
            this.chkCapCuu.CheckedChanged += new System.EventHandler(this.chkCapCuu_CheckedChanged);
            // 
            // chkSuaChua
            // 
            this.chkSuaChua.AutoSize = true;
            this.chkSuaChua.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuaChua.Location = new System.Drawing.Point(131, 171);
            this.chkSuaChua.Name = "chkSuaChua";
            this.chkSuaChua.Size = new System.Drawing.Size(113, 24);
            this.chkSuaChua.TabIndex = 12;
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
            this.txbTenPhong.TabIndex = 7;
            this.txbTenPhong.TextChanged += new System.EventHandler(this.txbTenPhong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tầng:";
            // 
            // cboTang
            // 
            this.cboTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTang.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Location = new System.Drawing.Point(131, 39);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(130, 30);
            this.cboTang.TabIndex = 7;
            this.cboTang.SelectedIndexChanged += new System.EventHandler(this.cboTang_SelectedIndexChanged);
            // 
            // chkBusy
            // 
            this.chkBusy.AutoSize = true;
            this.chkBusy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBusy.Location = new System.Drawing.Point(131, 201);
            this.chkBusy.Name = "chkBusy";
            this.chkBusy.Size = new System.Drawing.Size(62, 24);
            this.chkBusy.TabIndex = 13;
            this.chkBusy.Text = "Bận";
            this.chkBusy.UseVisualStyleBackColor = true;
            this.chkBusy.CheckedChanged += new System.EventHandler(this.chkBusy_CheckedChanged);
            // 
            // chkKhoa
            // 
            this.chkKhoa.AutoSize = true;
            this.chkKhoa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKhoa.Location = new System.Drawing.Point(131, 231);
            this.chkKhoa.Name = "chkKhoa";
            this.chkKhoa.Size = new System.Drawing.Size(73, 26);
            this.chkKhoa.TabIndex = 13;
            this.chkKhoa.Text = "Khoá";
            this.chkKhoa.UseVisualStyleBackColor = true;
            this.chkKhoa.CheckedChanged += new System.EventHandler(this.chkKhoa_CheckedChanged);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnPhongCapCuu;
        private System.Windows.Forms.Button btnPhongDay;
        private System.Windows.Forms.Button btnPhongTrong;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPhongDangSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkThuong;
        private System.Windows.Forms.NumericUpDown maxMember;
        private System.Windows.Forms.CheckBox chkCapCuu;
        private System.Windows.Forms.CheckBox chkSuaChua;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.ComboBox cboTang;
        private System.Windows.Forms.CheckBox chkBusy;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.CheckBox chkKhoa;
    }
}