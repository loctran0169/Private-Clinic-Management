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
        private UsersDTO usDTO = new UsersDTO();

        private NhanVienBUS nvBUS = new NhanVienBUS();
        public firmThongTinNV(UsersDTO us)
        {
            InitializeComponent();
            usDTO.MaUS = us.MaUS;
            usDTO.TaiKhoan = us.TaiKhoan;
            usDTO.MatKhau = us.MatKhau;
            usDTO.MaNV = us.MaNV;
            usDTO.MaQH = us.MaQH;
        }
        private void frmThongTinNV_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = usDTO.MaNV;
            txtTaiKhoan.Text = usDTO.TaiKhoan;
            txtMatKhau.Text = usDTO.MatKhau;
            txtQuyenHan.Text = usDTO.MaQH;
            DataTable k = nvBUS.loadDuLieuNhanVienTuMaUsers(usDTO.MaNV);
            foreach (DataRow row in k.Rows)
            {
                txtMaNhanVien.Text = row[0].ToString();
                txtHoVaTen.Text = row[1].ToString();
                txtGioiTinh.Text = row[2].ToString();
                dtmNgaySinh.Text = row[3].ToString();
                txtDiaChi.Text = row[4].ToString();
                txtSDT.Text = row[5].ToString();
                txtChucVu.Text = row[6].ToString();
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
