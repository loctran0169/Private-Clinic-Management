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
    public class QuyenHanBUS
    {
        private QuyenHanDAL qhDAL;
        public QuyenHanBUS()
        {
            qhDAL= new QuyenHanDAL();
        }
        public DataTable loadDuLieuQuyenHan()
        {
            DataTable k = new DataTable();
            k = qhDAL.loadDuLieuQuyenHan();
            return k;

        }
    }
}
