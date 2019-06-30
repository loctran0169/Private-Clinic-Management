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
        //public DataTable loadata()
        //{
        //    DataTable k = new DataTable();
        //    MySqlConnection kn = new MySqlConnection(connectionString);
        //    try
        //    {
        //        kn.Open();
        //        string query = string.Empty;
        //        query += "SELECT BN.HOTEN,TrieuChung,TenLoaiBenh,DT.MaThuoc,TenThuoc,SoLuong,TenDonVi,DonGia,CachDung ";

        //        query += "FROM DONTHUOC DT ";

        //        query += "JOIN PHIEUKHAM PK ON DT.MAPK=PK.MAPK ";

        //        query += "JOIN CACHDUNG CD ON DT.MACACHDUNG=CD.MACD ";
        //        query += "JOIN THUOC T ON T.MATHUOC= DT.MATHUOC ";
        //        query += "JOIN DONVITINH DVT ON DVT.MaDV=T.MaDV ";
        //        query += "JOIN BENHNHAN BN on BN.MABN=PK.MABN ";
        //        query += "JOIN BENH B ON PK.MALB=B.MALB ";
        //        query += "WHERE BN.MABN=" + s;
        //        MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
        //        dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
        //        kn.Close();
        //        dt.Dispose();

        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return k;
        //}
        public List<LapDonThuocDTO> select(string s)
        {
            string query = string.Empty;
            query += "SELECT BN.HOTEN,TrieuChung,TenLoaiBenh,DT.MaThuoc,TenThuoc,SoLuong,TenDonVi,DonGia,CachDung ";

            query += "FROM DONTHUOC DT ";

            query += "JOIN PHIEUKHAM PK ON DT.MAPK=PK.MAPK ";

            query += "JOIN CACHDUNG CD ON DT.MACACHDUNG=CD.MACD ";
            query += "JOIN THUOC T ON T.MATHUOC= DT.MATHUOC ";
            query += "JOIN DONVITINH DVT ON DVT.MaDV=T.MaDV ";
            query += "JOIN BENHNHAN BN on BN.MABN=PK.MABN ";
            query += "JOIN BENH B ON PK.MALB=B.MALB ";
            query += "WHERE BN.MABN="+s;


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
