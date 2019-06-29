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
    public partial class firmThongTinNV : Form
    {
        private UserDTO usDTO = new UserDTO();

        private NhanVienBUS nvBUS = new NhanVienBUS();
        public firmThongTinNV()
        {
            InitializeComponent();
        }
        private void frmThongTinNV_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = usDTO.MaNV1;
            txtTaiKhoan.Text = usDTO.TaiKhoan1;
            txtMatKhau.Text = usDTO.MatKhau1;
            txtQuyenHan.Text = usDTO.MaQH1;
            DataTable k = nvBUS.loadDuLieuNhanVienTuMaUsers(usDTO.MaNV1);
            foreach (DataRow row in k.Rows)
            {
                txtHoVaTen.Text = row[1].ToString();
                dtmNgaySinh.Text = row[2].ToString();
                txtGioiTinh.Text = row[3].ToString();
                txtSDT.Text = row[4].ToString();
                txtDiaChi.Text = row[5].ToString();
                txtChucVu.Text = row[6].ToString();
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
