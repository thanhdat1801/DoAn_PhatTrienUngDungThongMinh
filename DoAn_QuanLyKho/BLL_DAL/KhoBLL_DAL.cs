using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class KhoBLL_DAL
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public KhoBLL_DAL()
        {

        }

        //Load gridView
        public IQueryable loadDataKHo()
        {
            var data = quanLyKho.THONGTINKHOs.Select(s => new
            {
                ID_KHO = s.ID_KHO
            }
            );
            return data as IQueryable;
        }
    }
}
