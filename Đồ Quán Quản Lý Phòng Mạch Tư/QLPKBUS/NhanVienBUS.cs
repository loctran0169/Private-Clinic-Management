using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL nvdal;
        public NhanVienBUS()
        {
            nvdal = new NhanVienDAL();
        }
        public bool them(NhanVienDTO nv)
        {
            bool re = nvdal.them(nv);
            return re;
        }

        public bool xoa(NhanVienDTO nv)
        {
            bool re = nvdal.xoa(nv);
            return re;
        }

        public bool sua(NhanVienDTO nv)
        {
            bool re = nvdal.sua(nv);
            return re;
        }

        public List<NhanVienDTO> select()
        {
            return nvdal.select();
        }
        public List<NhanVienDTO> selectByKeyWord(string sKeyword)
        {
            return nvdal.selectByKeyWord(sKeyword);
        }
    }
}
