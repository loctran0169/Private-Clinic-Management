using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class HoaDonDTO
    {
        private string MaHD;
        private string MaPK;
        private DateTime NgayLapHD;
        private int TienThuoc;
        private int TongTien;

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaPK1 { get => MaPK; set => MaPK = value; }
        public DateTime NgayLapHD1 { get => NgayLapHD; set => NgayLapHD = value; }
        public int TienThuoc1 { get => TienThuoc; set => TienThuoc = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }

    }
}
