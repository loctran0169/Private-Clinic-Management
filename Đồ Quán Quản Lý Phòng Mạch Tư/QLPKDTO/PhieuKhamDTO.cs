using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class PhieuKhamDTO
    {
        private  string MaPK;
        private string MaBN;
        private string MaNV;
        private string MaLB;
        private DateTime NgayKham;
        private DateTime NgayKhamLai;

        public string MaPK1 { get => MaPK; set => MaPK = value; }
        public string MaBN1 { get => MaBN; set => MaBN = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaLB1 { get => MaLB; set => MaLB = value; }
        public DateTime NgayKham1 { get => NgayKham; set => NgayKham = value; }
        public DateTime NgayKhamLai1 { get => NgayKhamLai; set => NgayKhamLai = value; }
    }
}
