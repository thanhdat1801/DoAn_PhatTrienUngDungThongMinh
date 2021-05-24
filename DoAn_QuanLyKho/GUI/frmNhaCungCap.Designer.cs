
namespace GUI
{
    partial class frmNhaCungCap
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
            this.grdNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdNhaCungCap
            // 
            this.grdNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.grdNhaCungCap.MainView = this.gridView1;
            this.grdNhaCungCap.Name = "grdNhaCungCap";
            this.grdNhaCungCap.Size = new System.Drawing.Size(1247, 773);
            this.grdNhaCungCap.TabIndex = 0;
            this.grdNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdNhaCungCap.Click += new System.EventHandler(this.grdNhaCungCap_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdNhaCungCap;
            this.gridView1.Name = "gridView1";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 773);
            this.Controls.Add(this.grdNhaCungCap);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}