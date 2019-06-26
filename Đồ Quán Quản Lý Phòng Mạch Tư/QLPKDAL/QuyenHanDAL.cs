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
    public class QuyenHanDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public QuyenHanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(QuyenHanDTO qh)
        {

            string query = string.Empty;
            query += "INSERT INTO QUYENHAN (tenquyenhan,noidung) VALUES (@tenquyenhan,@noidung)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenquyenhan", qh.TenQuyenHan1);
                    cmd.Parameters.AddWithValue("@noidung", qh.NoiDung1);
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

        public bool sua(QuyenHanDTO qh)
        {
            string query = string.Empty;
            query += "UPDATE BENH SET maqh = @maqh, tenquyenhan = @tenquyenhan, noidung = @noidung WHERE maqh = @maqh";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maqh", qh.MaQH1);
                    cmd.Parameters.AddWithValue("@tenquyenhan", qh.TenQuyenHan1);
                    cmd.Parameters.AddWithValue("@noidung", qh.NoiDung1);
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

        public bool xoa(QuyenHanDTO qh)
        {
            string query = string.Empty;
            query += "DELETE FROM QUYENHAN WHERE maqh = @maqh";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maqh", qh.MaQH1);
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

        public List<QuyenHanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM QUYENHAN";

            List<QuyenHanDTO> listquyenhan = new List<QuyenHanDTO>();
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
                                QuyenHanDTO qh = new QuyenHanDTO();
                                qh.MaQH1 = int.Parse(reader["MaQH"].ToString());
                                qh.TenQuyenHan1 = reader["TenQuyenHan"].ToString(); ;
                                qh.NoiDung1 = reader["NoiDung"].ToString();
                                listquyenhan.Add(qh);
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
            return listquyenhan;
        }

        public List<QuyenHanDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM QUYENHAN";
            query += " WHERE (maqh LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (tenquyenhan LIKE CONCAT('%',@sKeyword,'%'))";

            List<QuyenHanDTO> listquyenhan = new List<QuyenHanDTO>();

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
                                QuyenHanDTO qh = new QuyenHanDTO();
                                qh.MaQH1 = int.Parse(reader["MaQH"].ToString());
                                qh.TenQuyenHan1 = reader["TenQuyenHan"].ToString(); ;
                                qh.NoiDung1 = reader["NoiDung"].ToString();
                                listquyenhan.Add(qh);
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
            return listquyenhan;
        }
    }
}
