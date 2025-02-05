﻿using System;
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

        public bool themDanhMuc_MH(string tenmh)
        {
            try
            {
                MANHINH mh = new MANHINH();
                mh.TENMANHINH = tenmh;
                quanLyKho.MANHINHs.InsertOnSubmit(mh);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaDanhMuc_MH(int id)
        {
            try
            {
                MANHINH mh = quanLyKho.MANHINHs.Where(s => s.ID_MANHINH == id).FirstOrDefault();
                quanLyKho.MANHINHs.DeleteOnSubmit(mh);
                quanLyKho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaDanhMuc_MH(int id, string tenmh)
        {
            try
            {
                MANHINH mh = quanLyKho.MANHINHs.Where(s => s.ID_MANHINH == id).FirstOrDefault();
                mh.TENMANHINH = tenmh;
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
