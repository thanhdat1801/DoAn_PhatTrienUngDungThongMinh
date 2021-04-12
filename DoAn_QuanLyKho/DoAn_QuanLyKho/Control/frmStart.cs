using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAn_QuanLyKho.Control
{
    public partial class frmStart : SplashScreen
    {
        Timer timer;
        public frmStart()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            progressBar1.Visible = true;

            this.progressBar1.Value = this.progressBar1.Value + 2;
            if (this.progressBar1.Value == 10)
            {
                labelStatus.Text = "Reading modules..";
            }
            else if (this.progressBar1.Value == 20)
            {
                labelStatus.Text = "Turning on modules.";
            }
            else if (this.progressBar1.Value == 40)
            {
                labelStatus.Text = "Starting modules..";
            }
            else if (this.progressBar1.Value == 60)
            {
                labelStatus.Text = "Loading modules..";
            }
            else if (this.progressBar1.Value == 80)
            {
                labelStatus.Text = "Done loading modules..";
            }
            else if (this.progressBar1.Value == 100)
            {
                frm.Show();
                timer1.Enabled = false;
                this.Hide();
                timer.Stop();
            }
        }


        private void frmStart_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 300; //Set time interval 300 miliseconds
            timer.Start(); //Start the timer
            timer.Tick += timer1_Tick;
        }
    }
}