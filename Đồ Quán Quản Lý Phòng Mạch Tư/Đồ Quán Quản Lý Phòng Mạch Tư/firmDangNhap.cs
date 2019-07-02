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
        //private UserBUS UsBus;
        //public firmDangNhap()
        //{
        //    InitializeComponent();

        //}

        //private void btnDangNhap_Click(object sender, EventArgs e)
        //{
        //    //1. Map data from GUI
        //    UserDTO UsDTO;
        //    UsDTO = new UserDTO();
        //    UsDTO.TaiKhoan = txtTaiKhoan.Text;
        //    UsDTO.MatKhau = txtMatKhau.Text;
        //    UsDTO.MaNV = null;
        //    UsDTO.MaQuyenHan = null;


        //    DataTable k = UsBus.dangNhap(UsDTO);
        //    if (k.Rows.Count > 0)
        //    {
        //        //gán các thông tin của người đăng nhập cho user
        //        UsDTO.MaUS = k.Rows[0][0].ToString();
        //        UsDTO.TaiKhoan = k.Rows[0][1].ToString();
        //        UsDTO.MatKhau = k.Rows[0][2].ToString();
        //        UsDTO.MaNV = k.Rows[0][3].ToString();
        //        UsDTO.MaQuyenHan = k.Rows[0][4].ToString();

        //        firmGUI f = new firmGUI(UsDTO);
        //        this.Hide();
        //        f.ShowDialog();//hiển thị form chính

        //    }
        //    else
        //    {
        //        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }

        //}

        //private void frmDangNhap_Load(object sender, EventArgs e)
        //{
        //    UsBus = new UserBUS();
        //}

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
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
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            try
            {
                UsersDTO us = new UsersDTO();
                us.TaiKhoan = txtTaiKhoan.Text;
                us.MatKhau = txtMatKhau.Text;
                if (txtTaiKhoan.Text == "1" && txtMatKhau.Text == "1")
                {
                    MessageBox.Show("Tài khoản mật khẩu bị từ chối");
                    return;
                }
                UsersBUS bus = new UsersBUS();
                DataTable k = bus.dangNhap(us);
                if (k.Rows.Count > 0)
                {
                    //gán các thông tin của người đăng nhập cho user
                    us.MaUS = k.Rows[0][0].ToString();
                    us.TaiKhoan = k.Rows[0][1].ToString();
                    us.MatKhau = k.Rows[0][2].ToString();
                    us.MaNV = k.Rows[0][3].ToString();
                    us.MaQH = k.Rows[0][4].ToString();
                    MessageBox.Show("Đăng nhập thành công");
                    firmGUI f = new firmGUI(us);
                    this.Hide();
                    f.ShowDialog();//hiển thị form chính
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void firmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
