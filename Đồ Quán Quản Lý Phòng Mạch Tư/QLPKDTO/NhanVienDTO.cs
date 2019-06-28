using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class NhanVienDTO
    {
        private string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string hoVaTen;
        public string HoVaTen
        {
            get { return hoVaTen; }
            set { hoVaTen = value; }
        }
        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string gioiTinh;
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string sDT;
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string chucVu;
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
    }
}
