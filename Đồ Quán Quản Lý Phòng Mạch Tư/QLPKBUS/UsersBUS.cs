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
    public class UsersBUS
    {

        //private UsersDAL usDAL;
        //public UsersBUS()
        //{
        //    usDAL = new UsersDAL();
        //}
        //public DataTable dangNhap(UsersDTO us)
        //{
        //    DataTable k = usDAL.dangNhap(us);
        //    return k;
        //}
        //public DataTable loadDuLieuUsers()
        //{
        //    DataTable k = usDAL.loadDuLieuUsers();
        //    return k;
        //}
        //public DataTable loadDuLieuNhanVien()
        //{
        //    DataTable k = new DataTable();
        //    k = usDAL.loadDuLieuNhanVien();
        //    return k;

        //}
        //public DataTable loadDuLieuQuyenHan()
        //{
        //    DataTable k = new DataTable();
        //    k = usDAL.loadDuLieuQuyenHan();
        //    return k;

        //}
        //public bool doiMatKhau(UsersDTO us)
        //{
        //    bool re = usDAL.doiMatKhau(us);
        //    return re;
        //}
        //public bool them(UsersDTO us)
        //{
        //    bool re = usDAL.them(us);

        //    return re;
        //}
        //public bool sua(UsersDTO us)
        //{
        //    bool re = usDAL.sua(us);

        //    return re;
        //}
        //public bool xoa(UsersDTO us)
        //{
        //    bool re = usDAL.xoa(us);

        //    return re;
        //}
        private UsersDAL bdal;
        public UsersBUS()
        {
            bdal = new UsersDAL();
        }
        public bool them(UsersDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(UsersDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(UsersDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }
        public bool suamk(UsersDTO lb)
        {
            bool re = bdal.suamk(lb);
            return re;
        }
   
        public DataTable loadDuLieuUsers()
        {
            return bdal.loadDuLieuUsers();
        }

        public DataTable loadDuLieuNhanVien()
        {
            return bdal.loadDuLieuNhanVien();
        }
        public DataTable loadDuLieuQuyenHan()
        {
            return bdal.loadDuLieuQuyenHan();
        }
        public bool CheckPass(string tk, string mk)
        {
            return bdal.CheckPass(tk, mk);
        }
        public DataTable dangNhap(UsersDTO us)
        {
            return bdal.dangNhap(us);
        }
        /*  public List<UsersDTO> select()
     {
         return bdal.select();
     }
     public List<UsersDTO> selectByKeyWord(string sKeyword)
     {
         return bdal.selectByKeyWord(sKeyword);
     }
 */
    }
}
