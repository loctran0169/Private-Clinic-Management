using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class QuyenHanDTO
    {
        private string maQH;
        private string tenQuyenHan;
        private string noiDung;

        public string MaQH { get => maQH; set => maQH = value; }
        public string TenQuyenHan { get => tenQuyenHan; set => tenQuyenHan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
    }
}
