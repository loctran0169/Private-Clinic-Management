using DevExpress.XtraReports.UI;
using QLPKBUS;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmHoaDon : Form
    {
        HoaDonBUS bus = new HoaDonBUS();
        DataTable dt_gv = new DataTable();
        DataTable pk = new DataTable();
        public firmHoaDon()
        {
            InitializeComponent();
            
        }

        private void firmHoaDon_Load(object sender, EventArgs e)
        {
            tb_tienkham.Text = bus.LoadThamSo();
        }

        private void bt_xem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Hóa đơn đã thanh toán");
                return;
            }
            else if(string.IsNullOrEmpty(tb_hoten.Text)|| string.IsNullOrEmpty(tb_tienkham.Text))
            {
                MessageBox.Show("Chưa nhập phiếu khám");
                return;
            }
            try
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHD1 = TaoMaTuDong();
                hd.MaPK1 = tb_pk.Text;
                hd.NgayLap1 = DateTime.Now.Date;
                hd.TienThuoc1 = int.Parse(tb_tienthuoc.Text);
                hd.TongTien1 = int.Parse(tb_tongtien.Text);
                tb_mahd.Text = hd.MaHD1;
                bool kq = bus.them(hd);
                if (kq == true)
                {
                    MessageBox.Show("lập hóa đơn thành công.");
                    checkBox1.Checked = true;
                }
                else
                    MessageBox.Show("Hóa đơn đã được lập hoặc kết nối bị ngắt");
            }
            catch(Exception ex)
            {

            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            try
            {
                pk = bus.LoadTienThuoc(tb_pk.Text);
                if (pk.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông tin phiếu khám");
                    return;
                }
                tb_hoten.Text = pk.Rows[0][0].ToString();
                tb_tienthuoc.Text = pk.Rows[0][1].ToString();
                string hd = bus.TimHoaDon(tb_pk.Text);
                if (string.IsNullOrEmpty(hd))
                {                    
                    checkBox1.Checked = false;
                    tb_mahd.Text = null;
                }       
                else
                {
                    tb_mahd.Text = hd;
                    checkBox1.Checked = true;
                }
                tb_tongtien.Text = (int.Parse(tb_tienkham.Text) +int.Parse(tb_tienthuoc.Text)).ToString();
                dt_gv = bus.loadDuLieu(tb_pk.Text);
                gchd.DataSource = dt_gv;
            }
            catch(Exception ex)
            {

            }
            //dataGridView1.DataSource = gv;
        }

        private string TaoMaTuDong()
        {
            DataTable dt = new DataTable();

            dt = bus.loadToDataTable();
            int coso = 0;
            if (dt.Rows.Count == 0)
            {
                coso = 1;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
            {
                coso = 2;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1)
            {
                coso = 1;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
                    {
                        coso = int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
                        break;
                    }
                }
                coso = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1;
            }

            //Sau khi lấy được cơ số thứ tự của thuốc, ta gắn thêm tiền tố T vào

            string ma = "";
            if (coso < 10)
                return ma = "HD00" + coso;
            else if (coso < 100)
                return ma = "HD0" + coso;
            else
                return ma = "HD" + coso;
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            if (dt_gv.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có thông tin");
                return;
            }
            gvhd.BestFitColumns();

            rpHoaDon rp = new rpHoaDon();
            rp.GridControl = gchd;
            rp.setName(tb_hoten.Text);
            rp.setNgayKham((DateTime)pk.Rows[0][2]);
            ReportPrintTool printTool = new ReportPrintTool(rp);
            printTool.ShowPreviewDialog();

        }
    }
}
