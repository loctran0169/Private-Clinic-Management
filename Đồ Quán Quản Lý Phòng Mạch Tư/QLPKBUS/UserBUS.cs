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
    public class UserBUS
    {
        private UserDAL bdal;
        public UserBUS()
        {
            bdal = new UserDAL();
        }
        public bool them(UserDTO lb)
        {
            bool re = bdal.them(lb);
            return re;
        }

        public bool xoa(UserDTO lb)
        {
            bool re = bdal.xoa(lb);
            return re;
        }

        public bool sua(UserDTO lb)
        {
            bool re = bdal.sua(lb);
            return re;
        }

        public List<UserDTO> select()
        {
            return bdal.select();
        }
        public List<UserDTO> selectByKeyWord(string sKeyword)
        {
            return bdal.selectByKeyWord(sKeyword);
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
    }
}
