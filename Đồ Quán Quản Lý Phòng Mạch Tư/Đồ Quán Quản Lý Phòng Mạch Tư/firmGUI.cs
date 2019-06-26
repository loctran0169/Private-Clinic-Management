using MySql.Data.MySqlClient;
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
        public firmGUI()
        {
            InitializeComponent();
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
            Form fm = new firmDoiMatKhau();
            fm.ShowDialog();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmThongTinNV));
            firmThongTinNV fm = new firmThongTinNV();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmNguoiDung));
            firmNguoiDung fm = new firmNguoiDung();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmQuyenHan));
            firmQuyenHan fm = new firmQuyenHan();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmNhanVien));
            firmNhanVien fm = new firmNhanVien();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBenhNhan));
            firmBenhNhan fm = new firmBenhNhan();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmDanhSachKhamBenh));
            firmDanhSachKhamBenh fm = new firmDanhSachKhamBenh();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmLapDanhSachKhamBenh));
            firmLapDanhSachKhamBenh fm = new firmLapDanhSachKhamBenh();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmPhieuKham));
            firmPhieuKham fm = new firmPhieuKham();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmLapDonThuoc));
            firmLapDonThuoc fm = new firmLapDonThuoc();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmHoaDon));
            firmHoaDon fm = new firmHoaDon();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBanThuoc));
            firmBanThuoc fm = new firmBanThuoc();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmThamSo));
            firmThamSo fm = new firmThamSo();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmThuoc));
            firmThuoc fm = new firmThuoc();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmDonVi));
            firmDonVi fm = new firmDonVi();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmCachDung));
            firmCachDung fm = new firmCachDung();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBenh));
            firmBenh fm = new firmBenh();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmCaLam));
            firmCaLam fm = new firmCaLam();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmCaLam));
            firmBaoCaoSuDungThuoc_Ngay fm = new firmBaoCaoSuDungThuoc_Ngay();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBaoCaoSuDungThuoc_Thang));
            firmBaoCaoSuDungThuoc_Thang fm = new firmBaoCaoSuDungThuoc_Thang();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBaoCaoNgay));
            firmBaoCaoNgay fm = new firmBaoCaoNgay();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(firmBaoCaoThang));
            firmBaoCaoThang fm = new firmBaoCaoThang();
            fm.MdiParent = this;
            fm.Show();
        }

        private void firmGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
