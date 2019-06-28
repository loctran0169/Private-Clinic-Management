namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmThuoc
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
            this.hsd = new System.Windows.Forms.DateTimePicker();
            this.nsx = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_huy = new System.Windows.Forms.Button();
            this.tb_luu = new System.Windows.Forms.Button();
            this.cbb_donvi = new System.Windows.Forms.ComboBox();
            this.tb_them = new System.Windows.Forms.Button();
            this.tb_sua = new System.Windows.Forms.Button();
            this.tb_xoa = new System.Windows.Forms.Button();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_tenthuoc = new System.Windows.Forms.TextBox();
            this.tb_mathuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.load = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.load);
            this.groupBox1.Controls.Add(this.hsd);
            this.groupBox1.Controls.Add(this.nsx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_huy);
            this.groupBox1.Controls.Add(this.tb_luu);
            this.groupBox1.Controls.Add(this.cbb_donvi);
            this.groupBox1.Controls.Add(this.tb_them);
            this.groupBox1.Controls.Add(this.tb_sua);
            this.groupBox1.Controls.Add(this.tb_xoa);
            this.groupBox1.Controls.Add(this.tb_dongia);
            this.groupBox1.Controls.Add(this.tb_tenthuoc);
            this.groupBox1.Controls.Add(this.tb_mathuoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thuốc";
            // 
            // hsd
            // 
            this.hsd.Cursor = System.Windows.Forms.Cursors.Default;
            this.hsd.CustomFormat = "dd/MM/yyyy";
            this.hsd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hsd.Location = new System.Drawing.Point(504, 58);
            this.hsd.Name = "hsd";
            this.hsd.Size = new System.Drawing.Size(200, 20);
            this.hsd.TabIndex = 18;
            // 
            // nsx
            // 
            this.nsx.Cursor = System.Windows.Forms.Cursors.Cross;
            this.nsx.CustomFormat = "dd/MM/yyyy";
            this.nsx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nsx.Location = new System.Drawing.Point(504, 26);
            this.nsx.Name = "nsx";
            this.nsx.Size = new System.Drawing.Size(200, 20);
            this.nsx.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "HSD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "NSX:";
            // 
            // tb_huy
            // 
            this.tb_huy.Location = new System.Drawing.Point(495, 149);
            this.tb_huy.Name = "tb_huy";
            this.tb_huy.Size = new System.Drawing.Size(75, 27);
            this.tb_huy.TabIndex = 14;
            this.tb_huy.Text = "Hủy";
            this.tb_huy.UseVisualStyleBackColor = true;
            this.tb_huy.Click += new System.EventHandler(this.tb_huy_Click);
            // 
            // tb_luu
            // 
            this.tb_luu.Location = new System.Drawing.Point(394, 149);
            this.tb_luu.Name = "tb_luu";
            this.tb_luu.Size = new System.Drawing.Size(75, 27);
            this.tb_luu.TabIndex = 13;
            this.tb_luu.Text = "Lưu";
            this.tb_luu.UseVisualStyleBackColor = true;
            this.tb_luu.Click += new System.EventHandler(this.tb_luu_Click);
            // 
            // cbb_donvi
            // 
            this.cbb_donvi.FormattingEnabled = true;
            this.cbb_donvi.Location = new System.Drawing.Point(153, 101);
            this.cbb_donvi.Name = "cbb_donvi";
            this.cbb_donvi.Size = new System.Drawing.Size(150, 21);
            this.cbb_donvi.TabIndex = 12;
            // 
            // tb_them
            // 
            this.tb_them.Location = new System.Drawing.Point(295, 149);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(75, 27);
            this.tb_them.TabIndex = 9;
            this.tb_them.Text = "Thêm";
            this.tb_them.UseVisualStyleBackColor = true;
            this.tb_them.Click += new System.EventHandler(this.tb_them_Click);
            // 
            // tb_sua
            // 
            this.tb_sua.Location = new System.Drawing.Point(394, 149);
            this.tb_sua.Name = "tb_sua";
            this.tb_sua.Size = new System.Drawing.Size(75, 27);
            this.tb_sua.TabIndex = 10;
            this.tb_sua.Text = "Sửa";
            this.tb_sua.UseVisualStyleBackColor = true;
            this.tb_sua.Click += new System.EventHandler(this.tb_sua_Click);
            // 
            // tb_xoa
            // 
            this.tb_xoa.Location = new System.Drawing.Point(495, 149);
            this.tb_xoa.Name = "tb_xoa";
            this.tb_xoa.Size = new System.Drawing.Size(75, 27);
            this.tb_xoa.TabIndex = 11;
            this.tb_xoa.Text = "Xóa";
            this.tb_xoa.UseVisualStyleBackColor = true;
            this.tb_xoa.Click += new System.EventHandler(this.tb_xoa_Click);
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(504, 94);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(121, 20);
            this.tb_dongia.TabIndex = 8;
            this.tb_dongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_dongia_KeyPress);
            // 
            // tb_tenthuoc
            // 
            this.tb_tenthuoc.Location = new System.Drawing.Point(153, 66);
            this.tb_tenthuoc.Name = "tb_tenthuoc";
            this.tb_tenthuoc.Size = new System.Drawing.Size(150, 20);
            this.tb_tenthuoc.TabIndex = 6;
            this.tb_tenthuoc.Validated += new System.EventHandler(this.tb_tenthuoc_Validated);
            // 
            // tb_mathuoc
            // 
            this.tb_mathuoc.Enabled = false;
            this.tb_mathuoc.Location = new System.Drawing.Point(153, 32);
            this.tb_mathuoc.Name = "tb_mathuoc";
            this.tb_mathuoc.Size = new System.Drawing.Size(150, 20);
            this.tb_mathuoc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Loại Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Thuốc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 250);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(34, 149);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 19;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // firmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "firmThuoc";
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.firmThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.TextBox tb_tenthuoc;
        private System.Windows.Forms.TextBox tb_mathuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_them;
        private System.Windows.Forms.Button tb_sua;
        private System.Windows.Forms.Button tb_xoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_donvi;
        private System.Windows.Forms.Button tb_huy;
        private System.Windows.Forms.Button tb_luu;
        private System.Windows.Forms.DateTimePicker hsd;
        private System.Windows.Forms.DateTimePicker nsx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button load;
    }
}