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
        private ThamSoDAL tsBus;
        public ThamSoBUS()
        {
            tsBus = new ThamSoDAL();
        }
        public bool sua(ThamSoDTO ts)
        {
            bool re = tsBus.sua(ts);
            return re;
        }
        public List<ThamSoDTO> select()
        {
            return tsBus.select();
        }
    }
}
