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
    public class NhanVienDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public NhanVienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public DataTable loadDuLieuNhanVien()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from NHANVIEN";
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
        public DataTable loadDuLieuNhanVienTuMaUsers(string MaNv)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select * from NHANVIEN where MaNV='" + MaNv + "'";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {
                
            }
            return k;
        }
        public bool them(NhanVienDTO nv)
        {

            string query = string.Empty;
            query += "INSERT INTO NHANVIEN(manv,hoten,gioitinh,ngaysinh,chucvu,diachi,sdt) VALUES (@manv,@hoten,@gioitinh,@ngaysinh,@chucvu,@diachi,@sdt)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", nv.MaNhanVien);
                    cmd.Parameters.AddWithValue("@hoten", nv.HoVaTen);
                    cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh);
                    cmd.Parameters.AddWithValue("@chucvu", nv.ChucVu);
                    cmd.Parameters.AddWithValue("@diachi", nv.DiaChi);
                    cmd.Parameters.AddWithValue("@sdt", nv.SDT);
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

        public bool sua(NhanVienDTO bn)
        {
            string query = string.Empty;
            query += "UPDATE NHANVIEN SET manv = @manv, hoten = @hoten, gioitinh = @gioitinh, ngaysinh = @ngaysinh,diachi = @diachi,sdt=@sdt, chucvu=@chucvu WHERE manv = @manv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", bn.MaNhanVien);
                    cmd.Parameters.AddWithValue("@hoten", bn.HoVaTen);
                    cmd.Parameters.AddWithValue("@gioitinh", bn.GioiTinh);
                    cmd.Parameters.AddWithValue("@ngaysinh", bn.NgaySinh);
                    cmd.Parameters.AddWithValue("@diachi", bn.DiaChi);
                    cmd.Parameters.AddWithValue("@sdt", bn.SDT);
                    cmd.Parameters.AddWithValue("@chucvu", bn.ChucVu);
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
        public bool xoa(NhanVienDTO nvDTO)
        {
            string query = string.Empty;
            query += "DELETE FROM NHANVIEN WHERE manv = @manv";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", nvDTO.MaNhanVien);
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
