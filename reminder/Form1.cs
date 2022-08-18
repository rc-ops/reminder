using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remindertimer
{
    public partial class Form1 : Form
    {
        private int specifiedTime = 0;
        private Boolean timeChosen = false;
        private String finishMessage = "Time's up!";

        public Form1()
        {
            InitializeComponent();
        }

        private void resetEverything()
        {
            trackbarTime.Value = specifiedTime = 0;
            lblTime.Text = specifiedTime.ToString();
            minimizeToTrayToolStripMenuItem.Checked = true;
            radioHours.Checked = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetEverything();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.specifiedTime == 0)
            {
                lblTime.Visible = false;
                this.timeChosen = false;
            } 
        }

        private void trackbarTime_Scroll(object sender, EventArgs e)
        {
            this.specifiedTime = trackbarTime.Value;

            if (radioHours.Checked && specifiedTime != 0)
            {
                lblTime.Visible = true;
                this.timeChosen = true;
                lblTime.Text = specifiedTime.ToString() + " hours";
            }
            else if (radioMinutes.Checked && specifiedTime != 0)
            {
                lblTime.Visible = true;
                this.timeChosen = true;
                lblTime.Text = specifiedTime.ToString() + " minutes";
            }
            else
            {
                lblTime.Visible = false;
                timeChosen = false;
            }
        }

        private void radioHours_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHours.Checked)
            {
                lblTime.Text = specifiedTime.ToString() + " hours";
            }
        }

        private void radioMinutes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMinutes.Checked)
            {
                lblTime.Text = specifiedTime.ToString() + " minutes";
            }
        }

        private void lblTime_TextChanged(object sender, EventArgs e)
        {
            if (lblTime.Text == "0")
            {
                lblTime.Visible = timeChosen = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && minimizeToTrayToolStripMenuItem.Checked && timer1.Enabled)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Started";
                notifyIcon1.BalloonTipText = "The time is running!";
                notifyIcon1.ShowBalloonTip(30);
            }
            else if (WindowState == FormWindowState.Minimized && minimizeToTrayToolStripMenuItem.Checked && !timer1.Enabled)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Stopped";
                notifyIcon1.BalloonTipText = "Application minimized but no time was set.";
                notifyIcon1.ShowBalloonTip(30);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timeChosen && !timer1.Enabled)
            {
                startTimer();
            }
            else
            {
                stopTimer(1);
            }
        }

        private void startTimer()
        {
            btnStart.Text = "STOP";
            trackbarTime.Enabled = false;

            if (radioHours.Checked)
            {
                timer1.Interval = specifiedTime * 3600000;
                timer1.Start();
            }
            else
            {
                timer1.Interval = specifiedTime * 60000;
                timer1.Start();
            }
        }

        private void stopTimer(int state)
        {
            /* States
             * 1 - Stopped by the user
             * 2 - Stopped by the timer itself
            */

            switch (state)
            {
                case 1:
                    stoppedUser();
                    break;
                case 2:
                    stoppedItself();
                    break;
            }

            void stoppedUser() {
                if (!timeChosen)
                {
                    MessageBox.Show("No time was set.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnStart.Text = "START";
                    timer1.Stop();
                    MessageBox.Show("Timer stopped.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trackbarTime.Enabled = true;
                }
            }

            void stoppedItself()
            {
                btnStart.Text = "START";
                timer1.Stop();
                trackbarTime.Enabled = true;
            }

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(finishMessage, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            WindowState = FormWindowState.Normal;
            stopTimer(2);
        }
    }
}