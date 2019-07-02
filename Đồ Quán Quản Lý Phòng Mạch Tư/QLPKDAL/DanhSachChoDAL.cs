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
   public class DanhSachChoDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DanhSachChoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DanhSachChoDTO> select(string s)
        {
            string query = string.Empty;
            
            query += "select PK.MABN,HOTEN,NGAYSINH,GIOITINH,SDT,DIACHI,NGAYKHAM ";
            query += "from PHIEUKHAM PK ";
            query += "JOIN BENHNHAN BN ON PK.MABN = BN.MABN ";
            query += "WHERE NGAYKHAM = \""+s+"\" ";
            query += "and  MAPK != all(";
            query += "SELECT MAPK ";
            query += "FROM DONTHUOC) ";
            



            List<DanhSachChoDTO> listBenhNhan = new List<DanhSachChoDTO>();
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
                                DanhSachChoDTO bn = new DanhSachChoDTO();
                                bn.MaBN1 = reader["MaBN"].ToString();
                                bn.NgaySinh1 = (DateTime)reader["NgaySinh"];
                                bn.NgayKham1 = (DateTime)reader["NgayKham"];
                                bn.GioiTinh1 = reader["GioiTinh"].ToString();
                                bn.DiaChi1 = reader["DiaChi"].ToString();
                                bn.HoTen1 = reader["HoTen"].ToString();
                                bn.SDT1 = reader["SDT"].ToString();

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
