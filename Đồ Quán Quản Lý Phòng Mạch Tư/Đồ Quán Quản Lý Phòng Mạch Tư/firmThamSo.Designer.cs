namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmThamSo
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
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_load = new System.Windows.Forms.Button();
            this.textBox_MaTS = new System.Windows.Forms.TextBox();
            this.textBox_TenTS = new System.Windows.Forms.TextBox();
            this.textBox_GiaTri = new System.Windows.Forms.TextBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.label_GiaTri = new System.Windows.Forms.Label();
            this.label_TenTS = new System.Windows.Forms.Label();
            this.label_MaTS = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Huy);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_load);
            this.panel1.Controls.Add(this.textBox_MaTS);
            this.panel1.Controls.Add(this.textBox_TenTS);
            this.panel1.Controls.Add(this.textBox_GiaTri);
            this.panel1.Controls.Add(this.bt_luu);
            this.panel1.Controls.Add(this.label_GiaTri);
            this.panel1.Controls.Add(this.label_TenTS);
            this.panel1.Controls.Add(this.label_MaTS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 142);
            this.panel1.TabIndex = 0;
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(633, 73);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(75, 32);
            this.bt_Huy.TabIndex = 14;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Visible = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(471, 73);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 32);
            this.bt_sua.TabIndex = 13;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Visible = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click_1);
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(379, 73);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(86, 32);
            this.bt_load.TabIndex = 0;
            this.bt_load.Text = "Load Dữ Liệu";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // textBox_MaTS
            // 
            this.textBox_MaTS.Location = new System.Drawing.Point(185, 30);
            this.textBox_MaTS.Name = "textBox_MaTS";
            this.textBox_MaTS.ReadOnly = true;
            this.textBox_MaTS.Size = new System.Drawing.Size(152, 20);
            this.textBox_MaTS.TabIndex = 2;
            // 
            // textBox_TenTS
            // 
            this.textBox_TenTS.Location = new System.Drawing.Point(447, 30);
            this.textBox_TenTS.Name = "textBox_TenTS";
            this.textBox_TenTS.ReadOnly = true;
            this.textBox_TenTS.Size = new System.Drawing.Size(261, 20);
            this.textBox_TenTS.TabIndex = 3;
            // 
            // textBox_GiaTri
            // 
            this.textBox_GiaTri.Location = new System.Drawing.Point(185, 70);
            this.textBox_GiaTri.Name = "textBox_GiaTri";
            this.textBox_GiaTri.ReadOnly = true;
            this.textBox_GiaTri.Size = new System.Drawing.Size(152, 20);
            this.textBox_GiaTri.TabIndex = 4;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(552, 73);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 32);
            this.bt_luu.TabIndex = 1;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Visible = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // label_GiaTri
            // 
            this.label_GiaTri.AutoSize = true;
            this.label_GiaTri.Location = new System.Drawing.Point(87, 73);
            this.label_GiaTri.Name = "label_GiaTri";
            this.label_GiaTri.Size = new System.Drawing.Size(38, 13);
            this.label_GiaTri.TabIndex = 12;
            this.label_GiaTri.Text = "Giá Trị";
            // 
            // label_TenTS
            // 
            this.label_TenTS.AutoSize = true;
            this.label_TenTS.Location = new System.Drawing.Point(357, 33);
            this.label_TenTS.Name = "label_TenTS";
            this.label_TenTS.Size = new System.Drawing.Size(72, 13);
            this.label_TenTS.TabIndex = 11;
            this.label_TenTS.Text = "Tên Tham Số";
            // 
            // label_MaTS
            // 
            this.label_MaTS.AutoSize = true;
            this.label_MaTS.Location = new System.Drawing.Point(87, 33);
            this.label_MaTS.Name = "label_MaTS";
            this.label_MaTS.Size = new System.Drawing.Size(68, 13);
            this.label_MaTS.TabIndex = 10;
            this.label_MaTS.Text = "Mã Tham Số";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 308);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Tham Số";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Tham Số";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá Trị";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // firmThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "firmThamSo";
            this.Text = "Tham Số";
            this.Load += new System.EventHandler(this.firmThamSo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_MaTS;
        private System.Windows.Forms.TextBox textBox_TenTS;
        private System.Windows.Forms.TextBox textBox_GiaTri;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label label_GiaTri;
        private System.Windows.Forms.Label label_TenTS;
        private System.Windows.Forms.Label label_MaTS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_sua;
    }
}