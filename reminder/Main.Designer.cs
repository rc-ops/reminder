namespace remindertimer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeBetweenNotifications = new System.Windows.Forms.Label();
            this.trackbarTime = new System.Windows.Forms.TrackBar();
            this.radioMinutes = new System.Windows.Forms.RadioButton();
            this.radioHours = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarTime)).BeginInit();
            this.contextMenuTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savetoolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // savetoolStripMenuItem1
            // 
            this.savetoolStripMenuItem1.Name = "savetoolStripMenuItem1";
            this.savetoolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.savetoolStripMenuItem1.Text = "Exit";
            this.savetoolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToTrayToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Checked = true;
            this.minimizeToTrayToolStripMenuItem.CheckOnClick = true;
            this.minimizeToTrayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeToTrayToolStripMenuItem.Enabled = false;
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to tray";
            this.minimizeToTrayToolStripMenuItem.ToolTipText = "For now this option is being enforced.";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblTimeBetweenNotifications
            // 
            this.lblTimeBetweenNotifications.AutoSize = true;
            this.lblTimeBetweenNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeBetweenNotifications.Location = new System.Drawing.Point(4, 26);
            this.lblTimeBetweenNotifications.Name = "lblTimeBetweenNotifications";
            this.lblTimeBetweenNotifications.Size = new System.Drawing.Size(197, 20);
            this.lblTimeBetweenNotifications.TabIndex = 0;
            this.lblTimeBetweenNotifications.Text = "Time between notifications";
            // 
            // trackbarTime
            // 
            this.trackbarTime.LargeChange = 2;
            this.trackbarTime.Location = new System.Drawing.Point(9, 49);
            this.trackbarTime.Name = "trackbarTime";
            this.trackbarTime.Size = new System.Drawing.Size(197, 45);
            this.trackbarTime.TabIndex = 5;
            this.trackbarTime.Scroll += new System.EventHandler(this.trackbarTime_Scroll);
            // 
            // radioMinutes
            // 
            this.radioMinutes.AutoSize = true;
            this.radioMinutes.Location = new System.Drawing.Point(212, 77);
            this.radioMinutes.Name = "radioMinutes";
            this.radioMinutes.Size = new System.Drawing.Size(62, 17);
            this.radioMinutes.TabIndex = 6;
            this.radioMinutes.Text = "Minutes";
            this.radioMinutes.UseVisualStyleBackColor = true;
            this.radioMinutes.CheckedChanged += new System.EventHandler(this.radioMinutes_CheckedChanged);
            // 
            // radioHours
            // 
            this.radioHours.AutoSize = true;
            this.radioHours.Checked = true;
            this.radioHours.Location = new System.Drawing.Point(212, 49);
            this.radioHours.Name = "radioHours";
            this.radioHours.Size = new System.Drawing.Size(53, 17);
            this.radioHours.TabIndex = 7;
            this.radioHours.TabStop = true;
            this.radioHours.Text = "Hours";
            this.radioHours.UseVisualStyleBackColor = true;
            this.radioHours.CheckedChanged += new System.EventHandler(this.radioHours_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 107);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(18, 20);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "0";
            this.lblTime.TextChanged += new System.EventHandler(this.lblTime_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Application minimized!";
            this.notifyIcon1.BalloonTipTitle = "Reminder";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuTrayIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Reminder";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuTrayIcon
            // 
            this.contextMenuTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuTrayIcon.Name = "contextMenuTrayIcon";
            this.contextMenuTrayIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(100, 97);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 34);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(276, 133);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.radioHours);
            this.Controls.Add(this.radioMinutes);
            this.Controls.Add(this.lblTimeBetweenNotifications);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.trackbarTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarTime)).EndInit();
            this.contextMenuTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblTimeBetweenNotifications;
        private System.Windows.Forms.TrackBar trackbarTime;
        private System.Windows.Forms.RadioButton radioMinutes;
        private System.Windows.Forms.RadioButton radioHours;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem savetoolStripMenuItem1;
    }
}

