
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyBenhNhan));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tpDangDieuTri = new System.Windows.Forms.TabPage();
            this.dtgvMember = new ADGV.AdvancedDataGridView();
            this.tpDaXuatVien = new System.Windows.Forms.TabPage();
            this.dtgvXuatVien = new ADGV.AdvancedDataGridView();
            this.tpDaChuyenTuyen = new System.Windows.Forms.TabPage();
            this.dtgvChuyenTuyen = new ADGV.AdvancedDataGridView();
            this.tpDanhSachBack = new System.Windows.Forms.TabPage();
            this.dtgvBack = new ADGV.AdvancedDataGridView();
            this.tpNhapBenhNhanTuFile = new System.Windows.Forms.TabPage();
            this.dtgvInput = new ADGV.AdvancedDataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txbFindMember = new System.Windows.Forms.TextBox();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelPerson = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPage = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.nUDPageRows = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabControl.SuspendLayout();
            this.tpDangDieuTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).BeginInit();
            this.tpDaXuatVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXuatVien)).BeginInit();
            this.tpDaChuyenTuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenTuyen)).BeginInit();
            this.tpDanhSachBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBack)).BeginInit();
            this.tpNhapBenhNhanTuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInput)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPageRows)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tpDangDieuTri);
            this.TabControl.Controls.Add(this.tpDaXuatVien);
            this.TabControl.Controls.Add(this.tpDaChuyenTuyen);
            this.TabControl.Controls.Add(this.tpDanhSachBack);
            this.TabControl.Controls.Add(this.tpNhapBenhNhanTuFile);
            this.TabControl.Location = new System.Drawing.Point(1, 45);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1517, 591);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpDangDieuTri
            // 
            this.tpDangDieuTri.Controls.Add(this.dtgvMember);
            this.tpDangDieuTri.Location = new System.Drawing.Point(4, 22);
            this.tpDangDieuTri.Name = "tpDangDieuTri";
            this.tpDangDieuTri.Padding = new System.Windows.Forms.Padding(3);
            this.tpDangDieuTri.Size = new System.Drawing.Size(1509, 565);
            this.tpDangDieuTri.TabIndex = 0;
            this.tpDangDieuTri.Text = "Đang điều trị";
            this.tpDangDieuTri.UseVisualStyleBackColor = true;
            // 
            // dtgvMember
            // 
            this.dtgvMember.AllowUserToAddRows = false;
            this.dtgvMember.AllowUserToDeleteRows = false;
            this.dtgvMember.AutoGenerateContextFilters = true;
            this.dtgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMember.DateWithTime = false;
            this.dtgvMember.Location = new System.Drawing.Point(0, 0);
            this.dtgvMember.Name = "dtgvMember";
            this.dtgvMember.ReadOnly = true;
            this.dtgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvMember.Size = new System.Drawing.Size(1507, 565);
            this.dtgvMember.TabIndex = 23;
            this.dtgvMember.TimeFilter = false;
            // 
            // tpDaXuatVien
            // 
            this.tpDaXuatVien.Controls.Add(this.dtgvXuatVien);
            this.tpDaXuatVien.Location = new System.Drawing.Point(4, 22);
            this.tpDaXuatVien.Name = "tpDaXuatVien";
            this.tpDaXuatVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpDaXuatVien.Size = new System.Drawing.Size(1509, 565);
            this.tpDaXuatVien.TabIndex = 1;
            this.tpDaXuatVien.Text = "Đã xuất viện";
            this.tpDaXuatVien.UseVisualStyleBackColor = true;
            // 
            // dtgvXuatVien
            // 
            this.dtgvXuatVien.AllowUserToAddRows = false;
            this.dtgvXuatVien.AllowUserToDeleteRows = false;
            this.dtgvXuatVien.AutoGenerateContextFilters = true;
            this.dtgvXuatVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXuatVien.DateWithTime = false;
            this.dtgvXuatVien.Location = new System.Drawing.Point(0, 0);
            this.dtgvXuatVien.Name = "dtgvXuatVien";
            this.dtgvXuatVien.ReadOnly = true;
            this.dtgvXuatVien.Size = new System.Drawing.Size(1516, 565);
            this.dtgvXuatVien.TabIndex = 23;
            this.dtgvXuatVien.TimeFilter = false;
            this.dtgvXuatVien.SortStringChanged += new System.EventHandler(this.dtgvXuatVien_SortStringChanged);
            this.dtgvXuatVien.FilterStringChanged += new System.EventHandler(this.dtgvXuatVien_FilterStringChanged);
            // 
            // tpDaChuyenTuyen
            // 
            this.tpDaChuyenTuyen.Controls.Add(this.dtgvChuyenTuyen);
            this.tpDaChuyenTuyen.Location = new System.Drawing.Point(4, 22);
            this.tpDaChuyenTuyen.Name = "tpDaChuyenTuyen";
            this.tpDaChuyenTuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tpDaChuyenTuyen.Size = new System.Drawing.Size(1509, 565);
            this.tpDaChuyenTuyen.TabIndex = 2;
            this.tpDaChuyenTuyen.Text = "Đã chuyển tuyến";
            this.tpDaChuyenTuyen.UseVisualStyleBackColor = true;
            // 
            // dtgvChuyenTuyen
            // 
            this.dtgvChuyenTuyen.AllowUserToAddRows = false;
            this.dtgvChuyenTuyen.AllowUserToDeleteRows = false;
            this.dtgvChuyenTuyen.AutoGenerateContextFilters = true;
            this.dtgvChuyenTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenTuyen.DateWithTime = false;
            this.dtgvChuyenTuyen.Location = new System.Drawing.Point(0, 0);
            this.dtgvChuyenTuyen.Name = "dtgvChuyenTuyen";
            this.dtgvChuyenTuyen.ReadOnly = true;
            this.dtgvChuyenTuyen.Size = new System.Drawing.Size(1507, 565);
            this.dtgvChuyenTuyen.TabIndex = 23;
            this.dtgvChuyenTuyen.TimeFilter = false;
            this.dtgvChuyenTuyen.SortStringChanged += new System.EventHandler(this.dtgvChuyenTuyen_SortStringChanged);
            this.dtgvChuyenTuyen.FilterStringChanged += new System.EventHandler(this.dtgvChuyenTuyen_FilterStringChanged);
            // 
            // tpDanhSachBack
            // 
            this.tpDanhSachBack.Controls.Add(this.dtgvBack);
            this.tpDanhSachBack.Location = new System.Drawing.Point(4, 22);
            this.tpDanhSachBack.Name = "tpDanhSachBack";
            this.tpDanhSachBack.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhSachBack.Size = new System.Drawing.Size(1509, 565);
            this.tpDanhSachBack.TabIndex = 3;
            this.tpDanhSachBack.Text = "Bệnh nhân quay lại viện";
            this.tpDanhSachBack.UseVisualStyleBackColor = true;
            // 
            // dtgvBack
            // 
            this.dtgvBack.AllowUserToAddRows = false;
            this.dtgvBack.AllowUserToDeleteRows = false;
            this.dtgvBack.AutoGenerateContextFilters = true;
            this.dtgvBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBack.DateWithTime = false;
            this.dtgvBack.Location = new System.Drawing.Point(0, 0);
            this.dtgvBack.Name = "dtgvBack";
            this.dtgvBack.ReadOnly = true;
            this.dtgvBack.Size = new System.Drawing.Size(1507, 565);
            this.dtgvBack.TabIndex = 24;
            this.dtgvBack.TimeFilter = false;
            // 
            // tpNhapBenhNhanTuFile
            // 
            this.tpNhapBenhNhanTuFile.Controls.Add(this.dtgvInput);
            this.tpNhapBenhNhanTuFile.Location = new System.Drawing.Point(4, 22);
            this.tpNhapBenhNhanTuFile.Name = "tpNhapBenhNhanTuFile";
            this.tpNhapBenhNhanTuFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhapBenhNhanTuFile.Size = new System.Drawing.Size(1509, 565);
            this.tpNhapBenhNhanTuFile.TabIndex = 4;
            this.tpNhapBenhNhanTuFile.Text = "Bệnh nhân nhập viện";
            this.tpNhapBenhNhanTuFile.UseVisualStyleBackColor = true;
            // 
            // dtgvInput
            // 
            this.dtgvInput.AllowUserToAddRows = false;
            this.dtgvInput.AllowUserToDeleteRows = false;
            this.dtgvInput.AutoGenerateContextFilters = true;
            this.dtgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInput.DateWithTime = false;
            this.dtgvInput.Location = new System.Drawing.Point(0, 0);
            this.dtgvInput.Name = "dtgvInput";
            this.dtgvInput.ReadOnly = true;
            this.dtgvInput.Size = new System.Drawing.Size(1507, 565);
            this.dtgvInput.TabIndex = 24;
            this.dtgvInput.TimeFilter = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2007|*.xlsx|Excel 2003|*.xls";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.cboPhong);
            this.panel3.Controls.Add(this.cboTang);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.dtpStop);
            this.panel3.Controls.Add(this.dtpStart);
            this.panel3.Controls.Add(this.txbFindMember);
            this.panel3.Controls.Add(this.btnFindPerson);
            this.panel3.Controls.Add(this.btnImport);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnDelPerson);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnEditPerson);
            this.panel3.Controls.Add(this.btnThongKe);
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1511, 42);
            this.panel3.TabIndex = 22;
            // 
            // cboPhong
            // 
            this.cboPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(840, 21);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(94, 21);
            this.cboPhong.TabIndex = 5;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // cboTang
            // 
            this.cboTang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Location = new System.Drawing.Point(840, 0);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(94, 21);
            this.cboTang.TabIndex = 4;
            this.cboTang.SelectedIndexChanged += new System.EventHandler(this.cboTang_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(938, 2);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm BN";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpStop
            // 
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(238, 9);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(105, 20);
            this.dtpStop.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(3, 9);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(105, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // txbFindMember
            // 
            this.txbFindMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFindMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFindMember.Location = new System.Drawing.Point(1142, 6);
            this.txbFindMember.Name = "txbFindMember";
            this.txbFindMember.Size = new System.Drawing.Size(263, 26);
            this.txbFindMember.TabIndex = 1;
            this.txbFindMember.TextChanged += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindPerson.Location = new System.Drawing.Point(1414, 3);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(97, 36);
            this.btnFindPerson.TabIndex = 0;
            this.btnFindPerson.Text = "Tìm kiếm";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(999, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(56, 36);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Nhập Excel";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1060, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(56, 36);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelPerson
            // 
            this.btnDelPerson.Location = new System.Drawing.Point(686, 3);
            this.btnDelPerson.Name = "btnDelPerson";
            this.btnDelPerson.Size = new System.Drawing.Size(97, 36);
            this.btnDelPerson.TabIndex = 0;
            this.btnDelPerson.Text = "Xoá bệnh nhân";
            this.btnDelPerson.UseVisualStyleBackColor = true;
            this.btnDelPerson.Click += new System.EventHandler(this.btnDelPerson_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(583, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại viện";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(480, 3);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(97, 36);
            this.btnEditPerson.TabIndex = 0;
            this.btnEditPerson.Text = "Sửa thông tin";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(125, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(97, 36);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(1, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số dòng mỗi trang: ";
            // 
            // txbPage
            // 
            this.txbPage.BackColor = System.Drawing.Color.White;
            this.txbPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPage.Location = new System.Drawing.Point(825, 644);
            this.txbPage.Name = "txbPage";
            this.txbPage.Size = new System.Drawing.Size(39, 19);
            this.txbPage.TabIndex = 24;
            this.txbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPage.TextChanged += new System.EventHandler(this.txbPage_TextChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(758, 642);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(57, 23);
            this.btnPrevious.TabIndex = 28;
            this.btnPrevious.Text = "Trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(973, 642);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(57, 23);
            this.btnLast.TabIndex = 27;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(695, 642);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(57, 23);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(910, 642);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 23);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.Location = new System.Drawing.Point(866, 644);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(17, 20);
            this.lbTotalPage.TabIndex = 29;
            this.lbTotalPage.Text = "/ ";
            // 
            // nUDPageRows
            // 
            this.nUDPageRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nUDPageRows.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUDPageRows.Location = new System.Drawing.Point(149, 642);
            this.nUDPageRows.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUDPageRows.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUDPageRows.Name = "nUDPageRows";
            this.nUDPageRows.ReadOnly = true;
            this.nUDPageRows.Size = new System.Drawing.Size(52, 23);
            this.nUDPageRows.TabIndex = 31;
            this.nUDPageRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDPageRows.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUDPageRows.ValueChanged += new System.EventHandler(this.nUDPageRows_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Document| *.xls;*.xlsx";
            // 
            // fQuanLyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 673);
            this.Controls.Add(this.nUDPageRows);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txbPage);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1534, 712);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1534, 712);
            this.Name = "fQuanLyBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bệnh nhân";
            this.TabControl.ResumeLayout(false);
            this.tpDangDieuTri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).EndInit();
            this.tpDaXuatVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXuatVien)).EndInit();
            this.tpDaChuyenTuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenTuyen)).EndInit();
            this.tpDanhSachBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBack)).EndInit();
            this.tpNhapBenhNhanTuFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInput)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPageRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tpDangDieuTri;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tpDaXuatVien;
        private ADGV.AdvancedDataGridView dtgvMember;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txbFindMember;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnDelPerson;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnThongKe;
        private ADGV.AdvancedDataGridView dtgvXuatVien;
        private System.Windows.Forms.TabPage tpDaChuyenTuyen;
        private ADGV.AdvancedDataGridView dtgvChuyenTuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPage;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.NumericUpDown nUDPageRows;
        private System.Windows.Forms.TabPage tpDanhSachBack;
        private ADGV.AdvancedDataGridView dtgvBack;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TabPage tpNhapBenhNhanTuFile;
        private ADGV.AdvancedDataGridView dtgvInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboTang;
        private System.Windows.Forms.Button btnAdd;
    }
}