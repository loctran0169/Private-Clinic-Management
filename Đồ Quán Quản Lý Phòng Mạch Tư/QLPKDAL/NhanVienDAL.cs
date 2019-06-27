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
    public class NhanVienDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public NhanVienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(NhanVienDTO nv)
        {

            string query = string.Empty;
            query += "INSERT INTO NHANVIEN(hoten,gioitinh,ngaysinh,chucvu,diachi) VALUES (@hoten,@gioitinh,@ngaysinh,@chucvu,@diachi)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@hoten", nv.HoTen1);
                    cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh1);
                    cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh1);
                    cmd.Parameters.AddWithValue("@chucvu", nv.ChucVu1);
                    cmd.Parameters.AddWithValue("@chucvu", nv.DiaChi1);
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

        public bool sua(NhanVienDTO nv)
        {
            string query = string.Empty;
            query += "UPDATE NHANVIEN SET manv = @manv, HoTen = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh,diachi = @diachi, chucvu=@chucvu WHERE manv = @manv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", nv.MaNV1);
                    cmd.Parameters.AddWithValue("@hoten", nv.HoTen1);
                    cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh1);
                    cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh1);
                    cmd.Parameters.AddWithValue("@diachi", nv.DiaChi1);
                    cmd.Parameters.AddWithValue("@diachi", nv.ChucVu1);
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

        public bool xoa(NhanVienDTO nv)
        {
            string query = string.Empty;
            query += "DELETE FROM NHANVIEN WHERE manv = @manv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", nv.MaNV1);
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

        public List<NhanVienDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM NHANVIEN";

            List<NhanVienDTO> listnhanvien = new List<NhanVienDTO>();
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
                                NhanVienDTO nv = new NhanVienDTO();
                                nv.MaNV1 = int.Parse(reader["MaNV"].ToString());
                                nv.NgaySinh1 = (DateTime)reader["NgaySinh"];
                                nv.GioiTinh1 = reader["GioiTinh"].ToString();
                                nv.DiaChi1 = reader["DiaChi"].ToString();
                                nv.HoTen1 = reader["HoTen"].ToString();
                                nv.ChucVu1 = reader["ChucVu"].ToString();
                                listnhanvien.Add(nv);
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
            return listnhanvien;
        }

        public List<NhanVienDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM NHANVIEN";
            query += " WHERE (manv LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (Hoten LIKE CONCAT('%',@sKeyword,'%'))";

            List<NhanVienDTO> listnhanvien = new List<NhanVienDTO>();

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
                                NhanVienDTO nv = new NhanVienDTO();
                                nv.MaNV1 = int.Parse(reader["MaBN"].ToString());
                                nv.NgaySinh1 = (DateTime)reader["NgaySinh"];
                                nv.GioiTinh1 = reader["GioiTinh"].ToString();
                                nv.DiaChi1 = reader["DiaChi"].ToString();
                                nv.HoTen1 = reader["HoTen"].ToString();
                                nv.ChucVu1 = reader["ChucVu"].ToString();
                                listnhanvien.Add(nv);
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
            return listnhanvien;
        }
    }
}
