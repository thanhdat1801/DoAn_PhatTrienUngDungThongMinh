
namespace GUI
{
    partial class frmNhomNguoiDung
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
            this.control_NhomNguoiDung1 = new BLL_DAL.Control_NhomNguoiDung();
            this.SuspendLayout();
            // 
            // control_NhomNguoiDung1
            // 
            this.control_NhomNguoiDung1.Location = new System.Drawing.Point(3, 1);
            this.control_NhomNguoiDung1.Name = "control_NhomNguoiDung1";
            this.control_NhomNguoiDung1.Size = new System.Drawing.Size(1138, 698);
            this.control_NhomNguoiDung1.TabIndex = 0;
            // 
            // frmNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 700);
            this.Controls.Add(this.control_NhomNguoiDung1);
            this.Name = "frmNhomNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm người dùng";
            this.ResumeLayout(false);

        }

        #endregion

        private BLL_DAL.Control_NhomNguoiDung control_NhomNguoiDung1;
    }
}