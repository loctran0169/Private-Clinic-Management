using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class ThamSoDTO
    {
        private string MaTS;
        private string TenThamSo;
        private int GiaTri;

        public ThamSoDTO()
        {

        }
        public ThamSoDTO(string maTS, string tenThamSo, int giaTri)
        {
            MaTS = maTS;
            TenThamSo = tenThamSo;
            GiaTri = giaTri;
        }

        public string MaTS1 { get => MaTS; set => MaTS = value; }
        public string TenThamSo1 { get => TenThamSo; set => TenThamSo = value; }
        public int GiaTri1 { get => GiaTri; set => GiaTri = value; }
    }
}
