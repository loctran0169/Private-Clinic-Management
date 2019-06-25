using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            query += "INSERT INTO BENHNHAN VALUES (";
            query += "'" + bn.MaBN1 + "',N'" + bn.HoTen1 + "','" + bn.NgaySinh1 + "',N'" + bn.GioiTinh1 + "',N'" + bn.DiaChi1 + "'";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
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

        public bool sua(BenhNhanDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE BENHNHAN SET mabn = @mabn, HoTen = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh,diachi = @diachi WHERE mabn = @mabn";
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
            query += "DELETE FROM BenhNhan WHERE mabn = @mabn";
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
            query += "FROM BenhNhan";

            List<BenhNhanDTO> listBenhNhan = new List<BenhNhanDTO>();

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
                                bn.HoTen1 = reader["SDT"].ToString();
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
            query += " FROM BenhNhan";
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
                                bn.HoTen1 = reader["SDT"].ToString();
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
    }
}
