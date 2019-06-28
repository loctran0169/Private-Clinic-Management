using MySql.Data.MySqlClient;
using QLPKBUS;
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
    public partial class firmLapDanhSachKhamBenh : Form
    {
        public firmLapDanhSachKhamBenh()
        {
            InitializeComponent();
        }
        private DanhSachKhamBenhBUS dsbus;
        private void loadDanhSach(List<DanhSachKhamBenhDTO> listdanhsach)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn bnma = new DataGridViewTextBoxColumn();
            bnma.Name = "MaBN1";
            bnma.HeaderText = "Mã Bệnh Nhân";
            bnma.DataPropertyName = "MaBN1";
            dataGridView1.Columns.Add(bnma);

            DataGridViewTextBoxColumn HoTen = new DataGridViewTextBoxColumn();
            HoTen.Name = "HoTen1";
            HoTen.HeaderText = "Họ Tên";
            HoTen.DataPropertyName = "HoTen1";
            dataGridView1.Columns.Add(HoTen);

            DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
            NgaySinh.Name = "NgaySinh1";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.DataPropertyName = "NgaySinh1";
            dataGridView1.Columns.Add(NgaySinh);

            DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
            GioiTinh.Name = "GioiTinh1";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.DataPropertyName = "GioiTinh1";
            dataGridView1.Columns.Add(GioiTinh);

            DataGridViewTextBoxColumn sdt = new DataGridViewTextBoxColumn();
            sdt.Name = "SDT1";
            sdt.HeaderText = "Số Điện Thoại";
            sdt.DataPropertyName = "SDT1";
            dataGridView1.Columns.Add(sdt);

            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
            DiaChi.Name = "DiaChi1";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.DataPropertyName = "DiaChi1";
            dataGridView1.Columns.Add(DiaChi);

            DataGridViewTextBoxColumn ngaykham = new DataGridViewTextBoxColumn();
            ngaykham.Name = "NgayKham1";
            ngaykham.HeaderText = "Ngày Khám";
            ngaykham.DataPropertyName = "NgayKham1";
            dataGridView1.Columns.Add(ngaykham);

            var bindingList = new BindingList<DanhSachKhamBenhDTO>(listdanhsach);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();



        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            dsbus = new DanhSachKhamBenhBUS();
            List<DanhSachKhamBenhDTO> listdanhsach = dsbus.select();
            if (listdanhsach == null)
                MessageBox.Show("Load danh sách bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Load bệnh nhân thành công");
            loadDanhSach(listdanhsach);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];

            tb_maBN.Text = row.Cells[0].Value.ToString();
            
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            DanhSachKhamBenhDTO bn = new DanhSachKhamBenhDTO();
            bn.MaBN1 = int.Parse(tb_maBN.Text);
            
            bn.NgaySinh1 = ((DateTime)dateTimePicker1.Value);
            
            dsbus = new DanhSachKhamBenhBUS();
            bool kq = dsbus.them(bn);
            if (kq == false)
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm thành công");
        }
    }
}
