using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class LichSuDTO
    {
        private string maUS;
        private string maNV;
        private DateTime thoiGianDN;

        public string MaUS { get => maUS; set => maUS = value; }
        public DateTime ThoiGianDN { get => thoiGianDN; set => thoiGianDN = value; }
    }
}
