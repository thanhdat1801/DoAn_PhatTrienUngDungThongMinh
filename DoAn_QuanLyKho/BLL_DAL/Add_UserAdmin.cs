using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Add_UserAdmin
    {
        public static AppSetting setting = new AppSetting();
        DefendPassword pass = new DefendPassword();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString"));

        public Add_UserAdmin()
        {

        }

        public bool addAdmin(string strTenDN, string strMatKhau, string strTenNhanVien, string strDiaChi, string strSoDT, string strEmail)
        {
            try
            {
                QL_NguoiDung nguoiDung = new QL_NguoiDung();
                nguoiDung.TenDangNhap = strTenDN;
                nguoiDung.MatKhau = pass.Encrypt(strMatKhau);
                nguoiDung.HoatDong = true;
                nguoiDung.TenNhanVien = strTenNhanVien;
                nguoiDung.DiaChi = strDiaChi;
                nguoiDung.SoDT = strSoDT;
                nguoiDung.Email = strEmail;
                quanLyKho.QL_NguoiDungs.InsertOnSubmit(nguoiDung);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
