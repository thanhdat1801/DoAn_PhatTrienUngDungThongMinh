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
using DoAn_QuanLyKho.Class;

namespace DoAn_QuanLyKho
{
    public partial class frmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        ConnectDatabase connect = new ConnectDatabase();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.SaveConfig(cboSevername.Text, txtUsername.Text, txtPassword.Text, cboDataname.Text);
                if (connect.Check_Company() == 1)
                {
                    this.Hide();
                    frmLogin frm = new frmLogin();
                    frm.Show();
                }
                else
                {
                    this.Hide();
                    Control.frmSetupCompany frm = new Control.frmSetupCompany();
                    frm.Show();
                }    
            }
            catch
            {
                MessageBox.Show("Cấu hình thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboSevername_DropDown(object sender, EventArgs e)
        {
            cboSevername.DataSource = connect.GetSeverName();
            cboSevername.DisplayMember = "SeverName";
        }

        private void cboDataname_DropDown(object sender, EventArgs e)
        {
            cboDataname.DataSource = connect.GetDBName(cboSevername.Text, txtUsername.Text, txtPassword.Text);
            cboDataname.DisplayMember = "name";
        }
    }
}