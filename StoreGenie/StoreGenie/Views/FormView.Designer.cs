namespace StoreGenie
{
    partial class FormView
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
            this.ctrlData = new StoreGenie.UserControlData();
            this.SuspendLayout();
            // 
            // ctrlData
            // 
            this.ctrlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlData.Location = new System.Drawing.Point(0, 0);
            this.ctrlData.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlData.Name = "ctrlData";
            this.ctrlData.Size = new System.Drawing.Size(800, 450);
            this.ctrlData.TabIndex = 0;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ctrlData);
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlData ctrlData;
    }
}