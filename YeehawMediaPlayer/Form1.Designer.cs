
namespace YeehawMediaPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMediaFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAutoplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autofillVideoSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutYMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMediaFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMediaFileToolStripMenuItem
            // 
            this.openMediaFileToolStripMenuItem.Name = "openMediaFileToolStripMenuItem";
            this.openMediaFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openMediaFileToolStripMenuItem.Text = "Open Media File";
            this.openMediaFileToolStripMenuItem.Click += new System.EventHandler(this.openMediaFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableAutoplayToolStripMenuItem,
            this.autofillVideoSizeToolStripMenuItem,
            this.playbackSpeedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // disableAutoplayToolStripMenuItem
            // 
            this.disableAutoplayToolStripMenuItem.Name = "disableAutoplayToolStripMenuItem";
            this.disableAutoplayToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.disableAutoplayToolStripMenuItem.Text = "Turn Autostart Off";
            this.disableAutoplayToolStripMenuItem.Click += new System.EventHandler(this.disableAutoplayToolStripMenuItem_Click);
            // 
            // autofillVideoSizeToolStripMenuItem
            // 
            this.autofillVideoSizeToolStripMenuItem.Name = "autofillVideoSizeToolStripMenuItem";
            this.autofillVideoSizeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.autofillVideoSizeToolStripMenuItem.Text = "Make Stretch to Fill Off";
            this.autofillVideoSizeToolStripMenuItem.Click += new System.EventHandler(this.autofillVideoSizeToolStripMenuItem_Click);
            // 
            // playbackSpeedToolStripMenuItem
            // 
            this.playbackSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2,
            this.normalToolStripMenuItem,
            this.xToolStripMenuItem3,
            this.xToolStripMenuItem4,
            this.xToolStripMenuItem5,
            this.xToolStripMenuItem6,
            this.xToolStripMenuItem7});
            this.playbackSpeedToolStripMenuItem.Name = "playbackSpeedToolStripMenuItem";
            this.playbackSpeedToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.playbackSpeedToolStripMenuItem.Text = "Playback Speed";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem.Text = "0.25x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem1.Text = "0.5x";
            this.xToolStripMenuItem1.Click += new System.EventHandler(this.xToolStripMenuItem1_Click);
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem2.Text = "0.75x";
            this.xToolStripMenuItem2.Click += new System.EventHandler(this.xToolStripMenuItem2_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem3
            // 
            this.xToolStripMenuItem3.Name = "xToolStripMenuItem3";
            this.xToolStripMenuItem3.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem3.Text = "1.5x";
            this.xToolStripMenuItem3.Click += new System.EventHandler(this.xToolStripMenuItem3_Click);
            // 
            // xToolStripMenuItem4
            // 
            this.xToolStripMenuItem4.Name = "xToolStripMenuItem4";
            this.xToolStripMenuItem4.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem4.Text = "2x";
            this.xToolStripMenuItem4.Click += new System.EventHandler(this.xToolStripMenuItem4_Click);
            // 
            // xToolStripMenuItem5
            // 
            this.xToolStripMenuItem5.Name = "xToolStripMenuItem5";
            this.xToolStripMenuItem5.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem5.Text = "3x";
            this.xToolStripMenuItem5.Click += new System.EventHandler(this.xToolStripMenuItem5_Click);
            // 
            // xToolStripMenuItem6
            // 
            this.xToolStripMenuItem6.Name = "xToolStripMenuItem6";
            this.xToolStripMenuItem6.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem6.Text = "4x";
            this.xToolStripMenuItem6.Click += new System.EventHandler(this.xToolStripMenuItem6_Click);
            // 
            // xToolStripMenuItem7
            // 
            this.xToolStripMenuItem7.Name = "xToolStripMenuItem7";
            this.xToolStripMenuItem7.Size = new System.Drawing.Size(114, 22);
            this.xToolStripMenuItem7.Text = "5x";
            this.xToolStripMenuItem7.Click += new System.EventHandler(this.xToolStripMenuItem7_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutYMPToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutYMPToolStripMenuItem
            // 
            this.aboutYMPToolStripMenuItem.Name = "aboutYMPToolStripMenuItem";
            this.aboutYMPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutYMPToolStripMenuItem.Text = "About YMP";
            this.aboutYMPToolStripMenuItem.Click += new System.EventHandler(this.aboutYMPToolStripMenuItem_Click);
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 24);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(600, 371);
            this.wmp.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 395);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Yeehaw Media Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMediaFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutYMPToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableAutoplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autofillVideoSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem7;
    }
}

