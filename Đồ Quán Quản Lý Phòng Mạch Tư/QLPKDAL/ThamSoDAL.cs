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
    public class ThamSoDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public ThamSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool sua(ThamSoDTO lb)
        {
            string query = string.Empty;
            query += "UPDATE THAMSO SET mats = @mats, tenthamso = @tenthamso, giatri = @giatri WHERE mats = @mats";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mats", lb.MaTS1);
                    cmd.Parameters.AddWithValue("@tenthamso", lb.TenThamSo1);
                    cmd.Parameters.AddWithValue("@giatri", lb.GiaTri1);
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

        

        public List<ThamSoDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM THAMSO";

            List<ThamSoDTO> listthamso = new List<ThamSoDTO>();
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
                                ThamSoDTO bn = new ThamSoDTO();
                                bn.MaTS1 = reader["MaTS"].ToString();
                                bn.GiaTri1 = int.Parse(reader["GiaTri"].ToString());
                                bn.TenThamSo1 = reader["TenThamSo"].ToString();
                                listthamso.Add(bn);
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
            return listthamso;
        }

        //public List<ThamSoDTO> selectByKeyWord(string sKeyword)
        //{
        //    string query = string.Empty;
        //    query += " SELECT *";
        //    query += " FROM THAMSO";
        //    query += " WHERE (mats LIKE CONCAT('%',@sKeyword,'%'))";
        //    query += " OR (tenthamso LIKE CONCAT('%',@sKeyword,'%'))";

        //    List<ThamSoDTO> listthamso = new List<ThamSoDTO>();

        //    using (MySqlConnection con = new MySqlConnection(ConnectionString))
        //    {

        //        using (MySqlCommand cmd = new MySqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;
        //            cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
        //            try
        //            {
        //                con.Open();
        //                MySqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        ThamSoDTO ts = new ThamSoDTO();
        //                        ts.MaTS1 = int.Parse(reader["MaTS"].ToString());
        //                        ts.TenThamSo1 = reader["TenThamSo"].ToString(); ;
        //                        ts.GiaTri1 = int.Parse(reader["GiaTri"].ToString());
        //                        listthamso.Add(ts);
        //                    }
        //                }

        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                return null;
        //            }
        //        }
        //    }
        //    return listthamso;
        //}
    }
}
