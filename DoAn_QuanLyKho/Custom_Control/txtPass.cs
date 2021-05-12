using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Control
{
    public class txtPass : BunifuMaterialTextbox
    {
        ErrorProvider error = new ErrorProvider();
        public txtPass()
        {
            this.KeyPress += TxtPass_KeyPress;
        }

        private void TxtPass_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            BunifuMaterialTextbox text = (BunifuMaterialTextbox)sender;
            if (char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && text.Text.Length >= 6)
            {
                error.Clear();
            }
            else
            {
                error.SetError(text, "Phải có kí tự đặc biệt và phải lớn hơn 6 kí tự!");
            }
        }
    }
}
