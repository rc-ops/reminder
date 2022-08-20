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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lblLinkRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.github.com/rc-ops/");
            } catch (Exception){
                MessageBox.Show("An error occurred when trying to open the webpage.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
