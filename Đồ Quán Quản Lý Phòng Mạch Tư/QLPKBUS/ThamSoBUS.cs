using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class ThamSoBUS
    {
        private ThamSoDAL bdal;

        public ThamSoBUS()
        {
            bdal = new ThamSoDAL();
        }   
            

        public bool sua(ThamSoDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<ThamSoDTO> select()
        {
            return bdal.select();
        }
        
    }
}
