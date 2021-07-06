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
using BLL_DAL;

namespace GUI
{
    public partial class frmQuanLyNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        QL_NhonmNguoiDung nhonmNguoiDung = new QL_NhonmNguoiDung();
        public frmQuanLyNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhomNguoiDung_Load(object sender, EventArgs e)
        {
            grvNhomNguoiDung.DataSource = nhonmNguoiDung.loadDataNhomNguoiDung();
        }

        private void grvNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNhomNguoiDung.Text = grvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            txtTenNhom.Text = grvNhomNguoiDung.CurrentRow.Cells[1].Value.ToString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}