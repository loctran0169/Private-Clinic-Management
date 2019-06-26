using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

        

        public bool sua(ThamSoDTO ts)
        {
            string query = string.Empty;
            query += "UPDATE THAMSO SET  tenthamso = @tenthamso,giatri=@giatri  WHERE mathamso = @mats";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mats", ts.MaTS1);
                    cmd.Parameters.AddWithValue("@tenthamso", ts.TenTS1);
                    cmd.Parameters.AddWithValue("@giatri",ts.GiaTri1);                    
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

            List<ThamSoDTO> listThamSo = new List<ThamSoDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ThamSoDTO ts = new ThamSoDTO();
                                ts.MaTS1 = reader["mathamso"].ToString();
                                
                                ts.TenTS1 = reader["tenthamso"].ToString();
                                ts.GiaTri1 = int.Parse(reader["giatri"].ToString());
                                listThamSo.Add(ts);
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
            return listThamSo;
        }

        
    }
}
