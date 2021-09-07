
namespace project_quan_ly_giuong_benh
{
    partial class fXuatVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fXuatVien));
            this.dtpNgayXuatVien = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayXetNghiem = new System.Windows.Forms.DateTimePicker();
            this.txbSoLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMaBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbCTValue = new System.Windows.Forms.TextBox();
            this.cboKq = new System.Windows.Forms.ComboBox();
            this.cboKTXN = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lbCanhBao = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayXuatVien
            // 
            this.dtpNgayXuatVien.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuatVien.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayXuatVien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuatVien.Location = new System.Drawing.Point(198, 109);
            this.dtpNgayXuatVien.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpNgayXuatVien.Name = "dtpNgayXuatVien";
            this.dtpNgayXuatVien.Size = new System.Drawing.Size(109, 20);
            this.dtpNgayXuatVien.TabIndex = 13;
            // 
            // dtpNgayXetNghiem
            // 
            this.dtpNgayXetNghiem.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXetNghiem.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayXetNghiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXetNghiem.Location = new System.Drawing.Point(198, 141);
            this.dtpNgayXetNghiem.Name = "dtpNgayXetNghiem";
            this.dtpNgayXetNghiem.Size = new System.Drawing.Size(109, 20);
            this.dtpNgayXetNghiem.TabIndex = 14;
            // 
            // txbSoLT
            // 
            this.txbSoLT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSoLT.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoLT.Location = new System.Drawing.Point(198, 77);
            this.txbSoLT.Name = "txbSoLT";
            this.txbSoLT.Size = new System.Drawing.Size(249, 29);
            this.txbSoLT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lưu trữ:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95454F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbHoTen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbSoLT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbMaBN, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayXuatVien, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayXetNghiem, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbCTValue, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cboKq, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cboKTXN, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 282);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bệnh nhân:";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbHoTen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.Location = new System.Drawing.Point(198, 13);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.ReadOnly = true;
            this.txbHoTen.Size = new System.Drawing.Size(249, 29);
            this.txbHoTen.TabIndex = 0;
            // 
            // txbMaBN
            // 
            this.txbMaBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMaBN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaBN.Location = new System.Drawing.Point(198, 45);
            this.txbMaBN.Name = "txbMaBN";
            this.txbMaBN.Size = new System.Drawing.Size(249, 29);
            this.txbMaBN.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày xuất viện:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày xét nghiệm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kỹ thuật xét nghiệm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kết quả:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "CT Value >= 30:";
            // 
            // txbCTValue
            // 
            this.txbCTValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCTValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCTValue.Location = new System.Drawing.Point(198, 237);
            this.txbCTValue.Name = "txbCTValue";
            this.txbCTValue.Size = new System.Drawing.Size(249, 29);
            this.txbCTValue.TabIndex = 20;
            // 
            // cboKq
            // 
            this.cboKq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKq.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboKq.FormattingEnabled = true;
            this.cboKq.Items.AddRange(new object[] {
            "Âm tính",
            "Dương tính"});
            this.cboKq.Location = new System.Drawing.Point(198, 205);
            this.cboKq.Name = "cboKq";
            this.cboKq.Size = new System.Drawing.Size(249, 30);
            this.cboKq.TabIndex = 19;
            // 
            // cboKTXN
            // 
            this.cboKTXN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKTXN.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboKTXN.FormattingEnabled = true;
            this.cboKTXN.Items.AddRange(new object[] {
            "PCR",
            "Test nhanh"});
            this.cboKTXN.Location = new System.Drawing.Point(198, 173);
            this.cboKTXN.Name = "cboKTXN";
            this.cboKTXN.Size = new System.Drawing.Size(249, 30);
            this.cboKTXN.TabIndex = 18;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(349, 296);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(123, 38);
            this.btnXacNhan.TabIndex = 22;
            this.btnXacNhan.Text = "&Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lbCanhBao
            // 
            this.lbCanhBao.AutoSize = true;
            this.lbCanhBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanhBao.ForeColor = System.Drawing.Color.Red;
            this.lbCanhBao.Location = new System.Drawing.Point(12, 301);
            this.lbCanhBao.Name = "lbCanhBao";
            this.lbCanhBao.Size = new System.Drawing.Size(0, 18);
            this.lbCanhBao.TabIndex = 23;
            // 
            // fXuatVien
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 346);
            this.Controls.Add(this.lbCanhBao);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnXacNhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 385);
            this.MinimumSize = new System.Drawing.Size(500, 385);
            this.Name = "fXuatVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin xuất viện";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgayXuatVien;
        private System.Windows.Forms.DateTimePicker dtpNgayXetNghiem;
        private System.Windows.Forms.TextBox txbSoLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbCTValue;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txbMaBN;
        private System.Windows.Forms.ComboBox cboKq;
        private System.Windows.Forms.ComboBox cboKTXN;
        private System.Windows.Forms.Label lbCanhBao;
    }
}