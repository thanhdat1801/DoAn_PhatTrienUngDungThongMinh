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
    public partial class frmSetupCompany : DevExpress.XtraEditors.XtraForm
    {
        public frmSetupCompany()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Tất cả chưa được lưu, bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Save Information Company in your Database:
            
        }

        private void frmSetupCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}