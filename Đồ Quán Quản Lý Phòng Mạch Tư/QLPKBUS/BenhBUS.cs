using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class BenhBUS
    {
        private BenhDAL bdal;
        public BenhBUS()
        {
            bdal = new BenhDAL();
        }
        public bool them(BenhDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(BenhDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(BenhDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<BenhDTO> select()
        {
            return bdal.select();
        }
        public List<BenhDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
    }
}
