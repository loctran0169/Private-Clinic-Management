﻿using MySql.Data.MySqlClient;
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
    public partial class firmDanhSachCho : Form
    {
        public firmDanhSachCho()
        {
            InitializeComponent();
        }
        private DanhSachChoBUS dsbus;
        private PhieuKhamBUS pkbus;
        private void loadDanhSach(List<DanhSachChoDTO> listdanhsach)
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

            DataGridViewTextBoxColumn NgayKham = new DataGridViewTextBoxColumn();
            NgayKham.Name = "NgayKham1";
            NgayKham.HeaderText = "Ngày Khám";
            NgayKham.DataPropertyName = "NgayKham1";
            dataGridView1.Columns.Add(NgayKham);

            var bindingList = new BindingList<DanhSachChoDTO>(listdanhsach);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();



        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            dsbus = new DanhSachChoBUS();
            string s = dateTimePicker1.Value.Year.ToString()+"-"+dateTimePicker1.Value.Month.ToString() + "-"+ dateTimePicker1.Value.Day.ToString() + "-";
            List<DanhSachChoDTO> listdanhsach = dsbus.select(s);
            if (listdanhsach == null)
                MessageBox.Show("Load danh sách bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                MessageBox.Show("Load bệnh nhân thành công");
                
            }

            loadDanhSach(listdanhsach);
        }

        
        private string TaoMaTuDong(string key)
        {
            DataTable dt = new DataTable();
            pkbus = new PhieuKhamBUS();
            dt = pkbus.loadToDataTable();
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
                return ma = key + "00" + coso;
            else if (coso < 100)
                return ma = key + "0" + coso;
            else
                return ma = key + coso;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_them_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            
        }

        private void firmDanhSachCho_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }
    }
}
