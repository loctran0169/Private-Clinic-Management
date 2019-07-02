namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    partial class firmKhoiPhuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_server = new System.Windows.Forms.ComboBox();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bt_restore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasword:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ file:";
            // 
            // cbb_server
            // 
            this.cbb_server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_server.FormattingEnabled = true;
            this.cbb_server.Items.AddRange(new object[] {
            "mysql-1325-0.cloudclusters.net"});
            this.cbb_server.Location = new System.Drawing.Point(124, 53);
            this.cbb_server.Name = "cbb_server";
            this.cbb_server.Size = new System.Drawing.Size(197, 21);
            this.cbb_server.TabIndex = 1;
            // 
            // tb_tk
            // 
            this.tb_tk.Location = new System.Drawing.Point(124, 81);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(197, 20);
            this.tb_tk.TabIndex = 2;
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(124, 108);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(197, 20);
            this.tb_mk.TabIndex = 3;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(124, 137);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(197, 20);
            this.tb_path.TabIndex = 9;
            // 
            // bt_restore
            // 
            this.bt_restore.Location = new System.Drawing.Point(339, 137);
            this.bt_restore.Name = "bt_restore";
            this.bt_restore.Size = new System.Drawing.Size(100, 23);
            this.bt_restore.TabIndex = 10;
            this.bt_restore.Text = "Restore";
            this.bt_restore.UseVisualStyleBackColor = true;
            this.bt_restore.Click += new System.EventHandler(this.bt_restore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Chọn File .bak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firmKhoiPhuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_restore);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.cbb_server);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "firmKhoiPhuc";
            this.Text = "Khôi Phục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_server;
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button bt_restore;
        private System.Windows.Forms.Button button1;
    }
}