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
    public class LichSuBUS
    {
        private LichSuDAL dal;
        public DataTable LoadByDate(DateTime ls)
        {
            dal = new LichSuDAL();
            return dal.LoadByDate(ls);
        }
        public DataTable LoadThongTinNV(string nv)
        {
            dal = new LichSuDAL();
            return dal.LoadThongTinNV(nv);
        }
    }
}
