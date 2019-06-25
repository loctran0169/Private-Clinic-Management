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
    public partial class firmBenhNhan : Form
    {
        private string sex = null;
        private BenhNhanBUS bnbus;
        public firmBenhNhan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BenhNhanDTO bn = new BenhNhanDTO();
            bn.MaBN1 = tb_mabn.Text;
            bn.HoTen1 = tb_hoten.Text;
            bn.NgaySinh1 = (DateTime)dtp_ngaysinh.Value;
            bn.GioiTinh1 = sex;
            bn.DiaChi1 = tb_diachi.Text;
            if(bn==null)
                MessageBox.Show("ss");
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
    }
}
