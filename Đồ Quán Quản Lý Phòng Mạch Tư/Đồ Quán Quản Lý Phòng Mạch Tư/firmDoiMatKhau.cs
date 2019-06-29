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
    public partial class firmDoiMatKhau : Form
    {
        UserBUS bus = new UserBUS();
        private UserDTO us = new UserDTO();
        public firmDoiMatKhau(UserDTO user)
        {
            us.MaUS1 = user.MaUS1;
            us.TaiKhoan1 = user.TaiKhoan1;
            us.MatKhau1 = user.MatKhau1;
            us.MaNV1 = user.MaNV1;
            us.MaQH1 = user.MaQH1;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_mkc.Text == null)
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ ", "Thông báo");
            else if (bus.CheckPass(us.TaiKhoan1,tb_mkc.Text) == false)
                MessageBox.Show("Bạn nhập sai mật khẩu cũ ", "Thông báo");
            else if (tb_mk1.Text != tb_mk2.Text)
                MessageBox.Show("Mật khẩu mới chưa trùng nhau nhau", "Thông báo");
            else
            {
                //us.MaUS1 = firmGUI.;
                us.MatKhau1 = tb_mk1.Text;
                bool kq = bus.sua(us);
                if (kq == false)
                    MessageBox.Show("Đổi mật khẩu thất bại.");

                else
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    tb_mk1.Text = tb_mkc.Text = tb_mk2.Text = null;
                }
            }
        }
    }
}
