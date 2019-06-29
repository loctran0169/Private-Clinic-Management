namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmBenhNhan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_benhnhan = new System.Windows.Forms.DataGridView();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_lưu = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tim = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_mabn = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_benhnhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_benhnhan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 284);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Bệnh Nhân";
            // 
            // dtgv_benhnhan
            // 
            this.dtgv_benhnhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_benhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_benhnhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_benhnhan.Location = new System.Drawing.Point(3, 16);
            this.dtgv_benhnhan.Name = "dtgv_benhnhan";
            this.dtgv_benhnhan.Size = new System.Drawing.Size(794, 265);
            this.dtgv_benhnhan.TabIndex = 0;
            this.dtgv_benhnhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_benhnhan_CellClick);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(649, 129);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(78, 31);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(565, 129);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(78, 31);
            this.bt_sua.TabIndex = 8;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(481, 129);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(78, 31);
            this.bt_them.TabIndex = 7;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_huy);
            this.groupBox1.Controls.Add(this.bt_lưu);
            this.groupBox1.Controls.Add(this.tb_search);
            this.groupBox1.Controls.Add(this.tim);
            this.groupBox1.Controls.Add(this.Load);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.tb_hoten);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.tb_mabn);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bệnh Nhân";
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(649, 129);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(78, 31);
            this.bt_huy.TabIndex = 17;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_lưu
            // 
            this.bt_lưu.Location = new System.Drawing.Point(565, 129);
            this.bt_lưu.Name = "bt_lưu";
            this.bt_lưu.Size = new System.Drawing.Size(78, 31);
            this.bt_lưu.TabIndex = 16;
            this.bt_lưu.Text = "Lưu";
            this.bt_lưu.UseVisualStyleBackColor = true;
            this.bt_lưu.Click += new System.EventHandler(this.bt_lưu_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(159, 129);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(152, 20);
            this.tb_search.TabIndex = 15;
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(331, 123);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(75, 31);
            this.tim.TabIndex = 14;
            this.tim.Text = "Tìm kiếm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 129);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(92, 31);
            this.Load.TabIndex = 13;
            this.Load.Text = "Load Dữ Liệu";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(123, 75);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(172, 20);
            this.dtp_ngaysinh.TabIndex = 12;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(123, 49);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(172, 20);
            this.tb_hoten.TabIndex = 11;
            this.tb_hoten.Validated += new System.EventHandler(this.tb_hoten_Validated);
            // 
            // tb_mabn
            // 
            this.tb_mabn.Enabled = false;
            this.tb_mabn.Location = new System.Drawing.Point(123, 20);
            this.tb_mabn.Name = "tb_mabn";
            this.tb_mabn.Size = new System.Drawing.Size(172, 20);
            this.tb_mabn.TabIndex = 10;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(531, 78);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(196, 20);
            this.tb_diachi.TabIndex = 9;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(531, 49);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(196, 20);
            this.tb_sdt.TabIndex = 8;
            this.tb_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sdt_KeyPress);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(646, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(531, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ Và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Bệnh Nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Điên Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới Tính";
            // 
            // firmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "firmBenhNhan";
            this.Text = "Bệnh Nhân";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_benhnhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgv_benhnhan;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mabn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_lưu;
    }
}