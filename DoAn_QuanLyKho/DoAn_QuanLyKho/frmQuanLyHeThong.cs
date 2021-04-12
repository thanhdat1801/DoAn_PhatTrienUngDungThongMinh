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

namespace DoAn_QuanLyKho
{
    public partial class frmQuanLyHeThong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQuanLyHeThong()
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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control.frmNguoiDung frm = new Control.frmNguoiDung();
            openSubForm(frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control.frmNhomNguoiDung frm = new Control.frmNhomNguoiDung();
            openSubForm(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control.frmManHinh frm = new Control.frmManHinh();
            openSubForm(frm);
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barEditItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control.frmThemNguoiDungVaoNhom frm = new Control.frmThemNguoiDungVaoNhom();
            openSubForm(frm);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control.frmPhanQuyen frm = new Control.frmPhanQuyen();
            openSubForm(frm);
        }

        private void frmQuanLyHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void colorPickEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}