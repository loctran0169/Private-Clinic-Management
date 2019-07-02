using MySql.Data.MySqlClient;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLPKDAL
{
    public class PhieuKhamDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        
        public PhieuKhamDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(PhieuKhamDTO pk)
        {

            string query = string.Empty;
            query += "INSERT INTO PHIEUKHAM VALUES (@mapk,@mabn,@manv,@malb,@ngaykham)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapk", pk.MaPK1);
                    cmd.Parameters.AddWithValue("@mabn", pk.MaBN1);
                    cmd.Parameters.AddWithValue("@manv", pk.MaNV1);
                    cmd.Parameters.AddWithValue("@malb", pk.MaLB1);
                    cmd.Parameters.AddWithValue("@ngaykham", pk.NgayKham1);
                    
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

        public bool sua(PhieuKhamDTO pk)
        {
            string query = string.Empty;
            query += "UPDATE PHIEUKHAM SET mapk = @mapk, mabn = @mabn, manv = @manv, malb = @malb,ngaykham = @ngaykham, ngaykhamlai=@ngaykhamlai WHERE mapk = @mapk";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapk", pk.MaPK1);
                    cmd.Parameters.AddWithValue("@mabn", pk.MaBN1);
                    cmd.Parameters.AddWithValue("@manv", pk.MaNV1);
                    cmd.Parameters.AddWithValue("@malb", pk.MaLB1);
                    cmd.Parameters.AddWithValue("@ngaykham", pk.NgayKham1);
                    cmd.Parameters.AddWithValue("@ngaykhamlai", pk.NgayKhamLai1);
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

        public bool xoa(PhieuKhamDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM PHIEUKHAM WHERE mapk = @mapk";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mapk", bn.MaPK1);
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
        public DataTable loadToDataTable()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT * FROM PHIEUKHAM";
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
        public List<PhieuKhamDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM PHIEUKHAM";

            List<PhieuKhamDTO> listphieukham = new List<PhieuKhamDTO>();
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
                                PhieuKhamDTO pk = new PhieuKhamDTO();
                                pk.MaPK1 =reader["MaPK"].ToString();
                                pk.MaBN1 = reader["MaBN"].ToString();
                                pk.MaNV1 = reader["MaNV"].ToString();
                                pk.MaLB1 = reader["MaLB"].ToString();
                                pk.NgayKham1 = (DateTime)reader["NgayKham"];
                                pk.NgayKhamLai1 = (DateTime)reader["NgayKhamLai"];                             
                                listphieukham.Add(pk);
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
            return listphieukham;
        }

        public List<PhieuKhamDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM PHIEUKHAM";
            query += " WHERE (mapk LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (mabn LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (manv LIKE CONCAT('%',@sKeyword,'%'))";

            List<PhieuKhamDTO> listphieukham = new List<PhieuKhamDTO>();

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
                                PhieuKhamDTO pk = new PhieuKhamDTO();
                                pk.MaPK1 = reader["MaPK"].ToString();
                                pk.MaBN1 = reader["MaBN"].ToString();
                                pk.MaNV1 = reader["MaNV"].ToString();
                                pk.MaLB1 = reader["MaLB"].ToString();
                                pk.NgayKham1 = (DateTime)reader["NgayKham"];
                                pk.NgayKhamLai1 = (DateTime)reader["NgayKhamLai"];
                                listphieukham.Add(pk);
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
            return listphieukham;
        }
    }
}
