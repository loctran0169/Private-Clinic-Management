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
        public DataTable LoadTienThuoc(string pk)
        {
            return bdal.LoadTienThuoc(pk);
        }
        public string TimHoaDon(string a)
        {
            return bdal.TimHoaDon(a);
        }
        public string LoadThamSo()
        {
            return bdal.LoadThamSo();
        }

        public DataTable loadToDataTable()
        {
            return bdal.loadToDataTable();
        }
        public bool them(HoaDonDTO hd)
        {
            return bdal.them(hd);
        }
    }
}
