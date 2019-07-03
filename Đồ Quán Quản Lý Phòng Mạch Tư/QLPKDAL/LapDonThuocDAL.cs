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
   public class LapDonThuocDAL
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public LapDonThuocDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public DataTable loadPKtoCombobox()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT MAPK FROM PHIEUKHAM";
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

        public DataTable loadThuoctoCombobox()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT MATHUOC,TENTHUOC FROM THUOC";
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
        public DataTable loadCDctoCombobox()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "SELECT * FROM CACHDUNG";
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

        public bool them(LapDonThuocDTO dt)
        {
            string query = string.Empty;
            query += "insert DONTHUOC set MAPK=@MAPK,MATHUOC=@MATHUOC,SOLUONG=@SOLUONG,MACD=@MACD";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@MAPK",dt.MaPK1 );
                    cmd.Parameters.AddWithValue("@MATHUOC", dt.MaThuoc1);
                    cmd.Parameters.AddWithValue("@SOLUONG", dt.SoLuong1);
                    cmd.Parameters.AddWithValue("@MACD", dt.MaCD1);
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

        public bool sua(LapDonThuocDTO dt)
        {
            string query = string.Empty;
            query += "update DONTHUOC set MATHUOC=@MATHUOC,SOLUONG=@SOLUONG,MACACHDUNG=@MACACHDUNG where MAPK=@MAPK and MATHUOC=@MATHUOC";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@MAPK", dt.MaPK1);
                    cmd.Parameters.AddWithValue("@MATHUOC", dt.MaThuoc1);
                    cmd.Parameters.AddWithValue("@SOLUONG", dt.SoLuong1);
                    cmd.Parameters.AddWithValue("@MACACHDUNG", dt.MaCD1);
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
        public bool xoa(LapDonThuocDTO dt)
        {
            string query = string.Empty;
            query += "delete from DONTHUOC where mathuoc=@MATHUOC and mapk=@MAPK";


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@MAPK", dt.MaPK1);
                    cmd.Parameters.AddWithValue("@MATHUOC", dt.MaThuoc1);
                   
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
        public List<LapDonThuocDTO> select(string s)
        {
            string query = string.Empty;
            query += "SELECT BN.HOTEN,TrieuChung,TenLoaiBenh,DT.MaThuoc,TenThuoc,SoLuong,TenDonVi,DonGia,DT.MACD,CachDung ";

            query += "FROM DONTHUOC DT ";

            query += "RIGHT JOIN PHIEUKHAM PK ON DT.MAPK=PK.MAPK ";

            query += "LEFT JOIN CACHDUNG CD ON DT.MACD=CD.MACD ";
            query += "LEFT JOIN THUOC T ON T.MATHUOC= DT.MATHUOC ";
            query += "LEFT JOIN DONVITINH DVT ON DVT.MaDV=T.MaDV ";
            query += " JOIN BENHNHAN BN on BN.MABN=PK.MABN ";
            query += " JOIN BENH B ON PK.MALB=B.MALB ";
            query += "WHERE DT.MAPK=\""+s+"\"";


            List<LapDonThuocDTO> list = new List<LapDonThuocDTO>();
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
                                LapDonThuocDTO dt = new LapDonThuocDTO();
                                dt.MaThuoc1 = reader["MaThuoc"].ToString();
                                dt.Tenthuoc1 = reader["TenThuoc"].ToString();
                                dt.SoLuong1 =int.Parse(reader["Soluong"].ToString());
                                dt.TenDonvi1 = reader["TenDonVi"].ToString();
                                dt.DonGia1 = int.Parse(reader["DonGia"].ToString());
                                dt.MaCD1 = reader["MACD"].ToString();
                                dt.CachDung1 = reader["CachDung"].ToString();
                                dt.TenBN1 = reader["HoTen"].ToString();
                                dt.TrieuChung1 = reader["TrieuChung"].ToString();
                                dt.TenLB1 = reader["TenLoaiBenh"].ToString();
                                list.Add(dt);
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
            return list ;
        }
    }
}
