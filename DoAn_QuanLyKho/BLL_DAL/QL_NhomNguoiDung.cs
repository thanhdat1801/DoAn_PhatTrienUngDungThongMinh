using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QL_NhomNguoiDung
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.QL_KHOHANGConnectionString"));

        public QL_NhomNguoiDung()
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

        public bool themNhomNguoiDung(string id, string tennhom)
        {
            try
            {
                NHOMNGUOIDUNG mh = new NHOMNGUOIDUNG();
                mh.ID_NHOM = id;
                mh.TENNHOM = tennhom;
                quanLyKho.NHOMNGUOIDUNGs.InsertOnSubmit(mh);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhomNguoiDung(string id)
        {
            try
            {
                NHOMNGUOIDUNG mh = quanLyKho.NHOMNGUOIDUNGs.Where(s => s.ID_NHOM == id).FirstOrDefault();
                quanLyKho.NHOMNGUOIDUNGs.DeleteOnSubmit(mh);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaNhomNguoiDung(string id, string tennhom)
        {
            try
            {
                NHOMNGUOIDUNG mh = quanLyKho.NHOMNGUOIDUNGs.Where(s => s.ID_NHOM == id).FirstOrDefault();
                mh.TENNHOM = tennhom;
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
