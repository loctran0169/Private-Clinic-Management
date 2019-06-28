using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class HoaDonDTO
    {
        private int MaHD;
        private int MaBN;
        private DateTime NgayLapHD;
        private int MaTS;
        private int TienThuoc;
        private int TongTien;

        public int MaHD1 { get => MaHD; set => MaHD = value; }
        public int MaBN1 { get => MaBN; set => MaBN = value; }
        public DateTime NgayLapHD1 { get => NgayLapHD; set => NgayLapHD = value; }
        public int MaTS1 { get => MaTS; set => MaTS = value; }
        public int TienThuoc1 { get => TienThuoc; set => TienThuoc = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
