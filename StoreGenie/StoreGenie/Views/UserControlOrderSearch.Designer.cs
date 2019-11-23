namespace StoreGenie
{
    partial class UserControlOrderSearch
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
            this.tBoxOrderSearchClientId = new System.Windows.Forms.TextBox();
            this.lblOrderSearchClId = new System.Windows.Forms.Label();
            this.gBoxOrderSearch = new System.Windows.Forms.GroupBox();
            this.tBoxOrderSearchId = new System.Windows.Forms.TextBox();
            this.lblOrderSearchId = new System.Windows.Forms.Label();
            this.tBoxOrderSearchDesc = new System.Windows.Forms.TextBox();
            this.lblOrderSearchDescr = new System.Windows.Forms.Label();
            this.btnOrderSearchAction = new System.Windows.Forms.Button();
            this.tBoxOrderSearchTotal = new System.Windows.Forms.TextBox();
            this.lblOrderSearchTotal = new System.Windows.Forms.Label();
            this.dtpOrderSearchOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderSearchOrderDate = new System.Windows.Forms.Label();
            this.gBoxOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxOrderSearchClientId
            // 
            this.tBoxOrderSearchClientId.Location = new System.Drawing.Point(100, 69);
            this.tBoxOrderSearchClientId.MaxLength = 30;
            this.tBoxOrderSearchClientId.Name = "tBoxOrderSearchClientId";
            this.tBoxOrderSearchClientId.Size = new System.Drawing.Size(150, 22);
            this.tBoxOrderSearchClientId.TabIndex = 6;
            this.tBoxOrderSearchClientId.Tag = "non_id";
            // 
            // lblOrderSearchClId
            // 
            this.lblOrderSearchClId.AutoSize = true;
            this.lblOrderSearchClId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSearchClId.Location = new System.Drawing.Point(20, 71);
            this.lblOrderSearchClId.Name = "lblOrderSearchClId";
            this.lblOrderSearchClId.Size = new System.Drawing.Size(55, 16);
            this.lblOrderSearchClId.TabIndex = 0;
            this.lblOrderSearchClId.Text = "Client Id";
            // 
            // gBoxOrderSearch
            // 
            this.gBoxOrderSearch.Controls.Add(this.lblOrderSearchOrderDate);
            this.gBoxOrderSearch.Controls.Add(this.dtpOrderSearchOrderDate);
            this.gBoxOrderSearch.Controls.Add(this.tBoxOrderSearchTotal);
            this.gBoxOrderSearch.Controls.Add(this.lblOrderSearchTotal);
            this.gBoxOrderSearch.Controls.Add(this.tBoxOrderSearchId);
            this.gBoxOrderSearch.Controls.Add(this.lblOrderSearchId);
            this.gBoxOrderSearch.Controls.Add(this.tBoxOrderSearchDesc);
            this.gBoxOrderSearch.Controls.Add(this.lblOrderSearchDescr);
            this.gBoxOrderSearch.Controls.Add(this.tBoxOrderSearchClientId);
            this.gBoxOrderSearch.Controls.Add(this.lblOrderSearchClId);
            this.gBoxOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxOrderSearch.Location = new System.Drawing.Point(20, 17);
            this.gBoxOrderSearch.Name = "gBoxOrderSearch";
            this.gBoxOrderSearch.Size = new System.Drawing.Size(273, 224);
            this.gBoxOrderSearch.TabIndex = 15;
            this.gBoxOrderSearch.TabStop = false;
            this.gBoxOrderSearch.Text = "Order Details";
            // 
            // tBoxOrderSearchId
            // 
            this.tBoxOrderSearchId.Location = new System.Drawing.Point(100, 39);
            this.tBoxOrderSearchId.MaxLength = 10;
            this.tBoxOrderSearchId.Name = "tBoxOrderSearchId";
            this.tBoxOrderSearchId.Size = new System.Drawing.Size(150, 22);
            this.tBoxOrderSearchId.TabIndex = 16;
            this.tBoxOrderSearchId.Tag = "id";
            // 
            // lblOrderSearchId
            // 
            this.lblOrderSearchId.AutoSize = true;
            this.lblOrderSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSearchId.Location = new System.Drawing.Point(20, 41);
            this.lblOrderSearchId.Name = "lblOrderSearchId";
            this.lblOrderSearchId.Size = new System.Drawing.Size(21, 16);
            this.lblOrderSearchId.TabIndex = 15;
            this.lblOrderSearchId.Text = "ID";
            // 
            // tBoxOrderSearchDesc
            // 
            this.tBoxOrderSearchDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxOrderSearchDesc.Location = new System.Drawing.Point(100, 159);
            this.tBoxOrderSearchDesc.MaxLength = 255;
            this.tBoxOrderSearchDesc.Multiline = true;
            this.tBoxOrderSearchDesc.Name = "tBoxOrderSearchDesc";
            this.tBoxOrderSearchDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxOrderSearchDesc.Size = new System.Drawing.Size(150, 36);
            this.tBoxOrderSearchDesc.TabIndex = 14;
            this.tBoxOrderSearchDesc.Tag = "non_id";
            // 
            // lblOrderSearchDescr
            // 
            this.lblOrderSearchDescr.AutoSize = true;
            this.lblOrderSearchDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSearchDescr.Location = new System.Drawing.Point(20, 161);
            this.lblOrderSearchDescr.Name = "lblOrderSearchDescr";
            this.lblOrderSearchDescr.Size = new System.Drawing.Size(76, 16);
            this.lblOrderSearchDescr.TabIndex = 13;
            this.lblOrderSearchDescr.Text = "Description";
            // 
            // btnOrderSearchAction
            // 
            this.btnOrderSearchAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSearchAction.Location = new System.Drawing.Point(107, 269);
            this.btnOrderSearchAction.Name = "btnOrderSearchAction";
            this.btnOrderSearchAction.Size = new System.Drawing.Size(97, 30);
            this.btnOrderSearchAction.TabIndex = 14;
            this.btnOrderSearchAction.Tag = "button";
            this.btnOrderSearchAction.Text = "button";
            this.btnOrderSearchAction.UseVisualStyleBackColor = true;
            // 
            // tBoxOrderSearchTotal
            // 
            this.tBoxOrderSearchTotal.Location = new System.Drawing.Point(100, 99);
            this.tBoxOrderSearchTotal.MaxLength = 10;
            this.tBoxOrderSearchTotal.Name = "tBoxOrderSearchTotal";
            this.tBoxOrderSearchTotal.Size = new System.Drawing.Size(150, 22);
            this.tBoxOrderSearchTotal.TabIndex = 24;
            this.tBoxOrderSearchTotal.Tag = "non_id";
            // 
            // lblOrderSearchTotal
            // 
            this.lblOrderSearchTotal.AutoSize = true;
            this.lblOrderSearchTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSearchTotal.Location = new System.Drawing.Point(20, 101);
            this.lblOrderSearchTotal.Name = "lblOrderSearchTotal";
            this.lblOrderSearchTotal.Size = new System.Drawing.Size(39, 16);
            this.lblOrderSearchTotal.TabIndex = 23;
            this.lblOrderSearchTotal.Text = "Total";
            // 
            // dtpOrderSearchOrderDate
            // 
            this.dtpOrderSearchOrderDate.Location = new System.Drawing.Point(100, 129);
            this.dtpOrderSearchOrderDate.Name = "dtpOrderSearchOrderDate";
            this.dtpOrderSearchOrderDate.Size = new System.Drawing.Size(150, 22);
            this.dtpOrderSearchOrderDate.TabIndex = 25;
            this.dtpOrderSearchOrderDate.Tag = "non_id";
            // 
            // lblOrderSearchOrderDate
            // 
            this.lblOrderSearchOrderDate.AutoSize = true;
            this.lblOrderSearchOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSearchOrderDate.Location = new System.Drawing.Point(20, 131);
            this.lblOrderSearchOrderDate.Name = "lblOrderSearchOrderDate";
            this.lblOrderSearchOrderDate.Size = new System.Drawing.Size(74, 16);
            this.lblOrderSearchOrderDate.TabIndex = 26;
            this.lblOrderSearchOrderDate.Text = "Order Date";
            // 
            // UserControlOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gBoxOrderSearch);
            this.Controls.Add(this.btnOrderSearchAction);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlOrderSearch";
            this.Size = new System.Drawing.Size(313, 324);
            this.Load += new System.EventHandler(this.UserControlOrderSearch_Load);
            this.gBoxOrderSearch.ResumeLayout(false);
            this.gBoxOrderSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxOrderSearchClientId;
        private System.Windows.Forms.Label lblOrderSearchClId;
        private System.Windows.Forms.GroupBox gBoxOrderSearch;
        private System.Windows.Forms.TextBox tBoxOrderSearchId;
        private System.Windows.Forms.Label lblOrderSearchId;
        private System.Windows.Forms.TextBox tBoxOrderSearchDesc;
        private System.Windows.Forms.Label lblOrderSearchDescr;
        private System.Windows.Forms.Button btnOrderSearchAction;
        private System.Windows.Forms.TextBox tBoxOrderSearchTotal;
        private System.Windows.Forms.Label lblOrderSearchTotal;
        private System.Windows.Forms.Label lblOrderSearchOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderSearchOrderDate;
    }
}
