namespace StoreGenie
{
    partial class UserControlLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.tBoxLoginPassword = new System.Windows.Forms.MaskedTextBox();
            this.tBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoginPassword.Location = new System.Drawing.Point(22, 83);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(77, 17);
            this.lblLoginPassword.TabIndex = 9;
            this.lblLoginPassword.Text = "Password";
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoginUsername.Location = new System.Drawing.Point(22, 34);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(81, 17);
            this.lblLoginUsername.TabIndex = 8;
            this.lblLoginUsername.Text = "Username";
            // 
            // tBoxLoginPassword
            // 
            this.tBoxLoginPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLoginPassword.HidePromptOnLeave = true;
            this.tBoxLoginPassword.Location = new System.Drawing.Point(130, 85);
            this.tBoxLoginPassword.Name = "tBoxLoginPassword";
            this.tBoxLoginPassword.PasswordChar = '*';
            this.tBoxLoginPassword.Size = new System.Drawing.Size(100, 22);
            this.tBoxLoginPassword.TabIndex = 7;
            this.tBoxLoginPassword.TextChanged += new System.EventHandler(this.tBoxLgnPassword_TextChanged);
            // 
            // tBoxLoginUsername
            // 
            this.tBoxLoginUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tBoxLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLoginUsername.Location = new System.Drawing.Point(130, 34);
            this.tBoxLoginUsername.MaxLength = 20;
            this.tBoxLoginUsername.Name = "tBoxLoginUsername";
            this.tBoxLoginUsername.Size = new System.Drawing.Size(100, 22);
            this.tBoxLoginUsername.TabIndex = 6;
            this.tBoxLoginUsername.TextChanged += new System.EventHandler(this.tBoxLgnUsername_TextChanged);
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Enabled = false;
            this.btnLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLogin.Location = new System.Drawing.Point(89, 146);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(96, 36);
            this.btnLoginLogin.TabIndex = 5;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLgnLogin_Click);
            // 
            // UserControlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.tBoxLoginPassword);
            this.Controls.Add(this.tBoxLoginUsername);
            this.Controls.Add(this.btnLoginLogin);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlLogin";
            this.Size = new System.Drawing.Size(268, 215);
            this.Load += new System.EventHandler(this.UserControlLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.MaskedTextBox tBoxLoginPassword;
        private System.Windows.Forms.TextBox tBoxLoginUsername;
        private System.Windows.Forms.Button btnLoginLogin;
    }
}
