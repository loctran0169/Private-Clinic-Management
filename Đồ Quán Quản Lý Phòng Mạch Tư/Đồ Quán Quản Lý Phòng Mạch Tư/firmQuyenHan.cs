using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPKDTO;
using QLPKDAL;
using QLPKBUS;
namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmQuyenHan : Form
    {

        private QuyenHanBUS qhBUS;
        public firmQuyenHan()
        {
            InitializeComponent();
        }

        private void frmQuyenHan_Load(object sender, EventArgs e)
        {
            qhBUS = new QuyenHanBUS();
            dataGridViewQuyenHan.DataSource = qhBUS.loadDuLieuQuyenHan();
            HienThiThongTinQuyenHan();
        }

        private void HienThiThongTinQuyenHan()
        {

            if (dataGridViewQuyenHan.RowCount > 0)
            {
                int r = dataGridViewQuyenHan.CurrentRow.Index;
                DataGridViewRow row = dataGridViewQuyenHan.Rows[r];
                txtMaQuyenHan.Text = row.Cells[0].Value.ToString();
                txtTenQuyenHan.Text = row.Cells[1].Value.ToString();
                txtNoiDung.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewQuyenHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow;
            indexrow = e.RowIndex;
            if (indexrow != -1)
            {
                HienThiThongTinQuyenHan();
            }
        }
    }
}
