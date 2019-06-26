using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class HoaDonDTO:BenhNhanDTO
    {
        private string MaHD;
        private string MaPK;       
        private int TienKham;
        private int TienThuoc;


        
        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaPK1 { get => MaPK; set => MaPK = value; }
        public int TienKham1 { get => TienKham; set => TienKham = value; }
        public int TienThuoc1 { get => TienThuoc; set => TienThuoc = value; }
    }
}
