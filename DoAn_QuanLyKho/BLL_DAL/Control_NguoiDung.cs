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
    public partial class Control_NguoiDung : DevExpress.XtraEditors.XtraUserControl
    {
        public Control_NguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetLogin);

        }

        private void Control_NguoiDung_Load(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            tableAdapterManager.Connection.ConnectionString = setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString");
            this.qL_NguoiDungTableAdapter.Fill(this.dataSetLogin.QL_NguoiDung);
        }
    }
}
