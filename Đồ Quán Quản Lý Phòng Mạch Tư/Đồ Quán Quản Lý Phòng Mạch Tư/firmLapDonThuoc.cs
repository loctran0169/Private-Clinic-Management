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

        private void load1()
        {
            DataTable dt = new DataTable();
            dtbus = new LapDonThuocBUS();
            dt = dtbus.loadPKtoCombobox();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        


        private void bt_load_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dtbus = new LapDonThuocBUS();
            dt = dtbus.loadPKtoCombobox();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][1].ToString());
            }
            MessageBox.Show("áhdahs");
        }
        private void loadDonThuoc(List<LapDonThuocDTO> listphieukham)
        {


            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn malb = new DataGridViewTextBoxColumn();
            malb.Name = "MaLB1";
            malb.HeaderText = "Mã Loại Bệnh";
            malb.DataPropertyName = "MaLB1";
            dataGridView1.Columns.Add(malb);

            DataGridViewTextBoxColumn TenThuoc = new DataGridViewTextBoxColumn();
            TenThuoc.Name = "MaThuoc1";
            TenThuoc.HeaderText = "Tên Loại Thuốc";
            TenThuoc.DataPropertyName = "MaThuoc1";
            dataGridView1.Columns.Add(TenThuoc);

            DataGridViewTextBoxColumn sl = new DataGridViewTextBoxColumn();
            sl.Name = "SoLuong1";
            sl.HeaderText = "Số Lượng";
            sl.DataPropertyName = "SoLuong1";
            dataGridView1.Columns.Add(sl);

            DataGridViewTextBoxColumn donvi = new DataGridViewTextBoxColumn();
            donvi.Name = "TenDonvi1";
            donvi.HeaderText = "Đơn Vị Tính";
            donvi.DataPropertyName = "TenDonvi1";
            dataGridView1.Columns.Add(donvi);

            DataGridViewTextBoxColumn dongia = new DataGridViewTextBoxColumn();
            dongia.Name = "DonGia1";
            dongia.HeaderText = "Đơn Giá";
            dongia.DataPropertyName = "DonGia1";
            dataGridView1.Columns.Add(dongia);

            DataGridViewTextBoxColumn cd = new DataGridViewTextBoxColumn();
            cd.Name = "CachDung1";
            cd.HeaderText = "Cách dùng thuốc";
            cd.DataPropertyName = "CachDung1";
            dataGridView1.Columns.Add(cd);

           


            var bindingList = new BindingList<LapDonThuocDTO>(listphieukham);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtbus = new LapDonThuocBUS();
            
            List <LapDonThuocDTO> list = dtbus.select(comboBox1.Text);
            


            loadDonThuoc(list);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];

            comboBox1.Text = row.Cells[1].Value.ToString();
            comboBox2.Text = row.Cells[5].Value.ToString();
            textBox5.Text = row.Cells[2].Value.ToString();
            textBox6.Text = row.Cells[4].Value.ToString();
        }
    }
}
