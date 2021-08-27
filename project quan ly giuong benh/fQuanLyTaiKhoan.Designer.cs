
namespace project_quan_ly_giuong_benh
{
    partial class fQuanLyTaiKhoan
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFindAccount = new System.Windows.Forms.Button();
            this.btnDelAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.btnFindAccount);
            this.panel4.Controls.Add(this.btnDelAccount);
            this.panel4.Controls.Add(this.btnEditAccount);
            this.panel4.Controls.Add(this.btnAddAccount);
            this.panel4.Location = new System.Drawing.Point(10, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 42);
            this.panel4.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(431, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnFindAccount
            // 
            this.btnFindAccount.Location = new System.Drawing.Point(656, 3);
            this.btnFindAccount.Name = "btnFindAccount";
            this.btnFindAccount.Size = new System.Drawing.Size(97, 36);
            this.btnFindAccount.TabIndex = 0;
            this.btnFindAccount.Text = "Tìm kiếm";
            this.btnFindAccount.UseVisualStyleBackColor = true;
            // 
            // btnDelAccount
            // 
            this.btnDelAccount.Location = new System.Drawing.Point(209, 3);
            this.btnDelAccount.Name = "btnDelAccount";
            this.btnDelAccount.Size = new System.Drawing.Size(97, 36);
            this.btnDelAccount.TabIndex = 0;
            this.btnDelAccount.Text = "Xoá tài khoản";
            this.btnDelAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(106, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(97, 36);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "Sửa thông tin";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(97, 36);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm tài khoản";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // dtgvUser
            // 
            this.dtgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(10, 59);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.Size = new System.Drawing.Size(759, 340);
            this.dtgvUser.TabIndex = 6;
            // 
            // fQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 411);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtgvUser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(795, 450);
            this.Name = "fQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFindAccount;
        private System.Windows.Forms.Button btnDelAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.DataGridView dtgvUser;
    }
}