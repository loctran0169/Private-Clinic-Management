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
    public class ThuocDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public ThuocDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(ThuocDTO bn)
        {

            string query = string.Empty;
            query += "INSERT INTO THUOC(mathuoc,tenthuoc,madv,nsx,hsd,dongia) VALUES (@mathuoc,@tenthuoc,@madv,@nsx,@hsd,@dongia)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mathuoc", bn.MaThuoc1);
                    cmd.Parameters.AddWithValue("@tenthuoc", bn.TenThuoc1);
                    cmd.Parameters.AddWithValue("@madv", bn.MaDV1);
                    cmd.Parameters.AddWithValue("@nsx", bn.NSX1);
                    cmd.Parameters.AddWithValue("@hsd", bn.HSD1);
                    cmd.Parameters.AddWithValue("@dongia", bn.DonGia1);
                    cmd.Parameters.AddWithValue("@soluongton", bn.SoLuongTon1);
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

        public bool sua(ThuocDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE THUOC SET mathuoc = @mathuoc,tenthuoc=@tenthuoc, madv = @madv, nsx = @nsx, hsd = @hsd ,dongia = @dongia  WHERE mathuoc = @mathuoc";

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mathuoc", bn.MaThuoc1);
                    cmd.Parameters.AddWithValue("@tenthuoc", bn.TenThuoc1);
                    cmd.Parameters.AddWithValue("@madv", bn.MaDV1);
                    cmd.Parameters.AddWithValue("@nsx", bn.NSX1);
                    cmd.Parameters.AddWithValue("@hsd", bn.HSD1);
                    cmd.Parameters.AddWithValue("@dongia", bn.DonGia1);

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

        public bool xoa(ThuocDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM THUOC WHERE mathuoc = @mathuoc";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mathuoc", bn.MaThuoc1);
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

        public List<ThuocDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM THUOC";

            List<ThuocDTO> listthuoc = new List<ThuocDTO>();

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
                                ThuocDTO bn = new ThuocDTO();
                                bn.MaThuoc1 = reader["MaThuoc"].ToString();
                                bn.MaDV1 = reader["MaDV"].ToString();
                                bn.NSX1 = (DateTime)reader["NSX"];
                                bn.HSD1 = (DateTime)reader["HSD"];
                                bn.DonGia1 = int.Parse(reader["DonGia"].ToString());
                                bn.SoLuongTon1 = int.Parse(reader["SoLuongTon"].ToString());
                                listthuoc.Add(bn);
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
            return listthuoc;
        }

        public List<ThuocDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM THUOC";
            query += " WHERE (mathuoc LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (tenthuoc LIKE CONCAT('%',@sKeyword,'%'))";

            List<ThuocDTO> listthuoc = new List<ThuocDTO>();

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
                                ThuocDTO bn = new ThuocDTO();
                                bn.MaThuoc1 = reader["MaThuoc"].ToString();
                                bn.MaDV1 = reader["MaDV"].ToString();
                                bn.NSX1 = (DateTime)reader["NSX"];
                                bn.HSD1 = (DateTime)reader["HSD"];
                                bn.DonGia1 = int.Parse(reader["DonGia"].ToString());
                                bn.SoLuongTon1 = int.Parse(reader["SoLuongTon"].ToString());
                                listthuoc.Add(bn);
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
            return listthuoc;
        }

        public DataTable loadDuLieuDonViTinh()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select MaDV, tendonvi from DONVITINH";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {
            }
            return k;
        }

        public DataTable loadDuLieuThuoc()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select mathuoc,tenthuoc,t.MaDV,nsx,HSD,DonGia from DONVITINH dv join THUOC t on dv.Madv = t.MaDV";
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
    }
}
