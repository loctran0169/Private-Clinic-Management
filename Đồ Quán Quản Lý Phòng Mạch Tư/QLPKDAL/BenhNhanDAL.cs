using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace QLPKDAL
{
    public class BenhNhanDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public BenhNhanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(BenhNhanDTO bn)
        {
            string query = string.Empty;
            query += "INSERT INTO BENHNHAN (mabn,hoten,ngaysinh,gioitinh,diachi,sdt) VALUES (@mabn,@hoten,@ngaysinh,@gioitinh,@diachi,@sdt)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mabn", bn.MaBN1);
                    cmd.Parameters.AddWithValue("@hoten", bn.HoTen1);
                    cmd.Parameters.AddWithValue("@ngaysinh", bn.NgaySinh1.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@gioitinh", bn.GioiTinh1);
                    cmd.Parameters.AddWithValue("@diachi", bn.DiaChi1);
                    cmd.Parameters.AddWithValue("@sdt", bn.SDT1);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                        return true;                      
                    }
                    catch (Exception ex)
                    {
                        string s = ex.Message;
                        con.Close();
                    }
                }
            }
            return false;
        }

        public bool sua(BenhNhanDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE BENHNHAN SET mabn = @mabn, HoTen = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh,diachi = @diachi,sdt=@sdt WHERE mabn = @mabn";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mabn", bn.MaBN1);
                    cmd.Parameters.AddWithValue("@hoten", bn.HoTen1);
                    cmd.Parameters.AddWithValue("@ngaysinh", bn.NgaySinh1);
                    cmd.Parameters.AddWithValue("@gioitinh", bn.GioiTinh1);
                    cmd.Parameters.AddWithValue("@diachi", bn.DiaChi1);
                    cmd.Parameters.AddWithValue("@sdt", bn.SDT1);
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

        public bool xoa(BenhNhanDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM BENHNHAN WHERE mabn = @mabn";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mabn", bn.MaBN1);
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

        public List<BenhNhanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM BENHNHAN";

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        MySqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                BenhNhanDTO bn = new BenhNhanDTO();
                                bn.MaBN1 = reader["MaBN"].ToString();
                                bn.NgaySinh1 = (DateTime)reader["NgaySinh"];
                                bn.GioiTinh1 = reader["GioiTinh"].ToString();
                                bn.DiaChi1 = reader["DiaChi"].ToString();
                                bn.HoTen1 = reader["HoTen"].ToString();
                                bn.SDT1= reader["SDT"].ToString();
                                listBenhNhan.Add(bn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }

                }
            }
            return listBenhNhan;
        }

        public List<BenhNhanDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM BENHNHAN";
            query += " WHERE (mabn LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (Hoten LIKE CONCAT('%',@sKeyword,'%'))";

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
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
                                BenhNhanDTO bn = new BenhNhanDTO();
                                bn.MaBN1 = reader["MaBN"].ToString();
                                bn.NgaySinh1 = (DateTime)reader["NgaySinh"];
                                bn.GioiTinh1 = reader["GioiTinh"].ToString();
                                bn.DiaChi1 = reader["DiaChi"].ToString();
                                bn.HoTen1 = reader["HoTen"].ToString();
                                bn.SDT1 = reader["SDT"].ToString();
                                listBenhNhan.Add(bn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return listBenhNhan;
        }

        public DataTable loadToDataTable()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from BENHNHAN";
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
        public DataTable loadDanhSachKhamBenh(DateTime t)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select pk.mabn, hoten,ngaysinh,gioitinh,diachi,sdt " +
                    "from BENHNHAN bn, PHIEUKHAM pk " +
                    "where bn.mabn = pk.mabn and year(pk.Ngaykham)= @year and month(pk.Ngaykham)= @month and day(pk.Ngaykham)= @day";
                MySqlCommand cm = new MySqlCommand(sql, kn);
                cm.Parameters.AddWithValue("@year",t.Year);
                cm.Parameters.AddWithValue("@month", t.Month);
                cm.Parameters.AddWithValue("@day", t.Day);
                MySqlDataAdapter dt = new MySqlDataAdapter(cm);
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
