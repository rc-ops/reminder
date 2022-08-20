namespace remindertimer
{
    partial class About
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
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLinkRepository = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(6, 9);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(134, 20);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "Created by rc-ops";
            // 
            // lblLinkRepository
            // 
            this.lblLinkRepository.AutoSize = true;
            this.lblLinkRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkRepository.Location = new System.Drawing.Point(10, 63);
            this.lblLinkRepository.Name = "lblLinkRepository";
            this.lblLinkRepository.Size = new System.Drawing.Size(119, 20);
            this.lblLinkRepository.TabIndex = 1;
            this.lblLinkRepository.TabStop = true;
            this.lblLinkRepository.Text = "rc-ops\'s GitHub";
            this.lblLinkRepository.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkRepository_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::remindertimer.Properties.Resources.identicon_rc_ops;
            this.pictureBox1.Location = new System.Drawing.Point(151, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 99);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLinkRepository);
            this.Controls.Add(this.lblCreatedBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel lblLinkRepository;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}