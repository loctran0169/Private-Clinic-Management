using MySql.Data.MySqlClient;
using QLPKBUS;
using QLPKDTO;
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
    public partial class firmSaoLuu : Form
    {
        MySqlConnection conn;
        string connString = ConfigurationManager.AppSettings["ConnectionString"];
        //string connString = "Data Source = localhost; Initial Catalog = QLPK; User ID = root; Password = angel1999";
        public firmSaoLuu()
        {
            InitializeComponent();
        }

        private void bt_ketnoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_server.Text))
            {
                MessageBox.Show("Chưa chọn server");
                return;
            }

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MessageBox.Show("Kết nối database thành công");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void bt_SaoLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_thumuc.Text))
            {
                MessageBox.Show("Chưa chọn thư mục");
                return;
            }
            if (conn.State==ConnectionState.Closed)
            {
                MessageBox.Show("Chưa kết nối database");
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            string file = tb_thumuc.Text + "\\" + conn.Database.ToString() + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak";
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sao lưu thất bại");
            }
            Load();
        }

        private void brower_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tb_thumuc.Text = dlg.SelectedPath;
                bt_SaoLuu.Enabled = true;
            }
            else
                return;
            Load();
        }
        public void Load()
        {
            string[] filePahts = Directory.GetFiles(tb_thumuc.Text,"*.bak");
            List<string> list = new List<string>(filePahts);
            DataTable table = new DataTable();
            table.Columns.Add("path");
            foreach(string str in list)
            {
                table.Rows.Add(str);
            }
            dtgv_saoluu.DataSource = table;
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgv_saoluu.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
