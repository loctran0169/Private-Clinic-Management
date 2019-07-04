using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class rpDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDoanhThu()
        {
            InitializeComponent();
        }
        private GridControl control;
        public GridControl GridControl
        {
            get
            {
                return control;
            }
            set
            {
                control = value;
                print.PrintableComponent = control;

            }
        }
        public void setThang(DateTime t) { thang.Text = "Tháng: "+t.ToString("MM-yyyy"); }

        private void date_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            date.Text = string.Format("Bình Dương, Ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }
    }
}
