using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class MyDllConfig : IDisposable
    {
        private string _oldConfig;
        private bool _libCompat;
        private const string _newConfig = "BLL_DAL.dll.config";
        // don't forget to rename this!!

        public MyDllConfig()
        {
            _libCompat = Assembly.GetAssembly(typeof(ConfigurationSettings)).GetName().Version.ToString().CompareTo("1.0.5000.0") == 0;
            _oldConfig = AppDomain.CurrentDomain.GetData("APP_CONFIG_FILE").ToString();
            Switch(_newConfig);
        }
        protected void Switch(string config)
        {
            if (_libCompat)
            {
                AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", config);
                FieldInfo fiInit = typeof(System.Configuration.ConfigurationSettings).GetField("_configurationInitialized",BindingFlags.NonPublic | BindingFlags.Static);
                FieldInfo fiSystem = typeof(System.Configuration.ConfigurationSettings).GetField("_configSystem", BindingFlags.NonPublic | BindingFlags.Static);
                if (fiInit != null && fiSystem != null)
                {
                    fiInit.SetValue(null, false);
                    fiSystem.SetValue(null, null);
                }
            }
        }

        public void Dispose()
        {
            Switch(_oldConfig);
        }

        [Obsolete]
        public static string ConnectionString()
        {
            string cstr;
            using (new MyDllConfig())
            {
                cstr = ConfigurationSettings.AppSettings["ConnectionString"];
            }
            return cstr;
        }
    }
}
