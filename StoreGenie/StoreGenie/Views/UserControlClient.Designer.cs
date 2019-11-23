namespace StoreGenie
{
    partial class UserControlClient
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
            this.lblClientFname = new System.Windows.Forms.Label();
            this.tBoxClientFname = new System.Windows.Forms.TextBox();
            this.btnClientAction = new System.Windows.Forms.Button();
            this.gBoxClient = new System.Windows.Forms.GroupBox();
            this.tBoxClientId = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.tBoxClientAddress = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.tBoxClientEmail = new System.Windows.Forms.TextBox();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.tBoxClientPhone = new System.Windows.Forms.TextBox();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.tBoxClientLname = new System.Windows.Forms.TextBox();
            this.lblClientLname = new System.Windows.Forms.Label();
            this.gBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientFname
            // 
            this.lblClientFname.AutoSize = true;
            this.lblClientFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFname.Location = new System.Drawing.Point(20, 71);
            this.lblClientFname.Name = "lblClientFname";
            this.lblClientFname.Size = new System.Drawing.Size(73, 16);
            this.lblClientFname.TabIndex = 0;
            this.lblClientFname.Text = "First Name";
            // 
            // tBoxClientFname
            // 
            this.tBoxClientFname.Location = new System.Drawing.Point(100, 69);
            this.tBoxClientFname.MaxLength = 30;
            this.tBoxClientFname.Name = "tBoxClientFname";
            this.tBoxClientFname.Size = new System.Drawing.Size(150, 22);
            this.tBoxClientFname.TabIndex = 6;
            this.tBoxClientFname.Tag = "non_id";
            // 
            // btnClientAction
            // 
            this.btnClientAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientAction.Location = new System.Drawing.Point(108, 287);
            this.btnClientAction.Name = "btnClientAction";
            this.btnClientAction.Size = new System.Drawing.Size(97, 30);
            this.btnClientAction.TabIndex = 12;
            this.btnClientAction.Tag = "button";
            this.btnClientAction.Text = "button";
            this.btnClientAction.UseVisualStyleBackColor = true;
            // 
            // gBoxClient
            // 
            this.gBoxClient.Controls.Add(this.tBoxClientId);
            this.gBoxClient.Controls.Add(this.lblClientId);
            this.gBoxClient.Controls.Add(this.tBoxClientAddress);
            this.gBoxClient.Controls.Add(this.lblClientAddress);
            this.gBoxClient.Controls.Add(this.tBoxClientEmail);
            this.gBoxClient.Controls.Add(this.lblClientEmail);
            this.gBoxClient.Controls.Add(this.tBoxClientPhone);
            this.gBoxClient.Controls.Add(this.lblClientPhone);
            this.gBoxClient.Controls.Add(this.tBoxClientLname);
            this.gBoxClient.Controls.Add(this.lblClientLname);
            this.gBoxClient.Controls.Add(this.tBoxClientFname);
            this.gBoxClient.Controls.Add(this.lblClientFname);
            this.gBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxClient.Location = new System.Drawing.Point(20, 17);
            this.gBoxClient.Name = "gBoxClient";
            this.gBoxClient.Size = new System.Drawing.Size(273, 249);
            this.gBoxClient.TabIndex = 13;
            this.gBoxClient.TabStop = false;
            this.gBoxClient.Text = "Client Details";
            // 
            // tBoxClientId
            // 
            this.tBoxClientId.Location = new System.Drawing.Point(100, 39);
            this.tBoxClientId.MaxLength = 10;
            this.tBoxClientId.Name = "tBoxClientId";
            this.tBoxClientId.Size = new System.Drawing.Size(150, 22);
            this.tBoxClientId.TabIndex = 16;
            this.tBoxClientId.Tag = "id";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.Location = new System.Drawing.Point(20, 41);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(21, 16);
            this.lblClientId.TabIndex = 15;
            this.lblClientId.Text = "ID";
            // 
            // tBoxClientAddress
            // 
            this.tBoxClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxClientAddress.Location = new System.Drawing.Point(100, 189);
            this.tBoxClientAddress.MaxLength = 255;
            this.tBoxClientAddress.Multiline = true;
            this.tBoxClientAddress.Name = "tBoxClientAddress";
            this.tBoxClientAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxClientAddress.Size = new System.Drawing.Size(150, 36);
            this.tBoxClientAddress.TabIndex = 14;
            this.tBoxClientAddress.Tag = "non_id";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(20, 191);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(59, 16);
            this.lblClientAddress.TabIndex = 13;
            this.lblClientAddress.Text = "Address";
            // 
            // tBoxClientEmail
            // 
            this.tBoxClientEmail.Location = new System.Drawing.Point(100, 159);
            this.tBoxClientEmail.MaxLength = 255;
            this.tBoxClientEmail.Name = "tBoxClientEmail";
            this.tBoxClientEmail.Size = new System.Drawing.Size(150, 22);
            this.tBoxClientEmail.TabIndex = 12;
            this.tBoxClientEmail.Tag = "non_id";
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEmail.Location = new System.Drawing.Point(20, 161);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(42, 16);
            this.lblClientEmail.TabIndex = 11;
            this.lblClientEmail.Text = "Email";
            // 
            // tBoxClientPhone
            // 
            this.tBoxClientPhone.Location = new System.Drawing.Point(100, 129);
            this.tBoxClientPhone.MaxLength = 10;
            this.tBoxClientPhone.Name = "tBoxClientPhone";
            this.tBoxClientPhone.Size = new System.Drawing.Size(150, 22);
            this.tBoxClientPhone.TabIndex = 10;
            this.tBoxClientPhone.Tag = "non_id";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhone.Location = new System.Drawing.Point(20, 131);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(47, 16);
            this.lblClientPhone.TabIndex = 9;
            this.lblClientPhone.Text = "Phone";
            // 
            // tBoxClientLname
            // 
            this.tBoxClientLname.Location = new System.Drawing.Point(100, 99);
            this.tBoxClientLname.MaxLength = 30;
            this.tBoxClientLname.Name = "tBoxClientLname";
            this.tBoxClientLname.Size = new System.Drawing.Size(150, 22);
            this.tBoxClientLname.TabIndex = 8;
            this.tBoxClientLname.Tag = "non_id";
            // 
            // lblClientLname
            // 
            this.lblClientLname.AutoSize = true;
            this.lblClientLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientLname.Location = new System.Drawing.Point(20, 101);
            this.lblClientLname.Name = "lblClientLname";
            this.lblClientLname.Size = new System.Drawing.Size(73, 16);
            this.lblClientLname.TabIndex = 7;
            this.lblClientLname.Text = "Last Name";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gBoxClient);
            this.Controls.Add(this.btnClientAction);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(313, 348);
            this.gBoxClient.ResumeLayout(false);
            this.gBoxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientFname;
        private System.Windows.Forms.TextBox tBoxClientFname;
        private System.Windows.Forms.Button btnClientAction;
        private System.Windows.Forms.GroupBox gBoxClient;
        private System.Windows.Forms.TextBox tBoxClientAddress;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox tBoxClientEmail;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.TextBox tBoxClientPhone;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.TextBox tBoxClientLname;
        private System.Windows.Forms.Label lblClientLname;
        private System.Windows.Forms.TextBox tBoxClientId;
        private System.Windows.Forms.Label lblClientId;
    }
}
