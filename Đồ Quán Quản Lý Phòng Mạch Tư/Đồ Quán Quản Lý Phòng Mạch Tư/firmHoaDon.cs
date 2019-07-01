using QLPKBUS;
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
        public firmHoaDon()
        {
            InitializeComponent();
            
        }

        private void firmHoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_xem_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {

        }
        private void loadDataGridView()
        {
            try
            {
                DataTable dt = bus.loadDuLieu(tb_pk.Text);
                if (dt.Rows.Count > 0)
                    MessageBox.Show("Load Thành công");
                else
                    MessageBox.Show("Không có thông tin cách dùng");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

    }
}
