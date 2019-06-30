using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class LoaiBenhDTO
    {
        private string maLB;
        public string MaLB
        {
            get { return maLB; }
            set { maLB = value; }
        }

        private string tenLoaiBenh;
        public string TenLoaiBenh
        {
            get { return tenLoaiBenh; }
            set { tenLoaiBenh = value; }
        }

        private string trieuChung;
        public string TrieuChung
        {
            get { return trieuChung; }
            set { trieuChung = value; }
        }

    }
}
