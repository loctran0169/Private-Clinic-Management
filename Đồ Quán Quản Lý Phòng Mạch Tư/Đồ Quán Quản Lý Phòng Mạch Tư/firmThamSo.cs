using MySql.Data.MySqlClient;
using QLPKBUS;
using QLPKDAL;
using QLPKDTO;
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
    public partial class firmThamSo : Form
    {
        public firmThamSo()
        {
            InitializeComponent();
        }
        private ThamSoBUS tsbus;
        private void bt_sua_Click(object sender, EventArgs e)
        {
            ThamSoDTO ts = new ThamSoDTO();
            ts.MaTS1 = int.Parse(textBox_MaTS.Text);
            ts.TenThamSo1 = textBox_TenTS.Text;
            ts.GiaTri1 = int.Parse(textBox_GiaTri.Text);
            tsbus = new ThamSoBUS();
            bool kq = tsbus.sua(ts);
            if (kq == false)
                MessageBox.Show("Sữa bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sữa bệnh nhân thành công");
        }

        private void loadData_Vao_GridView(List<ThamSoDTO> ListThamSo)
        {


            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn tsma = new DataGridViewTextBoxColumn();
            tsma.Name = "MaTS1";
            tsma.HeaderText = "Mã Tham Số";
            tsma.DataPropertyName = "MaTS1";
            dataGridView1.Columns.Add(tsma);

            DataGridViewTextBoxColumn tsten = new DataGridViewTextBoxColumn();
            tsten.Name = "TenThamSo1";
            tsten.HeaderText = "Tên Tham Số";
            tsten.DataPropertyName = "TenThamSo1";
            dataGridView1.Columns.Add(tsten);

            DataGridViewTextBoxColumn tsgiatri = new DataGridViewTextBoxColumn();
            tsgiatri.Name = "GiaTri1";
            tsgiatri.HeaderText = "Giá Trị";
            tsgiatri.DataPropertyName = "GiaTri1";
            dataGridView1.Columns.Add(tsgiatri);


            var bindingList = new BindingList<ThamSoDTO>(ListThamSo);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            //dataGridView1.DataSource = ListThamSo;
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }
        private void firmThamSo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Đang load tham số");
            tsbus = new ThamSoBUS();
            List<ThamSoDTO> listthamso = new List<ThamSoDTO>();
            listthamso = tsbus.select();

            if (listthamso == null)
                MessageBox.Show("Load danh sách tham số thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                MessageBox.Show("Load tham số thành công");
                
            }
            loadData_Vao_GridView(listthamso);

        }
    }
}
