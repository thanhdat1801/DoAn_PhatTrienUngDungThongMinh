using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BLL_DAL
{
    public class Company_Management
    {
        public static AppSetting setting = new AppSetting();
        QuanLyKhoDataContext quanLyKho = new QuanLyKhoDataContext(setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString"));

        public Company_Management()
        {

        }

        public bool AddCompany(string strIDCompany, string TenCongTy, string ChiNhanhChinh, string ChiNhanhPhu, string ThanhPho, string MaBuuDien, string SoSerial, string Sdt1, string sdt2, string SoFax, string EmailDK, string KichHoat)
        {
            try
            {
                ThietLapCongTy congTy = new ThietLapCongTy();
                congTy.IDCompany = strIDCompany;
                congTy.TenCongTy = TenCongTy;
                congTy.ChiNhanhChi = ChiNhanhChinh;
                congTy.ChiNhanhPhu = ChiNhanhPhu;
                congTy.ThanhPho = ThanhPho;
                congTy.MaBuuDien = MaBuuDien;
                congTy.SoSerial = SoSerial;
                congTy.SoDT1 = Sdt1;
                congTy.SoDT2 = sdt2;
                congTy.SoFAX = SoFax;
                congTy.EmailDK = EmailDK;
                congTy.KichHoat = KichHoat;
                quanLyKho.ThietLapCongTies.InsertOnSubmit(congTy);
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
