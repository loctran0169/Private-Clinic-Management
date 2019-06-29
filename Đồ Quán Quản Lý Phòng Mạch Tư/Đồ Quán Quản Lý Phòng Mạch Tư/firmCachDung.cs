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
    public partial class firmCachDung : Form
    {
        string flag = null;
        CachDungBUS bus = new CachDungBUS();
        int curline = -1;
        public firmCachDung()
        {
            InitializeComponent();
        }
        private void MoKhoaButton()
        {
            txtNoiDungCachDungThuoc.Enabled = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
        }
        private void KhoaButton()
        {
            txtNoiDungCachDungThuoc.Enabled = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
        private void ResetGiaTri()
        {
            txtMaCachDungThuoc.Text = txtNoiDungCachDungThuoc.Text = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKhoaButton();
            ResetGiaTri();
            txtMaCachDungThuoc.Text = TaoMaTuDong();
            flag = "Thêm";
            dtgv.Enabled = false;
        }
        private string TaoMaTuDong()
        {
            DataTable dt = new DataTable();
            dt = bus.loadDuLieuCachDung();



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
                return ma = "CD00" + coso;
            else if (coso < 100)
                return ma = "CD0" + coso;
            else
                return ma = "CD" + coso;

        }

        private void firmCachDung_Load(object sender, EventArgs e)
        {
            KhoaButton();
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

        private void txtNoiDungCachDungThuoc_Validated(object sender, EventArgs e)
        {
            txtNoiDungCachDungThuoc.Text = ChuanHoaChuoi(txtNoiDungCachDungThuoc.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoKhoaButton();
            txtMaCachDungThuoc.Enabled = false;//không cho sửa mã loại thuốc
            flag = "Sửa";
            dtgv.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa cách dùng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CachDungDTO dvtDTO = new CachDungDTO();
                dvtDTO.MaCD1 = txtMaCachDungThuoc.Text;
                dvtDTO.CachDung1 = txtNoiDungCachDungThuoc.Text;

                bool kq = bus.xoa(dvtDTO);
                if (kq == false)
                    MessageBox.Show("Xóa thông tin cách dùng thất bại.");

                else
                {
                    MessageBox.Show("Xóa thông tin cách dùng thành công");
                    ReloadDb();//load lại dữ liệu cho datagridview
                }
                KhoaButton();
            }
        }

        public void ReloadDb()
        {
            try
            {
                DataTable dt = bus.loadDuLieuCachDung();
                if (dt.Rows.Count > 0)
                    MessageBox.Show("Load Thành công");
                else
                    MessageBox.Show("Không có thông tin cách dùng");
                dtgv.DataSource = dt;
                curline = -1;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCachDungThuoc.Text))
                return;
            if (txtNoiDungCachDungThuoc.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            else if (flag == "Thêm")
            {
                //1. Map data from GUI
                CachDungDTO dvtDTO = new CachDungDTO();
                dvtDTO.MaCD1 = txtMaCachDungThuoc.Text;
                dvtDTO.CachDung1 = txtNoiDungCachDungThuoc.Text;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = bus.them(dvtDTO);
                if (kq == false)
                    MessageBox.Show("Thêm cách dùng thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Thêm cách dùng thành công");
                    dtgv.DataSource = bus.loadDuLieuCachDung();//load lại dữ liệu cho datagridview
                    dtgv.Enabled = true;
                    KhoaButton();
                }

            }
            else if (flag == "Sửa")
            {
                CachDungDTO dvtDTO = new CachDungDTO();
                dvtDTO.MaCD1 = txtMaCachDungThuoc.Text;
                dvtDTO.CachDung1 = txtNoiDungCachDungThuoc.Text;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = bus.sua(dvtDTO);
                if (kq == false)
                    MessageBox.Show("Sửa thông tin cách dùng thất bại. Vui lòng kiểm tra lại dũ liệu");

                else
                {
                    MessageBox.Show("Sửa thông tin cách dùng thành công");
                    dtgv.DataSource = bus.loadDuLieuCachDung();//load lại dữ liệu cho datagridview
                    dtgv.Enabled = true;
                    KhoaButton();
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaButton();
            ResetGiaTri();
            dtgv.Enabled = true;
            curline = -1;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv.Rows[e.RowIndex];

                txtMaCachDungThuoc.Text = row.Cells[0].Value + string.Empty;
                txtNoiDungCachDungThuoc.Text = row.Cells[1].Value + string.Empty;
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            ReloadDb();
        }
    }
}
