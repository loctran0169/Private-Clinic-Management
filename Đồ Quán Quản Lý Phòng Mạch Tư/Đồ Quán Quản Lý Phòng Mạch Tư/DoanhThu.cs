using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class DoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public DoanhThu()
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
                //pccReport.PrintableComponent = control;
            }
        }
    }
}
