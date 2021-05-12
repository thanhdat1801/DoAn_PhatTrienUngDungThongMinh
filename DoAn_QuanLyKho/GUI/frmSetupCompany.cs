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
using BLL_DAL;
using Custom_Control;

namespace GUI
{
    public partial class frmSetupCompany : DevExpress.XtraEditors.XtraForm
    {
        Company_Management company = new Company_Management();
        AppSetting setting = new AppSetting();
        public frmSetupCompany()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMail txt = new txtMail();
            bool rs = txt.isEmail(txtEmail.Text);
            if (rs == false)
            {
                MessageBox.Show("Sai định dạng email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtKichHoat.Text == "W269N-WFGWX-YVC9B-4J6C9-T83GX")
                {
                    bool kq = company.AddCompany(txtIDCompany.Text, txtCompany.Text, txtChiNhanhChinh.Text, txtChiNhanhPhu.Text, txtThanhPho.Text, txtMaBuuDien.Text, txtSoSeri.Text, txtSoDT1.Text, txtSoDT2.Text, txtFax.Text, txtEmail.Text, txtKichHoat.Text);
                    if (kq == true)
                    {
                        using (WaitForm1 frm1 = new WaitForm1(setting.SaveData))
                        {
                            frm1.ShowDialog(this);
                        }
                        MessageBox.Show("Lưu thông tin công ty thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmNguoiDungQuanTri frm = new frmNguoiDungQuanTri();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã kích hoạt của bạn không đúng hoặc hết hạn. Vui lòng liên hệ nhà cung cấp phần mềm của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}