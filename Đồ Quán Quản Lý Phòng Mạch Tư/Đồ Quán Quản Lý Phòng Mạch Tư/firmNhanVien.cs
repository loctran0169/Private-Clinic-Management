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
    public partial class firmNhanVien : Form
    {
        public firmNhanVien()
        {
            InitializeComponent();
            KhoaButton();
        }

        private NhanVienBUS nvBUS= new NhanVienBUS();
        string flag = null;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            KhoaButton();
            nvBUS = new NhanVienBUS();
            dataGridViewNhanVien.DataSource = nvBUS.loadDuLieuNhanVien();
        }
        private void MoKhoaButton()
        {
            txtHoVaTen.Enabled = true;
            txtSDT.Enabled = true;
            txtChucVu.Enabled = true;
            txtDiaChi.Enabled = true;
            dtmNgaySinh.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
        }
        private void KhoaButton()
        {
            txtHoVaTen.Enabled = false;
            txtSDT.Enabled = false;
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = false;
            dtmNgaySinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
        private void ResetGiaTri()
        {
            txtHoVaTen.Text = null;
            txtSDT.Text = null;
            txtChucVu.Text = null;
            txtDiaChi.Text = null;
            dtmNgaySinh.Text = DateTime.Now.ToString();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKhoaButton();
            ResetGiaTri();
            txtMaNhanVien.Text = TaoMaTuDong();
            flag = "Thêm";
            dataGridViewNhanVien.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            MoKhoaButton();
            txtMaNhanVien.Enabled = false;//không cho sửa mã loại thuốc
            flag = "Sửa";
            dataGridViewNhanVien.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVienDTO nvDTO = new NhanVienDTO();
                nvDTO.MaNhanVien = txtMaNhanVien.Text;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = nvBUS.xoa(nvDTO);
                if (kq == false)
                    MessageBox.Show("Xóa nhân viên thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Xóa nhân viên thành công");

                    dataGridViewNhanVien.DataSource = nvBUS.loadDuLieuNhanVien();//load lại dữ liệu cho datagridview

                }
            }
        }
        private void HienThiThongTinNhanVien()
        {
            if (dataGridViewNhanVien.RowCount > 0)

            {
                int r = dataGridViewNhanVien.CurrentRow.Index;
                DataGridViewRow row = dataGridViewNhanVien.Rows[r];
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtHoVaTen.Text = row.Cells[1].Value.ToString();
                dtmNgaySinh.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value.ToString() == "Nam")
                    rdoNam.Checked = true;
                else rdoNu.Checked = true;

                txtSDT.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
                txtChucVu.Text = row.Cells[6].Value.ToString();

            }

        }
        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)//hiển thị thông tin thuốc mỗi khi click vào datagridview
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewNhanVien.Rows[e.RowIndex];

                txtMaNhanVien.Text = row.Cells[0].Value + string.Empty;
                txtHoVaTen.Text = row.Cells[1].Value + string.Empty;
                if (row.Cells[2].Value + string.Empty == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dtmNgaySinh.Text = row.Cells[3].Value + string.Empty;
                txtDiaChi.Text = row.Cells[4].Value + string.Empty;
                txtSDT.Text = row.Cells[5].Value + string.Empty;
                txtChucVu.Text = row.Cells[6].Value + string.Empty;              
            }
        }
        private string TaoMaTuDong()
        {
            DataTable dt = new DataTable();
            dt = nvBUS.loadDuLieuNhanVien();


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
                return ma = "NV00" + coso;
            else if (coso < 100)
                return ma = "NV0" + coso;
            else
                return ma = "NV" + coso;

        }
        private bool KiemtraInt()
        {

            int n;
            bool isNumeric = int.TryParse(txtSDT.Text, out n);
            if (isNumeric == true) return true;
            return false;
        }

        private void txtSDT_Validated(object sender, EventArgs e)
        {
            if (KiemtraInt() == false)
                MessageBox.Show("Vui lòng nhập số điện thoại là số ", "Thông báo");
        }

        private void txtHoVaTen_Validated(object sender, EventArgs e)
        {
            txtHoVaTen.Text = ChuanHoaChuoi(txtHoVaTen.Text);
        }
        private string ChuanHoaChuoi(string xau)
        {
            string kq = "";
            xau = xau.Trim().ToLower();//Phải đổi sang Unicode thì sử dụng .ToLower() không bị lỗi font
            for (int i = 0; i < xau.Length; i++)
            {
                if (i == 0)
                    kq += xau[i].ToString().ToUpper();
                else
                    kq += xau[i];
                if (xau[i] == ' ')
                {
                    while (xau[i] == ' ')
                    {
                        i++;
                    }
                    kq += xau[i].ToString().ToUpper();
                }
            }
            return kq.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "" || (rdoNam.Checked == false && rdoNu.Checked == false) || txtSDT.Text == "" || txtDiaChi.Text == "" || txtChucVu.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            else if (flag == "Thêm")
            {
                if (string.IsNullOrEmpty(txtMaNhanVien.Text))
                    return;
                //1. Map data from GUI
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNhanVien = txtMaNhanVien.Text;
                nv.HoVaTen = txtHoVaTen.Text;

                nv.NgaySinh = ((DateTime)dtmNgaySinh.Value);

                if (rdoNam.Checked == true)
                    nv.GioiTinh = "Nam";
                else if (rdoNu.Checked == true)
                    nv.GioiTinh = "Nữ";
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.ChucVu = txtChucVu.Text;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB


                bool kq = nvBUS.them(nv);
                if (kq == false)
                    MessageBox.Show("Thêm nhân viên thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Thêm nhân viên thành công");

                    dataGridViewNhanVien.DataSource = nvBUS.loadDuLieuNhanVien();//load lại dữ liệu cho datagridview
                    dataGridViewNhanVien.Enabled = true;
                    KhoaButton();
                }

            }
            else if (flag == "Sửa")
            {
                if (string.IsNullOrEmpty(txtMaNhanVien.Text))
                    return;
                NhanVienDTO nvDTO = new NhanVienDTO();
                nvDTO.MaNhanVien = txtMaNhanVien.Text;
                nvDTO.HoVaTen = txtHoVaTen.Text;

                nvDTO.NgaySinh = ((DateTime)dtmNgaySinh.Value);

                if (rdoNam.Checked == true)
                    nvDTO.GioiTinh = "Nam";
                else if (rdoNu.Checked == true)
                    nvDTO.GioiTinh = "Nữ";
                nvDTO.SDT = txtSDT.Text;
                nvDTO.DiaChi = txtDiaChi.Text;
                nvDTO.ChucVu = txtChucVu.Text;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = nvBUS.sua(nvDTO);
                if (kq == false)
                    MessageBox.Show("Sửa nhân viên thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Sửa nhân viên thành công");

                    dataGridViewNhanVien.DataSource = nvBUS.loadDuLieuNhanVien();//load lại dữ liệu cho datagridview
                    dataGridViewNhanVien.Enabled = true;
                    KhoaButton();
                }

            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaButton();
            //HienThiThongTinNhanVien();
            dataGridViewNhanVien.Enabled = true;
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNhanVien.DataSource = nvBUS.loadDuLieuNhanVien();
                MessageBox.Show("Load thành công");
            }
            catch
            {
                MessageBox.Show("Load thất bại. Kiểm tra lại kết nối");
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            KhoaButton();
            empty();
            
        }
        private void empty()
        {
            txtMaNhanVien.Text = txtHoVaTen.Text = txtSDT.Text = txtDiaChi.Text = txtChucVu.Text = null;
            rdoNam.Checked = rdoNu.Checked = false;
            dataGridViewNhanVien.Enabled = true;
        }

    }
}
