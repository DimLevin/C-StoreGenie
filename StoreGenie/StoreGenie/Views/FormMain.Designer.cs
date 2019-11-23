namespace StoreGenie
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemSession = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemSnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHpViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSession,
            this.mnuItemHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(931, 24);
            this.mnuMain.TabIndex = 1;
            // 
            // mnuItemSession
            // 
            this.mnuItemSession.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSnLogout,
            this.toolStripSeparator1,
            this.mnuItemSnExit});
            this.mnuItemSession.Name = "mnuItemSession";
            this.mnuItemSession.Size = new System.Drawing.Size(58, 20);
            this.mnuItemSession.Text = "Session";
            // 
            // mnuItemSnLogout
            // 
            this.mnuItemSnLogout.Enabled = false;
            this.mnuItemSnLogout.Name = "mnuItemSnLogout";
            this.mnuItemSnLogout.Size = new System.Drawing.Size(117, 22);
            this.mnuItemSnLogout.Text = "Log Out";
            this.mnuItemSnLogout.Click += new System.EventHandler(this.mnuItemSnLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // mnuItemSnExit
            // 
            this.mnuItemSnExit.Name = "mnuItemSnExit";
            this.mnuItemSnExit.Size = new System.Drawing.Size(117, 22);
            this.mnuItemSnExit.Text = "Exit";
            this.mnuItemSnExit.Click += new System.EventHandler(this.mnuItemSnExit_Click);
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHpViewHelp,
            this.mnuItemHpAbout});
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuItemHelp.Text = "Help";
            // 
            // mnuItemHpViewHelp
            // 
            this.mnuItemHpViewHelp.Name = "mnuItemHpViewHelp";
            this.mnuItemHpViewHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuItemHpViewHelp.Size = new System.Drawing.Size(146, 22);
            this.mnuItemHpViewHelp.Text = "View Help";
            this.mnuItemHpViewHelp.Click += new System.EventHandler(this.mnuItemHpViewHelp_Click);
            // 
            // mnuItemHpAbout
            // 
            this.mnuItemHpAbout.Name = "mnuItemHpAbout";
            this.mnuItemHpAbout.Size = new System.Drawing.Size(146, 22);
            this.mnuItemHpAbout.Text = "About";
            this.mnuItemHpAbout.Click += new System.EventHandler(this.mnuItemHpAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(931, 597);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FormMain";
            this.Text = "StoreGenie";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSession;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSnExit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHpViewHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSnLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

