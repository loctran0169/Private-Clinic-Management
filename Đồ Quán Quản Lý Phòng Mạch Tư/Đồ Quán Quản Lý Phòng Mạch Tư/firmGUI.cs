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
    }
}
