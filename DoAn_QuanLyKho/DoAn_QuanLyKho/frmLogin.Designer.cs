
namespace DoAn_QuanLyKho
{
    partial class frmLogin
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
            this.control_DangNhap1 = new DoAn_QuanLyKho.Control.Control_DangNhap();
            this.SuspendLayout();
            // 
            // control_DangNhap1
            // 
            this.control_DangNhap1.Location = new System.Drawing.Point(3, 2);
            this.control_DangNhap1.Name = "control_DangNhap1";
            this.control_DangNhap1.Size = new System.Drawing.Size(760, 318);
            this.control_DangNhap1.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 332);
            this.Controls.Add(this.control_DangNhap1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.Control_DangNhap control_DangNhap1;
    }
}