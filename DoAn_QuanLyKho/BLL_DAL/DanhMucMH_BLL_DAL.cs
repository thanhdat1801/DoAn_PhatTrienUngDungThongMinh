using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DanhMucMH_BLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public DanhMucMH_BLL_DAL()
        {

        }

        public IQueryable loadDataDanhMucMH()
        {
            var data = quanLyKho.MANHINHs.Select(s => new
            {
                ID_MANHINH = s.ID_MANHINH,
                TENMANHINH = s.TENMANHINH
            }
            );
            return data as IQueryable;
        }
    }
}
