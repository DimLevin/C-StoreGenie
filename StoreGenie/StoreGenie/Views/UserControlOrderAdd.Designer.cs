namespace StoreGenie
{
    partial class UserControlOrderAdd
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
            this.btnOrderAddSelectClient = new System.Windows.Forms.Button();
            this.btnOrderAddProduct = new System.Windows.Forms.Button();
            this.gBoxOrderAddProductAdd = new System.Windows.Forms.GroupBox();
            this.btnOrderAddProductLeft = new System.Windows.Forms.Button();
            this.btnOrderAddProductRight = new System.Windows.Forms.Button();
            this.lblOrderAddQuantity = new System.Windows.Forms.Label();
            this.cmbOrderAddProdQty = new System.Windows.Forms.ComboBox();
            this.gBoxOrderAddOrder = new System.Windows.Forms.GroupBox();
            this.lstvOrderSummary = new System.Windows.Forms.ListView();
            this.btnOrderAddAction = new System.Windows.Forms.Button();
            this.gBoxOrderAddOrDetails = new System.Windows.Forms.GroupBox();
            this.tBoxOrderAddTotal = new System.Windows.Forms.TextBox();
            this.tBoxOrderAddItems = new System.Windows.Forms.TextBox();
            this.lblOrderAddTotal = new System.Windows.Forms.Label();
            this.lblOrderAddItems = new System.Windows.Forms.Label();
            this.btnOrderAddSelectClientRight = new System.Windows.Forms.Button();
            this.btnOrderAddSelectClientLeft = new System.Windows.Forms.Button();
            this.pnlOrderAddClientSelect = new System.Windows.Forms.Panel();
            this.userControlProduct = new StoreGenie.UserControlProduct();
            this.userControlClient = new StoreGenie.UserControlClient();
            this.gBoxOrderAddProductAdd.SuspendLayout();
            this.gBoxOrderAddOrder.SuspendLayout();
            this.gBoxOrderAddOrDetails.SuspendLayout();
            this.pnlOrderAddClientSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderAddSelectClient
            // 
            this.btnOrderAddSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAddSelectClient.Location = new System.Drawing.Point(54, 6);
            this.btnOrderAddSelectClient.Name = "btnOrderAddSelectClient";
            this.btnOrderAddSelectClient.Size = new System.Drawing.Size(98, 31);
            this.btnOrderAddSelectClient.TabIndex = 2;
            this.btnOrderAddSelectClient.Text = "Select";
            this.btnOrderAddSelectClient.UseVisualStyleBackColor = true;
            this.btnOrderAddSelectClient.Click += new System.EventHandler(this.btnOrderAddSelectClient_Click);
            // 
            // btnOrderAddProduct
            // 
            this.btnOrderAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnOrderAddProduct.Location = new System.Drawing.Point(179, 31);
            this.btnOrderAddProduct.Name = "btnOrderAddProduct";
            this.btnOrderAddProduct.Size = new System.Drawing.Size(98, 31);
            this.btnOrderAddProduct.TabIndex = 3;
            this.btnOrderAddProduct.Text = "Add";
            this.btnOrderAddProduct.UseVisualStyleBackColor = true;
            this.btnOrderAddProduct.Click += new System.EventHandler(this.btnOrderAddProduct_Click);
            // 
            // gBoxOrderAddProductAdd
            // 
            this.gBoxOrderAddProductAdd.Controls.Add(this.btnOrderAddProductLeft);
            this.gBoxOrderAddProductAdd.Controls.Add(this.btnOrderAddProductRight);
            this.gBoxOrderAddProductAdd.Controls.Add(this.lblOrderAddQuantity);
            this.gBoxOrderAddProductAdd.Controls.Add(this.cmbOrderAddProdQty);
            this.gBoxOrderAddProductAdd.Controls.Add(this.btnOrderAddProduct);
            this.gBoxOrderAddProductAdd.Enabled = false;
            this.gBoxOrderAddProductAdd.Location = new System.Drawing.Point(280, 422);
            this.gBoxOrderAddProductAdd.Name = "gBoxOrderAddProductAdd";
            this.gBoxOrderAddProductAdd.Size = new System.Drawing.Size(358, 87);
            this.gBoxOrderAddProductAdd.TabIndex = 4;
            this.gBoxOrderAddProductAdd.TabStop = false;
            // 
            // btnOrderAddProductLeft
            // 
            this.btnOrderAddProductLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAddProductLeft.Location = new System.Drawing.Point(129, 31);
            this.btnOrderAddProductLeft.Name = "btnOrderAddProductLeft";
            this.btnOrderAddProductLeft.Size = new System.Drawing.Size(44, 31);
            this.btnOrderAddProductLeft.TabIndex = 29;
            this.btnOrderAddProductLeft.Text = "<-";
            this.btnOrderAddProductLeft.UseVisualStyleBackColor = true;
            this.btnOrderAddProductLeft.Click += new System.EventHandler(this.btnOrderAddProductLeft_Click);
            // 
            // btnOrderAddProductRight
            // 
            this.btnOrderAddProductRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAddProductRight.Location = new System.Drawing.Point(283, 32);
            this.btnOrderAddProductRight.Name = "btnOrderAddProductRight";
            this.btnOrderAddProductRight.Size = new System.Drawing.Size(44, 31);
            this.btnOrderAddProductRight.TabIndex = 29;
            this.btnOrderAddProductRight.Text = "->";
            this.btnOrderAddProductRight.UseVisualStyleBackColor = true;
            this.btnOrderAddProductRight.Click += new System.EventHandler(this.btnOrderAddProductRight_Click);
            // 
            // lblOrderAddQuantity
            // 
            this.lblOrderAddQuantity.AutoSize = true;
            this.lblOrderAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAddQuantity.Location = new System.Drawing.Point(30, 18);
            this.lblOrderAddQuantity.Name = "lblOrderAddQuantity";
            this.lblOrderAddQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblOrderAddQuantity.TabIndex = 22;
            this.lblOrderAddQuantity.Text = "Quantity";
            // 
            // cmbOrderAddProdQty
            // 
            this.cmbOrderAddProdQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderAddProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderAddProdQty.FormattingEnabled = true;
            this.cmbOrderAddProdQty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOrderAddProdQty.Location = new System.Drawing.Point(33, 43);
            this.cmbOrderAddProdQty.Name = "cmbOrderAddProdQty";
            this.cmbOrderAddProdQty.Size = new System.Drawing.Size(53, 23);
            this.cmbOrderAddProdQty.TabIndex = 5;
            // 
            // gBoxOrderAddOrder
            // 
            this.gBoxOrderAddOrder.Controls.Add(this.lstvOrderSummary);
            this.gBoxOrderAddOrder.Enabled = false;
            this.gBoxOrderAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxOrderAddOrder.Location = new System.Drawing.Point(22, 532);
            this.gBoxOrderAddOrder.Name = "gBoxOrderAddOrder";
            this.gBoxOrderAddOrder.Size = new System.Drawing.Size(616, 267);
            this.gBoxOrderAddOrder.TabIndex = 6;
            this.gBoxOrderAddOrder.TabStop = false;
            this.gBoxOrderAddOrder.Text = "Order";
            // 
            // lstvOrderSummary
            // 
            this.lstvOrderSummary.Location = new System.Drawing.Point(7, 22);
            this.lstvOrderSummary.Name = "lstvOrderSummary";
            this.lstvOrderSummary.Size = new System.Drawing.Size(603, 239);
            this.lstvOrderSummary.TabIndex = 0;
            this.lstvOrderSummary.UseCompatibleStateImageBehavior = false;
            // 
            // btnOrderAddAction
            // 
            this.btnOrderAddAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnOrderAddAction.Location = new System.Drawing.Point(280, 829);
            this.btnOrderAddAction.Name = "btnOrderAddAction";
            this.btnOrderAddAction.Size = new System.Drawing.Size(98, 31);
            this.btnOrderAddAction.TabIndex = 24;
            this.btnOrderAddAction.Text = "Add";
            this.btnOrderAddAction.UseVisualStyleBackColor = true;
            // 
            // gBoxOrderAddOrDetails
            // 
            this.gBoxOrderAddOrDetails.Controls.Add(this.tBoxOrderAddTotal);
            this.gBoxOrderAddOrDetails.Controls.Add(this.tBoxOrderAddItems);
            this.gBoxOrderAddOrDetails.Controls.Add(this.lblOrderAddTotal);
            this.gBoxOrderAddOrDetails.Controls.Add(this.lblOrderAddItems);
            this.gBoxOrderAddOrDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxOrderAddOrDetails.Location = new System.Drawing.Point(22, 402);
            this.gBoxOrderAddOrDetails.Name = "gBoxOrderAddOrDetails";
            this.gBoxOrderAddOrDetails.Size = new System.Drawing.Size(214, 100);
            this.gBoxOrderAddOrDetails.TabIndex = 25;
            this.gBoxOrderAddOrDetails.TabStop = false;
            this.gBoxOrderAddOrDetails.Text = "Order Details";
            // 
            // tBoxOrderAddTotal
            // 
            this.tBoxOrderAddTotal.Enabled = false;
            this.tBoxOrderAddTotal.Location = new System.Drawing.Point(96, 63);
            this.tBoxOrderAddTotal.MaxLength = 10;
            this.tBoxOrderAddTotal.Name = "tBoxOrderAddTotal";
            this.tBoxOrderAddTotal.ReadOnly = true;
            this.tBoxOrderAddTotal.Size = new System.Drawing.Size(74, 22);
            this.tBoxOrderAddTotal.TabIndex = 27;
            this.tBoxOrderAddTotal.Tag = "";
            // 
            // tBoxOrderAddItems
            // 
            this.tBoxOrderAddItems.Enabled = false;
            this.tBoxOrderAddItems.Location = new System.Drawing.Point(96, 35);
            this.tBoxOrderAddItems.MaxLength = 10;
            this.tBoxOrderAddItems.Name = "tBoxOrderAddItems";
            this.tBoxOrderAddItems.ReadOnly = true;
            this.tBoxOrderAddItems.Size = new System.Drawing.Size(74, 22);
            this.tBoxOrderAddItems.TabIndex = 26;
            this.tBoxOrderAddItems.Tag = "";
            // 
            // lblOrderAddTotal
            // 
            this.lblOrderAddTotal.AutoSize = true;
            this.lblOrderAddTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAddTotal.Location = new System.Drawing.Point(16, 63);
            this.lblOrderAddTotal.Name = "lblOrderAddTotal";
            this.lblOrderAddTotal.Size = new System.Drawing.Size(39, 16);
            this.lblOrderAddTotal.TabIndex = 24;
            this.lblOrderAddTotal.Text = "Total";
            // 
            // lblOrderAddItems
            // 
            this.lblOrderAddItems.AutoSize = true;
            this.lblOrderAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAddItems.Location = new System.Drawing.Point(16, 35);
            this.lblOrderAddItems.Name = "lblOrderAddItems";
            this.lblOrderAddItems.Size = new System.Drawing.Size(40, 16);
            this.lblOrderAddItems.TabIndex = 23;
            this.lblOrderAddItems.Text = "Items";
            // 
            // btnOrderAddSelectClientRight
            // 
            this.btnOrderAddSelectClientRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAddSelectClientRight.Location = new System.Drawing.Point(158, 6);
            this.btnOrderAddSelectClientRight.Name = "btnOrderAddSelectClientRight";
            this.btnOrderAddSelectClientRight.Size = new System.Drawing.Size(44, 31);
            this.btnOrderAddSelectClientRight.TabIndex = 27;
            this.btnOrderAddSelectClientRight.Text = "->";
            this.btnOrderAddSelectClientRight.UseVisualStyleBackColor = true;
            this.btnOrderAddSelectClientRight.Click += new System.EventHandler(this.btnOrderAddSelectClientRight_Click);
            // 
            // btnOrderAddSelectClientLeft
            // 
            this.btnOrderAddSelectClientLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAddSelectClientLeft.Location = new System.Drawing.Point(4, 6);
            this.btnOrderAddSelectClientLeft.Name = "btnOrderAddSelectClientLeft";
            this.btnOrderAddSelectClientLeft.Size = new System.Drawing.Size(44, 31);
            this.btnOrderAddSelectClientLeft.TabIndex = 28;
            this.btnOrderAddSelectClientLeft.Text = "<-";
            this.btnOrderAddSelectClientLeft.UseVisualStyleBackColor = true;
            this.btnOrderAddSelectClientLeft.Click += new System.EventHandler(this.btnOrderAddSelectClientLeft_Click);
            // 
            // pnlOrderAddClientSelect
            // 
            this.pnlOrderAddClientSelect.Controls.Add(this.btnOrderAddSelectClient);
            this.pnlOrderAddClientSelect.Controls.Add(this.btnOrderAddSelectClientLeft);
            this.pnlOrderAddClientSelect.Controls.Add(this.btnOrderAddSelectClientRight);
            this.pnlOrderAddClientSelect.Location = new System.Drawing.Point(53, 318);
            this.pnlOrderAddClientSelect.Name = "pnlOrderAddClientSelect";
            this.pnlOrderAddClientSelect.Size = new System.Drawing.Size(208, 44);
            this.pnlOrderAddClientSelect.TabIndex = 29;
            // 
            // userControlProduct
            // 
            this.userControlProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlProduct.Enabled = false;
            this.userControlProduct.Location = new System.Drawing.Point(313, 0);
            this.userControlProduct.Margin = new System.Windows.Forms.Padding(0);
            this.userControlProduct.Name = "userControlProduct";
            this.userControlProduct.Size = new System.Drawing.Size(343, 442);
            this.userControlProduct.TabIndex = 1;
            // 
            // userControlClient
            // 
            this.userControlClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlClient.Location = new System.Drawing.Point(0, 0);
            this.userControlClient.Margin = new System.Windows.Forms.Padding(0);
            this.userControlClient.Name = "userControlClient";
            this.userControlClient.Size = new System.Drawing.Size(313, 348);
            this.userControlClient.TabIndex = 0;
            // 
            // UserControlOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlOrderAddClientSelect);
            this.Controls.Add(this.gBoxOrderAddOrDetails);
            this.Controls.Add(this.btnOrderAddAction);
            this.Controls.Add(this.gBoxOrderAddOrder);
            this.Controls.Add(this.gBoxOrderAddProductAdd);
            this.Controls.Add(this.userControlProduct);
            this.Controls.Add(this.userControlClient);
            this.Name = "UserControlOrderAdd";
            this.Size = new System.Drawing.Size(655, 884);
            this.Load += new System.EventHandler(this.UserControlOrderAdd_Load);
            this.gBoxOrderAddProductAdd.ResumeLayout(false);
            this.gBoxOrderAddProductAdd.PerformLayout();
            this.gBoxOrderAddOrder.ResumeLayout(false);
            this.gBoxOrderAddOrDetails.ResumeLayout(false);
            this.gBoxOrderAddOrDetails.PerformLayout();
            this.pnlOrderAddClientSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlClient userControlClient;
        private UserControlProduct userControlProduct;
        private System.Windows.Forms.Button btnOrderAddSelectClient;
        private System.Windows.Forms.Button btnOrderAddProduct;
        private System.Windows.Forms.GroupBox gBoxOrderAddProductAdd;
        private System.Windows.Forms.ComboBox cmbOrderAddProdQty;
        private System.Windows.Forms.Label lblOrderAddQuantity;
        private System.Windows.Forms.GroupBox gBoxOrderAddOrder;
        private System.Windows.Forms.Button btnOrderAddAction;
        private System.Windows.Forms.GroupBox gBoxOrderAddOrDetails;
        private System.Windows.Forms.Label lblOrderAddTotal;
        private System.Windows.Forms.Label lblOrderAddItems;
        private System.Windows.Forms.TextBox tBoxOrderAddTotal;
        private System.Windows.Forms.TextBox tBoxOrderAddItems;
        private System.Windows.Forms.Button btnOrderAddSelectClientRight;
        private System.Windows.Forms.Button btnOrderAddSelectClientLeft;
        private System.Windows.Forms.Panel pnlOrderAddClientSelect;
        private System.Windows.Forms.Button btnOrderAddProductLeft;
        private System.Windows.Forms.Button btnOrderAddProductRight;
        private System.Windows.Forms.ListView lstvOrderSummary;
    }
}
