using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class ThuocDTO
    {
        private string MaThuoc;
        private string TenThuoc;
        private string MaDV;
        private DateTime NSX;
        private DateTime HSD;
        private int DonGia;
        private int SoLuongTon;

        public string MaThuoc1 { get => MaThuoc; set => MaThuoc = value; }
        public string MaDV1 { get => MaDV; set => MaDV = value; }
        public string TenThuoc1 { get => TenThuoc; set => TenThuoc = value; }
        public DateTime NSX1 { get => NSX; set => NSX = value; }
        public DateTime HSD1 { get => HSD; set => HSD = value; }
        public int DonGia1 { get => DonGia; set => DonGia = value; }
        public int SoLuongTon1 { get => SoLuongTon; set => SoLuongTon = value; }
    }
}
