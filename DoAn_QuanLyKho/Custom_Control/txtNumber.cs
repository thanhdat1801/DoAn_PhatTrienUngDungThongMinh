using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Control
{
    public class txtNumber : BunifuMaterialTextbox
    {
        public txtNumber()
        {
            this.KeyPress += TxtNumberPhone_KeyPress;
        }

        private void TxtNumberPhone_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
