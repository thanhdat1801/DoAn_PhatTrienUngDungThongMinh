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

namespace GUI
{
    public partial class frmQuanLyKho : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TestMapControl testMapControl = new TestMapControl();
            testMapControl.Show();
        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {

        }
    }
}