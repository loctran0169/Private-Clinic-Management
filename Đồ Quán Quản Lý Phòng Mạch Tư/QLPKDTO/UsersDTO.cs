using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class UsersDTO
    {
        private string maUS;
        public string MaUS
        {
            get { return maUS; }
            set { maUS = value; }
        }
        private string taiKhoan;
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string maQuyenHan;
        public string MaQH
        {
            get { return maQuyenHan; }
            set { maQuyenHan = value; }
        }
    }
}
