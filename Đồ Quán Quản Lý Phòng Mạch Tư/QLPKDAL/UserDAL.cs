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
    public class UserDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public UserDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(UserDTO us)
        {

            string query = string.Empty;
            query += "INSERT INTO USERS (maus,taikhoan,matkhau,manv,maqh) VALUES (@maus,@taikhoan,@matkhau,@manv,@maqh)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS1);
                    cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan1);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau1);
                    cmd.Parameters.AddWithValue("@manv", us.MaNV1);
                    cmd.Parameters.AddWithValue("@maqh", us.MaQH1);
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

        public bool sua(UserDTO us)
        {
            string query = string.Empty;
            query += "UPDATE USERS SET  taikhoan = @taikhoan, matkhau = @matkhau,manv=@manv,maqh=@maqh WHERE maus = @maus";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS1);
                    cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan1);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau1);
                    cmd.Parameters.AddWithValue("@manv", us.MaNV1);
                    cmd.Parameters.AddWithValue("@maqh", us.MaQH1);
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

        public bool suamk(UserDTO us)
        {
            string query = string.Empty;
            query += "UPDATE USERS SET  matkhau = @matkhau WHERE maus = @maus";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS1);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau1);
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
        public bool xoa(UserDTO us)
        {
            string query = string.Empty;
            query += "DELETE FROM USERS WHERE maus = @maus";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS1);
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

        public List<UserDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM USERS";

            List<UserDTO> listuser = new List<UserDTO>();
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
                                UserDTO us = new UserDTO();
                                us.MaUS1 = reader["MaUS"].ToString();
                                us.MaNV1 = reader["MaNV"].ToString();
                                us.MaQH1 = reader["MaQH"].ToString();
                                us.TaiKhoan1 = reader["TaiKhoan"].ToString(); ;
                                us.MatKhau1 = reader["MatKhau"].ToString();
                                listuser.Add(us);
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
            return listuser;
        }

        public List<UserDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM USERS";
            query += " WHERE (maus LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (taikhoan LIKE CONCAT('%',@sKeyword,'%'))";

            List<UserDTO> listuser = new List<UserDTO>();

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
                                UserDTO us = new UserDTO();
                                us.MaUS1 = reader["MaUS"].ToString();
                                us.MaNV1 = reader["MaNV"].ToString();
                                us.MaQH1 = reader["MaQH"].ToString();
                                us.TaiKhoan1 = reader["TaiKhoan"].ToString(); ;
                                us.MatKhau1 = reader["MatKhau"].ToString();
                                listuser.Add(us);
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
            return listuser;
        }

        public DataTable loadDuLieuUsers()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from USERS";
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
        public DataTable loadDuLieuNhanVien()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select MaNhanVien from NHANVIEN";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public DataTable loadDuLieuQuyenHan()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select MaQH,TenQuyenHan from QUYENHAN";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {
               
            }
            return k;
        }

        public bool CheckPass(string tk, string mk)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                
                string sql = "select * from USERS where taikhoan=@taikhoan and MatKhau=@MatKhau";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@taikhoan", tk);
                cmd.Parameters.AddWithValue("@MatKhau", mk);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);     
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                if (k.Rows.Count >0)
                    return true;
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {

            }
            return false;
        }

        public DataTable dangNhap(UserDTO us)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                kn.Open();
                string sql = "select * from USERS where taikhoan=@taikhoan and matkhau=@matkhau";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan1);
                cmd.Parameters.AddWithValue("@matkhau", us.MatKhau1);
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                string s = e.Message;
                int b = 5;
            }
            return k;
        }
    }
}
