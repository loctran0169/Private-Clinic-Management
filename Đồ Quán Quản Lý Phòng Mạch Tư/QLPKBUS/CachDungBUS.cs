using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class CachDungBUS
    {
        private CachDungDAL bdal;

        public CachDungBUS()
        {
            bdal = new CachDungDAL();
        }
        public bool them(CachDungDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(CachDungDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(CachDungDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<CachDungDTO> select()
        {
            return bdal.select();
        }
        public List<CachDungDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
    }
}
