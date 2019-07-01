using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QLPKBUS
{
   public class LapDonThuocBUS
    {
        private LapDonThuocDAL dtdal;

        public LapDonThuocBUS()
        {
            dtdal = new LapDonThuocDAL();

        }
        public DataTable loadPKtoCombobox()
        {
            return dtdal.loadPKtoCombobox();
        }
        public List<LapDonThuocDTO> select(string s)
        {
            return dtdal.select(s);
        }
        public bool them(LapDonThuocDTO dt)
        {
            bool re = dtdal.them(dt);
            return re;
        }
        public bool sua(LapDonThuocDTO dt)
        {
            bool re = dtdal.sua(dt);
            return re;
        }
        public bool xoa(LapDonThuocDTO dt)
        {
            bool re = dtdal.xoa(dt);
            return re;
        }
        public DataTable loadThuoctoCombobox()
        {
            return dtdal.loadThuoctoCombobox();
        }
        public DataTable loadCDtoCombobox()
        {
            return dtdal.loadCDctoCombobox();
        }
    }
}
