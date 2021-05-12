using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLyKho : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmQuanLyKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}