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
    public partial class Control_ThenNguoiDungVaoNhom : DevExpress.XtraEditors.XtraUserControl
    {
        public Control_ThenNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            AppSetting setting = new AppSetting();
            tableAdapterManager.Connection.ConnectionString = setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString");
            try
            {
                this.qL_NguoiDungNhomNguoiDungDKTableAdapter.FillDK(this.dataSetLogin.QL_NguoiDungNhomNguoiDungDK, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //qL_NguoiDungNhomNguoiDungTableAdapter
            string _strTenDangNhap = qL_NguoiDungBunifuCustomDataGrid.CurrentRow.Cells[0].Value.ToString();
            string _strMaNhomNguoiDung = qL_NhomNguoiDungComboBox.SelectedValue.ToString();

            int? kq = qL_NguoiDungNhomNguoiDungTableAdapter.KiemTraKhoaChinh(_strTenDangNhap, _strMaNhomNguoiDung);
            if (kq.Value == 0)
            {
                qL_NguoiDungNhomNguoiDungTableAdapter.Insert(_strTenDangNhap, _strMaNhomNguoiDung, "");
                loadData();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Trùng khóa chính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in qL_NguoiDungNhomNguoiDungDKBunifuCustomDataGrid.SelectedRows)
            {
                if (this.qL_NguoiDungNhomNguoiDungDKTableAdapter.Delete(item.Cells[0].Value.ToString(), qL_NhomNguoiDungComboBox.SelectedValue.ToString(), item.Cells[2].Value.ToString()) == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                loadData();
            }
        }

        private void Control_ThenNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            tableAdapterManager.Connection.ConnectionString = setting.GetConnectionString("BLL_DAL.Properties.Settings.DoAn_QuanLyKhoConnectionString");
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSetLogin.QL_NguoiDungNhomNguoiDung);
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSetLogin.QL_NhomNguoiDung);
            this.qL_NguoiDungTableAdapter.Fill(this.dataSetLogin.QL_NguoiDung);
        }

        private void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
