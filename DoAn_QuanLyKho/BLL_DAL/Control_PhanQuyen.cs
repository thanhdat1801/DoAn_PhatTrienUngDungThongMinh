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
    public partial class Control_PhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        public Control_PhanQuyen()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetLogin);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string _strNhomNguoiDung = qL_NhomNguoiDungBunifuCustomDataGrid.CurrentRow.Cells[0].Value.ToString();
            foreach (DataGridViewRow item in qL_GetPhanQuyenBunifuCustomDataGrid.Rows)
            {
                if (qL_GetPhanQuyenTableAdapter.KiemTraKhoaChinh(_strNhomNguoiDung, item.Cells[0].Value.ToString()) == null)
                {
                    try
                    {
                        qL_PhanQuyenTableAdapter.Insert(_strNhomNguoiDung, item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                    }
                    catch
                    {
                        qL_PhanQuyenTableAdapter.Insert(_strNhomNguoiDung, item.Cells[0].Value.ToString(), false);
                    }
                }
                else
                {
                    try
                    {
                        qL_PhanQuyenTableAdapter.UpdateQuery((item.Cells[2] == null) ? false : (bool)(item.Cells[2].Value), _strNhomNguoiDung, item.Cells[0].Value.ToString());
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        public void loadData()
        {
            this.qL_GetPhanQuyenTableAdapter.Fill(this.dataSetLogin.QL_GetPhanQuyen, qL_NhomNguoiDungBunifuCustomDataGrid.CurrentRow.Cells[0].Value.ToString());
        }

        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Control_PhanQuyen_Load(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            tableAdapterManager.Connection.ConnectionString = setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString");
            this.qL_PhanQuyenTableAdapter.Fill(this.dataSetLogin.QL_PhanQuyen);
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSetLogin.QL_NhomNguoiDung);

        }

        private void qL_NhomNguoiDungBunifuCustomDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
