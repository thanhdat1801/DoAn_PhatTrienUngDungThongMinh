
namespace GUI
{
    partial class frmSetupCompany
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompany = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChiNhanhChinh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChiNhanhPhu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhPho = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKichHoat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtEmail = new Custom_Control.txtMail();
            this.txtMaBuuDien = new Custom_Control.txtNumber();
            this.txtSoSeri = new Custom_Control.txtNumber();
            this.txtSoDT1 = new Custom_Control.txtNumber();
            this.txtSoDT2 = new Custom_Control.txtNumber();
            this.txtFax = new Custom_Control.txtNumber();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIDCompany = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelLeft.Controls.Add(this.label9);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(428, 742);
            this.panelLeft.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 691);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Beta Version 1.0 2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KHO HÀNG";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(436, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thiết lập công ty của bạn";
            // 
            // txtCompany
            // 
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCompany.HintForeColor = System.Drawing.Color.Empty;
            this.txtCompany.HintText = "";
            this.txtCompany.isPassword = false;
            this.txtCompany.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtCompany.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtCompany.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtCompany.LineThickness = 3;
            this.txtCompany.Location = new System.Drawing.Point(443, 197);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(5);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(396, 38);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(439, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Tên công ty:";
            // 
            // txtChiNhanhChinh
            // 
            this.txtChiNhanhChinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChiNhanhChinh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtChiNhanhChinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChiNhanhChinh.HintForeColor = System.Drawing.Color.Empty;
            this.txtChiNhanhChinh.HintText = "";
            this.txtChiNhanhChinh.isPassword = false;
            this.txtChiNhanhChinh.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtChiNhanhChinh.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtChiNhanhChinh.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtChiNhanhChinh.LineThickness = 3;
            this.txtChiNhanhChinh.Location = new System.Drawing.Point(440, 284);
            this.txtChiNhanhChinh.Margin = new System.Windows.Forms.Padding(5);
            this.txtChiNhanhChinh.Name = "txtChiNhanhChinh";
            this.txtChiNhanhChinh.Size = new System.Drawing.Size(396, 38);
            this.txtChiNhanhChinh.TabIndex = 3;
            this.txtChiNhanhChinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(436, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "&Chi nhánh chính:";
            // 
            // txtChiNhanhPhu
            // 
            this.txtChiNhanhPhu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChiNhanhPhu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtChiNhanhPhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChiNhanhPhu.HintForeColor = System.Drawing.Color.Empty;
            this.txtChiNhanhPhu.HintText = "";
            this.txtChiNhanhPhu.isPassword = false;
            this.txtChiNhanhPhu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtChiNhanhPhu.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtChiNhanhPhu.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtChiNhanhPhu.LineThickness = 3;
            this.txtChiNhanhPhu.Location = new System.Drawing.Point(443, 371);
            this.txtChiNhanhPhu.Margin = new System.Windows.Forms.Padding(5);
            this.txtChiNhanhPhu.Name = "txtChiNhanhPhu";
            this.txtChiNhanhPhu.Size = new System.Drawing.Size(396, 38);
            this.txtChiNhanhPhu.TabIndex = 4;
            this.txtChiNhanhPhu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(439, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "&Chi nhánh phụ:";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhPho.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtThanhPho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThanhPho.HintForeColor = System.Drawing.Color.Empty;
            this.txtThanhPho.HintText = "";
            this.txtThanhPho.isPassword = false;
            this.txtThanhPho.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtThanhPho.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtThanhPho.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtThanhPho.LineThickness = 3;
            this.txtThanhPho.Location = new System.Drawing.Point(443, 458);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(5);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(396, 38);
            this.txtThanhPho.TabIndex = 5;
            this.txtThanhPho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(439, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "&Thành phố (Tỉnh):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(439, 517);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "&Mã bưu điện:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(889, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "&Số Serial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label10.Location = new System.Drawing.Point(889, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "&Số điện thoại 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label11.Location = new System.Drawing.Point(889, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "&Số điện thoại 2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label12.Location = new System.Drawing.Point(889, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "&Số FAX:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label13.Location = new System.Drawing.Point(889, 430);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "&Email đăng ký phần mềm:";
            // 
            // txtKichHoat
            // 
            this.txtKichHoat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKichHoat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKichHoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKichHoat.HintForeColor = System.Drawing.Color.Empty;
            this.txtKichHoat.HintText = "";
            this.txtKichHoat.isPassword = false;
            this.txtKichHoat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtKichHoat.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtKichHoat.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtKichHoat.LineThickness = 3;
            this.txtKichHoat.Location = new System.Drawing.Point(893, 546);
            this.txtKichHoat.Margin = new System.Windows.Forms.Padding(5);
            this.txtKichHoat.Name = "txtKichHoat";
            this.txtKichHoat.Size = new System.Drawing.Size(396, 38);
            this.txtKichHoat.TabIndex = 12;
            this.txtKichHoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label14.Location = new System.Drawing.Point(889, 517);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "&Mã kích hoạt phần mềm:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(893, 650);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(396, 42);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "&Lưu thiết lập công ty";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(893, 452);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(396, 44);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaBuuDien
            // 
            this.txtMaBuuDien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBuuDien.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMaBuuDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaBuuDien.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaBuuDien.HintText = "";
            this.txtMaBuuDien.isPassword = false;
            this.txtMaBuuDien.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtMaBuuDien.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtMaBuuDien.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtMaBuuDien.LineThickness = 3;
            this.txtMaBuuDien.Location = new System.Drawing.Point(443, 545);
            this.txtMaBuuDien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBuuDien.Name = "txtMaBuuDien";
            this.txtMaBuuDien.Size = new System.Drawing.Size(396, 38);
            this.txtMaBuuDien.TabIndex = 6;
            this.txtMaBuuDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoSeri
            // 
            this.txtSoSeri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoSeri.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoSeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoSeri.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoSeri.HintText = "";
            this.txtSoSeri.isPassword = false;
            this.txtSoSeri.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoSeri.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoSeri.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoSeri.LineThickness = 3;
            this.txtSoSeri.Location = new System.Drawing.Point(893, 115);
            this.txtSoSeri.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoSeri.Name = "txtSoSeri";
            this.txtSoSeri.Size = new System.Drawing.Size(396, 38);
            this.txtSoSeri.TabIndex = 7;
            this.txtSoSeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoDT1
            // 
            this.txtSoDT1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoDT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDT1.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoDT1.HintText = "";
            this.txtSoDT1.isPassword = false;
            this.txtSoDT1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT1.LineThickness = 3;
            this.txtSoDT1.Location = new System.Drawing.Point(893, 196);
            this.txtSoDT1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDT1.Name = "txtSoDT1";
            this.txtSoDT1.Size = new System.Drawing.Size(396, 38);
            this.txtSoDT1.TabIndex = 8;
            this.txtSoDT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoDT2
            // 
            this.txtSoDT2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoDT2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDT2.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoDT2.HintText = "";
            this.txtSoDT2.isPassword = false;
            this.txtSoDT2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtSoDT2.LineThickness = 3;
            this.txtSoDT2.Location = new System.Drawing.Point(893, 285);
            this.txtSoDT2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDT2.Name = "txtSoDT2";
            this.txtSoDT2.Size = new System.Drawing.Size(396, 38);
            this.txtSoDT2.TabIndex = 9;
            this.txtSoDT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFax
            // 
            this.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFax.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFax.HintForeColor = System.Drawing.Color.Empty;
            this.txtFax.HintText = "";
            this.txtFax.isPassword = false;
            this.txtFax.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtFax.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtFax.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtFax.LineThickness = 3;
            this.txtFax.Location = new System.Drawing.Point(893, 370);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(396, 38);
            this.txtFax.TabIndex = 10;
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.wms_logo;
            this.pictureBox1.Location = new System.Drawing.Point(88, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtIDCompany
            // 
            this.txtIDCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDCompany.HintForeColor = System.Drawing.Color.Empty;
            this.txtIDCompany.HintText = "";
            this.txtIDCompany.isPassword = false;
            this.txtIDCompany.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtIDCompany.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtIDCompany.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtIDCompany.LineThickness = 3;
            this.txtIDCompany.Location = new System.Drawing.Point(443, 115);
            this.txtIDCompany.Margin = new System.Windows.Forms.Padding(5);
            this.txtIDCompany.Name = "txtIDCompany";
            this.txtIDCompany.Size = new System.Drawing.Size(396, 38);
            this.txtIDCompany.TabIndex = 1;
            this.txtIDCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label15.Location = new System.Drawing.Point(441, 88);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "&ID công ty:";
            // 
            // frmSetupCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 742);
            this.Controls.Add(this.txtIDCompany);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtSoDT2);
            this.Controls.Add(this.txtSoDT1);
            this.Controls.Add(this.txtSoSeri);
            this.Controls.Add(this.txtMaBuuDien);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtKichHoat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtThanhPho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChiNhanhPhu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChiNhanhChinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetupCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetupCompany";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKichHoat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtThanhPho;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtChiNhanhPhu;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtChiNhanhChinh;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private Custom_Control.txtMail txtEmail;
        private Custom_Control.txtNumber txtMaBuuDien;
        private Custom_Control.txtNumber txtSoSeri;
        private Custom_Control.txtNumber txtSoDT1;
        private Custom_Control.txtNumber txtSoDT2;
        private Custom_Control.txtNumber txtFax;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDCompany;
        private System.Windows.Forms.Label label15;
    }
}