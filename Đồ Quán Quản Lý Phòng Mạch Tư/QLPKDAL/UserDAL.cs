using MySql.Data.MySqlClient;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            query += "INSERT INTO USERS (taikhoan,matkhau,manv,maqh) VALUES (@taikhoan,@matkhau,@manv,@maqh)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
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
            query += "UPDATE USERS SET maus = @maus, taikhoan = @taikhoan, matkhau = @matkhau,manv=@manv,maqh@maqh WHERE matk = @matk";
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
                                us.MaUS1 = int.Parse(reader["MaUS"].ToString());
                                us.MaNV1 = int.Parse(reader["MaNV"].ToString());
                                us.MaQH1 = int.Parse(reader["MaQH"].ToString());
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
                                us.MaUS1 = int.Parse(reader["MaUS"].ToString());
                                us.MaNV1 = int.Parse(reader["MaNV"].ToString());
                                us.MaQH1 = int.Parse(reader["MaQH"].ToString());
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
    }
}
