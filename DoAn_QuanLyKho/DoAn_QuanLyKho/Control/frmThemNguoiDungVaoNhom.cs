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

namespace DoAn_QuanLyKho.Control
{
    public partial class frmThemNguoiDungVaoNhom : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_QuanLyKho);

        }

        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_QuanLyKho.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.dataSet_QuanLyKho.QL_NhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet_QuanLyKho.QL_NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSet_QuanLyKho.QL_NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSet_QuanLyKho.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.dataSet_QuanLyKho.QL_NguoiDung);

        }

        private void fillDKToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.qL_NguoiDungNhomNguoiDungDKTableAdapter.FillDK(this.dataSet_QuanLyKho.QL_NguoiDungNhomNguoiDungDK, maNhomNguoiDungToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        public void loadData()
        {
            try
            {
                this.qL_NguoiDungNhomNguoiDungDKTableAdapter.FillDK(this.dataSet_QuanLyKho.QL_NguoiDungNhomNguoiDungDK, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in qL_NguoiDungNhomNguoiDungDKDataGridView.SelectedRows)
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

        private void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //qL_NguoiDungNhomNguoiDungTableAdapter
            string _strTenDangNhap = qL_NguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
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
    }
}