using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class BenhNhanDTO
    {
        private int MaBN;
        private string HoTen;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string DiaChi;

        public BenhNhanDTO(){

        }
        public BenhNhanDTO(int maBN, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi)
        {
            MaBN = maBN;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }

        public int MaBN1 { get => MaBN; set => MaBN = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
