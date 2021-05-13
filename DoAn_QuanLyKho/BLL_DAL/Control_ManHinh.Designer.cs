
namespace BLL_DAL
{
    partial class Control_ManHinh
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
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_ManHinh));
            this.dataSetLogin = new BLL_DAL.DataSetLogin();
            this.dM_ManHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ManHinhTableAdapter = new BLL_DAL.DataSetLoginTableAdapters.DM_ManHinhTableAdapter();
            this.tableAdapterManager = new BLL_DAL.DataSetLoginTableAdapters.TableAdapterManager();
            this.dM_ManHinhBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dM_ManHinhBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dM_ManHinhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maManHinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenManHinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingNavigator)).BeginInit();
            this.dM_ManHinhBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maManHinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenManHinhTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.Location = new System.Drawing.Point(4, 56);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(91, 17);
            maManHinhLabel.TabIndex = 2;
            maManHinhLabel.Text = "&Mã màn hình:";
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.Location = new System.Drawing.Point(4, 84);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(97, 17);
            tenManHinhLabel.TabIndex = 4;
            tenManHinhLabel.Text = "&Tên màn hình:";
            // 
            // dataSetLogin
            // 
            this.dataSetLogin.DataSetName = "DataSetLogin";
            this.dataSetLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_ManHinhBindingSource
            // 
            this.dM_ManHinhBindingSource.DataMember = "DM_ManHinh";
            this.dM_ManHinhBindingSource.DataSource = this.dataSetLogin;
            // 
            // dM_ManHinhTableAdapter
            // 
            this.dM_ManHinhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = this.dM_ManHinhTableAdapter;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BLL_DAL.DataSetLoginTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_ManHinhBindingNavigator
            // 
            this.dM_ManHinhBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dM_ManHinhBindingNavigator.BindingSource = this.dM_ManHinhBindingSource;
            this.dM_ManHinhBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dM_ManHinhBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dM_ManHinhBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dM_ManHinhBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dM_ManHinhBindingNavigatorSaveItem});
            this.dM_ManHinhBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dM_ManHinhBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dM_ManHinhBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dM_ManHinhBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dM_ManHinhBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dM_ManHinhBindingNavigator.Name = "dM_ManHinhBindingNavigator";
            this.dM_ManHinhBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dM_ManHinhBindingNavigator.Size = new System.Drawing.Size(732, 31);
            this.dM_ManHinhBindingNavigator.TabIndex = 0;
            this.dM_ManHinhBindingNavigator.Text = "bindingNavigator1";
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
            // dM_ManHinhBindingNavigatorSaveItem
            // 
            this.dM_ManHinhBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dM_ManHinhBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dM_ManHinhBindingNavigatorSaveItem.Image")));
            this.dM_ManHinhBindingNavigatorSaveItem.Name = "dM_ManHinhBindingNavigatorSaveItem";
            this.dM_ManHinhBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.dM_ManHinhBindingNavigatorSaveItem.Text = "Save Data";
            this.dM_ManHinhBindingNavigatorSaveItem.Click += new System.EventHandler(this.dM_ManHinhBindingNavigatorSaveItem_Click);
            // 
            // dM_ManHinhGridControl
            // 
            this.dM_ManHinhGridControl.DataSource = this.dM_ManHinhBindingSource;
            this.dM_ManHinhGridControl.Location = new System.Drawing.Point(3, 125);
            this.dM_ManHinhGridControl.MainView = this.gridView1;
            this.dM_ManHinhGridControl.Name = "dM_ManHinhGridControl";
            this.dM_ManHinhGridControl.Size = new System.Drawing.Size(727, 579);
            this.dM_ManHinhGridControl.TabIndex = 1;
            this.dM_ManHinhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dM_ManHinhGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // maManHinhTextEdit
            // 
            this.maManHinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dM_ManHinhBindingSource, "MaManHinh", true));
            this.maManHinhTextEdit.Location = new System.Drawing.Point(106, 53);
            this.maManHinhTextEdit.Name = "maManHinhTextEdit";
            this.maManHinhTextEdit.Size = new System.Drawing.Size(341, 22);
            this.maManHinhTextEdit.TabIndex = 3;
            // 
            // tenManHinhTextEdit
            // 
            this.tenManHinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dM_ManHinhBindingSource, "TenManHinh", true));
            this.tenManHinhTextEdit.Location = new System.Drawing.Point(106, 81);
            this.tenManHinhTextEdit.Name = "tenManHinhTextEdit";
            this.tenManHinhTextEdit.Size = new System.Drawing.Size(341, 22);
            this.tenManHinhTextEdit.TabIndex = 5;
            // 
            // Control_ManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maManHinhLabel);
            this.Controls.Add(this.maManHinhTextEdit);
            this.Controls.Add(tenManHinhLabel);
            this.Controls.Add(this.tenManHinhTextEdit);
            this.Controls.Add(this.dM_ManHinhGridControl);
            this.Controls.Add(this.dM_ManHinhBindingNavigator);
            this.Name = "Control_ManHinh";
            this.Size = new System.Drawing.Size(732, 707);
            this.Load += new System.EventHandler(this.Control_ManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingNavigator)).EndInit();
            this.dM_ManHinhBindingNavigator.ResumeLayout(false);
            this.dM_ManHinhBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maManHinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenManHinhTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetLogin dataSetLogin;
        private System.Windows.Forms.BindingSource dM_ManHinhBindingSource;
        private DataSetLoginTableAdapters.DM_ManHinhTableAdapter dM_ManHinhTableAdapter;
        private DataSetLoginTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dM_ManHinhBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dM_ManHinhBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl dM_ManHinhGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit maManHinhTextEdit;
        private DevExpress.XtraEditors.TextEdit tenManHinhTextEdit;
    }
}
