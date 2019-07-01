using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDAL
{
    public class HoaDonDAL
    {
        public DataTable loadDuLieu(string pk)
        {

            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {

                string sql = "SELECT t.TenThuoc,SoLuong,SoLuong*DonGia as 'DonGia',CachDung FROM PHIEUKHAM pk, DONTHUOC dt, THUOC t, CACHDUNG cd where pk.MaPK = dt.MaPK and dt.MaThuoc = t.MaThuoc and cd.MaCD = dt.MaCD and dt.MaPK = @pk";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@pk", pk);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                string s = e.Message;
                int a = 3;
            }
            return k;
        }
    }
}
