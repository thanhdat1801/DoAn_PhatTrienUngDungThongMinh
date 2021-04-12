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
    public partial class frmManHinh : DevExpress.XtraEditors.XtraForm
    {
        public frmManHinh()
        {
            InitializeComponent();
        }

        private void dM_ManHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dM_ManHinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_QuanLyKho);

        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_QuanLyKho.DM_ManHinh' table. You can move, or remove it, as needed.
            this.dM_ManHinhTableAdapter.Fill(this.dataSet_QuanLyKho.DM_ManHinh);

        }
    }
}