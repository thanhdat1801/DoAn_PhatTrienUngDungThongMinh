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

namespace GUI
{
    public partial class frmDanhMucMH : DevExpress.XtraEditors.XtraForm
    {
        DanhMucMH_BLL_DAL dm = new DanhMucMH_BLL_DAL();
        public frmDanhMucMH()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhMucMH_Load(object sender, EventArgs e)
        {
            grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
        }

        private void grvDanhMucManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenManHinh.Text = grvDanhMucManHinh.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenmh = txtTenManHinh.Text;
            if(dm.themDanhMuc_MH(tenmh) == true)
            {
                grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenManHinh.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grvDanhMucManHinh.CurrentRow.Cells[0].Value.ToString());
            if(dm.xoaDanhMuc_MH(id) == true)
            {
                grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grvDanhMucManHinh.CurrentRow.Cells[0].Value.ToString());
            string tenmh = txtTenManHinh.Text;
            if (dm.suaDanhMuc_MH(id, tenmh) == true)
            {
                grvDanhMucManHinh.DataSource = dm.loadDataDanhMucMH();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenManHinh.Enabled = false;
            }   
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenManHinh.Enabled = true;
            txtTenManHinh.Focus();
            txtTenManHinh.ResetText();
        }
    }
}