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
    public partial class firmNguoiDung : Form
    {
        public firmNguoiDung()
        {
            InitializeComponent();
            
        }

        private UsersBUS usBUS = new UsersBUS();
        string flag = null;
        
        private void MoKhoaButton()
        {
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            cboMaNV.Enabled = true;
            cboMaQuyenHan.Enabled = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
        }
        private void KhoaButton()
        {
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            cboMaNV.Enabled = false;
            cboMaQuyenHan.Enabled = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
        private void ResetGiaTri()
        {
            txtTaiKhoan.Text = null;
            txtMatKhau.Text = null;
            cboMaNV.Text = null;
            cboMaQuyenHan.Text = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKhoaButton();
            ResetGiaTri();
            txtMaUS.Text = TaoMaTuDong();
            flag = "Thêm";
            dataGridViewNguoiDung.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaUS.Text))
                return;
            MoKhoaButton();
            txtMaUS.Enabled = false;//không cho sửa mã loại thuốc
            flag = "Sửa";
            dataGridViewNguoiDung.Enabled = false;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaUS.Text))
                return;
            if (MessageBox.Show("Bạn muốn xóa users?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                UsersDTO us = new UsersDTO();
                us.MaUS = txtMaUS.Text;
                us.TaiKhoan = txtTaiKhoan.Text;
                us.MatKhau = txtMatKhau.Text;
                us.MaNV = cboMaNV.Text;
                us.MaQH= cboMaQuyenHan.Text;

                bool kq = usBUS.xoa(us);
                if (kq == false)
                    MessageBox.Show("Xóa thông tin users thất bại.");

                else
                {
                    MessageBox.Show("Xóa thông tin users thành công");
                    dataGridViewNguoiDung.DataSource = usBUS.loadDuLieuUsers();//load lại dữ liệu cho datagridview
                    empty();
                }
                KhoaButton();
            }
        }
        

        private string TaoMaTuDong()
        {
            DataTable dt = new DataTable();
            dt = usBUS.loadDuLieuUsers();


            //Phương thức thứ 2 là Substring(int index,int lenght).
            //Phuơng thức này sẽ trả về chuỗi con của chuỗi từ vị trí bắt đầu (index) và có chiều dài bao nhiêu (lenght)
            int coso = 0;
            if (dt.Rows.Count == 0)// nếu danh sách thuốc rỗng
            {
                coso = 1;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1) // nếu danh sách có 1 thuốc mà mã thuốc này là T001
            {
                coso = 2;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1) // nếu danh sách có 1 thuốc mà mã thuốc này khác T001
            {

                coso = 1;
            }
            else // nếu danh sách có hơn 1 thuốc
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
                return ma = "US00" + coso;
            else if (coso < 100)
                return ma = "US0" + coso;
            else
                return ma = "US" + coso;

        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "" || txtTaiKhoan.Text == "" || cboMaNV.Text == "" || cboMaQuyenHan.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            else if (flag == "Thêm")
            {
                UsersDTO us = new UsersDTO();

                us.MaUS = txtMaUS.Text;
                us.TaiKhoan = txtTaiKhoan.Text;
                us.MatKhau = txtMatKhau.Text;
                us.MaNV = cboMaNV.Text;
                us.MaQH = cboMaQuyenHan.SelectedValue.ToString();

                bool kq = usBUS.them(us);
                if (kq == false)
                    MessageBox.Show("Thêm thông tin users thất bại.");

                else
                {
                    MessageBox.Show("Thêm thông tin users thành công");
                    dataGridViewNguoiDung.DataSource = usBUS.loadDuLieuUsers();//load lại dữ liệu cho datagridview
                    KhoaButton();
                    dataGridViewNguoiDung.Enabled = true;
                    empty();
                }

            }
            else if (flag == "Sửa")
            {

                UsersDTO us = new UsersDTO();

                us.MaUS = txtMaUS.Text;
                us.TaiKhoan = txtTaiKhoan.Text;
                us.MatKhau = txtMatKhau.Text;
                us.MaNV = cboMaNV.Text;
                us.MaQH = cboMaQuyenHan.SelectedValue.ToString();



                bool kq = usBUS.sua(us);
                if (kq == false)
                    MessageBox.Show("Sửa thông tin users thất bại.");

                else
                {
                    MessageBox.Show("Sửa thông tin users thành công");
                    dataGridViewNguoiDung.DataSource = usBUS.loadDuLieuUsers();//load lại dữ liệu cho datagridview
                    KhoaButton();
                    dataGridViewNguoiDung.Enabled = true;
                    empty();
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaButton();
            empty();
            dataGridViewNguoiDung.Enabled = true;
        }
        private bool KiemTraTenDangNhap(string a)
        {// kiểm tra xem đã có tài khoản trong csdl chưa
            DataTable k = usBUS.loadDuLieuUsers();
            foreach (DataRow dtRow in k.Rows)
            {
                // On all tables' columns
                foreach (DataColumn dc in k.Columns)
                {
                    if (dc.ColumnName == "TaiKhoan")
                    {
                        var field1 = dtRow[dc].ToString();
                        if (a == field1)
                            return false;
                    }

                }
            }
            return true;
        }
        private bool KiemTraTenDangNhapSua(string a)
        {// kiểm tra xem đã có tài khoản trong csdl chưa
            DataTable k = usBUS.loadDuLieuUsers();
            int r = dataGridViewNguoiDung.CurrentRow.Index;
            foreach (DataRow dtRow in k.Rows)
            {
                // On all tables' columns
                foreach (DataColumn dc in k.Columns)
                {
                    if (dc.ColumnName == "TaiKhoan")
                    {
                        var field1 = dtRow[dc].ToString();
                        if (a == field1 && k.Rows[r] != dtRow)
                            return false;
                    }

                }
            }
            return true;
        }

        private void txtTaiKhoan_Valued(object sender, EventArgs e)
        {
            if (flag == "Thêm")
            {
                if (KiemTraTenDangNhap(txtTaiKhoan.Text) != true)
                    MessageBox.Show("Đã tồn tại tài khoản");
            }

            if (flag == "Sửa")
            {
                if (KiemTraTenDangNhapSua(txtTaiKhoan.Text) != true)
                    MessageBox.Show("Đã tồn tại tài khoản");
            }
        }

        private void firmNguoiDung_Load(object sender, EventArgs e)
        {
           
            //đổ dữ liệu vào combobox mã quyền hạn
            cboMaQuyenHan.DataSource = usBUS.loadDuLieuQuyenHan();
            cboMaQuyenHan.DisplayMember = "TenQuyenHan";
            cboMaQuyenHan.ValueMember = "MaQH";
            KhoaButton();
        }
        public void empty()
        {
            txtMaUS.Text = txtMatKhau.Text = txtTaiKhoan.Text = cboMaNV.Text = null;
        }

        private void dataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow;
            indexrow = e.RowIndex;
            if (indexrow != -1)
            {
                HienThiThongTin();
            }
        }
        private void HienThiThongTin()
        {
            if (dataGridViewNguoiDung.RowCount > 0)

            {
                int r = dataGridViewNguoiDung.CurrentRow.Index;
                DataGridViewRow row = dataGridViewNguoiDung.Rows[r];

                txtMaUS.Text = row.Cells[0].Value + string.Empty;
                txtTaiKhoan.Text = row.Cells[1].Value + string.Empty;
                txtMatKhau.Text = row.Cells[2].Value + string.Empty;
                cboMaNV.Text = row.Cells[3].Value + string.Empty;
                //cboMaQuyenHan.Text = row.Cells[4].Value + string.Empty;
                cboMaQuyenHan.SelectedItem = row.Cells[4].Value + string.Empty;
            }

        }

        private void load_Click(object sender, EventArgs e)
        {
            dataGridViewNguoiDung.DataSource = usBUS.loadDuLieuUsers();
            HienThiThongTin();
        }
    }
}
