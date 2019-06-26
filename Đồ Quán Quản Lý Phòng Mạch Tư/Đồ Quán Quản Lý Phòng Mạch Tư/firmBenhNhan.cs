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
    public partial class firmBenhNhan : Form
    {
        private string sex = null;
        private BenhNhanBUS bnbus;
        public firmBenhNhan()
        {
            InitializeComponent();
            dtp_ngaysinh.CustomFormat = "yyyy-MM-dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BenhNhanDTO bn = new BenhNhanDTO();
            bn.HoTen1 = tb_hoten.Text;
            bn.NgaySinh1 = ((DateTime)dtp_ngaysinh.Value);
            bn.GioiTinh1 = sex;
            bn.DiaChi1 = tb_diachi.Text;

            bnbus = new BenhNhanBUS();
            bool kq = bnbus.them(bn);
            if (kq == false)
                MessageBox.Show("Thêm bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm bệnh nhân thành công");
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
            BenhNhanDTO bn = new BenhNhanDTO();
            bn.MaBN1 = int.Parse(tb_mabn.Text);
            bn.HoTen1 = tb_hoten.Text;
            bn.NgaySinh1 = ((DateTime)dtp_ngaysinh.Value);
            bn.GioiTinh1 = sex;
            bn.DiaChi1 = tb_diachi.Text;
            bnbus = new BenhNhanBUS();
            bool kq = bnbus.sua(bn);
            if (kq == false)
                MessageBox.Show("Sữa bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sữa bệnh nhân thành công");
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            BenhNhanDTO bn = new BenhNhanDTO();
            bn.MaBN1 = int.Parse(tb_mabn.Text);
            bnbus = new BenhNhanBUS();
            bool kq = bnbus.xoa(bn);
            if (kq == false)
                MessageBox.Show("Sữa bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sữa bệnh nhân thành công");
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
                MessageBox.Show("Load danh sách bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Load bệnh nhân thành công");
            loadBenhNhan(listbenhnhan);
        }

        private void tim_Click(object sender, EventArgs e)
        {
            string sKeyword = tb_mabn.Text.Trim();
            bnbus = new BenhNhanBUS();
            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0) // tìm tất cả
            {
                List<BenhNhanDTO> listKieuNau = bnbus.select();
                this.loadBenhNhan(listKieuNau);
            }
            else
            {
                List<BenhNhanDTO> listKieuNau = bnbus.selectByKeyWord(sKeyword);
                this.loadBenhNhan(listKieuNau);
            }
        }
    }
}
