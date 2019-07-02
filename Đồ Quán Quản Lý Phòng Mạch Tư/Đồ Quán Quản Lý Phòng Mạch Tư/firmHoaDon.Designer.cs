namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmHoaDon
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
            this.tb_pk = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_xem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_mahd = new System.Windows.Forms.TextBox();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.tb_tienthuoc = new System.Windows.Forms.TextBox();
            this.tb_tienkham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gchd = new DevExpress.XtraGrid.GridControl();
            this.gvhd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gchd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pk);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.bt_xem);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt_in);
            this.groupBox1.Controls.Add(this.tb_hoten);
            this.groupBox1.Controls.Add(this.tb_mahd);
            this.groupBox1.Controls.Add(this.tb_tongtien);
            this.groupBox1.Controls.Add(this.tb_tienthuoc);
            this.groupBox1.Controls.Add(this.tb_tienkham);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // tb_pk
            // 
            this.tb_pk.Location = new System.Drawing.Point(172, 49);
            this.tb_pk.Name = "tb_pk";
            this.tb_pk.Size = new System.Drawing.Size(124, 20);
            this.tb_pk.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(172, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Thanh Toán";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(302, 50);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(62, 21);
            this.bt_tim.TabIndex = 18;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_xem
            // 
            this.bt_xem.Location = new System.Drawing.Point(398, 132);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(89, 39);
            this.bt_xem.TabIndex = 17;
            this.bt_xem.Text = "Lập Hóa Đơn";
            this.bt_xem.UseVisualStyleBackColor = true;
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(513, 132);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(96, 39);
            this.bt_in.TabIndex = 15;
            this.bt_in.Text = "In Hóa Đơn";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // tb_hoten
            // 
            this.tb_hoten.Enabled = false;
            this.tb_hoten.Location = new System.Drawing.Point(172, 76);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(192, 20);
            this.tb_hoten.TabIndex = 13;
            // 
            // tb_mahd
            // 
            this.tb_mahd.Enabled = false;
            this.tb_mahd.Location = new System.Drawing.Point(172, 24);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.Size = new System.Drawing.Size(192, 20);
            this.tb_mahd.TabIndex = 12;
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Enabled = false;
            this.tb_tongtien.Location = new System.Drawing.Point(513, 72);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.Size = new System.Drawing.Size(200, 20);
            this.tb_tongtien.TabIndex = 11;
            // 
            // tb_tienthuoc
            // 
            this.tb_tienthuoc.Enabled = false;
            this.tb_tienthuoc.Location = new System.Drawing.Point(513, 46);
            this.tb_tienthuoc.Name = "tb_tienthuoc";
            this.tb_tienthuoc.Size = new System.Drawing.Size(200, 20);
            this.tb_tienthuoc.TabIndex = 10;
            // 
            // tb_tienkham
            // 
            this.tb_tienkham.Enabled = false;
            this.tb_tienkham.Location = new System.Drawing.Point(513, 20);
            this.tb_tienkham.Name = "tb_tienkham";
            this.tb_tienkham.Size = new System.Drawing.Size(200, 20);
            this.tb_tienkham.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiền Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền Khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Và Tên Bệnh Nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Phiếu Khám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Hóa Đơn";
            // 
            // gchd
            // 
            this.gchd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gchd.Location = new System.Drawing.Point(0, 188);
            this.gchd.MainView = this.gvhd;
            this.gchd.Name = "gchd";
            this.gchd.Size = new System.Drawing.Size(800, 262);
            this.gchd.TabIndex = 2;
            this.gchd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvhd});
            // 
            // gvhd
            // 
            this.gvhd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvhd.GridControl = this.gchd;
            this.gvhd.Name = "gvhd";
            this.gvhd.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Thuốc";
            this.gridColumn1.FieldName = "TenThuoc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số Lượng";
            this.gridColumn2.FieldName = "SoLuong";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn Giá";
            this.gridColumn3.FieldName = "DonGia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cách Dùng";
            this.gridColumn4.FieldName = "CachDung";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // firmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gchd);
            this.Controls.Add(this.groupBox1);
            this.Name = "firmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.firmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gchd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_mahd;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.TextBox tb_tienthuoc;
        private System.Windows.Forms.TextBox tb_tienkham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_xem;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_pk;
        private DevExpress.XtraGrid.GridControl gchd;
        private DevExpress.XtraGrid.Views.Grid.GridView gvhd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}