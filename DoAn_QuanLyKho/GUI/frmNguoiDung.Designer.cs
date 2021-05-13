
namespace GUI
{
    partial class frmNguoiDung
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
            this.control_NguoiDung1 = new BLL_DAL.Control_NguoiDung();
            this.SuspendLayout();
            // 
            // control_NguoiDung1
            // 
            this.control_NguoiDung1.Location = new System.Drawing.Point(0, 0);
            this.control_NguoiDung1.Name = "control_NguoiDung1";
            this.control_NguoiDung1.Size = new System.Drawing.Size(1192, 700);
            this.control_NguoiDung1.TabIndex = 0;
            // 
            // frmNguoiDung
            // 
            this.ClientSize = new System.Drawing.Size(1598, 860);
            this.Controls.Add(this.control_NguoiDung1);
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BLL_DAL.Control_NguoiDung control_NguoiDung1;
    }
}