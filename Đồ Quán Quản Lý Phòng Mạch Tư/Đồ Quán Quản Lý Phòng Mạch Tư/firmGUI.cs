using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            Form fm = new firmDoiMatKhau();
            fm.ShowDialog();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmThongTinNV fm = new firmThongTinNV();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmNguoiDung fm = new firmNguoiDung();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmQuyenHan fm = new firmQuyenHan();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmNhanVien fm = new firmNhanVien();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmBenhNhan fm = new firmBenhNhan();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmDanhSachKhamBenh fm = new firmDanhSachKhamBenh();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmLapDanhSachKhamBenh fm = new firmLapDanhSachKhamBenh();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmPhieuKham fm = new firmPhieuKham();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmLapDonThuoc fm = new firmLapDonThuoc();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmHoaDon fm = new firmHoaDon();
            fm.MdiParent = this;
            fm.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmBanThuoc fm = new firmBanThuoc();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
