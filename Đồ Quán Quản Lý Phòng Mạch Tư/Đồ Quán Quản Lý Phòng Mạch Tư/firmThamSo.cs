
using QLPKBUS;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private ThamSoBUS tsBus;
        public firmThamSo()
        {
            InitializeComponent();
        }
        private void loadData_Vao_GridView()
        {
            MessageBox.Show("1");
            List<ThamSoDTO> listTS = tsBus.select();
            if (listTS == null)
            {
                MessageBox.Show("null");
                return;
            }
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listTS;
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }
            private void firmThamSo_Load(object sender, EventArgs e)
        {
            tsBus = new ThamSoBUS();
            this.loadData_Vao_GridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThamSoDTO ts = new ThamSoDTO();
            ts.MaTS1 = textBox3.Text;
            ts.TenTS1 = textBox2.Text;
            ts.GiaTri1 = int.Parse(textBox1.Text);
            if (ts == null)
                MessageBox.Show("NuLL");
            bool kq = tsBus.sua(ts);
            if(kq==false)
                MessageBox.Show("Sửa  thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("sửa thành công");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
