using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading;

namespace BLL_DAL
{
    public class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\BLL_DAL\app.config");
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = Path.Combine(sFile)
            };
            
            config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        }

        private string strConn;

        public string StrConn { get => strConn; set => strConn = value; }

        public string GetConnectionString(string key)
        {
            StrConn = config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
            return StrConn;
        }

        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection(key);
            Properties.Settings.Default.Reload();
            Properties.Settings.Default.Save();
            //BLL_DAL.Properties.Settings.Default.DoAn_QuanLyKhoConnectionString = null;
        }

        public void SaveData()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10); //Simulator
            }
        }

        //public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        //{
        //    BLL_DAL.Properties.Settings.Default.DoAn_QuanLyKhoConnectionString = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
        //    BLL_DAL.Properties.Settings.Default.Save();
        //}
    }
}
