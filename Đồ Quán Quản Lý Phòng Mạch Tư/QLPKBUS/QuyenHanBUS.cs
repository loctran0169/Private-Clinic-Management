using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class QuyenHanBUS
    {
        private QuyenHanDAL qhdal;
        public QuyenHanBUS()
        {
            qhdal = new QuyenHanDAL();
        }
        public bool them(QuyenHanDTO qh)
        {
            bool re = qhdal.them(qh);
            return re;
        }

        public bool xoa(QuyenHanDTO qh)
        {
            bool re = qhdal.xoa(qh);
            return re;
        }

        public bool sua(QuyenHanDTO qh)
        {
            bool re = qhdal.sua(qh);
            return re;
        }

        public List<QuyenHanDTO> select()
        {
            return qhdal.select();
        }
        public List<QuyenHanDTO> selectByKeyWord(string sKeyword)
        {
            return qhdal.selectByKeyWord(sKeyword);
        }
    }
}
