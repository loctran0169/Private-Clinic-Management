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
    public class DanhSachKhamBenhDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DanhSachKhamBenhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(DanhSachKhamBenhDTO ds)
        {


            




            string query = string.Empty;
            query += "UPDATE PHIEUKHAM SET NGAYKHAM=@ngaykham WHERE mabn = @mabn";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mabn", ds.MaBN1);
                    cmd.Parameters.AddWithValue("@ngaykham", ds.NgayKham1);
                    
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

        public List<DanhSachKhamBenhDTO> select()
        {
            string query = string.Empty;
            query += "select BENHNHAN.MABN,HOTEN,NGAYSINH,GIOITINH,DIACHI,SDT,PHIEUKHAM.NGAYKHAM";
            query += " from BENHNHAN left outer JOIN  PHIEUKHAM";
            query += " on BENHNHAN.MaBN=PHIEUKHAM.MaBN ";
            


            List<DanhSachKhamBenhDTO> listDanhSachKhamBenh = new List<DanhSachKhamBenhDTO>();
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
                                DanhSachKhamBenhDTO ds = new DanhSachKhamBenhDTO();
                                ds.MaBN1 = reader["MABN"].ToString();
                                ds.HoTen1 = reader["HOTEN"].ToString();
                                ds.NgaySinh1 = (DateTime)reader["NGAYSINH"];
                                

                                ds.GioiTinh1 = reader["GIOITINH"].ToString();
                                ds.DiaChi1 = reader["DIACHI"].ToString();
                                ds.SDT1 = reader["SDT"].ToString();


                                
                                string str = reader["NGAYKHAM"].ToString();
                                if (str != "")
                                    ds.NgayKham1 = (DateTime)reader["NGAYKHAM"];                                                                                        
                                    listDanhSachKhamBenh.Add(ds);
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
            
            return listDanhSachKhamBenh;

        }
    }
}
    

