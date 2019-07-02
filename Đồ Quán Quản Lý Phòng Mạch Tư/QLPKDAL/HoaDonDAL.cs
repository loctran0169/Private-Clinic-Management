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

        public DataTable LoadTienThuoc(string pk)
        {

            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = string.Empty;
                query += "SELECT bn.HoTen,sum(SoLuong*DonGia) as 'TienThuoc', NgayKham ";
                query += "FROM DONTHUOC dt, PHIEUKHAM pk, THUOC t,BENHNHAN bn ";
                query += "where pk.MaPK=@pk and pk.MaPK=dt.MaPK and t.MaThuoc=dt.MaThuoc and bn.MaBN=pk.MaBN ";
                //query += "and not exists (select* from HOADON hd where pk.MaPK = hd.MaPK) ";
                query += "group by pk.MaPK ";
                MySqlCommand cmd = new MySqlCommand(query, kn);
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

        public string TimHoaDon(string sKeyword)
        {
            string kq = null;
            string query = string.Empty;
            query += " SELECT MaHD";
            query += " FROM HOADON";
            query += " WHERE (mapk LIKE CONCAT('%',@sKeyword,'%'))";
            
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                kq=reader["MaHD"].ToString();
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return kq;
        }

        public string LoadThamSo()
        {
            string k = null;
            DataTable tb = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                kn.Open();
                string sql = "select GiaTri from THAMSO where MaTS = 'TS001'";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(tb);//đổ dữ liệu từ DataBase sang bảng
                k= tb.Rows[0][0].ToString();
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {

            }
            return k;
        }

        public DataTable loadToDataTable()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                kn.Open();
                string sql = "select * from HOADON";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception e)
            {

            }
            return k;
        }

         
        public bool them(HoaDonDTO hd)
        {
            string query = string.Empty;
            query += "INSERT INTO HOADON (mahd,mapk,ngaylap,tienthuoc,tongtien) VALUES (@mahd,@mapk,@ngaylap,@tienthuoc,@tongtien)";
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mahd", hd.MaHD1);
                    cmd.Parameters.AddWithValue("@mapk", hd.MaPK1);
                    cmd.Parameters.AddWithValue("@ngaylap", hd.NgayLap1);
                    cmd.Parameters.AddWithValue("@tienthuoc", hd.TienThuoc1);
                    cmd.Parameters.AddWithValue("@tongtien", hd.TongTien1);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        return true;
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                    }
                }
            }
            return false;
        }
    }
}
