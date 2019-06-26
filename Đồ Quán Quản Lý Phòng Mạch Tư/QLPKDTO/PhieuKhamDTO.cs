using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class PhieuKhamDTO
    {
        private int MaPK;
        private int MaBN;
        private int MaNV;
        private int MaLB;
        private DateTime NgayKham;
        private DateTime NgayKhamLai;

        public int MaKP1 { get => MaPK; set => MaPK = value; }
        public int MaBN1 { get => MaBN; set => MaBN = value; }
        public int MaLB1 { get => MaLB; set => MaLB = value; }
        public DateTime NgayKham1 { get => NgayKham; set => NgayKham = value; }
        public int MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayKhamLai1 { get => NgayKhamLai; set => NgayKhamLai = value; }
    }
}
