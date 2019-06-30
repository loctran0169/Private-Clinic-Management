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
    }
}
