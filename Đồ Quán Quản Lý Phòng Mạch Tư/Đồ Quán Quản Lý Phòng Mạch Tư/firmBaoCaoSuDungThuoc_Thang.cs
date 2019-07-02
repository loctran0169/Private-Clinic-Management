using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class firmBaoCaoSuDungThuoc_Thang : Form
    {
        DataTable dt = new DataTable();
        public firmBaoCaoSuDungThuoc_Thang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = loadDuLieu(dtpk.Value.Month, dtpk.Value.Year);
            gcthuoc.DataSource = dt;
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có thông tin trong tháng này");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin trong tháng này");
                return;
            }
            gvthuoc.BestFitColumns();
            rpSuDungThuoc rp = new rpSuDungThuoc();
            rp.GridControl = gcthuoc;
            rp.setThang(dtpk.Value);
            ReportPrintTool printTool = new ReportPrintTool(rp);
            printTool.ShowPreviewDialog();
        }
        public DataTable loadDuLieu(int month, int year)
        {

            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                string query = null;
                query += "SELECT TenThuoc,dv.TenDonVi ,sum(SoLuong) as   'SoLuong', count(TenThuoc) as 'SoLanDung'  ";
                query += "FROM DONTHUOC dt, HOADON hd, THUOC t,DONVITINH dv ";
                query += "where year(hd.NgayLap) =@year and month(hd.NgayLap) = @month and hd.MaPK=dt.MaPK and t.MaThuoc=dt.MaThuoc and dv.MaDV=t.MaDV ";
                query += "group by t.MaThuoc";
                //string sql = "SELECT TenThuoc,dv.TenDonVi ,sum(SoLuong) as   'SoLuong', count(TenThuoc) as 'SoLanDung' FROM CHITIETHOADON ct, HOADON hd, THUOC t,DONVITINH dv where month(hd.NgayLap) = @month and hd.MaHD = ct.MaHD and t.MaThuoc = ct.MaThuoc and dv.MaDV = t.MaDV group by t.MaThuoc";
                MySqlCommand cmd = new MySqlCommand(query, kn);
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
