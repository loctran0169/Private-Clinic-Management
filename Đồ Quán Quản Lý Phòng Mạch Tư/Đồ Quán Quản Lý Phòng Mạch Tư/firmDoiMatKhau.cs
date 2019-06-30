using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPKDAL;
using QLPKDTO;
using QLPKBUS;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class frmDoiMatKhau : Form
    {
        private UsersDTO usDTO = new UsersDTO();
        public frmDoiMatKhau(UsersDTO us)
        {
            InitializeComponent();
            usDTO.MaUS = us.MaUS;
            usDTO.TaiKhoan = us.TaiKhoan;
            usDTO.MatKhau = us.MatKhau;
            usDTO.MaNV = us.MaNV;
            usDTO.MaQH = us.MaQH;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            UsersBUS usBUS = new UsersBUS();
            if (txtMauKhauCu.Text == null)
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ ", "Thông báo");
            else if (txtMauKhauCu.Text != usDTO.MatKhau)
                MessageBox.Show("Bạn nhập sai mật khẩu cũ ", "Thông báo");
            else if (txtMatKhauMoi.Text != txtMatKhauMoi2.Text)
                MessageBox.Show("Mật khẩu mới chưa trùng nhau nhau", "Thông báo");
            else
            { usDTO.MatKhau = txtMatKhauMoi.Text;
                bool kq = usBUS.suamk(usDTO);
                if (kq == false)
                    MessageBox.Show("Đổi mật khẩu thất bại.");

                else
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
            }
        }
    }
}
