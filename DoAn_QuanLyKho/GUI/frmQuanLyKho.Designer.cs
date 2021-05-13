
namespace GUI
{
    partial class frmQuanLyKho
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1,
            this.repositoryItemTextEdit1});
            this.ribbon.Size = new System.Drawing.Size(1325, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Người dùng          ";
            this.barButtonItem1.Hint = "Chức năng này sử dụng để thêm, xóa hoặc sửa người dùng";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.Image = global::GUI.Properties.Resources.customer_16x16;
            this.barButtonItem1.ImageOptions.LargeImage = global::GUI.Properties.Resources.customer_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Nhóm người dùng            ";
            this.barButtonItem2.Hint = "Chức năng này để quản lý nhóm người dùng";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.Image = global::GUI.Properties.Resources.publicfix_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = global::GUI.Properties.Resources.publicfix_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Màn hình sử dụng              ";
            this.barButtonItem3.Hint = "Chức năng này để quản lý màn hình sử dùng";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.Image = global::GUI.Properties.Resources.example_16x16;
            this.barButtonItem3.ImageOptions.LargeImage = global::GUI.Properties.Resources.example_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm người dùng vào nhóm                      ";
            this.barButtonItem4.Hint = "Chức năng này để thêm người dùng vào 1 nhóm";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageOptions.Image = global::GUI.Properties.Resources.assignto_16x16;
            this.barButtonItem4.ImageOptions.LargeImage = global::GUI.Properties.Resources.assignto_32x32;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Phân quyền";
            this.barButtonItem5.Hint = "Chức năng này để phân quyền người dùng";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.ImageOptions.Image = global::GUI.Properties.Resources.bouser_16x16;
            this.barButtonItem5.ImageOptions.LargeImage = global::GUI.Properties.Resources.bouser_32x32;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý nhân viên";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 803);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1325, 30);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = global::GUI.Properties.Resources.user_32x321;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý nhân viên";
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 833);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmQuanLyKho";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyKho_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}