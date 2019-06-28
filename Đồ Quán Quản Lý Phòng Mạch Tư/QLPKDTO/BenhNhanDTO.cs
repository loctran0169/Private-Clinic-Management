using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class BenhNhanDTO
    {
        private string MaBN;
        private string HoTen;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;

        public BenhNhanDTO(){

        }
        public BenhNhanDTO(string maBN, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi)
        {
            MaBN = maBN;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }

        public string MaBN1 { get => MaBN; set => MaBN = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
    }
}
