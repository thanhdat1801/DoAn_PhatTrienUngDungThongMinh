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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void openSubForm(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            mainPanel.BringToFront();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_1_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            indicator.Top = ((Control)sender).Top;
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
        }

        private void btnLienHe_2_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhà cung cấp";
            indicator.Top = ((Control)sender).Top;
            frmNhaCungCap frm = new frmNhaCungCap();
            openSubForm(frm);
        }

        private void btnKho_3_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Quản lý kho";
            indicator.Top = ((Control)sender).Top;
            frmQuanLyKho frm = new frmQuanLyKho();
            openSubForm(frm);
        }

        private void btnSanPham_4_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Sản phẩm";
            indicator.Top = ((Control)sender).Top;
        }

        private void btnBaoCao_5_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Báo cáo";
            indicator.Top = ((Control)sender).Top;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Trang chủ";
            frmTrangChu frm = new frmTrangChu();
            openSubForm(frm);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Nhân viên";
            indicator.Top = ((Control)sender).Top;
            frmNhanVien frm = new frmNhanVien();
            openSubForm(frm);
        }
    }
}