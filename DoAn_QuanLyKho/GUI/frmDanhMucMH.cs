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
    public partial class frmDanhMucMH : DevExpress.XtraEditors.XtraForm
    {
        DanhMucMH_BLL_DAL dm = new DanhMucMH_BLL_DAL();
        public frmDanhMucMH()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhMucMH_Load(object sender, EventArgs e)
        {
            grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
        }

        private void grvDanhMucManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDManHinh.Text = grvDanhMucManHinh.CurrentRow.Cells[0].Value.ToString();
            txtTenManHinh.Text = grvDanhMucManHinh.CurrentRow.Cells[1].Value.ToString();
        }
    }
}