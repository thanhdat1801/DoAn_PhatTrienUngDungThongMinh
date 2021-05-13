
namespace GUI
{
    partial class frmLoading
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
            this.components = new System.ComponentModel.Container();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(32, 353);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(4);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(54, 16);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(32, 265);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 16);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Starting...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 242);
            this.panel1.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.BorderRadius = 10;
            this.progressBar1.Location = new System.Drawing.Point(32, 291);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.MaximumValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.progressBar1.Size = new System.Drawing.Size(547, 28);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // peLogo
            // 
            this.peLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peLogo.EditValue = global::GUI.Properties.Resources.wms_logo;
            this.peLogo.Location = new System.Drawing.Point(388, 327);
            this.peLogo.Margin = new System.Windows.Forms.Padding(4);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.AllowFocused = false;
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowMenu = false;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peLogo.Size = new System.Drawing.Size(207, 52);
            this.peLogo.TabIndex = 8;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.peLogo);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCopyright);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoading";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.Shown += new System.EventHandler(this.frmLoading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuProgressBar progressBar1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
    }
}
