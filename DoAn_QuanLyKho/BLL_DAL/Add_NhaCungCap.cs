using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Add_NhaCungCap
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString"));
        
        public Add_NhaCungCap()
        {

        }

        public IQueryable<NhaCungCap> loadDataNCC()
        {
            return quanLyKho.NhaCungCaps.Select(t => t);
        }

        public bool add_NCC(string strMaNCC, string strTenNCC, string strDiaChi, string strThanhPho, string strSoDT1, string strSoDT2, string strEmail, string strGhiChu)
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCungCap = strMaNCC;
                ncc.TenNhaCungCap = strTenNCC;
                ncc.DiaChi = strDiaChi;
                ncc.ThanhPho = strThanhPho;
                ncc.SoDT1 = strSoDT1;
                ncc.SoDT2 = strSoDT2;
                ncc.Email = strEmail;
                ncc.GhiChu = strGhiChu;
                quanLyKho.NhaCungCaps.InsertOnSubmit(ncc);
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
