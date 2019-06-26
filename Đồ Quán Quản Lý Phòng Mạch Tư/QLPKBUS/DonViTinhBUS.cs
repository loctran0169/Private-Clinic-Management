using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class DonViTinhBUS
    {
        private DonViTinhDAL bdal;
        public DonViTinhBUS()
        {
            bdal = new DonViTinhDAL();
        }
        public bool them(DonViTinhDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(DonViTinhDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(DonViTinhDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<DonViTinhDTO> select()
        {
            return bdal.select();
        }
        public List<DonViTinhDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
    }
}
