using MySql.Data.MySqlClient;
using QLPKBUS;
using QLPKDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmLapDonThuoc : Form
    {
        public firmLapDonThuoc()
        {
            InitializeComponent();
        }
        private LapDonThuocBUS dtbus;
        private void bt_load_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dtbus = new LapDonThuocBUS();
            dt = dtbus.loadPKtoCombobox();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtbus = new LapDonThuocBUS();
            List<LapPhieuKhamDTO> listphieukham = dtbus.select();
            if (listphieukham == null)
                MessageBox.Show("Load danh sách bệnh nhân thất bại. Vui lòng kiểm tra đường truyền");
            else
            {
                MessageBox.Show("Load bệnh nhân thành công");
                bt_sua.Visible = true;
                bt_xoa.Visible = true;
            }
            loadDsPK(listphieukham);
        }
    }
}
