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
        public class BenhDAL
        {
            private string connectionString;

            public string ConnectionString { get => connectionString; set => connectionString = value; }

            public BenhDAL()
            {
                connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            }
        public DataTable loadToDataTable()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT * FROM BENH";
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
        public bool them(BenhDTO lb)
            {

                string query = string.Empty;
                query += "INSERT INTO BENH (tenloaibenh,trieuchung) VALUES (@tenloaibenh,@trieuchung)";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@tenloaibenh", lb.TenLoaiBenh1);
                        cmd.Parameters.AddWithValue("@trieuchung", lb.TrieuChung1);
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

            public bool sua(BenhDTO lb)
            {
                string query = string.Empty;
                query += "UPDATE BENH SET malb = @malb, tenloaibenh = @tenloaibenh, trieuchung = @trieuchung WHERE malb = @malb";
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@malb", lb.MaLB1);
                        cmd.Parameters.AddWithValue("@tenloaibenh", lb.TenLoaiBenh1);
                        cmd.Parameters.AddWithValue("@trieuchung", lb.TrieuChung1);
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

            public bool xoa(BenhDTO lb)
            {
                string query = string.Empty;
                query += "DELETE FROM BENH WHERE malb = @malb";
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@malb", lb.MaLB1);
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

            public List<BenhDTO> select()
            {
                string query = string.Empty;
                query += "SELECT * ";
                query += "FROM BENH";

                List<BenhDTO> listBenh = new List<BenhDTO>();
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
                                    BenhDTO lb = new BenhDTO();
                                    lb.MaLB1 = int.Parse(reader["MaBN"].ToString());
                                    lb.TenLoaiBenh1 = reader["TenLoaiBenh"].ToString(); ;
                                    lb.TrieuChung1 = reader["TrieuChung"].ToString();
                                    listBenh.Add(lb);
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
                return listBenh;
            }

            public List<BenhDTO> selectByKeyWord(string sKeyword)
            {
                string query = string.Empty;
                query += " SELECT *";
                query += " FROM BENH";
                query += " WHERE (malb LIKE CONCAT('%',@sKeyword,'%'))";
                query += " OR (tenloaibenh LIKE CONCAT('%',@sKeyword,'%'))";

                List<BenhDTO> listBenh = new List<BenhDTO>();

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
                                    BenhDTO lb = new BenhDTO();
                                    lb.MaLB1 = int.Parse(reader["MaBN"].ToString());
                                    lb.TenLoaiBenh1 = reader["TenLoaiBenh"].ToString(); ;
                                    lb.TrieuChung1 = reader["TrieuChung"].ToString();
                                    listBenh.Add(lb);
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
                return listBenh;
            }
        }
}
