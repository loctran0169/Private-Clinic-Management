using MySql.Data.MySqlClient;
using QLPKDTO;
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
        private UserDTO us = new UserDTO();
        public firmGUI(UserDTO user)
        {
            us.MaUS1 = user.MaUS1;
            us.TaiKhoan1 = user.TaiKhoan1;
            us.MatKhau1 = user.MatKhau1;
            us.MaNV1 = user.MaNV1;
            us.MaQH1 = user.MaQH1;

            InitializeComponent();
            //Status bar
            bartk.Caption = "Tài Khoản: "+us.TaiKhoan1;
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
                firmLichSuDN forms = new firmLichSuDN();
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
            Form frm = kiemtraform(typeof(firmDoiMatKhau));
            if (frm == null)
            {
                UserDTO user = new UserDTO();
                user.MaUS1 = us.MaUS1;
                user.TaiKhoan1 = us.TaiKhoan1;
                user.MatKhau1 = us.MatKhau1;
                user.MaNV1 = us.MaNV1;
                user.MaQH1 = us.MaQH1;
                firmDoiMatKhau forms = new firmDoiMatKhau(user);
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
                firmThongTinNV forms = new firmThongTinNV();
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
            Form frm = kiemtraform(typeof(firmLapDanhSachKhamBenh));
            if (frm == null)
            {
                firmLapDanhSachKhamBenh forms = new firmLapDanhSachKhamBenh();
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
            Form frm = kiemtraform(typeof(firmBanThuoc));
            if (frm == null)
            {
                firmBanThuoc forms = new firmBanThuoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
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
            Form frm = kiemtraform(typeof(firmCaLam));
            if (frm == null)
            {
                firmCaLam forms = new firmCaLam();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBaoCaoSuDungThuoc_Ngay));
            if (frm == null)
            {
                firmBaoCaoSuDungThuoc_Ngay forms = new firmBaoCaoSuDungThuoc_Ngay();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
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

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBaoCaoNgay));
            if (frm == null)
            {
                firmBaoCaoNgay forms = new firmBaoCaoNgay();
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
            //MessageBox.Show(int.Parse(("BN001").Substring(2,3)).ToString());
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
            if (MessageBox.Show("Bạn muốn đăng xuất chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                firmDangNhap f = new firmDangNhap();
                this.Hide();
                f.ShowDialog();
               
               //hiển thị form chính
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
    }
}
