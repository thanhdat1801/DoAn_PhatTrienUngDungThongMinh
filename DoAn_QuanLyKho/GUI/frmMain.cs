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
using BLL_DAL;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void openSubForm(Form frm)
        {
            //frm.MdiParent = this;
            pcMain.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pcMain.Controls.Add(frm);
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

        private void backstageViewButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void nbiUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNguoiDung frm = new frmNguoiDung();
            openSubForm(frm);
        }

        private void nbiNhomNguoiDung_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNhomNguoiDung frm = new frmNhomNguoiDung();
            openSubForm(frm);
        }

        private void nbiManHinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmManHinh frm = new frmManHinh();
            openSubForm(frm);
        }

        private void nbiThemNguoiDungVaoNhom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemNguoiDungVaoNhom frm = new frmThemNguoiDungVaoNhom();
            openSubForm(frm);
        }

        private void nbiPhanQuyen_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            openSubForm(frm);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AppSetting setting = new AppSetting();
            using (WaitForm1 frm = new WaitForm1(setting.SaveData))
            {
                frm.ShowDialog(this);
            }
            frmDashboard frm1 = new frmDashboard();
            frm1.Show();
        }

        private void pcMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            openSubForm(frm);
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}