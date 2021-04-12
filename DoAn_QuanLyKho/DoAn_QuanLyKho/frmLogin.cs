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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        ConnectDatabase conn = new ConnectDatabase();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                this.txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPass.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                this.txtPass.Focus();
                return;
            }
            int kq = conn.Check_Config(); //hàm Check_Config()
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại", "Thông báo", MessageBoxButtons.OK);// Xử lý cấu hình
                //ProcessConfig();
                this.Hide();
                frmCauHinh ch = new frmCauHinh();
                ch.ShowDialog();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp", "Thông báo", MessageBoxButtons.OK);// Xử lý cấu hình
                this.Hide();
                frmCauHinh ch = new frmCauHinh();
                ch.ShowDialog();
            }
        }

        private void ProcessLogin()
        {
            int result;
            result = conn.Check_User(txtUser.Text, txtPass.Text); //Check_User
            //Wrong name or pass
            if (result == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            //Account has been disable
            else if (result == -1)
            {
                MessageBox.Show("Tài khoản bị khóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                frmQuanLyHeThong frm = new frmQuanLyHeThong();
                frm.ShowDialog();
                this.Hide();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}