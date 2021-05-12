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
    public partial class frmNguoiDungQuanTri : DevExpress.XtraEditors.XtraForm
    {
        public frmNguoiDungQuanTri()
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

        private void frmNguoiDungQuanTri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_UserAdmin add = new Add_UserAdmin();
            AppSetting setting = new AppSetting();
            txtMail txt = new txtMail();
            bool cus = txt.isEmail(txtMail.Text);
            if (cus == false)
            {
                MessageBox.Show("Sai định dạng email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kq = add.addAdmin(txtUsername.Text, txtPass.Text, txtTenNV.Text, txtDiaChi.Text, txtNumber.Text, txtMail.Text);
                if (kq == true)
                {
                    using (WaitForm1 frm1 = new WaitForm1(setting.SaveData))
                    {
                        frm1.ShowDialog(this);
                    }
                    MessageBox.Show("Tạo tài khoản thành công. Bây giờ đăng nhập lại để thực hiện công việc tiếp theo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkShowPass_OnChange(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == false)
            {
                txtPass.isPassword = true;
            }
            else
            {
                txtPass.isPassword = false;
            }
        }
    }
}