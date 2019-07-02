using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class DanhSachChoBUS
    {
        private DanhSachChoDAL ds;
        public DanhSachChoBUS()
        {
            ds = new DanhSachChoDAL();
        }
        public List<QLPKDTO.DanhSachChoDTO> select(string s)
        {
            return ds.select(s);
        }
        
    }

}
