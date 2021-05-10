using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Check_Login
    {
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext();

        public Check_Login()
        {

        }

        public int kiemTraDangNhap(string strTenDangNhap, string strMatKhau)
        {
            IQueryable<QL_NguoiDung> kq = quanLyKho.QL_NguoiDungs.Where(t => t.TenDangNhap == strTenDangNhap && t.MatKhau == strMatKhau);
            if (kq == null)
            {
                return 0; //Không tìm thấy đăng nhập
            }
            else
            {
                return 1; //Đăng nhập thành công
            }
        }
    }
}
