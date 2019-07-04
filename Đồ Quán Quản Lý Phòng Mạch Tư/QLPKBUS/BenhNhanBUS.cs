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
    public class BenhNhanBUS
    {
        private BenhNhanDAL bndal;
        public BenhNhanBUS()
        {
            bndal = new BenhNhanDAL();
        }
        public bool them(BenhNhanDTO bn)
        {
            bool re = bndal.them(bn);
            return re;
        }

        public bool xoa(BenhNhanDTO bn)
        {
            bool re = bndal.xoa(bn);
            return re;
        }

        public bool sua(BenhNhanDTO bn)
        {
            bool re = bndal.sua(bn);
            return re;
        }

        public List<BenhNhanDTO> select()
        {
            return bndal.select();
        }
        public List<BenhNhanDTO> selectByKeyWord(string sKeyword)
        {
            return bndal.selectByKeyWord(sKeyword);
        }
        public DataTable loadToDataTable()
        {
            return bndal.loadToDataTable();
        }
        public DataTable loadDanhSachKhamBenh(DateTime t)
        {
            return bndal.loadDanhSachKhamBenh(t);
        }
    }
}
