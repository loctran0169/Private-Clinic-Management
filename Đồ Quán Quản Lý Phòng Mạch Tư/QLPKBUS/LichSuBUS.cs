﻿using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class LichSuBUS
    {
        private LichSuDAL lsDAL;
        public LichSuBUS()
        {
            lsDAL = new LichSuDAL();
        }

        public DataTable loadDuLieuloadDuLieuLichSuDangNhap(DateTime dt)
        {
            return lsDAL.loadDuLieuLichSuDangNhap(dt);

        }
        public bool them(LichSuDTO lsDTO)
        {
            bool re = lsDAL.them(lsDTO);

            return re;
        }
        public bool xoa()
        {
            bool re = lsDAL.xoa();

            return re;
        }
    }
}
