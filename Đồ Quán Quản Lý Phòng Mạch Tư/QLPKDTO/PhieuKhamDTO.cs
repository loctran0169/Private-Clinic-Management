using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    class PhieuKhamDTO
    {
        private string MaKP;
        private string MaBN;
        private string TrieuChung;
        private string MaLN;
        private DateTime NgayKham;

        public string MaKP1 { get => MaKP; set => MaKP = value; }
        public string MaBN1 { get => MaBN; set => MaBN = value; }
        public string TrieuChung1 { get => TrieuChung; set => TrieuChung = value; }
        public string MaLoaiBenh1 { get => MaLN; set => MaLN = value; }
        public DateTime NgayKham1 { get => NgayKham; set => NgayKham = value; }
    }
}
