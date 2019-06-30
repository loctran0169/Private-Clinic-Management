using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace QLPKDAL
{
    public class LapPhieuKhamDAL
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public LapPhieuKhamDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<LapPhieuKhamDTO> select()
        {
            string query = string.Empty;
            query += "SELECT MAPK,PK.MABN,BN.HOTEN tenbn,PK.MANV,NV.HOTEN tennv,PK.MALB,TRIEUCHUNG ,TENLOAIBENH,NGAYKHAM ";
            query += "FROM PHIEUKHAM PK  ";
            query += "RIGHT JOIN BENHNHAN BN ON PK.MABN=BN.MABN ";
            query += "LEFT JOIN NHANVIEN NV ON PK.MANV=NV.MANV ";
            query += "LEFT JOIN BENH B ON PK.MALB=B.MALB ";


            List<LapPhieuKhamDTO> listPhieuKham = new List<LapPhieuKhamDTO>();
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
                                if (reader["NGAYKHAM"].ToString() != "")
                                {
                                    LapPhieuKhamDTO ds = new LapPhieuKhamDTO();
                                    ds.MaPK1 = reader["MAPK"].ToString();
                                    ds.MaBN1 = reader["MABN"].ToString();
                                    ds.TenBN1 = reader["TENBN"].ToString();
                                    ds.MaBS1 = reader["MANV"].ToString();
                                    ds.TenBS1 = reader["TENNV"].ToString();
                                    ds.MaLB1 = reader["MALB"].ToString();
                                    ds.TenLB1 = reader["TENLOAIBENH"].ToString();
                                    ds.TrieuChung1 = reader["TRIEUCHUNG"].ToString();
                                    ds.NgayKham1 = (DateTime)reader["NGAYKHAM"];

                                    listPhieuKham.Add(ds);
                                }
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
            return listPhieuKham;
        }
        public bool sua(LapPhieuKhamDTO pk)
        {
            string query = string.Empty;
            query += "update PHIEUKHAM set malb=@malb,manv=@manv where mapk=@mapk";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@malb", pk.MaLB1);
                    cmd.Parameters.AddWithValue("@manv", pk.MaBS1);
                    cmd.Parameters.AddWithValue("@mapk", pk.MaPK1);
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
        public bool xoa(LapPhieuKhamDTO pk)
        {
            string query = string.Empty;
            query += "delete from PHIEUKHAM where mapk=@mapk";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    
                    cmd.Parameters.AddWithValue("@mapk", pk.MaPK1);
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
    }
}
