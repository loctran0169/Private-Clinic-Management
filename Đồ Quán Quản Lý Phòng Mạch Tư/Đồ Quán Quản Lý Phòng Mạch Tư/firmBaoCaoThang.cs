using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmBaoCaoThang : Form
    {
        DataTable dt = new DataTable();
        public firmBaoCaoThang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt=loadDuLieu(dtpk.Value.Month, dtpk.Value.Year);
            gcDoanhThu.DataSource = dt;
            if (dt.Rows.Count==0)
                MessageBox.Show("Không có thông tin trong tháng này");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin trong tháng này");
                return;
            }
            gvdoanhthu.BestFitColumns();

            rpDoanhThu rp = new rpDoanhThu();
            rp.GridControl = gcDoanhThu;
            rp.setThang(dtpk.Value);
            ReportPrintTool printTool = new ReportPrintTool(rp);
            printTool.ShowPreviewDialog();
        }
        public DataTable loadDuLieu(int month, int year)
        {

            DataTable k = new DataTable();
            k.Columns.Add("NgayLap", typeof(DateTime));
            k.Columns.Add("SoLuongBenhNhan", typeof(int));
            k.Columns.Add("DoanhThu", typeof(string));
            k.Columns.Add("TyLe", typeof(float));
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {

                string sql = "SELECT NgayLap,COUNT(*) as   'SoLuongBenhNhan', sum(tongtien) as 'DoanhThu',sum(tongtien)*100/(SELECT sum(tongtien) " +
                    "FROM HOADON where year(HOADON.NgayLap)= @year and month(HOADON.NgayLap) = @month) as 'TyLe'FROM HOADON " +
                    "where year(HOADON.NgayLap)= @year and month(HOADON.NgayLap) = @month " +
                    "group by NgayLap";
                MySqlCommand cmd = new MySqlCommand(sql, kn);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);
                kn.Open();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();
            }
            catch (Exception e)
            {
                string s = e.Message;
                int a = 3;
            }
            return k;
        }
    }
}
