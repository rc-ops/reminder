using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public partial class Form1 : Form
    {
        private int time = 0;
        private Boolean timeChosen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void resetEverything()
        {
            trackbarTime.Value = this.time = 0;
            lblTime.Text = this.time.ToString();
            minimizeToTrayToolStripMenuItem.Checked = true;
            radioHours.Checked = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetEverything();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (trackbarTime.Value == 0)
            {
                lblTime.Visible = false;
                this.timeChosen = false;
            }
        }

        private void trackbarTime_Scroll(object sender, EventArgs e)
        {
            this.time = trackbarTime.Value;

            if (radioHours.Checked && this.time != 0)
            {
                lblTime.Visible = this.timeChosen = true;
                lblTime.Text = this.time.ToString() + " hours";
            }
            else if (radioMinutes.Checked && this.time != 0)
            {
                lblTime.Visible = this.timeChosen = true;
                lblTime.Text = this.time.ToString() + " minutes";
            }
            else
            {
                lblTime.Visible = false;
            }
        }

        private void radioHours_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHours.Checked)
            {
                lblTime.Text = this.time.ToString() + " hours";
            }
        }

        private void radioMinutes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMinutes.Checked)
            {
                lblTime.Text = this.time.ToString() + " minutes";
            }
        }

        private void lblTime_TextChanged(object sender, EventArgs e)
        {
            if (lblTime.Text == "0")
            {
                lblTime.Visible = this.timeChosen = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && minimizeToTrayToolStripMenuItem.Checked && this.timeChosen)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Started";
                notifyIcon1.BalloonTipText = "Application minimized with..."; // Editar isso aqui
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Minimized && minimizeToTrayToolStripMenuItem.Checked && !this.timeChosen)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Stopped";
                notifyIcon1.BalloonTipText = "Application minimized but no time was set.";
                notifyIcon1.ShowBalloonTip(30);
            }
        }

        private void notification(int Interval)
        {
            timer1.Interval = Interval;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (minimizeToTrayToolStripMenuItem.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
    }

}
