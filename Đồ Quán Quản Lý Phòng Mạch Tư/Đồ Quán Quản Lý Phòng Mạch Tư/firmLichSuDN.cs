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
using QLPKBUS;
using QLPKDTO;
namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmLichSuDN : Form
    {
        private UsersDTO usDTO = new UsersDTO();
        private LichSuDTO lsDTO = new LichSuDTO();
        private LichSuBUS lsBUS = new LichSuBUS();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        public firmLichSuDN(UsersDTO us,LichSuDTO ls)
        {
            InitializeComponent();
            usDTO.MaUS = us.MaUS;
            usDTO.TaiKhoan = us.TaiKhoan;
            usDTO.MatKhau = us.MatKhau;
            usDTO.MaNV = us.MaNV;
            usDTO.MaQH = us.MaQH;
            lsDTO.MaUS = ls.MaUS;
            lsDTO.ThoiGianDN = ls.ThoiGianDN;
        }

      
        private void dataGridViewLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow;
            indexrow = e.RowIndex;
            if (indexrow != -1)
            {
                int r = dataGridViewLS.CurrentRow.Index;
                DataGridViewRow row = dataGridViewLS.Rows[r];
                usDTO.MaNV= row.Cells[1].Value.ToString();
                HienThiThongTinLSDN();
            }
           
        }
        private void HienThiThongTinLSDN()
        {
            if (dataGridViewLS.RowCount > 0)

            {
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

        }

        private void frmLichSuDN_Load(object sender, EventArgs e)
        {
            lsBUS.them(lsDTO);
            dataGridViewLS.DataSource = lsBUS.loadDuLieuloadDuLieuLichSuDangNhap();
            HienThiThongTinLSDN();
        }

        private void btnXoaLSDN_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa lịch sử đăng nhập","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                lsBUS.xoa();
                dataGridViewLS.DataSource = lsBUS.loadDuLieuloadDuLieuLichSuDangNhap();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
