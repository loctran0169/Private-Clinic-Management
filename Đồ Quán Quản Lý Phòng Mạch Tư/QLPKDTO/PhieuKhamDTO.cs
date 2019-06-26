using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class PhieuKhamDTO
    {
        private int MaKP;
        private int MaBN;
        private string TrieuChung;
        private int MaLN;
        private DateTime NgayKham;

        public int MaKP1 { get => MaKP; set => MaKP = value; }
        public int MaBN1 { get => MaBN; set => MaBN = value; }
        public string TrieuChung1 { get => TrieuChung; set => TrieuChung = value; }
        public int MaLoaiBenh1 { get => MaLN; set => MaLN = value; }
        public DateTime NgayKham1 { get => NgayKham; set => NgayKham = value; }
    }
}
