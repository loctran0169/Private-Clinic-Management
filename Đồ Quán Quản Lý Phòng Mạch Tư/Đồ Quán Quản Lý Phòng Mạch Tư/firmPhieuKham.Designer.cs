namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmPhieuKham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.tB_HoTen = new System.Windows.Forms.TextBox();
            this.bt_Load = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_LoaiBenh = new System.Windows.Forms.ComboBox();
            this.comboBox_TenBS = new System.Windows.Forms.ComboBox();
            this.tB_MaPK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tB_them = new System.Windows.Forms.Button();
            this.tB_mabn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_mabn);
            this.groupBox1.Controls.Add(this.tB_them);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_Huy);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.tB_HoTen);
            this.groupBox1.Controls.Add(this.bt_Load);
            this.groupBox1.Controls.Add(this.bt_luu);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox_LoaiBenh);
            this.groupBox1.Controls.Add(this.comboBox_TenBS);
            this.groupBox1.Controls.Add(this.tB_MaPK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Khám";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(611, 115);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 29);
            this.bt_xoa.TabIndex = 19;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Visible = false;
            this.bt_xoa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(611, 115);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(75, 29);
            this.bt_Huy.TabIndex = 18;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Visible = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(697, 115);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 29);
            this.bt_sua.TabIndex = 17;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Visible = false;
            this.bt_sua.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_HoTen
            // 
            this.tB_HoTen.Location = new System.Drawing.Point(148, 50);
            this.tB_HoTen.Name = "tB_HoTen";
            this.tB_HoTen.ReadOnly = true;
            this.tB_HoTen.Size = new System.Drawing.Size(240, 20);
            this.tB_HoTen.TabIndex = 16;
            // 
            // bt_Load
            // 
            this.bt_Load.Location = new System.Drawing.Point(6, 127);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(75, 29);
            this.bt_Load.TabIndex = 15;
            this.bt_Load.Text = "Load dữ liệu";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(697, 115);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 29);
            this.bt_luu.TabIndex = 13;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Visible = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // comboBox_LoaiBenh
            // 
            this.comboBox_LoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LoaiBenh.Enabled = false;
            this.comboBox_LoaiBenh.FormattingEnabled = true;
            this.comboBox_LoaiBenh.Location = new System.Drawing.Point(530, 77);
            this.comboBox_LoaiBenh.Name = "comboBox_LoaiBenh";
            this.comboBox_LoaiBenh.Size = new System.Drawing.Size(242, 21);
            this.comboBox_LoaiBenh.TabIndex = 9;
            // 
            // comboBox_TenBS
            // 
            this.comboBox_TenBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TenBS.Enabled = false;
            this.comboBox_TenBS.FormattingEnabled = true;
            this.comboBox_TenBS.Location = new System.Drawing.Point(148, 103);
            this.comboBox_TenBS.Name = "comboBox_TenBS";
            this.comboBox_TenBS.Size = new System.Drawing.Size(240, 21);
            this.comboBox_TenBS.TabIndex = 8;
            // 
            // tB_MaPK
            // 
            this.tB_MaPK.Location = new System.Drawing.Point(148, 22);
            this.tB_MaPK.Name = "tB_MaPK";
            this.tB_MaPK.ReadOnly = true;
            this.tB_MaPK.Size = new System.Drawing.Size(240, 20);
            this.tB_MaPK.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại Bệnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Phiếu Khám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bác Sĩ Khám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Và Tên Bệnh Nhân";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 288);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tB_them
            // 
            this.tB_them.Location = new System.Drawing.Point(530, 115);
            this.tB_them.Name = "tB_them";
            this.tB_them.Size = new System.Drawing.Size(75, 29);
            this.tB_them.TabIndex = 20;
            this.tB_them.Text = "Thêm";
            this.tB_them.UseVisualStyleBackColor = true;
            this.tB_them.Visible = false;
            this.tB_them.Click += new System.EventHandler(this.tB_them_Click);
            // 
            // tB_mabn
            // 
            this.tB_mabn.Location = new System.Drawing.Point(148, 77);
            this.tB_mabn.Name = "tB_mabn";
            this.tB_mabn.ReadOnly = true;
            this.tB_mabn.Size = new System.Drawing.Size(86, 20);
            this.tB_mabn.TabIndex = 21;
            // 
            // firmPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "firmPhieuKham";
            this.Text = "Phiếu Khám";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox tB_HoTen;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_LoaiBenh;
        private System.Windows.Forms.ComboBox comboBox_TenBS;
        private System.Windows.Forms.TextBox tB_MaPK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button tB_them;
        private System.Windows.Forms.TextBox tB_mabn;
    }
}