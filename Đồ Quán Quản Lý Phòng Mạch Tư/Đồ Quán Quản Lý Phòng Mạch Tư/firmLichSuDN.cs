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
    public partial class firmLichSuDN : Form
    {
        private UserDTO usDTO = new UserDTO();
        private LichSuDTO lsDTO = new LichSuDTO();
        private LichSuBUS lsBUS = new LichSuBUS();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        int curline = -1;
        public firmLichSuDN()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpk_load.Value.ToString("yyyy"));
            try
            {
                DataTable dt = lsBUS.LoadByDate(dtpk_load.Value);
                if (dt.Rows.Count > 0 )
                    MessageBox.Show("Load Thành công");
                else
                    MessageBox.Show("Không có thông tin đăng nhập trong ngày");
                dtgv_ls.DataSource = dt;
                curline = -1;
            }
            catch(Exception ex)
            {

            }
        }

        private void dataGridViewLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 &&e.RowIndex!=curline)
            {
                curline = e.RowIndex;
                DataGridViewRow row = this.dtgv_ls.Rows[e.RowIndex];

                tb_manv.Text = row.Cells[1].Value + string.Empty;

                try
                {
                    DataTable dt = lsBUS.LoadThongTinNV(tb_manv.Text);
                    tb_hoten.Text = dt.Rows[0][1].ToString();
                    tb_gioitinh.Text = dt.Rows[0][2].ToString();
                    tb_ngaysinh.Text = ((DateTime)dt.Rows[0][3]).ToString("dd-MM-yyyy"); 
                    tb_diachi.Text = dt.Rows[0][4].ToString();
                    tb_sdt.Text = dt.Rows[0][5].ToString();
                    tb_chucvu.Text = dt.Rows[0][6].ToString();
                    tb_tk.Text = dt.Rows[0][7].ToString();

                    //dtpk_ngaysinh.DataBindings.Add("Value", dt, "NgaySinh");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Dtpk_load_Validated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
