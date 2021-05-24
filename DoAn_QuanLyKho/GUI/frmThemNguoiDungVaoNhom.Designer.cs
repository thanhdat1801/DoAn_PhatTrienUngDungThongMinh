
namespace GUI
{
    partial class frmThemNguoiDungVaoNhom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.control_ThenNguoiDungVaoNhom1 = new BLL_DAL.Control_ThenNguoiDungVaoNhom();
            this.SuspendLayout();
            // 
            // control_ThenNguoiDungVaoNhom1
            // 
            this.control_ThenNguoiDungVaoNhom1.Location = new System.Drawing.Point(2, -3);
            this.control_ThenNguoiDungVaoNhom1.Name = "control_ThenNguoiDungVaoNhom1";
            this.control_ThenNguoiDungVaoNhom1.Size = new System.Drawing.Size(1409, 760);
            this.control_ThenNguoiDungVaoNhom1.TabIndex = 0;
            // 
            // frmThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.control_ThenNguoiDungVaoNhom1);
            this.Name = "frmThemNguoiDungVaoNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng vào nhóm";
            this.ResumeLayout(false);

        }

        #endregion

        private BLL_DAL.Control_ThenNguoiDungVaoNhom control_ThenNguoiDungVaoNhom1;
    }
}