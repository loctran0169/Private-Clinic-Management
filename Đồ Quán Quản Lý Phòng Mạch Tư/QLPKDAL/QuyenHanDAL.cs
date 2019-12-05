using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace QLPKDAL
{
    public class QuyenHanDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public QuyenHanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public DataTable loadDuLieuQuyenHan()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select * from QUYENHAN";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối" + e.Message);
            }
            return k;
        }

    }

}
