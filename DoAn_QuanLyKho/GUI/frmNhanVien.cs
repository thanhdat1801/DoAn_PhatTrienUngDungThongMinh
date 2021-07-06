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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNhanVien_Shown(object sender, EventArgs e)
        {
            grvNhanVien.Rows.Add(
                new object[]
                {
                    1,
                    "Phan Văn Đại"
                }
                );
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}