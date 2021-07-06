
namespace GUI
{
    partial class frmDanhMucMH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucMH));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.grvDanhMucManHinh = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTenManHinh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDManHinh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuaNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThemNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoaNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucManHinh)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblClose.Location = new System.Drawing.Point(1179, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 30);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // grvDanhMucManHinh
            // 
            this.grvDanhMucManHinh.AllowUserToAddRows = false;
            this.grvDanhMucManHinh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.grvDanhMucManHinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grvDanhMucManHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvDanhMucManHinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDanhMucManHinh.BackgroundColor = System.Drawing.Color.White;
            this.grvDanhMucManHinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvDanhMucManHinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvDanhMucManHinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDanhMucManHinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvDanhMucManHinh.ColumnHeadersHeight = 50;
            this.grvDanhMucManHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDanhMucManHinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvDanhMucManHinh.DoubleBuffered = true;
            this.grvDanhMucManHinh.EnableHeadersVisualStyles = false;
            this.grvDanhMucManHinh.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.grvDanhMucManHinh.HeaderForeColor = System.Drawing.Color.White;
            this.grvDanhMucManHinh.Location = new System.Drawing.Point(373, 258);
            this.grvDanhMucManHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvDanhMucManHinh.Name = "grvDanhMucManHinh";
            this.grvDanhMucManHinh.ReadOnly = true;
            this.grvDanhMucManHinh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvDanhMucManHinh.RowHeadersVisible = false;
            this.grvDanhMucManHinh.RowHeadersWidth = 51;
            this.grvDanhMucManHinh.RowTemplate.DividerHeight = 1;
            this.grvDanhMucManHinh.RowTemplate.Height = 30;
            this.grvDanhMucManHinh.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDanhMucManHinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDanhMucManHinh.Size = new System.Drawing.Size(831, 513);
            this.grvDanhMucManHinh.TabIndex = 6;
            this.grvDanhMucManHinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDanhMucManHinh_CellClick);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelLeft.Controls.Add(this.label9);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(367, 782);
            this.panelLeft.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 749);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Beta Version 1.0 2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KHO HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(373, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Quản lý danh mục màn hình";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.grvDanhMucManHinh;
            // 
            // txtTenManHinh
            // 
            this.txtTenManHinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenManHinh.Enabled = false;
            this.txtTenManHinh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenManHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenManHinh.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenManHinh.HintText = "";
            this.txtTenManHinh.isPassword = false;
            this.txtTenManHinh.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenManHinh.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenManHinh.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtTenManHinh.LineThickness = 3;
            this.txtTenManHinh.Location = new System.Drawing.Point(775, 207);
            this.txtTenManHinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenManHinh.Name = "txtTenManHinh";
            this.txtTenManHinh.Size = new System.Drawing.Size(339, 31);
            this.txtTenManHinh.TabIndex = 44;
            this.txtTenManHinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(771, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "&Tên màn hình:";
            // 
            // txtIDManHinh
            // 
            this.txtIDManHinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDManHinh.Enabled = false;
            this.txtIDManHinh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDManHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDManHinh.HintForeColor = System.Drawing.Color.Empty;
            this.txtIDManHinh.HintText = "";
            this.txtIDManHinh.isPassword = false;
            this.txtIDManHinh.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtIDManHinh.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtIDManHinh.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtIDManHinh.LineThickness = 3;
            this.txtIDManHinh.Location = new System.Drawing.Point(378, 207);
            this.txtIDManHinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDManHinh.Name = "txtIDManHinh";
            this.txtIDManHinh.Size = new System.Drawing.Size(339, 31);
            this.txtIDManHinh.TabIndex = 42;
            this.txtIDManHinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(374, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "&ID Màn hình:";
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.ActiveBorderThickness = 1;
            this.btnSuaNCC.ActiveCornerRadius = 35;
            this.btnSuaNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnSuaNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSuaNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaNCC.BackgroundImage")));
            this.btnSuaNCC.ButtonText = "Sửa";
            this.btnSuaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.IdleBorderThickness = 1;
            this.btnSuaNCC.IdleCornerRadius = 20;
            this.btnSuaNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnSuaNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaNCC.Location = new System.Drawing.Point(1102, 43);
            this.btnSuaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(95, 48);
            this.btnSuaNCC.TabIndex = 47;
            this.btnSuaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.ActiveBorderThickness = 1;
            this.btnThemNCC.ActiveCornerRadius = 35;
            this.btnThemNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThemNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.BackgroundImage")));
            this.btnThemNCC.ButtonText = "Thêm";
            this.btnThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.IdleBorderThickness = 1;
            this.btnThemNCC.IdleCornerRadius = 20;
            this.btnThemNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnThemNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemNCC.Location = new System.Drawing.Point(910, 43);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(95, 48);
            this.btnThemNCC.TabIndex = 45;
            this.btnThemNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.ActiveBorderThickness = 1;
            this.btnXoaNCC.ActiveCornerRadius = 35;
            this.btnXoaNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoaNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXoaNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.BackgroundImage")));
            this.btnXoaNCC.ButtonText = "Xóa";
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.IdleBorderThickness = 1;
            this.btnXoaNCC.IdleCornerRadius = 20;
            this.btnXoaNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.IdleForecolor = System.Drawing.Color.White;
            this.btnXoaNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaNCC.Location = new System.Drawing.Point(1006, 43);
            this.btnXoaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(95, 48);
            this.btnXoaNCC.TabIndex = 46;
            this.btnXoaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.wms_logo;
            this.pictureBox1.Location = new System.Drawing.Point(70, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_MANHINH";
            this.Column1.HeaderText = "ID màn hình";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENMANHINH";
            this.Column2.HeaderText = "Tên màn hình";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmDanhMucMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 782);
            this.Controls.Add(this.btnSuaNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.txtTenManHinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDManHinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.grvDanhMucManHinh);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhMucMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhMucMH";
            this.Load += new System.EventHandler(this.frmDanhMucMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucManHinh)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grvDanhMucManHinh;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenManHinh;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDManHinh;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSuaNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}