
namespace GUI
{
    partial class frmPhanQuyen
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
            this.control_PhanQuyen1 = new BLL_DAL.Control_PhanQuyen();
            this.SuspendLayout();
            // 
            // control_PhanQuyen1
            // 
            this.control_PhanQuyen1.Location = new System.Drawing.Point(4, 2);
            this.control_PhanQuyen1.Name = "control_PhanQuyen1";
            this.control_PhanQuyen1.Size = new System.Drawing.Size(1232, 810);
            this.control_PhanQuyen1.TabIndex = 0;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 811);
            this.Controls.Add(this.control_PhanQuyen1);
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền";
            this.ResumeLayout(false);

        }

        #endregion

        private BLL_DAL.Control_PhanQuyen control_PhanQuyen1;
    }
}