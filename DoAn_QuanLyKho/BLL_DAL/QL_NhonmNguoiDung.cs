using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QL_NhonmNguoiDung
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public QL_NhonmNguoiDung()
        {

        }

        public IQueryable loadDataNhomNguoiDung()
        {
            var data = quanLyKho.NHOMNGUOIDUNGs.Select(s => new
            {
                ID_NHOM = s.ID_NHOM,
                TENNHOM = s.TENNHOM
            }
            );
            return data as IQueryable;
        }
    }
}
