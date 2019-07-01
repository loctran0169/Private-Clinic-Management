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
        private string flag;
     

        
       private void loadcombobox()
        {
            DataTable dt = new DataTable();
            dtbus = new LapDonThuocBUS();
            dt = dtbus.loadPKtoCombobox();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_mapk.Items.Add(dt.Rows[i][0].ToString());
            }
            ////

            LapDonThuocBUS dtbus1 = new LapDonThuocBUS();
            DataTable dt1 = new DataTable();
            dtbus1 = new LapDonThuocBUS();
            dt1 = dtbus1.loadThuoctoCombobox();

           
            for(int i=0;i<dt.Rows.Count;i++)
            {
                comboBox_Loaithuoc.Items.Add("(" + dt1.Rows[i][0] + ")\t" + dt1.Rows[i][1].ToString());

            }
            LapDonThuocBUS dtbus2 = new LapDonThuocBUS();
            DataTable dt2 = new DataTable();
            dtbus2 = new LapDonThuocBUS();
            dt2 = dtbus2.loadCDtoCombobox();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_cachdung.Items.Add("(" + dt2.Rows[i][0] + ")\t" + dt2.Rows[i][1].ToString());

            }

        }

        private void bt_load_Click(object sender, EventArgs e)
        {

            

           
            
        }

        private void loadDonThuoc(List<LapDonThuocDTO> list)
        {


            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn malb = new DataGridViewTextBoxColumn();
            malb.Name = "MaThuoc1";
            malb.HeaderText = "Mã Loại Thuốc";
            malb.DataPropertyName = "MaThuoc1";
            dataGridView1.Columns.Add(malb);

            DataGridViewTextBoxColumn TenThuoc = new DataGridViewTextBoxColumn();
            TenThuoc.Name = "TenThuoc1";
            TenThuoc.HeaderText = "Tên Loại Thuốc";
            TenThuoc.DataPropertyName = "TenThuoc1";
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

            DataGridViewTextBoxColumn macd = new DataGridViewTextBoxColumn();
            macd.Name = "MaCD1";
            macd.HeaderText = "Mã Cách dùng";
            macd.DataPropertyName = "MaCD1";
            dataGridView1.Columns.Add(macd);

            DataGridViewTextBoxColumn cd = new DataGridViewTextBoxColumn();
            cd.Name = "CachDung1";
            cd.HeaderText = "Cách dùng thuốc";
            cd.DataPropertyName = "CachDung1";
            dataGridView1.Columns.Add(cd);

           


            var bindingList = new BindingList<LapDonThuocDTO>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }
        private string connectionString;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tB_load.Visible = true;
            //dtbus = new LapDonThuocBUS();
            //List<LapDonThuocDTO> list = dtbus.select(comboBox_mapk.Text);
            //loadDonThuoc(list);


        }
        private void load_dulieu()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            DataTable k = new DataTable();
            MySqlConnection kn = new MySqlConnection(connectionString);
            try
            {
                kn.Open();
                string query = string.Empty;
                query += "SELECT BN.HOTEN tenbn,TRIEUCHUNG ,TENLOAIBENH  ";

                query += "FROM PHIEUKHAM PK ";

                query += "LEFT JOIN BENH B ON PK.MALB=B.MALB  ";

                query += "JOIN BENHNHAN BN ON PK.MABN=BN.MABN ";


                query += "WHERE MAPK= \"" + comboBox_mapk.Text + "\"";
                MySqlDataAdapter dt = new MySqlDataAdapter(query, kn);
                dt.Fill(k);//đổ dữ liệu từ DataBase sang bảng
                kn.Close();
                dt.Dispose();

            }
            catch (Exception b)
            {

            }



            string str = k.Rows[0][0].ToString();
            tB_hoten.Text = k.Rows[0][0].ToString();
            tB_TrieuChung.Text = k.Rows[0][1].ToString();
            tB_Benh.Text = k.Rows[0][2].ToString();
        }
        private void load_datagridview()
        {
            dtbus = new LapDonThuocBUS();
            List<LapDonThuocDTO> list = dtbus.select(comboBox_mapk.Text);
            
            loadDonThuoc(list);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            row = dataGridView1.Rows[e.RowIndex];

            comboBox_Loaithuoc.Text ="("+row.Cells[0].Value.ToString()+")\t"+ row.Cells[1].Value.ToString();



            comboBox_cachdung.Text = "(" + row.Cells[5].Value.ToString() + ")\t" + row.Cells[6].Value.ToString();

            
            tB_soluong.Text = row.Cells[2].Value.ToString();
            tB_dongia.Text = row.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = "them";
            tB_Luu.Visible = true;
            tB_sua.Visible = false;
            comboBox_Loaithuoc.Enabled = true;
            comboBox_cachdung.Enabled = true;
            tB_xoa.Visible = false;
            button3.Visible = false;
            tB_huy.Visible = true;
        }

        private void firmLapDonThuoc_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void tB_Luu_Click(object sender, EventArgs e)
        {
            if(flag=="them")
            {
                LapDonThuocDTO dt = new LapDonThuocDTO();
                dt.MaPK1 = comboBox_mapk.Text;
                dt.MaThuoc1 = comboBox_Loaithuoc.Text.Substring(1, 4);
                dt.SoLuong1 = int.Parse(tB_soluong.Text);
                dt.MaCD1 = comboBox_cachdung.Text.Substring(1, 5);
                bool kq = dtbus.them(dt);
                if (kq == true)
                {
                    MessageBox.Show("Thêm  thành công");                    
                    
                }
                else
                { 
                    MessageBox.Show("Thêm  thất bại");
                    return;
                }
            }
            else if(flag=="sua")
            {
                LapDonThuocDTO dt = new LapDonThuocDTO();
                dt.MaPK1 = comboBox_mapk.Text;
                dt.MaThuoc1 = comboBox_Loaithuoc.Text.Substring(1, 4);
                dt.SoLuong1 = int.Parse(tB_soluong.Text);
                dt.MaCD1 = comboBox_cachdung.Text.Substring(1, 5);
                bool kq = dtbus.sua(dt);
                if (kq == true)
                {
                    MessageBox.Show("Sửa  thành công");

                }
                else
                {
                    MessageBox.Show("Sửa  thất bại");
                    return;
                }
            }
            else if(flag=="xoa")
            {
                LapDonThuocDTO dt = new LapDonThuocDTO();
                dt.MaPK1 = comboBox_mapk.Text;
                dt.MaThuoc1 = comboBox_Loaithuoc.Text.Substring(1, 4);
                dt.SoLuong1 = int.Parse(tB_soluong.Text);
                dt.MaCD1 = comboBox_cachdung.Text.Substring(1, 5);
                bool kq = dtbus.xoa(dt);
                if (kq == true)
                {
                    MessageBox.Show("Xóa  thành công");

                }
                else
                {
                    MessageBox.Show("Xóa  thất bại");
                    return;
                }
            }

            tB_huy.Visible = false;
            tB_Luu.Visible = false;
            tB_sua.Visible = true;
            tB_xoa.Visible = true;
            button3.Visible = true;
            load_datagridview();


        }

        private void tB_load_Click(object sender, EventArgs e)
        {
            load_dulieu();
            load_datagridview();
            tB_load.Visible = false;
        }

        private void tB_sua_Click(object sender, EventArgs e)
        {
            flag = "sua";
            tB_Luu.Visible = true;
            tB_sua.Visible = false;
            comboBox_Loaithuoc.Enabled = true;
            comboBox_cachdung.Enabled = true;
            tB_xoa.Visible = false;
            button3.Visible = false;
            tB_huy.Visible = true;
        }

        private void tB_xoa_Click(object sender, EventArgs e)
        {
            flag = "xoa";
            tB_Luu.Visible = true;
            tB_sua.Visible = false;
            comboBox_Loaithuoc.Enabled = true;
            comboBox_cachdung.Enabled = true;
            tB_xoa.Visible = false;
            button3.Visible = false;
            tB_huy.Visible = true;
        }

        private void tB_huy_Click(object sender, EventArgs e)
        {
            tB_huy.Visible = false;
            tB_Luu.Visible = false;
            tB_sua.Visible = true;
            tB_xoa.Visible = true;
            button3.Visible = true;
        }
    }
}
