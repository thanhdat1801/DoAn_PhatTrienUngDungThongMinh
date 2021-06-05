
namespace GUI
{
    partial class TestMapControl
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
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMiles = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromAddress = new System.Windows.Forms.TextBox();
            this.txtToAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(1203, 807);
            this.mapControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtToAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFromAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 66);
            this.panel1.TabIndex = 1;
            // 
            // lblMiles
            // 
            this.lblMiles.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Appearance.Options.UseFont = true;
            this.lblMiles.Location = new System.Drawing.Point(26, 21);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(36, 23);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "KM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Adress:";
            // 
            // txtFromAddress
            // 
            this.txtFromAddress.Location = new System.Drawing.Point(311, 21);
            this.txtFromAddress.Name = "txtFromAddress";
            this.txtFromAddress.Size = new System.Drawing.Size(268, 23);
            this.txtFromAddress.TabIndex = 2;
            // 
            // txtToAddress
            // 
            this.txtToAddress.Location = new System.Drawing.Point(731, 21);
            this.txtToAddress.Name = "txtToAddress";
            this.txtToAddress.Size = new System.Drawing.Size(268, 23);
            this.txtToAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Adress:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1033, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(158, 42);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // TestMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 807);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mapControl1);
            this.Name = "TestMapControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Map";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private System.Windows.Forms.TextBox txtToAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromAddress;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lblMiles;
    }
}