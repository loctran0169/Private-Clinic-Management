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
    public class LoaiBenhBUS
    {
        private LoaiBenhDAL bdal;
        public LoaiBenhBUS()
        {
            bdal = new LoaiBenhDAL();
        }
        public bool them(LoaiBenhDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }
        public DataTable loadDuLieuLoaiBenh()
        {
            return bdal.loadDuLieuLoaiBenh();
        }
        public bool xoa(LoaiBenhDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(LoaiBenhDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<LoaiBenhDTO> select()
        {
            return bdal.select();
        }
        public List<LoaiBenhDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
        }
    }
}
