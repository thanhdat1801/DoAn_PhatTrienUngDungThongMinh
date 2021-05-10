using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using Bunifu.Framework.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Custom_Control
{
    public class txtMail : BunifuMaterialTextbox
    {
        private DXErrorProvider dxErrorProvider1 = new DXErrorProvider();
        private System.ComponentModel.IContainer components;
        public txtMail()
        {
            this.OnValueChanged += TxtMail_OnValueChanged;
        }

        private void TxtMail_OnValueChanged(object sender, EventArgs e)
        {
            BunifuMaterialTextbox mail = (BunifuMaterialTextbox)sender;
            if (isEmail(mail.Text.ToString().Trim()))
            {
                dxErrorProvider1.ClearErrors();
            }
            else
            {
                dxErrorProvider1.SetError(mail, "Email không hợp lệ!");
            }
        }

        public bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // txtMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.Name = "txtMail";
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
