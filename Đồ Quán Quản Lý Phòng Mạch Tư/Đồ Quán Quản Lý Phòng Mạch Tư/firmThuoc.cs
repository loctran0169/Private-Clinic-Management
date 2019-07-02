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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Quán_Quản_Lý_Phòng_Mạch_Tư
{
    public partial class firmThuoc : Form
    {
        string flag = null;
        ThuocBUS bus = new ThuocBUS();
        public firmThuoc()
        {
            InitializeComponent();
        }
        private void MoKhoaButton()
        {
            nsx.Enabled = true;
            hsd.Enabled = true;
            tb_tenthuoc.Enabled = true;
            cbb_donvi.Enabled = true;
            tb_dongia.Enabled = true;
            tb_them.Visible = false;
            tb_them.Visible = false;
            tb_xoa.Visible = false;
            tb_luu.Visible = true;
            tb_huy.Visible = true;
        }
        private void KhoaButton()
        {
            nsx.Enabled = false;
            hsd.Enabled = false;
            tb_tenthuoc.Enabled = false;
            cbb_donvi.Enabled = false;
            tb_dongia.Enabled = false;
            tb_them.Visible = true;
            tb_them.Visible = true;
            tb_xoa.Visible = true;
            tb_luu.Visible = false;
            tb_huy.Visible = false;
        }
        private void ResetGiaTri()
        {
            tb_tenthuoc.Text = null;
            cbb_donvi.Text = null;
            tb_dongia.Text = null;
        }
        private void tb_them_Click(object sender, EventArgs e)
        {
            MoKhoaButton();
            ResetGiaTri();
            tb_mathuoc.Text = TaoMaThuocTuDong();
            flag = "Thêm";
            dataGridView1.Enabled = false;
        }

        private void tb_sua_Click(object sender, EventArgs e)
        {
            MoKhoaButton();           
            flag = "Sửa";
            dataGridView1.Enabled = false;
        }

        private void tb_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin thuốc?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ThuocDTO thDTO = new ThuocDTO();
                thDTO.MaThuoc1 = tb_mathuoc.Text;

                bool kq = bus.xoa(thDTO);
                if (kq == false)
                    MessageBox.Show("Xóa thông tin thuốc thất bại.");

                else
                {
                    MessageBox.Show("Xóa thông tin thuốc thành công");
                    dataGridView1.DataSource = bus.loadDuLieuThuoc();//load lại dữ liệu cho datagridview
                }
                KhoaButton();
            }
        }

        private void tb_luu_Click(object sender, EventArgs e)
        {

            if (tb_mathuoc.Text == "" || cbb_donvi.Text == "" || tb_dongia.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            else if (flag == "Thêm")
            {
                if (string.IsNullOrEmpty(tb_mathuoc.Text))
                    return;
                //1. Map data from GUI
                ThuocDTO thDTO = new ThuocDTO();
                thDTO.MaThuoc1 = tb_mathuoc.Text;
                thDTO.TenThuoc1 = tb_tenthuoc.Text;
                thDTO.MaDV1 = cbb_donvi.SelectedValue.ToString();
                thDTO.DonGia1 = int.Parse(tb_dongia.Text);
                thDTO.NSX1 = nsx.Value;
                thDTO.HSD1 = hsd.Value;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = bus.them(thDTO);
                if (kq == false)
                    MessageBox.Show("Thêm thuốc thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Thêm thuốc thành công");

                    dataGridView1.DataSource = bus.loadDuLieuThuoc();//load lại dữ liệu cho datagridview
                    dataGridView1.Enabled = true;
                    KhoaButton();
                }

            }
            else if (flag == "Sửa")
            {
                if (string.IsNullOrEmpty(tb_mathuoc.Text))
                    return;
                ThuocDTO thDTO = new ThuocDTO();
                thDTO.MaThuoc1 = tb_mathuoc.Text;
                thDTO.TenThuoc1 = tb_tenthuoc.Text;
                thDTO.MaDV1 = cbb_donvi.SelectedValue.ToString();
                thDTO.DonGia1 = int.Parse(tb_dongia.Text);
                thDTO.NSX1 = nsx.Value;
                thDTO.HSD1 = hsd.Value;
                //2. Kiểm tra data hợp lệ or not

                //3. Thêm vào DB
                bool kq = bus.sua(thDTO);
                if (kq == false)
                    MessageBox.Show("Sửa thông tin thuốc thất bại. Vui lòng kiểm tra lại dũ liệu");

                else
                {
                    MessageBox.Show("Sửa thông tin thuốc thành công");
                    dataGridView1.DataSource = bus.loadDuLieuThuoc();//load lại dữ liệu cho datagridview
                    dataGridView1.Enabled = true;
                    KhoaButton();
                }

            }
        }

        private void tb_huy_Click(object sender, EventArgs e)
        {
            KhoaButton();
            HienThiThongTinThuoc();
            dataGridView1.Enabled = true;
        }

        private void firmThuoc_Load(object sender, EventArgs e)
        {
            cbb_donvi.DataSource = bus.loadDuLieuDonViTinh();
            cbb_donvi.DisplayMember = "TenDonVi";
            cbb_donvi.ValueMember = "MaDV";
            cbb_donvi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbb_donvi.AutoCompleteSource = AutoCompleteSource.ListItems;
            KhoaButton();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow;
            indexrow = e.RowIndex;
            if (indexrow != -1)
            {
                HienThiThongTinThuoc();
            }
        }
        private void HienThiThongTinThuoc()
        {
            if (dataGridView1.RowCount > 0)

            {
                int r = dataGridView1.CurrentRow.Index;
                DataGridViewRow row = dataGridView1.Rows[r];

                tb_mathuoc.Text = row.Cells[0].Value.ToString();
                tb_tenthuoc.Text = row.Cells[1].Value.ToString();
                cbb_donvi.Text = row.Cells[2].Value.ToString();
                nsx.Text = row.Cells[3].Value.ToString();
                hsd.Text = row.Cells[4].Value.ToString();
                tb_dongia.Text = row.Cells[5].Value.ToString();
            }

        }
        private string TaoMaThuocTuDong()
        {
            DataTable dt = new DataTable();
            dt = bus.loadDuLieuThuoc();


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

            //Sau khi lấy được cơ số thứ tự của thuốc, ta gắn thêm tiền tố T vào

            string ma = "";
            if (coso < 10)
                return ma = "T00" + coso;
            else if (coso < 100)
                return ma = "T0" + coso;
            else
                return ma = "T" + coso;

        }

        private void tb_dongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void tb_tenthuoc_Validated(object sender, EventArgs e)
        {
            tb_tenthuoc.Text = ChuanHoaChuoi(tb_tenthuoc.Text);
        }

        private void load_Click(object sender, EventArgs e)
        {
                ReloadDb();
                HienThiThongTinThuoc();
        }
        public void ReloadDb()
        {
            try
            {
                DataTable dt = bus.loadDuLieuThuoc();
                if (dt.Rows.Count > 0)
                    MessageBox.Show("Load Thành công");
                else
                    MessageBox.Show("Không có thông tin cách dùng");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
