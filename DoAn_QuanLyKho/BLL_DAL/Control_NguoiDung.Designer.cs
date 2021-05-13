
namespace BLL_DAL
{
    partial class Control_NguoiDung
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
            System.Windows.Forms.Label iDNhanVienLabel;
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hoatDongLabel;
            System.Windows.Forms.Label tenNhanVienLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label soDTLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_NguoiDung));
            this.qL_NguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLogin = new BLL_DAL.DataSetLogin();
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
            this.iDNhanVienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenDangNhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoatDongCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tenNhanVienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.qL_NguoiDungTableAdapter = new BLL_DAL.DataSetLoginTableAdapters.QL_NguoiDungTableAdapter();
            this.tableAdapterManager = new BLL_DAL.DataSetLoginTableAdapters.TableAdapterManager();
            this.qL_NguoiDungGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            iDNhanVienLabel = new System.Windows.Forms.Label();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            tenNhanVienLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            soDTLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).BeginInit();
            this.qL_NguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNhanVienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanVienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDNhanVienLabel
            // 
            iDNhanVienLabel.AutoSize = true;
            iDNhanVienLabel.Location = new System.Drawing.Point(8, 54);
            iDNhanVienLabel.Name = "iDNhanVienLabel";
            iDNhanVienLabel.Size = new System.Drawing.Size(92, 17);
            iDNhanVienLabel.TabIndex = 2;
            iDNhanVienLabel.Text = "&ID Nhân viên:";
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(8, 82);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(106, 17);
            tenDangNhapLabel.TabIndex = 4;
            tenDangNhapLabel.Text = "&Tên đăng nhập:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(8, 110);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(69, 17);
            matKhauLabel.TabIndex = 6;
            matKhauLabel.Text = "&Mật khẩu:";
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(8, 138);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(78, 17);
            hoatDongLabel.TabIndex = 8;
            hoatDongLabel.Text = "&Hoạt động:";
            // 
            // tenNhanVienLabel
            // 
            tenNhanVienLabel.AutoSize = true;
            tenNhanVienLabel.Location = new System.Drawing.Point(8, 168);
            tenNhanVienLabel.Name = "tenNhanVienLabel";
            tenNhanVienLabel.Size = new System.Drawing.Size(100, 17);
            tenNhanVienLabel.TabIndex = 10;
            tenNhanVienLabel.Text = "&Tên nhân viên:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(8, 196);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(53, 17);
            diaChiLabel.TabIndex = 12;
            diaChiLabel.Text = "&Địa chỉ:";
            // 
            // soDTLabel
            // 
            soDTLabel.AutoSize = true;
            soDTLabel.Location = new System.Drawing.Point(8, 224);
            soDTLabel.Name = "soDTLabel";
            soDTLabel.Size = new System.Drawing.Size(92, 17);
            soDTLabel.TabIndex = 14;
            soDTLabel.Text = "&Số điện thoại:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(8, 252);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 17);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "&Email:";
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
            this.qL_NguoiDungBindingNavigator.Size = new System.Drawing.Size(1192, 31);
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
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.dataSetLogin;
            // 
            // dataSetLogin
            // 
            this.dataSetLogin.DataSetName = "DataSetLogin";
            this.dataSetLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.qL_NguoiDungBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NguoiDungBindingNavigatorSaveItem_Click);
            // 
            // iDNhanVienTextEdit
            // 
            this.iDNhanVienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "IDNhanVien", true));
            this.iDNhanVienTextEdit.Location = new System.Drawing.Point(123, 51);
            this.iDNhanVienTextEdit.Name = "iDNhanVienTextEdit";
            this.iDNhanVienTextEdit.Size = new System.Drawing.Size(226, 22);
            this.iDNhanVienTextEdit.TabIndex = 3;
            // 
            // tenDangNhapTextEdit
            // 
            this.tenDangNhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextEdit.Location = new System.Drawing.Point(123, 79);
            this.tenDangNhapTextEdit.Name = "tenDangNhapTextEdit";
            this.tenDangNhapTextEdit.Size = new System.Drawing.Size(226, 22);
            this.tenDangNhapTextEdit.TabIndex = 5;
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "MatKhau", true));
            this.matKhauTextEdit.Location = new System.Drawing.Point(123, 107);
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Size = new System.Drawing.Size(226, 22);
            this.matKhauTextEdit.TabIndex = 7;
            // 
            // hoatDongCheckEdit
            // 
            this.hoatDongCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "HoatDong", true));
            this.hoatDongCheckEdit.EditValue = true;
            this.hoatDongCheckEdit.Location = new System.Drawing.Point(123, 135);
            this.hoatDongCheckEdit.Name = "hoatDongCheckEdit";
            this.hoatDongCheckEdit.Properties.Caption = "";
            this.hoatDongCheckEdit.Size = new System.Drawing.Size(125, 24);
            this.hoatDongCheckEdit.TabIndex = 9;
            // 
            // tenNhanVienTextEdit
            // 
            this.tenNhanVienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "TenNhanVien", true));
            this.tenNhanVienTextEdit.Location = new System.Drawing.Point(123, 165);
            this.tenNhanVienTextEdit.Name = "tenNhanVienTextEdit";
            this.tenNhanVienTextEdit.Size = new System.Drawing.Size(226, 22);
            this.tenNhanVienTextEdit.TabIndex = 11;
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "DiaChi", true));
            this.diaChiTextEdit.Location = new System.Drawing.Point(123, 193);
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(226, 22);
            this.diaChiTextEdit.TabIndex = 13;
            // 
            // soDTTextEdit
            // 
            this.soDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "SoDT", true));
            this.soDTTextEdit.Location = new System.Drawing.Point(123, 221);
            this.soDTTextEdit.Name = "soDTTextEdit";
            this.soDTTextEdit.Size = new System.Drawing.Size(226, 22);
            this.soDTTextEdit.TabIndex = 15;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NguoiDungBindingSource, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(123, 249);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(226, 22);
            this.emailTextEdit.TabIndex = 17;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BLL_DAL.DataSetLoginTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NguoiDungGridControl
            // 
            this.qL_NguoiDungGridControl.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungGridControl.Location = new System.Drawing.Point(11, 289);
            this.qL_NguoiDungGridControl.MainView = this.gridView1;
            this.qL_NguoiDungGridControl.Name = "qL_NguoiDungGridControl";
            this.qL_NguoiDungGridControl.Size = new System.Drawing.Size(1166, 397);
            this.qL_NguoiDungGridControl.TabIndex = 17;
            this.qL_NguoiDungGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.qL_NguoiDungGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Control_NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.qL_NguoiDungGridControl);
            this.Controls.Add(iDNhanVienLabel);
            this.Controls.Add(this.iDNhanVienTextEdit);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(this.tenDangNhapTextEdit);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextEdit);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckEdit);
            this.Controls.Add(tenNhanVienLabel);
            this.Controls.Add(this.tenNhanVienTextEdit);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextEdit);
            this.Controls.Add(soDTLabel);
            this.Controls.Add(this.soDTTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(this.qL_NguoiDungBindingNavigator);
            this.Name = "Control_NguoiDung";
            this.Size = new System.Drawing.Size(1192, 700);
            this.Load += new System.EventHandler(this.Control_NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingNavigator)).EndInit();
            this.qL_NguoiDungBindingNavigator.ResumeLayout(false);
            this.qL_NguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNhanVienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanVienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetLogin dataSetLogin;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private DataSetLoginTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private DataSetLoginTableAdapters.TableAdapterManager tableAdapterManager;
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
        private DevExpress.XtraEditors.TextEdit iDNhanVienTextEdit;
        private DevExpress.XtraEditors.TextEdit tenDangNhapTextEdit;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
        private DevExpress.XtraEditors.CheckEdit hoatDongCheckEdit;
        private DevExpress.XtraEditors.TextEdit tenNhanVienTextEdit;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit soDTTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraGrid.GridControl qL_NguoiDungGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
