using MySql.Data.MySqlClient;
using QLPKDTO;
using QLPKBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmGUI : DevExpress.XtraEditors.XtraForm
    {
        private UsersDTO us = new UsersDTO();
        private LichSuDTO lsDTO = new LichSuDTO();
        private LichSuBUS lsBUS= new LichSuBUS();
        public firmGUI(UsersDTO user)
        {
            us.MaUS = user.MaUS;
            us.TaiKhoan = user.TaiKhoan;
            us.MatKhau = user.MatKhau;
            us.MaNV= user.MaNV;
            us.MaQH = user.MaQH;
            //gán thông tin để tạo lịch sử đăng nhập
            lsDTO.MaUS = us.MaUS;
            lsDTO.ThoiGianDN = DateTime.Now;
            //thêm lịch sử đăng nhập cho tài khoản mỗi khi đăng nhập
            lsBUS.them(lsDTO);

            InitializeComponent();
            //Status bar
            bartk.Caption = "Tài Khoản: "+us.TaiKhoan;
            bartt.Caption = "Trạng thái: Đã đăng nhập";
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmLichSuDN));
            if (frm == null)
            {
                firmLichSuDN forms = new firmLichSuDN(us, lsDTO);
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmDoiMatKhau));
            if (frm == null)
            {
                frmDoiMatKhau forms = new frmDoiMatKhau(us);
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmThongTinNV));
            if (frm == null)
            {
                firmThongTinNV forms = new firmThongTinNV(us);
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmNguoiDung));
            if (frm == null)
            {
                firmNguoiDung forms = new firmNguoiDung();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmQuyenHan));
            if (frm == null)
            {
                firmQuyenHan forms = new firmQuyenHan();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmNhanVien));
            if (frm == null)
            {
                firmNhanVien forms = new firmNhanVien();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBenhNhan));
            if (frm == null)
            {
                firmBenhNhan forms = new firmBenhNhan();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmDanhSachKhamBenh));
            if (frm == null)
            {
                firmDanhSachKhamBenh forms = new firmDanhSachKhamBenh();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmDanhSachCho));
            if (frm == null)
            {
                firmDanhSachCho forms = new firmDanhSachCho();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmPhieuKham));
            if (frm == null)
            {
                firmPhieuKham forms = new firmPhieuKham();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmLapDonThuoc));
            if (frm == null)
            {
                firmLapDonThuoc forms = new firmLapDonThuoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmHoaDon));
            if (frm == null)
            {
                firmHoaDon forms = new firmHoaDon();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            
            Form frm = kiemtraform(typeof(firmThamSo));
            if (frm == null)
            {
                firmThamSo forms = new firmThamSo();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmThuoc));
            if (frm == null)
            {
                firmThuoc forms = new firmThuoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmDonVi));
            if (frm == null)
            {
                firmDonVi forms = new firmDonVi();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmCachDung));
            if (frm == null)
            {
                firmCachDung forms = new firmCachDung();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBenh));
            if (frm == null)
            {
                firmBenh forms = new firmBenh();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmSaoLuu));
            if (frm == null)
            {
                firmSaoLuu forms = new firmSaoLuu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBaoCaoSuDungThuoc_Thang));
            if (frm == null)
            {
                firmBaoCaoSuDungThuoc_Thang forms = new firmBaoCaoSuDungThuoc_Thang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }



        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBaoCaoThang));
            if (frm == null)
            {
                firmBaoCaoThang forms = new firmBaoCaoThang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void firmGUI_Load(object sender, EventArgs e)
        {
            if(us.MaQH=="QH002")// khi người dùng đăng nhập với quyền hạn là nhân viên bình thường thì sẽ ẩn đi những chức năng người này không được phép sử dụng
            {
                this.barBtnNguoiDung.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                this.barBtnVaiTro.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                this.barBtnNhatKy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                this.ribbonPageSaoLuu.Visible = false;
                this.ribbonPageNhanVien.Visible = false;
                this.ribbonPageDanhMuc.Visible = false;
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                firmDangNhap dt = new firmDangNhap();
                this.Hide();
                dt.ShowDialog();
            }
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = kiemtraform(typeof(firmGioiThieu));
            if (frm == null)
            {
                firmGioiThieu forms = new firmGioiThieu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmKhoiPhuc));
            if (frm == null)
            {
                firmKhoiPhuc forms = new firmKhoiPhuc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void firmGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
