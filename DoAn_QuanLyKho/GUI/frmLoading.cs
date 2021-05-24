using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class frmLoading : SplashScreen
    {
        Timer timer;
        public frmLoading()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 05 - " + DateTime.Now.Year.ToString();
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

        private void frmLoading_Load(object sender, EventArgs e)
        {

        }

        private void frmLoading_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 300; //Set time interval 300 miliseconds
            timer.Start(); //Start the timer
            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SQLHelper helper = new SQLHelper();
            progressBar1.Visible = true;

            this.progressBar1.Value = this.progressBar1.Value + 2;
            if (this.progressBar1.Value == 10)
            {
                labelStatus.Text = "Reading modules...";
            }
            else if (this.progressBar1.Value == 20)
            {
                labelStatus.Text = "Turning on modules...";
            }
            else if (this.progressBar1.Value == 40)
            {
                labelStatus.Text = "Starting modules...";
            }
            else if (this.progressBar1.Value == 60)
            {
                labelStatus.Text = "Loading modules...";
            }
            else if (this.progressBar1.Value == 80)
            {
                if (helper.Check_Config() == 1 || helper.Check_Config() == 2)
                {
                    labelStatus.Text = "First setup...";
                }
                else
                {
                    labelStatus.Text = "Done loading modules...";
                }
            }
            else if (this.progressBar1.Value == 100)
            {
                timer.Stop();
                if (helper.Check_Config() == 1 || helper.Check_Config() == 2)
                {
                    frmConfig frm = new frmConfig();
                    frm.Show();
                    timer1.Enabled = false;
                    this.Hide();
                }
                else
                {
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    timer1.Enabled = false;
                    this.Hide();
                }  
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}