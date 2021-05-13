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

        public void openSubForm(Form frm)
        {
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmQuanLyKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNguoiDung frm = new frmNguoiDung();
            openSubForm(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmManHinh frm = new frmManHinh();
            openSubForm(frm);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThemNguoiDungVaoNhom frm = new frmThemNguoiDungVaoNhom();
            openSubForm(frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhomNguoiDung frm = new frmNhomNguoiDung();
            openSubForm(frm);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            openSubForm(frm);
        }
    }
}