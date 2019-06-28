namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmNguoiDung
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cboMaQuyenHan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaUS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboNhanVien = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cboNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(518, 121);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(65, 36);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(612, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(65, 37);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cboMaQuyenHan
            // 
            this.cboMaQuyenHan.FormattingEnabled = true;
            this.cboMaQuyenHan.Location = new System.Drawing.Point(449, 49);
            this.cboMaQuyenHan.Name = "cboMaQuyenHan";
            this.cboMaQuyenHan.Size = new System.Drawing.Size(172, 21);
            this.cboMaQuyenHan.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã quyền hạn";
            // 
            // txtMaUS
            // 
            this.txtMaUS.Enabled = false;
            this.txtMaUS.Location = new System.Drawing.Point(123, 22);
            this.txtMaUS.Name = "txtMaUS";
            this.txtMaUS.Size = new System.Drawing.Size(172, 20);
            this.txtMaUS.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Users";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(612, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 37);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(123, 77);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(172, 20);
            this.txtMatKhau.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(518, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 37);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(123, 48);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(172, 20);
            this.txtTaiKhoan.TabIndex = 10;
            this.txtTaiKhoan.Validated += new System.EventHandler(this.txtTaiKhoan_Valued);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(428, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 37);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tài khoản";
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.AllowUserToAddRows = false;
            this.dataGridViewNguoiDung.AllowUserToDeleteRows = false;
            this.dataGridViewNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.USER,
            this.PASS,
            this.NHANVIEN,
            this.Column2});
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(6, 37);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.ReadOnly = true;
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(741, 188);
            this.dataGridViewNguoiDung.TabIndex = 0;
            this.dataGridViewNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoiDung_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dataGridViewNguoiDung);
            this.groupBox3.Location = new System.Drawing.Point(12, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 244);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.cboNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.AutoSize = true;
            this.cboNhanVien.Controls.Add(this.load);
            this.cboNhanVien.Controls.Add(this.cboMaNV);
            this.cboNhanVien.Controls.Add(this.btnLuu);
            this.cboNhanVien.Controls.Add(this.btnHuy);
            this.cboNhanVien.Controls.Add(this.cboMaQuyenHan);
            this.cboNhanVien.Controls.Add(this.label2);
            this.cboNhanVien.Controls.Add(this.txtMaUS);
            this.cboNhanVien.Controls.Add(this.label1);
            this.cboNhanVien.Controls.Add(this.btnXoa);
            this.cboNhanVien.Controls.Add(this.txtMatKhau);
            this.cboNhanVien.Controls.Add(this.btnSua);
            this.cboNhanVien.Controls.Add(this.txtTaiKhoan);
            this.cboNhanVien.Controls.Add(this.btnThem);
            this.cboNhanVien.Controls.Add(this.label6);
            this.cboNhanVien.Controls.Add(this.label5);
            this.cboNhanVien.Controls.Add(this.label4);
            this.cboNhanVien.Location = new System.Drawing.Point(12, 12);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(765, 176);
            this.cboNhanVien.TabIndex = 7;
            this.cboNhanVien.TabStop = false;
            this.cboNhanVien.Text = "Thông Tin Tài Khoản";
            // 
            // cboMaNV
            // 
            this.cboMaNV.Location = new System.Drawing.Point(449, 23);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(172, 20);
            this.cboMaNV.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaUS";
            this.Column1.HeaderText = "Mã Users";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // USER
            // 
            this.USER.DataPropertyName = "TaiKhoan";
            this.USER.HeaderText = "Tài Khoản";
            this.USER.Name = "USER";
            this.USER.ReadOnly = true;
            // 
            // PASS
            // 
            this.PASS.DataPropertyName = "MatKhau";
            this.PASS.HeaderText = "Mật Khẩu";
            this.PASS.Name = "PASS";
            this.PASS.ReadOnly = true;
            // 
            // NHANVIEN
            // 
            this.NHANVIEN.DataPropertyName = "MaNV";
            this.NHANVIEN.HeaderText = "Mã nhân viên";
            this.NHANVIEN.Name = "NHANVIEN";
            this.NHANVIEN.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaQH";
            this.Column2.HeaderText = "Mã quyền hạn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(27, 121);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 36);
            this.load.TabIndex = 21;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // firmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "firmNguoiDung";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.firmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cboNhanVien.ResumeLayout(false);
            this.cboNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cboMaQuyenHan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaUS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox cboNhanVien;
        private System.Windows.Forms.TextBox cboMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button load;
    }
}