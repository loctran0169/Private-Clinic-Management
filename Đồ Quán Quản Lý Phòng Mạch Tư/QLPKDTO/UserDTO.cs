using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKDTO
{
    public class UserDTO
    {
        private int MaUS;
        private int MaNV;
        private int MaQH;
        private string TaiKhoan;
        private string MatKhau;

        public int MaUS1 { get => MaUS; set => MaUS = value; }
        public int MaNV1 { get => MaNV; set => MaNV = value; }
        public int MaQH1 { get => MaQH; set => MaQH = value; }
        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
