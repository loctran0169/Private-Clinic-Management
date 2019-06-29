using QLPKBUS;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmDangNhap : Form
    {
        public firmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            try
            {
                UserDTO us = new UserDTO();
                us.TaiKhoan1 = txtTaiKhoan.Text;
                us.MatKhau1 = txtMatKhau.Text;
                if (txtTaiKhoan.Text == "1" && txtMatKhau.Text == "1")
                    MessageBox.Show("Tài khoản mật khẩu bị từ chối");
                UserBUS bus = new UserBUS();
                DataTable k = bus.dangNhap(us);
                if (k.Rows.Count > 0)
                {
                    //gán các thông tin của người đăng nhập cho user
                    us.MaUS1 = k.Rows[0][0].ToString();
                    us.TaiKhoan1 = k.Rows[0][1].ToString();
                    us.MatKhau1 = k.Rows[0][2].ToString();
                    us.MaNV1 = k.Rows[0][3].ToString();
                    us.MaQH1 = k.Rows[0][4].ToString();
                    MessageBox.Show("Đăng nhập thành công");
                    firmGUI f = new firmGUI(us);
                    this.Hide();
                    f.ShowDialog();//hiển thị form chính
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
