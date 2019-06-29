using MySql.Data.MySqlClient;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDAL
{
    public class LichSuDAL
    {
        public LichSuDAL()
        {

        }
        public DataTable LoadByDate(DateTime ls)
        {
            
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                kn.Open();
                string sql = "select *from LICHSUDANGNHAP where year(ThoiGianDN)=@year and month(ThoiGianDN) = @month and day(ThoiGianDN) = @day";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@year", int.Parse(ls.ToString("yyyy")));
                cmd.Parameters.AddWithValue("@month", int.Parse(ls.ToString("MM")));
                cmd.Parameters.AddWithValue("@day", int.Parse(ls.ToString("dd")));
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public DataTable LoadThongTinNV(string manv)
        {

            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                kn.Open();
                string sql = "select NHANVIEN.MaNV,HoTen,GioiTinh,NgaySinh,DiaChi,SDT,ChucVu,TaiKhoan from NHANVIEN, USERS where NHANVIEN.MANV = USERS.MANV AND NHANVIEN.MaNV = @manv";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@manv", manv);
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {

            }
            return k;
        }
    }
}
