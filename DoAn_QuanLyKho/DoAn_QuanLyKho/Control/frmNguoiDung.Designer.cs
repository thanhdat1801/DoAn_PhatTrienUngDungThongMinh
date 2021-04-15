
namespace DoAn_QuanLyKho.Control
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hoatDongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.dataSet_QuanLyKho = new DoAn_QuanLyKho.Modules.DataSet_QuanLyKho();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungTableAdapter = new DoAn_QuanLyKho.Modules.DataSet_QuanLyKhoTableAdapters.QL_NguoiDungTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKho.Modules.DataSet_QuanLyKhoTableAdapters.TableAdapterManager();
            this.qL_NguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.qL_NguoiDungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NguoiDungGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenDangNhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoatDongCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QuanLyKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).BeginInit();
            this.qL_NguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(16, 56);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(106, 17);
            tenDangNhapLabel.TabIndex = 2;
            tenDangNhapLabel.Text = "Tên đăng nhập:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(16, 84);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(69, 17);
            matKhauLabel.TabIndex = 4;
            matKhauLabel.Text = "Mật khẩu:";
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(16, 112);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(78, 17);
            hoatDongLabel.TabIndex = 6;
            hoatDongLabel.Text = "Hoạt động:";
            // 
            // dataSet_QuanLyKho
            // 
            this.dataSet_QuanLyKho.DataSetName = "DataSet_QuanLyKho";
            this.dataSet_QuanLyKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.dataSet_QuanLyKho;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangKhoTableAdapter = null;
            this.tableAdapterManager.BangPhieuNhapKhoTableAdapter = null;
            this.tableAdapterManager.BangThuKhoTableAdapter = null;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.HangHoaTableAdapter = null;
            this.tableAdapterManager.NhomHangTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKho.Modules.DataSet_QuanLyKhoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NguoiDungBindingNavigator
            // 
            this.qL_NguoiDungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NguoiDungBindingNavigator.BindingSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NguoiDungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NguoiDungBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qL_NguoiDungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.qL_NguoiDungBindingNavigatorSaveItem});
            this.qL_NguoiDungBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NguoiDungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NguoiDungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NguoiDungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NguoiDungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NguoiDungBindingNavigator.Name = "qL_NguoiDungBindingNavigator";
            this.qL_NguoiDungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NguoiDungBindingNavigator.Size = new System.Drawing.Size(787, 31);
            this.qL_NguoiDungBindingNavigator.TabIndex = 0;
            this.qL_NguoiDungBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // qL_NguoiDungBindingNavigatorSaveItem
            // 
            this.qL_NguoiDungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NguoiDungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NguoiDungBindingNavigatorSaveItem.Image")));
            this.qL_NguoiDungBindingNavigatorSaveItem.Name = "qL_NguoiDungBindingNavigatorSaveItem";
            this.qL_NguoiDungBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.qL_NguoiDungBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NguoiDungBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NguoiDungBindingNavigatorSaveItem_Click_4);
            // 
            // qL_NguoiDungGridControl
            // 
            this.qL_NguoiDungGridControl.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungGridControl.Location = new System.Drawing.Point(12, 151);
            this.qL_NguoiDungGridControl.MainView = this.gridView1;
            this.qL_NguoiDungGridControl.Name = "qL_NguoiDungGridControl";
            this.qL_NguoiDungGridControl.Size = new System.Drawing.Size(755, 436);
            this.qL_NguoiDungGridControl.TabIndex = 1;
            this.qL_NguoiDungGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.qL_NguoiDungGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // tenDangNhapTextEdit
            // 
            this.tenDangNhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextEdit.Location = new System.Drawing.Point(131, 53);
            this.tenDangNhapTextEdit.Name = "tenDangNhapTextEdit";
            this.tenDangNhapTextEdit.Size = new System.Drawing.Size(298, 22);
            this.tenDangNhapTextEdit.TabIndex = 3;
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "MatKhau", true));
            this.matKhauTextEdit.Location = new System.Drawing.Point(131, 81);
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Size = new System.Drawing.Size(298, 22);
            this.matKhauTextEdit.TabIndex = 5;
            // 
            // hoatDongCheckEdit
            // 
            this.hoatDongCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "HoatDong", true));
            this.hoatDongCheckEdit.Location = new System.Drawing.Point(131, 109);
            this.hoatDongCheckEdit.Name = "hoatDongCheckEdit";
            this.hoatDongCheckEdit.Properties.Caption = "";
            this.hoatDongCheckEdit.Size = new System.Drawing.Size(125, 24);
            this.hoatDongCheckEdit.TabIndex = 7;
            this.hoatDongCheckEdit.CheckedChanged += new System.EventHandler(this.hoatDongCheckEdit_CheckedChanged);
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 607);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(this.tenDangNhapTextEdit);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextEdit);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckEdit);
            this.Controls.Add(this.qL_NguoiDungGridControl);
            this.Controls.Add(this.qL_NguoiDungBindingNavigator);
            this.Name = "frmNguoiDung";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QuanLyKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).EndInit();
            this.qL_NguoiDungBindingNavigator.ResumeLayout(false);
            this.qL_NguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Modules.DataSet_QuanLyKho dataSet_QuanLyKho;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private Modules.DataSet_QuanLyKhoTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private Modules.DataSet_QuanLyKhoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NguoiDungBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton qL_NguoiDungBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl qL_NguoiDungGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit tenDangNhapTextEdit;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
        private DevExpress.XtraEditors.CheckEdit hoatDongCheckEdit;
    }
}