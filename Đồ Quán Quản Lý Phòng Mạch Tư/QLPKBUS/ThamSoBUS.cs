using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class ThamSoBUS
    {
        private ThamSoDAL bdal;
        public ThamSoBUS()
        {
            bdal = new ThamSoDAL();
        }
        public bool them(ThamSoDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(ThamSoDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(ThamSoDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<ThamSoDTO> select()
        {
            return bdal.select();
        }
        public List<ThamSoDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
    }
}
