namespace MusicH_WF
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRTISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rANKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLBUMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mUSICTRACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTISTToolStripMenuItem,
            this.rANKINGToolStripMenuItem,
            this.aLBUMToolStripMenuItem,
            this.mUSICTRACKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRTISTToolStripMenuItem
            // 
            this.aRTISTToolStripMenuItem.Name = "aRTISTToolStripMenuItem";
            this.aRTISTToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aRTISTToolStripMenuItem.Text = "ARTIST";
            this.aRTISTToolStripMenuItem.Click += new System.EventHandler(this.aRTISTToolStripMenuItem_Click);
            // 
            // rANKINGToolStripMenuItem
            // 
            this.rANKINGToolStripMenuItem.Name = "rANKINGToolStripMenuItem";
            this.rANKINGToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.rANKINGToolStripMenuItem.Text = "RANKING";
            this.rANKINGToolStripMenuItem.Click += new System.EventHandler(this.rANKINGToolStripMenuItem_Click);
            // 
            // aLBUMToolStripMenuItem
            // 
            this.aLBUMToolStripMenuItem.Name = "aLBUMToolStripMenuItem";
            this.aLBUMToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aLBUMToolStripMenuItem.Text = "ALBUM";
            this.aLBUMToolStripMenuItem.Click += new System.EventHandler(this.aLBUMToolStripMenuItem_Click);
            // 
            // mUSICTRACKToolStripMenuItem
            // 
            this.mUSICTRACKToolStripMenuItem.Name = "mUSICTRACKToolStripMenuItem";
            this.mUSICTRACKToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.mUSICTRACKToolStripMenuItem.Text = "MUSICTRACK";
            this.mUSICTRACKToolStripMenuItem.Click += new System.EventHandler(this.mUSICTRACKToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 312);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRTISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rANKINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLBUMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mUSICTRACKToolStripMenuItem;
    }
}

