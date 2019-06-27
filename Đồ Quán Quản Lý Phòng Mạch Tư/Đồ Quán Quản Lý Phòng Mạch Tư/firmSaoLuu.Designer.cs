namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmSaoLuu
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
            this.cbb_server = new System.Windows.Forms.ComboBox();
            this.brower = new System.Windows.Forms.Button();
            this.bt_SaoLuu = new System.Windows.Forms.Button();
            this.bt_ketnoi = new System.Windows.Forms.Button();
            this.tb_thumuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_saoluu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_saoluu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_server);
            this.groupBox1.Controls.Add(this.brower);
            this.groupBox1.Controls.Add(this.bt_SaoLuu);
            this.groupBox1.Controls.Add(this.bt_ketnoi);
            this.groupBox1.Controls.Add(this.tb_thumuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sao Lưu";
            // 
            // cbb_server
            // 
            this.cbb_server.FormattingEnabled = true;
            this.cbb_server.Items.AddRange(new object[] {
            "mysql-1325-0.cloudclusters.net"});
            this.cbb_server.Location = new System.Drawing.Point(118, 28);
            this.cbb_server.Name = "cbb_server";
            this.cbb_server.Size = new System.Drawing.Size(327, 21);
            this.cbb_server.TabIndex = 9;
            // 
            // brower
            // 
            this.brower.Location = new System.Drawing.Point(370, 62);
            this.brower.Name = "brower";
            this.brower.Size = new System.Drawing.Size(75, 23);
            this.brower.TabIndex = 8;
            this.brower.Text = "Brower";
            this.brower.UseVisualStyleBackColor = true;
            this.brower.Click += new System.EventHandler(this.brower_Click);
            // 
            // bt_SaoLuu
            // 
            this.bt_SaoLuu.Location = new System.Drawing.Point(451, 62);
            this.bt_SaoLuu.Name = "bt_SaoLuu";
            this.bt_SaoLuu.Size = new System.Drawing.Size(75, 23);
            this.bt_SaoLuu.TabIndex = 7;
            this.bt_SaoLuu.Text = "Sao Lưu";
            this.bt_SaoLuu.UseVisualStyleBackColor = true;
            this.bt_SaoLuu.Click += new System.EventHandler(this.bt_SaoLuu_Click);
            // 
            // bt_ketnoi
            // 
            this.bt_ketnoi.Location = new System.Drawing.Point(451, 28);
            this.bt_ketnoi.Name = "bt_ketnoi";
            this.bt_ketnoi.Size = new System.Drawing.Size(75, 23);
            this.bt_ketnoi.TabIndex = 6;
            this.bt_ketnoi.Text = "Kết Nối";
            this.bt_ketnoi.UseVisualStyleBackColor = true;
            this.bt_ketnoi.Click += new System.EventHandler(this.bt_ketnoi_Click);
            // 
            // tb_thumuc
            // 
            this.tb_thumuc.Location = new System.Drawing.Point(118, 65);
            this.tb_thumuc.Name = "tb_thumuc";
            this.tb_thumuc.Size = new System.Drawing.Size(241, 20);
            this.tb_thumuc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thư Mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // dtgv_saoluu
            // 
            this.dtgv_saoluu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_saoluu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_saoluu.Location = new System.Drawing.Point(12, 137);
            this.dtgv_saoluu.Name = "dtgv_saoluu";
            this.dtgv_saoluu.ReadOnly = true;
            this.dtgv_saoluu.Size = new System.Drawing.Size(776, 301);
            this.dtgv_saoluu.TabIndex = 1;
            // 
            // firmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgv_saoluu);
            this.Controls.Add(this.groupBox1);
            this.Name = "firmSaoLuu";
            this.Text = "firmSaoLuu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_saoluu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_SaoLuu;
        private System.Windows.Forms.Button bt_ketnoi;
        private System.Windows.Forms.TextBox tb_thumuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brower;
        private System.Windows.Forms.DataGridView dtgv_saoluu;
        private System.Windows.Forms.ComboBox cbb_server;
    }
}