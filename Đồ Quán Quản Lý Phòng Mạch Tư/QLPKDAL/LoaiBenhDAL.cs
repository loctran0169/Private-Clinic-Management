using System;
using QLPKDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
namespace QLPKDAL
{
        public class LoaiBenhDAL
        {
            private string connectionString;

            public string ConnectionString { get => connectionString; set => connectionString = value; }

            public LoaiBenhDAL()
            {
                connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            }
            public DataTable loadDuLieuLoaiBenh()
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
            public bool them(LoaiBenhDTO lb)
            {

                string query = string.Empty;
                query += "INSERT INTO BENH (malb,tenloaibenh,trieuchung) VALUES (@malb,@tenloaibenh,@trieuchung)";
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@malb", lb.MaLB);
                    cmd.Parameters.AddWithValue("@tenloaibenh", lb.TenLoaiBenh);
                        cmd.Parameters.AddWithValue("@trieuchung", lb.TrieuChung);
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

            public bool sua(LoaiBenhDTO lb)
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
                        cmd.Parameters.AddWithValue("@malb", lb.MaLB);
                        cmd.Parameters.AddWithValue("@tenloaibenh", lb.TenLoaiBenh);
                        cmd.Parameters.AddWithValue("@trieuchung", lb.TrieuChung);
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

            public bool xoa(LoaiBenhDTO lb)
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
                        cmd.Parameters.AddWithValue("@malb", lb.MaLB);
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

            public List<LoaiBenhDTO> select()
            {
                string query = string.Empty;
                query += "SELECT * ";
                query += "FROM BENH";

                List<LoaiBenhDTO> listBenh = new List<LoaiBenhDTO>();
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
                                    LoaiBenhDTO lb = new LoaiBenhDTO();
                                    lb.MaLB = reader["MaLB"].ToString();
                                    lb.TenLoaiBenh = reader["TenLoaiBenh"].ToString(); ;
                                    lb.TrieuChung = reader["TrieuChung"].ToString();
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

            public List<LoaiBenhDTO> selectByKeyWord(string sKeyword)
            {
                string query = string.Empty;
                query += " SELECT *";
                query += " FROM BENH";
                query += " WHERE (malb LIKE CONCAT('%',@sKeyword,'%'))";
                query += " OR (tenloaibenh LIKE CONCAT('%',@sKeyword,'%'))";

                List<LoaiBenhDTO> listBenh = new List<LoaiBenhDTO>();

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
                                    LoaiBenhDTO lb = new LoaiBenhDTO();
                                    lb.MaLB = reader["MaLB"].ToString();
                                    lb.TenLoaiBenh = reader["TenLoaiBenh"].ToString(); ;
                                    lb.TrieuChung = reader["TrieuChung"].ToString();
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

