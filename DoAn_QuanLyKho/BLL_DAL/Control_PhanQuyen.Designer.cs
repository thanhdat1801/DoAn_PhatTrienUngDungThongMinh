
namespace BLL_DAL
{
    partial class Control_PhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.qL_GetPhanQuyenBunifuCustomDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.qL_NhomNguoiDungBunifuCustomDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_GetPhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLogin = new BLL_DAL.DataSetLogin();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new BLL_DAL.DataSetLoginTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new BLL_DAL.DataSetLoginTableAdapters.TableAdapterManager();
            this.qL_GetPhanQuyenTableAdapter = new BLL_DAL.DataSetLoginTableAdapters.QL_GetPhanQuyenTableAdapter();
            this.qL_PhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PhanQuyenTableAdapter = new BLL_DAL.DataSetLoginTableAdapters.QL_PhanQuyenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBunifuCustomDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBunifuCustomDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::BLL_DAL.Properties.Resources.savepagesetup_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(4, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(263, 66);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "&Lưu thay đổi";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = global::BLL_DAL.Properties.Resources.ide_32x32;
            this.groupControl2.Controls.Add(this.qL_GetPhanQuyenBunifuCustomDataGrid);
            this.groupControl2.Location = new System.Drawing.Point(611, 119);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(601, 671);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách quyền truy cập";
            // 
            // qL_GetPhanQuyenBunifuCustomDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.qL_GetPhanQuyenBunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.AutoGenerateColumns = false;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.qL_GetPhanQuyenBunifuCustomDataGrid.DataSource = this.qL_GetPhanQuyenBindingSource;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.DoubleBuffered = true;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.EnableHeadersVisualStyles = false;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.Location = new System.Drawing.Point(5, 36);
            this.qL_GetPhanQuyenBunifuCustomDataGrid.Name = "qL_GetPhanQuyenBunifuCustomDataGrid";
            this.qL_GetPhanQuyenBunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.RowHeadersWidth = 51;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.RowTemplate.Height = 24;
            this.qL_GetPhanQuyenBunifuCustomDataGrid.Size = new System.Drawing.Size(591, 630);
            this.qL_GetPhanQuyenBunifuCustomDataGrid.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::BLL_DAL.Properties.Resources.publicfix_32x32;
            this.groupControl1.Controls.Add(this.qL_NhomNguoiDungBunifuCustomDataGrid);
            this.groupControl1.Location = new System.Drawing.Point(4, 119);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 671);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách nhóm người dùng";
            // 
            // qL_NhomNguoiDungBunifuCustomDataGrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.qL_NhomNguoiDungBunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.AutoGenerateColumns = false;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qL_NhomNguoiDungBunifuCustomDataGrid.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.DoubleBuffered = true;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.EnableHeadersVisualStyles = false;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.Location = new System.Drawing.Point(5, 36);
            this.qL_NhomNguoiDungBunifuCustomDataGrid.Name = "qL_NhomNguoiDungBunifuCustomDataGrid";
            this.qL_NhomNguoiDungBunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.RowHeadersWidth = 51;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.RowTemplate.Height = 24;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.Size = new System.Drawing.Size(591, 630);
            this.qL_NhomNguoiDungBunifuCustomDataGrid.TabIndex = 0;
            this.qL_NhomNguoiDungBunifuCustomDataGrid.SelectionChanged += new System.EventHandler(this.qL_NhomNguoiDungBunifuCustomDataGrid_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã màn hình";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên màn hình";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Có quyền";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qL_GetPhanQuyenBindingSource
            // 
            this.qL_GetPhanQuyenBindingSource.DataMember = "QL_GetPhanQuyen";
            this.qL_GetPhanQuyenBindingSource.DataSource = this.dataSetLogin;
            // 
            // dataSetLogin
            // 
            this.dataSetLogin.DataSetName = "DataSetLogin";
            this.dataSetLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // qL_GetPhanQuyenTableAdapter
            // 
            this.qL_GetPhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PhanQuyenBindingSource
            // 
            this.qL_PhanQuyenBindingSource.DataMember = "QL_PhanQuyen";
            this.qL_PhanQuyenBindingSource.DataSource = this.dataSetLogin;
            // 
            // qL_PhanQuyenTableAdapter
            // 
            this.qL_PhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // Control_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Control_PhanQuyen";
            this.Size = new System.Drawing.Size(1232, 810);
            this.Load += new System.EventHandler(this.Control_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBunifuCustomDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBunifuCustomDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DataSetLogin dataSetLogin;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private DataSetLoginTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private DataSetLoginTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource qL_GetPhanQuyenBindingSource;
        private DataSetLoginTableAdapters.QL_GetPhanQuyenTableAdapter qL_GetPhanQuyenTableAdapter;
        private System.Windows.Forms.BindingSource qL_PhanQuyenBindingSource;
        private DataSetLoginTableAdapters.QL_PhanQuyenTableAdapter qL_PhanQuyenTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid qL_NhomNguoiDungBunifuCustomDataGrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid qL_GetPhanQuyenBunifuCustomDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
