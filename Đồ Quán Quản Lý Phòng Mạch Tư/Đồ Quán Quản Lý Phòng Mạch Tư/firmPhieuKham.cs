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
    public partial class firmPhieuKham : Form
    {
        public firmPhieuKham()
        {
            InitializeComponent();
        }
        LapPhieuKhamBUS pkbus = new LapPhieuKhamBUS();

        string flag = "";
        private void loadDsPK(List<LapPhieuKhamDTO> listphieukham)
        {


            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn mapk = new DataGridViewTextBoxColumn();
            mapk.Name = "MaPK1";
            mapk.HeaderText = "Mã Phiếu Khám";
            mapk.DataPropertyName = "MaPK1";
            dataGridView1.Columns.Add(mapk);

            DataGridViewTextBoxColumn HoTen = new DataGridViewTextBoxColumn();
            HoTen.Name = "TenBN1";
            HoTen.HeaderText = "Họ Tên Bệnh Nhân";
            HoTen.DataPropertyName = "TenBN1";
            dataGridView1.Columns.Add(HoTen);

            DataGridViewTextBoxColumn bs = new DataGridViewTextBoxColumn();
            bs.Name = "TenBS1";
            bs.HeaderText = "Bác Sĩ Khám";
            bs.DataPropertyName = "TenBS1";
            dataGridView1.Columns.Add(bs);

            DataGridViewTextBoxColumn NgayKham = new DataGridViewTextBoxColumn();
            NgayKham.Name = "NgayKham1";
            NgayKham.HeaderText = "Ngày Khám";
            NgayKham.DataPropertyName = "NgayKham1";
            dataGridView1.Columns.Add(NgayKham);

            DataGridViewTextBoxColumn TrieuChung = new DataGridViewTextBoxColumn();
            TrieuChung.Name = "TrieuChung1";
            TrieuChung.HeaderText = "Triệu Chứng";
            TrieuChung.DataPropertyName = "TrieuChung1";
            dataGridView1.Columns.Add(TrieuChung);

            DataGridViewTextBoxColumn LoaiBenh = new DataGridViewTextBoxColumn();
            LoaiBenh.Name = "TenLB1";
            LoaiBenh.HeaderText = "Loại Bệnh";
            LoaiBenh.DataPropertyName = "TenLB1";
            dataGridView1.Columns.Add(LoaiBenh);

            var bindingList = new BindingList<LapPhieuKhamDTO>(listphieukham);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }
        private void bt_Load_Click(object sender, EventArgs e)
        {
            loadcomboboxtenbs();
            loadcomboboxloaibenh();
            pkbus = new LapPhieuKhamBUS();
            List<LapPhieuKhamDTO> listphieukham = pkbus.select();
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


        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (flag == "Sửa")
            {
                LapPhieuKhamDTO pk = new LapPhieuKhamDTO();
                pk.MaPK1 = tB_MaPK.Text;
                pk.MaLB1 = comboBox_LoaiBenh.Text.Substring(1, 5);
                pk.MaBS1 = comboBox_TenBS.Text.Substring(1, 5);


                LapPhieuKhamBUS pkbus = new LapPhieuKhamBUS();
                bool kq = pkbus.sua(pk);
                if (kq == true)
                {
                    MessageBox.Show("Thêm bệnh nhân thành công");
                    pkbus = new LapPhieuKhamBUS();
                    List<LapPhieuKhamDTO> listdanhsach = pkbus.select();
                    loadDsPK(listdanhsach);
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân thất bại");

                }
                
            }
            else if(flag=="Xóa")
            {
                LapPhieuKhamDTO pk = new LapPhieuKhamDTO();
                pk.MaPK1 = tB_MaPK.Text;
                


                LapPhieuKhamBUS pkbus = new LapPhieuKhamBUS();
                bool kq = pkbus.xoa(pk);
                if (kq == true)
                {
                    MessageBox.Show("Xóa  thành công");
                    pkbus = new LapPhieuKhamBUS();
                    List<LapPhieuKhamDTO> listdanhsach = pkbus.select();
                    loadDsPK(listdanhsach);
                }
                else
                {
                    MessageBox.Show("Xóa  thất bại");

                }
            }
            bt_sua.Visible = true;
            bt_luu.Visible = false;
            bt_Huy.Visible = false;
            comboBox_TenBS.Enabled = false;
            comboBox_LoaiBenh.Enabled = false;
        }
        private NhanVienBUS nvbus;
        public void loadcomboboxtenbs()
        {
            DataTable dt = new DataTable();
            nvbus = new NhanVienBUS();
            dt = nvbus.loadToDataTable();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_TenBS.Items.Add("(" + dt.Rows[i][0] + ")\t" + dt.Rows[i][1].ToString());
            }

        }
        private LoaiBenhBUS benhbus;
        public void loadcomboboxloaibenh()
        {
            DataTable dt = new DataTable();
            benhbus = new LoaiBenhBUS();
            dt = benhbus.loadDuLieuLoaiBenh();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_LoaiBenh.Items.Add("(" + dt.Rows[i][0] + ")\t" + dt.Rows[i][1].ToString());
            }

        }


        

        private void comboBox_TenBS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox_LoaiBenh.Enabled = true;
            comboBox_TenBS.Enabled = true;
            bt_luu.Visible = true;
            bt_sua.Visible = false;
            bt_xoa.Visible = false;
            bt_Huy.Visible = true;
            flag = "Sửa";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            bt_luu.Visible = true;
            bt_sua.Visible = false;
            bt_xoa.Visible = false;
            bt_Huy.Visible = true;
            flag = "Xóa";
        }
        private void bt_Huy_Click(object sender, EventArgs e)
        {
            bt_xoa.Visible = true;
            bt_sua.Visible = true;
            comboBox_LoaiBenh.Enabled = false;
            comboBox_TenBS.Enabled = false;
            bt_luu.Visible = false;
            bt_Huy.Visible = false;

        }

        private void comboBox_TenBS_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            row = dataGridView1.Rows[e.RowIndex];

            tB_MaPK.Text = row.Cells[0].Value.ToString();
            tB_HoTen.Text = row.Cells[1].Value.ToString();
            comboBox_TenBS.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();

            comboBox_LoaiBenh.Text = row.Cells[5].Value.ToString();

        }

        
    }
}
