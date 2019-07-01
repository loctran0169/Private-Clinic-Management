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
    public partial class firmBenhNhan : Form
    {
        private string sex = null;
        string flag = null;
        BenhNhanBUS bnbus = new BenhNhanBUS();
        public firmBenhNhan()
        {
            InitializeComponent();
            ChiDoc();
        }
        private bool checkData()
        {
            if (string.IsNullOrEmpty(tb_hoten.Text))
            {
                MessageBox.Show("Chưa nhập họ tên");
                tb_hoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dtp_ngaysinh.Text))
            {
                MessageBox.Show("Chưa nhập ngày sinh");
                dtp_ngaysinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sex))
            {
                MessageBox.Show("Chưa chọn giới tính");
                return false;
            }
            if (string.IsNullOrEmpty(tb_sdt.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                tb_sdt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_diachi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                tb_diachi.Focus();
                return false;
            }
            return true;
        }
        private void ChiDoc()
        {
            tb_hoten.Enabled = false;
            tb_diachi.Enabled = false;
            tb_sdt.Enabled = false;
            dtp_ngaysinh.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            bt_them.Visible = bt_sua.Visible = bt_xoa.Visible = true;
            bt_huy.Visible = bt_lưu.Visible = false;
            dtgv_benhnhan.Enabled = true;
        }
        private void ChiSua()
        {
            tb_hoten.Enabled = true;
            tb_diachi.Enabled = true;
            tb_sdt.Enabled = true;
            dtp_ngaysinh.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            bt_them.Visible = bt_sua.Visible = bt_xoa.Visible = false;
            bt_huy.Visible = bt_lưu.Visible = true;
            dtgv_benhnhan.Enabled = false;
        }
        private void empty()
        {
            tb_mabn.Text = tb_hoten.Text = tb_sdt.Text = tb_diachi.Text = tb_search.Text = null;
            radioButton1.Checked = radioButton2.Checked = false;
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
        private void button1_Click(object sender, EventArgs e)
        {
            ChiSua();
            empty();
            tb_mabn.Text = TaoMaTuDong("BN");
            flag = "them";
            dtgv_benhnhan.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Nam";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Nữ";
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_mabn.Text))
                return;
            ChiSua();
            flag = "sua";
            dtgv_benhnhan.Enabled = false;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_mabn.Text))
                return;
            if (MessageBox.Show("Bạn muốn xóa bệnh nhân?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BenhNhanDTO bn = new BenhNhanDTO();
                bn.MaBN1 = tb_mabn.Text;
                bnbus = new BenhNhanBUS();
                bool kq = bnbus.xoa(bn);
                if (kq == false)
                    MessageBox.Show("Xóa bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                    MessageBox.Show("Xóa bệnh nhân thành công");
            }
        }

        
        private void loadBenhNhan(List<BenhNhanDTO>listbenhnhan)
        {
            

            dtgv_benhnhan.Columns.Clear();
            dtgv_benhnhan.DataSource = null;
            dtgv_benhnhan.AutoGenerateColumns = false;
            dtgv_benhnhan.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn bnma = new DataGridViewTextBoxColumn();
            bnma.Name = "MaBN1";
            bnma.HeaderText = "Mã Bệnh Nhân";
            bnma.DataPropertyName = "MaBN1";
            dtgv_benhnhan.Columns.Add(bnma);

            DataGridViewTextBoxColumn HoTen = new DataGridViewTextBoxColumn();
            HoTen.Name = "HoTen1";
            HoTen.HeaderText = "Họ Tên";
            HoTen.DataPropertyName = "HoTen1";
            dtgv_benhnhan.Columns.Add(HoTen);

            DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
            NgaySinh.Name = "NgaySinh1";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.DataPropertyName = "NgaySinh1";
            dtgv_benhnhan.Columns.Add(NgaySinh);

            DataGridViewTextBoxColumn GioiTinh = new DataGridViewTextBoxColumn();
            GioiTinh.Name = "GioiTinh1";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.DataPropertyName = "GioiTinh1";
            dtgv_benhnhan.Columns.Add(GioiTinh);

            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
            DiaChi.Name = "DiaChi1";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.DataPropertyName = "DiaChi1";
            dtgv_benhnhan.Columns.Add(DiaChi);

            DataGridViewTextBoxColumn sdt = new DataGridViewTextBoxColumn();
            sdt.Name = "SDT1";
            sdt.HeaderText = "Số điện thoại";
            sdt.DataPropertyName = "SDT1";
            dtgv_benhnhan.Columns.Add(sdt);

            var bindingList = new BindingList<BenhNhanDTO>(listbenhnhan);
            var source = new BindingSource(bindingList, null);
            dtgv_benhnhan.DataSource = source;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgv_benhnhan.DataSource];
            myCurrencyManager.Refresh();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            bnbus = new BenhNhanBUS();
            List<BenhNhanDTO> listbenhnhan = bnbus.select();
            if (listbenhnhan == null)
                MessageBox.Show("Load  thất bại. Vui lòng kiểm tra đường truyền");
            else
                MessageBox.Show("Load thành công");
            loadBenhNhan(listbenhnhan);
        }

        private void tim_Click(object sender, EventArgs e)
        {
            string sKeyword = tb_search.Text.Trim();
            bnbus = new BenhNhanBUS();
            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                List<BenhNhanDTO> listbenhnhan = bnbus.select();
                this.loadBenhNhan(listbenhnhan);
            }
            else
            {
                List<BenhNhanDTO> listbenhnhan = bnbus.selectByKeyWord(sKeyword);
                if (listbenhnhan.Count==0)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                this.loadBenhNhan(listbenhnhan);
            }
        }

        private void dtgv_benhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = this.dtgv_benhnhan.Rows[e.RowIndex];

                tb_mabn.Text= row.Cells[0].Value + string.Empty;
                tb_hoten.Text = row.Cells[1].Value + string.Empty;
                dtp_ngaysinh.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value + string.Empty == "Nam")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                tb_diachi.Text = row.Cells[4].Value + string.Empty;
                tb_sdt.Text = row.Cells[5].Value + string.Empty;
            }
        }

        private void bt_lưu_Click(object sender, EventArgs e)
        {
            if (flag == "them")
            {
                if (checkData() == false)
                    return;
                BenhNhanDTO bn = new BenhNhanDTO();
                bn.MaBN1 = tb_mabn.Text;
                bn.HoTen1 = tb_hoten.Text;
                bn.NgaySinh1 = (DateTime)dtp_ngaysinh.Value;
                bn.GioiTinh1 = sex;
                bn.SDT1 = tb_sdt.Text;
                bn.DiaChi1 = tb_diachi.Text;
                bool kq = bnbus.them(bn);
                if (kq == true)
                {
                    MessageBox.Show("Thêm bệnh nhân thành công");
                    dtgv_benhnhan.Enabled = true;
                    ChiDoc();
                    empty();
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân thất bại");
                    return;
                }
            }
            else if (flag == "sua" )
            {
                if (checkData() == false)
                    return;
                BenhNhanDTO bn = new BenhNhanDTO();
                bn.MaBN1 = tb_mabn.Text;
                bn.HoTen1 = tb_hoten.Text;
                bn.NgaySinh1 = ((DateTime)dtp_ngaysinh.Value);
                bn.GioiTinh1 = sex;
                bn.DiaChi1 = tb_diachi.Text;
                bn.SDT1 = tb_sdt.Text;
                bnbus = new BenhNhanBUS();
                bool kq = bnbus.sua(bn);
                if (kq == false)
                {
                    MessageBox.Show("Sữa bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
                    ChiDoc();
                    return;
                }
                else
                {
                    MessageBox.Show("Sữa bệnh nhân thành công");
                    dtgv_benhnhan.Enabled = true;
                    ChiDoc();
                    empty();
                }             
            }
            Reload();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            ChiDoc();
            empty();
            dtgv_benhnhan.Enabled = true;
        }

        private void tb_hoten_Validated(object sender, EventArgs e)
        {
            tb_hoten.Text = ChuanHoaChuoi(tb_hoten.Text);
        }

        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private string TaoMaTuDong(string key)
        {
            DataTable dt = new DataTable();
            
            dt = bnbus.loadToDataTable();
            int coso = 0;
            if (dt.Rows.Count == 0)
            {
                coso = 1;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1) 
            {
                coso = 2;
            }
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1) 
            {
                coso = 1;
            }
            else 
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
                return ma = key+"00" + coso;
            else if (coso < 100)
                return ma = key+"0" + coso;
            else
                return ma = key + coso;
        }
        public void Reload()
        {
            bnbus = new BenhNhanBUS();
            List<BenhNhanDTO> listbenhnhan = bnbus.select();
            loadBenhNhan(listbenhnhan);
        }
    }
}
