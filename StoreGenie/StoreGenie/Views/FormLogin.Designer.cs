namespace StoreGenie
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.ctrlLogin = new StoreGenie.UserControlLogin();
            this.SuspendLayout();
            // 
            // ctrlLogin
            // 
            this.ctrlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlLogin.Location = new System.Drawing.Point(115, 59);
            this.ctrlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlLogin.Name = "ctrlLogin";
            this.ctrlLogin.Size = new System.Drawing.Size(268, 219);
            this.ctrlLogin.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.ctrlLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlLogin ctrlLogin;
    }
}