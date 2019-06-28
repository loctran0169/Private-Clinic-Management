using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class DanhSachKhamBenhBUS
    {
        private DanhSachKhamBenhDAL ds;
        public DanhSachKhamBenhBUS()
        {
            ds = new DanhSachKhamBenhDAL();
        }
        public List<DanhSachKhamBenhDTO> select()
        {
            return ds.select();
        }
        public bool them(DanhSachKhamBenhDTO dsdto)
        {
            bool re = ds.them(dsdto);
            return re;
        }
    }

}
