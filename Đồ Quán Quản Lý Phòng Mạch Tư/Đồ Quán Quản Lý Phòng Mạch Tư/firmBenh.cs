using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using QLPKBUS;
using QLPKDTO;
using QLPKDAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmBenh : Form
    {
        private LoaiBenhBUS lbBUS;
        string flag = null;
        public firmBenh()
        {
            InitializeComponent();
        }

        private void frmBenh_Load(object sender, EventArgs e)
        {
            lbBUS = new LoaiBenhBUS();
            KhoaButton();

        }
        private void MoKhoaButton()
        {
            txtTenLoaiBenh.Enabled= true;
            txtTrieuChung.Enabled = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
        }
        private void KhoaButton()
        {
            txtTenLoaiBenh.Enabled = false;
            txtTrieuChung.Enabled = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
        private void ResetGiaTri()
        {
            txtTenLoaiBenh.Text = null;
            txtTrieuChung.Text = null;
        }

        private void HienThiThongTinLoaiBenh()
        {

            if (dataGridViewBenh.RowCount > 0)
            {
                int r = dataGridViewBenh.CurrentRow.Index;
                DataGridViewRow row = dataGridViewBenh.Rows[r];
                txtMaLoaiBenh.Text = row.Cells[0].Value.ToString();
                txtTenLoaiBenh.Text = row.Cells[1].Value.ToString();
                txtTrieuChung.Text = row.Cells[2].Value.ToString();
            }
        }

        private string TaoMaTuDong()
        {
            DataTable dt = new DataTable();
            dt = lbBUS.loadDuLieuLoaiBenh();


            //Phương thức thứ 2 là Substring(int index,int lenght).
            //Phuơng thức này sẽ trả về chuỗi con của chuỗi từ vị trí bắt đầu (index) và có chiều dài bao nhiêu (lenght)
            int coso = 0;
            if (dt.Rows.Count == 0)// nếu danh sách thuốc rỗng
            {
                coso = 1;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(1, 3)) == 1) // nếu danh sách có 1 thuốc mà mã thuốc này là T001
            {
                coso = 2;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(1, 3)) > 1) // nếu danh sách có 1 thuốc mà mã thuốc này khác T001
            {

                coso = 1;
            }
            else // nếu danh sách có hơn 1 thuốc
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(1, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(1, 3)) > 1)
                    {
                        coso = int.Parse(dt.Rows[i][0].ToString().Substring(1, 3)) + 1;
                        break;
                    }
                }
                coso = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(1, 3)) + 1;
            }

            //Sau khi lấy được cơ số thứ tự của bệnh, ta gắn thêm tiền tố B vào

            string ma = "";
            if (coso < 10)
                return ma = "B00" + coso;
            else if (coso < 100)
                return ma = "B0" + coso;
            else
                return ma = "B" + coso;

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

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            MoKhoaButton();
            ResetGiaTri();
            txtMaLoaiBenh.Text = TaoMaTuDong();
            flag = "Thêm";
            dataGridViewBenh.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoKhoaButton();
            txtMaLoaiBenh.Enabled = false;//không cho sửa mã loại thuốc
            flag = "Sửa";
            dataGridViewBenh.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin loại bệnh?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoaiBenhDTO lbDTO = new LoaiBenhDTO();
                lbDTO.MaLB = txtMaLoaiBenh.Text;
                lbDTO.TenLoaiBenh = txtTenLoaiBenh.Text;
                lbDTO.TrieuChung = txtTrieuChung.Text;

                bool kq = lbBUS.xoa(lbDTO);
                if (kq == false)
                    MessageBox.Show("Xóa loại bệnh thất bại.");

                else
                {
                    MessageBox.Show("Xóa loại bệnh thành công");
                    dataGridViewBenh.DataSource =lbBUS.loadDuLieuLoaiBenh();//load lại dữ liệu cho datagridview
                }
                KhoaButton();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (flag == "Thêm")
            {
                //1. Map data from GUI
                LoaiBenhDTO lbDTO = new LoaiBenhDTO();
                lbDTO.MaLB = txtMaLoaiBenh.Text;
                lbDTO.TenLoaiBenh = txtTenLoaiBenh.Text;
                lbDTO.TrieuChung = txtTrieuChung.Text;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = lbBUS.them(lbDTO);
                if (kq == false)
                    MessageBox.Show("Thêm loại bệnh thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Thêm loại bệnh thành công");

                    dataGridViewBenh.DataSource = lbBUS.loadDuLieuLoaiBenh();//load lại dữ liệu cho datagridview
                    dataGridViewBenh.Enabled = true;
                }

            }
            if (flag == "Sửa")
            {
                //1. Map data from GUI
                LoaiBenhDTO lbDTO = new LoaiBenhDTO();
                lbDTO.MaLB = txtMaLoaiBenh.Text;
                lbDTO.TenLoaiBenh = txtTenLoaiBenh.Text;
                lbDTO.TrieuChung = txtTrieuChung.Text;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = lbBUS.sua(lbDTO);
                if (kq == false)
                    MessageBox.Show("Sửa loại bệnh thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Sửa loại bệnh thành công");

                    dataGridViewBenh.DataSource = lbBUS.loadDuLieuLoaiBenh();//load lại dữ liệu cho datagridview
                    dataGridViewBenh.Enabled = true;
                }

            }
            KhoaButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaButton();
            HienThiThongTinLoaiBenh();
            dataGridViewBenh.Enabled = true;
        }

        private void dataGridViewCachDung_CellClick(object sender, DataGridViewCellEventArgs e)// hiển thị thông tin đơn vị tính
        {
            int indexrow;
            indexrow = e.RowIndex;
            if (indexrow != -1)
            {
                HienThiThongTinLoaiBenh();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ReloadDb();
            HienThiThongTinLoaiBenh();

        }
        public void ReloadDb()
        {
            try
            {
                DataTable dt = lbBUS.loadDuLieuLoaiBenh();
                if (dt.Rows.Count > 0)
                    MessageBox.Show("Load Thành công");
                else
                    MessageBox.Show("Không có thông tin cách dùng");
                dataGridViewBenh.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }
    }
}