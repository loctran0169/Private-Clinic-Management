using MySql.Data.MySqlClient;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKDAL
{
    public class UsersDAL
    {
        //private string connectionString;

        //public string ConnectionString
        //{
        //    get { return connectionString; }
        //    set { connectionString = value; }
        //}

        //public UsersDAL()
        //{
        //    connectionString = ConfigurationManager.AppSettings["ConnectionString"];

        //}
        //public DataTable dangNhap(UsersDTO us)
        //{
        //    MySqlConnection conn = new MySqlConnection(connectionString);
        //    DataTable k = new DataTable();
        //    try
        //    {
        //        conn.Open();
        //        string sql = "select * from USERS where taikhoan=@taikhoan and matkhau=@matkhau";
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan);
        //        cmd.Parameters.AddWithValue("@matkhau", us.MatKhau);
        //        MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
        //        dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
        //        conn.Close();
        //        dt.Dispose();
        //        //conn.Open();
        //        //string sql1 = "select * from USERS where TaiKhoan = '" + us.TaiKhoan + "' and MatKhau='" + us.MatKhau + "'";
        //        //MySqlDataAdapter dt = new MySqlDataAdapter(sql1, conn);

        //        //dt.Fill(k);
        //        return k;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi kết nối " + ex.Message);
        //    }
        //    return k;
        //}
        //public bool doiMatKhau(UsersDTO us)
        //{
        //    MySqlConnection kn = new MySqlConnection(connectionString);
        //    try
        //    {
        //        kn.Open();

        //        string sql1 = "update USERS set MatKhau=N'" + us.MatKhau + "' where MaUS=N'" + us.MaUS + "'";

        //        MySqlCommand cmd = new MySqlCommand(sql1, kn);

        //        int kq = (int)cmd.ExecuteNonQuery();
        //        kn.Close();
        //        if (kq > 0)
        //        {
        //            return true;
        //        }
        //        else
        //            return false;

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Lỗi kết nối" + ex.Message);
        //        return false;
        //    }
        //}
        //public DataTable loadDuLieuUsers()
        //{
        //    DataTable k = new DataTable();
        //    MySqlConnection kn = new MySqlConnection(connectionString);

        //    try
        //    {
        //        kn.Open();
        //        string sql = "select * from USERS";
        //        MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
        //        dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Lỗi kết nối" + e.Message);
        //    }
        //    return k;
        //}
        //public DataTable loadDuLieuNhanVien()
        //{
        //    DataTable k = new DataTable();
        //    MySqlConnection kn = new MySqlConnection(connectionString);

        //    try
        //    {
        //        kn.Open();
        //        string sql = "select MaNV from NHANVIEN";
        //        MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
        //        dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Lỗi kết nối" + e.Message);
        //    }
        //    return k;
        //}
        //public DataTable loadDuLieuQuyenHan()
        //{
        //    DataTable k = new DataTable();
        //    MySqlConnection kn = new MySqlConnection(connectionString);

        //    try
        //    {
        //        kn.Open();
        //        string sql = "select MaQH from QUYENHAN";
        //        MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
        //        dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Lỗi kết nối" + e.Message);
        //    }
        //    return k;
        //}
        //public bool them(UsersDTO usDTO)
        //{

        //    MySqlConnection kn = new MySqlConnection(connectionString);
        //    try
        //    {
        //        kn.Open();
        //        //thêm thông tin đơn vị tính
        //        string sql1 = "insert into USERS values(N'" + usDTO.MaUS + "',N'" + usDTO.TaiKhoan + "',N'" + usDTO.MatKhau + "',N'" + usDTO.MaNV + "',N'" + usDTO.MaQuyenHan + "')";
        //        MySqlCommand cmd = new MySqlCommand(sql1, kn);
        //        int kq = (int)cmd.ExecuteNonQuery();
        //        kn.Close();
        //        if (kq > 0)
        //        {
        //            return true;
        //        }
        //        else
        //            return false;

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Lỗi kết nối" + ex.Message);
        //        return false;
        //    }
        //}
        //public bool sua(UsersDTO usDTO)
        //{
        //    MySqlConnection kn = new MySqlConnection(connectionString);
        //    try
        //    {
        //        kn.Open();
        //        //sửa thông tin thuốc
        //        string sql1 = "update USERS set TaiKhoan=N'" + usDTO.TaiKhoan + "',MatKhau=N'" + usDTO.MatKhau + "',MaNV=N'" + usDTO.MaNV + "',MaQH=N'" + usDTO.MaQuyenHan + "' where MaUS=N'" + usDTO.MaUS + "'";

        //        MySqlCommand cmd = new MySqlCommand(sql1, kn);
        //        int kq = (int)cmd.ExecuteNonQuery();
        //        kn.Close();
        //        if (kq > 0)
        //        {
        //            return true;
        //        }
        //        else
        //            return false;

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Lỗi kết nối" + ex.Message);
        //        return false;
        //    }
        //}
        //public bool xoa(UsersDTO usDTO)
        //{
        //    string query = string.Empty;
        //    query += "DELETE FROM USERS WHERE [MaUS] = @MaUS";
        //    using (MySqlConnection con = new MySqlConnection(ConnectionString))
        //    {

        //        using (MySqlCommand cmd = new MySqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;
        //            cmd.Parameters.AddWithValue("@MaUS", usDTO.MaUS);
        //            try
        //            {
        //                con.Open();
        //                cmd.ExecuteNonQuery();
        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public UsersDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool them(UsersDTO us)
        {

            string query = string.Empty;
            query += "INSERT INTO USERS (maus,taikhoan,matkhau,manv,maqh) VALUES (@maus,@taikhoan,@matkhau,@manv,@maqh)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS);
                    cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau);
                    cmd.Parameters.AddWithValue("@manv", us.MaNV);
                    cmd.Parameters.AddWithValue("@maqh", us.MaQH);
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

        public bool sua(UsersDTO us)
        {
            string query = string.Empty;
            query += "UPDATE USERS SET  taikhoan = @taikhoan, matkhau = @matkhau,manv=@manv,maqh=@maqh WHERE maus = @maus";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS);
                    cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau);
                    cmd.Parameters.AddWithValue("@manv", us.MaNV);
                    cmd.Parameters.AddWithValue("@maqh", us.MaQH);
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

        public bool suamk(UsersDTO us)
        {
            string query = string.Empty;
            query += "UPDATE USERS SET  matkhau = @matkhau WHERE maus = @maus";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS);
                    cmd.Parameters.AddWithValue("@matkhau", us.MatKhau);
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
        public bool xoa(UsersDTO us)
        {
            string query = string.Empty;
            query += "DELETE FROM USERS WHERE maus = @maus";
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maus", us.MaUS);
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

        public List<UsersDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM USERS";

            List<UsersDTO> listuser = new List<UsersDTO>();
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
                                UsersDTO us = new UsersDTO();
                                us.MaUS = reader["MaUS"].ToString();
                                us.MaNV = reader["MaNV"].ToString();
                                us.MaQH = reader["MaQH"].ToString();
                                us.TaiKhoan = reader["TaiKhoan"].ToString(); ;
                                us.MatKhau = reader["MatKhau"].ToString();
                                listuser.Add(us);
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
            return listuser;
        }

        public List<UsersDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT *";
            query += " FROM USERS";
            query += " WHERE (maus LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR (taikhoan LIKE CONCAT('%',@sKeyword,'%'))";

            List<UsersDTO> listuser = new List<UsersDTO>();

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
                                UsersDTO us = new UsersDTO();
                                us.MaUS = reader["MaUS"].ToString();
                                us.MaNV= reader["MaNV"].ToString();
                                us.MaQH = reader["MaQH"].ToString();
                                us.TaiKhoan = reader["TaiKhoan"].ToString(); ;
                                us.MatKhau = reader["MatKhau"].ToString();
                                listuser.Add(us);
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
            return listuser;
        }

        public DataTable loadDuLieuUsers()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string sql = "select * from USERS";
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
        public DataTable loadDuLieuNhanVien()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select MaNhanVien from NHANVIEN";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {

            }
            return k;
        }
        public DataTable loadDuLieuQuyenHan()
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);

            try
            {
                kn.Open();
                string sql = "select MaQH,TenQuyenHan from QUYENHAN";
                MySqlDataAdapter dt = new MySqlDataAdapter(sql, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng

            }
            catch (Exception e)
            {

            }
            return k;
        }

        public bool CheckPass(string tk, string mk)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {

                string sql = "select * from USERS where taikhoan=@taikhoan and MatKhau=@MatKhau";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@taikhoan", tk);
                cmd.Parameters.AddWithValue("@MatKhau", mk);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                if (k.Rows.Count > 0)
                    return true;
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {

            }
            return false;
        }

        public DataTable dangNhap(UsersDTO us)
        {
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                kn.Open();
                string sql = "select * from USERS where taikhoan=@taikhoan and matkhau=@matkhau";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@taikhoan", us.TaiKhoan);
                cmd.Parameters.AddWithValue("@matkhau", us.MatKhau);
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                string s = e.Message;
                int b = 5;
            }
            return k;
        }
    }
}
