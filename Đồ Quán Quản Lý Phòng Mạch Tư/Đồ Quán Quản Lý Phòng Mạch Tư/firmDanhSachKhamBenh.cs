using DevExpress.XtraReports.UI;
using QLPKBUS;
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
    public partial class firmDanhSachKhamBenh : Form
    {
        BenhNhanBUS bus = new BenhNhanBUS();
        DataTable dt = new DataTable();
        public firmDanhSachKhamBenh()
        {
            InitializeComponent();
        }

        private void firmDanhSachKhamBenh_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin trong tháng này");
                return;
            }
            gvdanhsach.BestFitColumns();

            prDanhSachKhamBenh rp = new prDanhSachKhamBenh();
            rp.GridControl = gcdanhsach;
            rp.setNgay(dateTimePicker1.Value.Date);
            ReportPrintTool printTool = new ReportPrintTool(rp);
            printTool.ShowPreviewDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dt = bus.loadDanhSachKhamBenh(dateTimePicker1.Value.Date);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Load danh sách thành công");
                gcdanhsach.DataSource = dt;
            }
            else
            {
                MessageBox.Show("không có sánh sách bệnh nhân");
            }
        }
    }
}
