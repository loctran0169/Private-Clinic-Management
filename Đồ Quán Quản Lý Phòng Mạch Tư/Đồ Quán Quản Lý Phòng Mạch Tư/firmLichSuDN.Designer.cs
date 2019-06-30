namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmLichSuDN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewLS = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaLSDN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLS)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewLS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 343);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewLS
            // 
            this.dataGridViewLS.AllowUserToAddRows = false;
            this.dataGridViewLS.AllowUserToDeleteRows = false;
            this.dataGridViewLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.Column1,
            this.TaiKhoan,
            this.ThoiGian});
            this.dataGridViewLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLS.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLS.Name = "dataGridViewLS";
            this.dataGridViewLS.ReadOnly = true;
            this.dataGridViewLS.Size = new System.Drawing.Size(508, 343);
            this.dataGridViewLS.TabIndex = 0;
            this.dataGridViewLS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLS_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoaLSDN);
            this.panel2.Controls.Add(this.txtChucVu);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtGioiTinh);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.dtmNgaySinh);
            this.panel2.Controls.Add(this.txtHoVaTen);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(508, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 343);
            this.panel2.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(100, 190);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(138, 20);
            this.txtSDT.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(100, 164);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(138, 20);
            this.txtDiaChi.TabIndex = 24;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinh.Enabled = false;
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinh.Location = new System.Drawing.Point(100, 112);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(138, 20);
            this.dtmNgaySinh.TabIndex = 23;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Enabled = false;
            this.txtHoVaTen.Location = new System.Drawing.Point(100, 86);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(138, 20);
            this.txtHoVaTen.TabIndex = 22;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(100, 59);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(138, 20);
            this.txtMaNhanVien.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ Và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thông Tin Tài Khoản";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(100, 138);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(138, 20);
            this.txtGioiTinh.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Giới tính";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Location = new System.Drawing.Point(100, 216);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(138, 20);
            this.txtChucVu.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Chức vụ";
            // 
            // btnXoaLSDN
            // 
            this.btnXoaLSDN.Location = new System.Drawing.Point(22, 269);
            this.btnXoaLSDN.Name = "btnXoaLSDN";
            this.btnXoaLSDN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLSDN.TabIndex = 1;
            this.btnXoaLSDN.Text = "Xóa lịch sử";
            this.btnXoaLSDN.UseVisualStyleBackColor = true;
            this.btnXoaLSDN.Click += new System.EventHandler(this.btnXoaLSDN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(128, 269);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // IP
            // 
            this.IP.DataPropertyName = "MaUS";
            this.IP.HeaderText = "Mã Users";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài Khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGianDN";
            this.ThoiGian.HeaderText = "Thời Điểm Đăng Nhập";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // frmLichSuDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(779, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLichSuDN";
            this.Text = "Lịch Sử Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLichSuDN_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewLS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaLSDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
    }
}