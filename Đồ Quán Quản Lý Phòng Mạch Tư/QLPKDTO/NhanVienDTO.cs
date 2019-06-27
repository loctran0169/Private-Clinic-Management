using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class NhanVienDTO
    {
        private int MaNV;
        private string HoTen;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string ChucVu;
        private string DiaChi;

        public int MaNV1 { get => MaNV; set => MaNV = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
