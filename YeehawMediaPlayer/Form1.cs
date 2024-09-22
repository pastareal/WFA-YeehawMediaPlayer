using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeehawMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openMediaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog yeehaw = new OpenFileDialog();
            yeehaw.Title = "Open Media File...";
            yeehaw.Filter = "MP4 File(*.mp4)|*.mp4|MOV File(*.mov)|*.mov|AVI File(*.avi)|*.avi|WMV File(*.wmv)|*.wmv|FLV File(*flv)|*.flv|MKV File(*.mkv)|*.mkv|All Files(*.*)|*.*";
            if (yeehaw.ShowDialog() == DialogResult.OK)
            {
                wmp.URL = yeehaw.FileName;
                wmp.settings.rate = 1;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 0.25;
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 0.5;
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 0.75;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 1;
        }

        private void xToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 1.5;
        }

        private void xToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 2;
        }

        private void xToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 3;
        }

        private void xToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 4;
        }

        private void xToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            wmp.settings.rate = 5;
        }

        private void disableAutoplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disableAutoplayToolStripMenuItem.Text == "Turn Autostart On")
            {
                disableAutoplayToolStripMenuItem.Text = "Turn Autostart Off";
                wmp.settings.autoStart = false;
            }
            else if (disableAutoplayToolStripMenuItem.Text == "Turn Autostart Off")
            {
                disableAutoplayToolStripMenuItem.Text = "Turn Autostart On";
                wmp.settings.autoStart = true;
            }
        }

        private void autofillVideoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autofillVideoSizeToolStripMenuItem.Text == "Make Stretch to Fill On")
            {
                autofillVideoSizeToolStripMenuItem.Text = "Make Stretch to Fill Off";
                wmp.stretchToFit = false;
            }
            else if (autofillVideoSizeToolStripMenuItem.Text == "Make Stretch to Fill Off")
            {
                autofillVideoSizeToolStripMenuItem.Text = "Make Stretch to Fill On";
                wmp.stretchToFit = true;
            }
        }

        private void aboutYMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by yeehaw so that I can open source this code to Github, made in VS 2019 with .NET 4.7.2", "About Yeehaw Media Player");
        }
    }
}
