using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmKhoiPhuc : Form
    {

        string connString;

        public firmKhoiPhuc()
        {
            InitializeComponent();
        }
        public void Check()
        {
            if (string.IsNullOrEmpty(cbb_server.Text))
            {
                MessageBox.Show("Chưa chọn database");
                return;
            }
            else if (string.IsNullOrEmpty(tb_tk.Text))
            {
                MessageBox.Show("Chưa nhập tài khoản database");
                tb_tk.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tb_dbname.Text))
            {
                MessageBox.Show("Chưa nhập tên database");
                tb_dbname.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tb_path.Text))
            {
                MessageBox.Show("Chưa chọn file database");
                return;
            }
        }
        private void bt_restore_Click(object sender, EventArgs e)
        {
            string file = tb_path.Text;
            if (string.IsNullOrEmpty(cbb_server.Text))
            {
                MessageBox.Show("Chưa chọn server");
                return;
            }
            else if (string.IsNullOrEmpty(tb_tk.Text))
            {
                MessageBox.Show("Chưa nhập tài khoản");
                tb_tk.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tb_mk.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                tb_mk.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tb_port.Text))
            {
                MessageBox.Show("Chưa nhập port");
                tb_port.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tb_dbname.Text))
            {
                MessageBox.Show("Chưa nhập tên Database");
                tb_dbname.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tb_path.Text))
            {
                MessageBox.Show("Chưa chọn thư mục");
                return;
            }
            try
            {
                //connString= "SERVER="+cbb_server.Text+";PORT="+tb_port.Text+";DATABASE="+tb_dbname.Text+";UID="+tb_tk.Text+";PASSWORD="+tb_mk.Text+";Charset = utf8";
                //connString= "Data Source = localhost; Initial Catalog = QLPK; User ID = root; Password = angel1999";
                connString = "SERVER=mysql-1325-0.cloudclusters.net;PORT=10001;DATABASE=QLKP;UID=loctran0169;PASSWORD=angel1999;Charset = utf8";
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            MessageBox.Show("Khôi phục thành công");
                            conn.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                string x = ex.Message;
                MessageBox.Show("Khôi phục thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter= "bak files (*.bak)|*.bak";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = dlg.FileName;
                bt_restore.Enabled = true;
            }
            else
                return;
        }
    }
}
