using QLPKDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL bdal;
        public HoaDonBUS()
        {
            bdal = new HoaDonDAL();
        }
        public DataTable loadDuLieu(string pk)
        {
            return bdal.loadDuLieu(pk);
        }
    }
}
