using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmKhoiPhuc : Form
    {

        string connString = "Data Source=localhost;Initial Catalog=QLPK;User ID=root;Password=angel1999";

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
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = dlg.SelectedPath;
                bt_restore.Enabled = true;
            }
        }
    }
}
