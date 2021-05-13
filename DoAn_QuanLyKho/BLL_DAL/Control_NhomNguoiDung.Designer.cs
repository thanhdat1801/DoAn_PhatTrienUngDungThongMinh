
namespace BLL_DAL
{
    partial class Control_NhomNguoiDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maNhomLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_NhomNguoiDung));
            this.dataSetLogin = new BLL_DAL.DataSetLogin();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new BLL_DAL.DataSetLoginTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new BLL_DAL.DataSetLoginTableAdapters.TableAdapterManager();
            this.qL_NhomNguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.qL_NhomNguoiDungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NhomNguoiDungGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maNhomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenNhomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghiChuTextEdit = new DevExpress.XtraEditors.TextEdit();
            maNhomLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingNavigator)).BeginInit();
            this.qL_NhomNguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maNhomLabel
            // 
            maNhomLabel.AutoSize = true;
            maNhomLabel.Location = new System.Drawing.Point(4, 47);
            maNhomLabel.Name = "maNhomLabel";
            maNhomLabel.Size = new System.Drawing.Size(70, 17);
            maNhomLabel.TabIndex = 2;
            maNhomLabel.Text = "&Mã nhóm:";
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.Location = new System.Drawing.Point(4, 75);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(76, 17);
            tenNhomLabel.TabIndex = 4;
            tenNhomLabel.Text = "&Tên nhóm:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(4, 103);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(59, 17);
            ghiChuLabel.TabIndex = 6;
            ghiChuLabel.Text = "&Ghi chú:";
            // 
            // dataSetLogin
            // 
            this.dataSetLogin.DataSetName = "DataSetLogin";
            this.dataSetLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.dataSetLogin;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BLL_DAL.DataSetLoginTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NhomNguoiDungBindingNavigator
            // 
            this.qL_NhomNguoiDungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NhomNguoiDungBindingNavigator.BindingSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NhomNguoiDungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NhomNguoiDungBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qL_NhomNguoiDungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qL_NhomNguoiDungBindingNavigatorSaveItem});
            this.qL_NhomNguoiDungBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NhomNguoiDungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NhomNguoiDungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NhomNguoiDungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NhomNguoiDungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NhomNguoiDungBindingNavigator.Name = "qL_NhomNguoiDungBindingNavigator";
            this.qL_NhomNguoiDungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NhomNguoiDungBindingNavigator.Size = new System.Drawing.Size(956, 31);
            this.qL_NhomNguoiDungBindingNavigator.TabIndex = 0;
            this.qL_NhomNguoiDungBindingNavigator.Text = "bindingNavigator1";
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
            // qL_NhomNguoiDungBindingNavigatorSaveItem
            // 
            this.qL_NhomNguoiDungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NhomNguoiDungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NhomNguoiDungBindingNavigatorSaveItem.Image")));
            this.qL_NhomNguoiDungBindingNavigatorSaveItem.Name = "qL_NhomNguoiDungBindingNavigatorSaveItem";
            this.qL_NhomNguoiDungBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.qL_NhomNguoiDungBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NhomNguoiDungBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NhomNguoiDungBindingNavigatorSaveItem_Click);
            // 
            // qL_NhomNguoiDungGridControl
            // 
            this.qL_NhomNguoiDungGridControl.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungGridControl.Location = new System.Drawing.Point(3, 141);
            this.qL_NhomNguoiDungGridControl.MainView = this.gridView1;
            this.qL_NhomNguoiDungGridControl.Name = "qL_NhomNguoiDungGridControl";
            this.qL_NhomNguoiDungGridControl.Size = new System.Drawing.Size(950, 480);
            this.qL_NhomNguoiDungGridControl.TabIndex = 1;
            this.qL_NhomNguoiDungGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.qL_NhomNguoiDungGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // maNhomTextEdit
            // 
            this.maNhomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NhomNguoiDungBindingSource, "MaNhom", true));
            this.maNhomTextEdit.Location = new System.Drawing.Point(87, 44);
            this.maNhomTextEdit.Name = "maNhomTextEdit";
            this.maNhomTextEdit.Size = new System.Drawing.Size(294, 22);
            this.maNhomTextEdit.TabIndex = 3;
            // 
            // tenNhomTextEdit
            // 
            this.tenNhomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NhomNguoiDungBindingSource, "TenNhom", true));
            this.tenNhomTextEdit.Location = new System.Drawing.Point(87, 72);
            this.tenNhomTextEdit.Name = "tenNhomTextEdit";
            this.tenNhomTextEdit.Size = new System.Drawing.Size(294, 22);
            this.tenNhomTextEdit.TabIndex = 5;
            // 
            // ghiChuTextEdit
            // 
            this.ghiChuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NhomNguoiDungBindingSource, "GhiChu", true));
            this.ghiChuTextEdit.Location = new System.Drawing.Point(87, 100);
            this.ghiChuTextEdit.Name = "ghiChuTextEdit";
            this.ghiChuTextEdit.Size = new System.Drawing.Size(294, 22);
            this.ghiChuTextEdit.TabIndex = 7;
            // 
            // Control_NhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maNhomLabel);
            this.Controls.Add(this.maNhomTextEdit);
            this.Controls.Add(tenNhomLabel);
            this.Controls.Add(this.tenNhomTextEdit);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.qL_NhomNguoiDungGridControl);
            this.Controls.Add(this.qL_NhomNguoiDungBindingNavigator);
            this.Controls.Add(this.ghiChuTextEdit);
            this.Name = "Control_NhomNguoiDung";
            this.Size = new System.Drawing.Size(956, 624);
            this.Load += new System.EventHandler(this.Control_NhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingNavigator)).EndInit();
            this.qL_NhomNguoiDungBindingNavigator.ResumeLayout(false);
            this.qL_NhomNguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetLogin dataSetLogin;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private DataSetLoginTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private DataSetLoginTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NhomNguoiDungBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton qL_NhomNguoiDungBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl qL_NhomNguoiDungGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit maNhomTextEdit;
        private DevExpress.XtraEditors.TextEdit tenNhomTextEdit;
        private DevExpress.XtraEditors.TextEdit ghiChuTextEdit;
    }
}
