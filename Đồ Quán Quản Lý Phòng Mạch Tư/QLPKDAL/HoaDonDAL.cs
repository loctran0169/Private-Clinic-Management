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
    public class HoaDonDAL
    {
        //private string connectionString;

        //public string ConnectionString { get => connectionString; set => connectionString = value; }

        //public HoaDonDAL()
        //{
        //    connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        //}

        //public List<HoaDonDTO> select()
        //{
        //    List<HoaDonDTO> lsHoaDon = new List<HoaDonDTO>();

            
        //    string query = string.Empty;
        //    query += "Select mathuoc,tenthuoc,soluong,donvitinh,dongia,noidungcachdung";
        //    query += " From hoadon, donthuoc, thuoc, donvitinh, cachdungthuoc, phieukham, benhnhan";
        //    query += " Where hoadon.mapk = phieukham.mapk";
        //    query += " and Phieukham.mabn = benhnhan.mabn";
        //    query +=" and Hoadon.mapk = donthuoc.mapk";
        //    query += " and Donthuoc.mathuoc = thuoc.mathuoc";
        //    query += " and Donthuoc.madonvitinh = donvitinh.madonvitinh";
        //    query += " and donthuoc.macachdung = cacdungthuoc.macachdung";

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;

        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        HoaDonDTO kn = new HoaDonDTO();
        //                        hd.HoTen1 = reader["mathuoc"].ToString();
        //                        kn.MaHD1 = reader["tenthuoc"].ToString();
        //                        kn.MaPK1 = reader["soluong"].ToString();
        //                        kn.MaPK1 = reader["donvitinh"].ToString();
        //                        kn.MaPK1 = reader["dongia"].ToString();
        //                        kn.HoTen1 = reader["noidungcachdung"].ToString();
        //                        lsHoaDon.Add(kn);
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
        //    return lsHoaDon;






        //}
    }
}
