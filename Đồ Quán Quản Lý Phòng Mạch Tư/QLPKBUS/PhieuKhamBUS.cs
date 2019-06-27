using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class PhieuKhamBUS
    {
        private PhieuKhamDAL pkdal;

        public PhieuKhamBUS()
        {
            pkdal = new PhieuKhamDAL();
        }
        public bool them(PhieuKhamDTO pk)
        {
            bool re = pkdal.them(pk);
            return re;
        }

        public bool xoa(PhieuKhamDTO pk)
        {
            bool re = pkdal.xoa(pk);
            return re;
        }

        public bool sua(PhieuKhamDTO pk)
        {
            bool re = pkdal.sua(pk);
            return re;
        }

        public List<PhieuKhamDTO> select()
        {
            return pkdal.select();
        }
        public List<PhieuKhamDTO> selectByKeyWord(string sKeyword)
        {
            return pkdal.selectByKeyWord(sKeyword);
        }
    }
}
