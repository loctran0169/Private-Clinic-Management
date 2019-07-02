using MySql.Data.MySqlClient;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKDAL
{
    public class LichSuDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public LichSuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        //public LichSuDAL()
        //{

        //}
        //public DataTable LoadByDate(DateTime ls)
        //{

        //    DataTable k = new DataTable();
        //    MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        //    try
        //    {
        //        kn.Open();
        //        string sql = "select *from LICHSUDANGNHAP where year(ThoiGianDN)=@year and month(ThoiGianDN) = @month and day(ThoiGianDN) = @day";
        //        MySqlCommand cmd = new MySqlCommand(sql, kn);
        //        cmd.Parameters.AddWithValue("@year", int.Parse(ls.ToString("yyyy")));
        //        cmd.Parameters.AddWithValue("@month", int.Parse(ls.ToString("MM")));
        //        cmd.Parameters.AddWithValue("@day", int.Parse(ls.ToString("dd")));
        //        MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
        //        dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
        //        kn.Close();
        //        dt.Dispose();

        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return k;
        //}
        //public DataTable LoadThongTinNV(string manv)
        //{

        //    DataTable k = new DataTable();
        //    MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        //    try
        //    {
        //        kn.Open();
        //        string sql = "select NHANVIEN.MaNV,HoTen,GioiTinh,NgaySinh,DiaChi,SDT,ChucVu,TaiKhoan from NHANVIEN, USERS where NHANVIEN.MANV = USERS.MANV AND NHANVIEN.MaNV = @manv";
        //        MySqlCommand cmd = new MySqlCommand(sql, kn);
        //        cmd.Parameters.AddWithValue("@manv", manv);
        //        MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
        //        dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
        //        kn.Close();
        //        dt.Dispose();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return k;
        //}

        public DataTable loadDuLieuLichSuDangNhap(DateTime t)
        {

            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select ls.MaUS, MaNV,TaiKhoan, ThoiGianDN from USERS us join LICHSUDANGNHAP ls on us.MaUS = ls.MaUS where year(ls.ThoiGianDN) = @year and month(ls.ThoiGianDN) = @month and day(ls.ThoiGianDN) = @day ORDER BY ThoiGianDN DESC";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@year", t.Year);
                cmd.Parameters.AddWithValue("@month", t.Month);
                cmd.Parameters.AddWithValue("@day", t.Day);
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                string a = e.Message;
                int b = 9;
            }
            return k;
        }

        public bool them(LichSuDTO lsDTO)
         {

            string query = string.Empty;
        query += "insert into LICHSUDANGNHAP(maus,thoigiandn) values(@maus,@thoigiandn)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", lsDTO.MaUS);
                    cmd.Parameters.AddWithValue("@thoigiandn", lsDTO.ThoiGianDN);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public bool xoa()
            {
                string query = string.Empty;
                query += "DELETE FROM LICHSUDANGNHAP ";
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            con.Dispose();
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            return false;
                        }
                    }
                }
                return true;
            }
        
    }
}
