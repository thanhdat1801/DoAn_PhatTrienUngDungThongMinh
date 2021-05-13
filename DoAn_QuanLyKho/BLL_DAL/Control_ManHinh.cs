using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public partial class Control_ManHinh : DevExpress.XtraEditors.XtraUserControl
    {
        public Control_ManHinh()
        {
            InitializeComponent();
        }

        private void dM_ManHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dM_ManHinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetLogin);

        }

        private void Control_ManHinh_Load(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            tableAdapterManager.Connection.ConnectionString = setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString");
            this.dM_ManHinhTableAdapter.Fill(this.dataSetLogin.DM_ManHinh);
        }
    }
}
