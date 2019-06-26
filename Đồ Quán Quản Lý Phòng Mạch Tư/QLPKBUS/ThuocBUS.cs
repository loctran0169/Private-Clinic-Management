using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class ThuocBUS
    {
        private ThuocDAL bdal;
        public ThuocBUS()
        {
            bdal = new ThuocDAL();
        }
        public bool them(ThuocDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(ThuocDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(ThuocDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<ThuocDTO> select()
        {
            return bdal.select();
        }
        public List<ThuocDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
    }
}
