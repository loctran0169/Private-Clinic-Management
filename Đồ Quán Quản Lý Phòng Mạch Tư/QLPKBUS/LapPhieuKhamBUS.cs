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
    public class LapPhieuKhamBUS
    {
        private LapPhieuKhamDAL dsdal;
        public LapPhieuKhamBUS()
        {
            dsdal = new LapPhieuKhamDAL();
        }
        public List<LapPhieuKhamDTO> select()
        {
            return dsdal.select();
        }
        public bool sua(LapPhieuKhamDTO dsdto)
        {
            bool re = dsdal.sua(dsdto);
            return re;
        }
    }
}

