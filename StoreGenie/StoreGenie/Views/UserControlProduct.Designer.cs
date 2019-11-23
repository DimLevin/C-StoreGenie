namespace StoreGenie
{
    partial class UserControlProduct
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
            this.tBoxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gBoxProduct = new System.Windows.Forms.GroupBox();
            this.tBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.cmbProductSuppliers = new System.Windows.Forms.ComboBox();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.tBoxProductCatNum = new System.Windows.Forms.TextBox();
            this.lblProductCatNum = new System.Windows.Forms.Label();
            this.tBoxProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.tBoxProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.tBoxProductImagePath = new System.Windows.Forms.TextBox();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.tBoxProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tBoxProductCategory = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.btnProductAction = new System.Windows.Forms.Button();
            this.gBoxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxProductName
            // 
            this.tBoxProductName.Location = new System.Drawing.Point(132, 69);
            this.tBoxProductName.MaxLength = 30;
            this.tBoxProductName.Name = "tBoxProductName";
            this.tBoxProductName.Size = new System.Drawing.Size(150, 22);
            this.tBoxProductName.TabIndex = 6;
            this.tBoxProductName.Tag = "non_id";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(20, 71);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(91, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product name";
            // 
            // gBoxProduct
            // 
            this.gBoxProduct.Controls.Add(this.tBoxProductQuantity);
            this.gBoxProduct.Controls.Add(this.lblProductQuantity);
            this.gBoxProduct.Controls.Add(this.cmbProductSuppliers);
            this.gBoxProduct.Controls.Add(this.lblProductSupplier);
            this.gBoxProduct.Controls.Add(this.tBoxProductCatNum);
            this.gBoxProduct.Controls.Add(this.lblProductCatNum);
            this.gBoxProduct.Controls.Add(this.tBoxProductId);
            this.gBoxProduct.Controls.Add(this.lblProductId);
            this.gBoxProduct.Controls.Add(this.tBoxProductDescription);
            this.gBoxProduct.Controls.Add(this.lblProductDesc);
            this.gBoxProduct.Controls.Add(this.tBoxProductImagePath);
            this.gBoxProduct.Controls.Add(this.lblProductImage);
            this.gBoxProduct.Controls.Add(this.tBoxProductPrice);
            this.gBoxProduct.Controls.Add(this.lblProductPrice);
            this.gBoxProduct.Controls.Add(this.tBoxProductCategory);
            this.gBoxProduct.Controls.Add(this.lblProductCategory);
            this.gBoxProduct.Controls.Add(this.tBoxProductName);
            this.gBoxProduct.Controls.Add(this.lblProductName);
            this.gBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxProduct.Location = new System.Drawing.Point(20, 17);
            this.gBoxProduct.Name = "gBoxProduct";
            this.gBoxProduct.Size = new System.Drawing.Size(303, 336);
            this.gBoxProduct.TabIndex = 17;
            this.gBoxProduct.TabStop = false;
            this.gBoxProduct.Text = "Product Details";
            // 
            // tBoxProductQuantity
            // 
            this.tBoxProductQuantity.Location = new System.Drawing.Point(132, 294);
            this.tBoxProductQuantity.MaxLength = 10;
            this.tBoxProductQuantity.Name = "tBoxProductQuantity";
            this.tBoxProductQuantity.Size = new System.Drawing.Size(150, 22);
            this.tBoxProductQuantity.TabIndex = 22;
            this.tBoxProductQuantity.Tag = "non_id";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(20, 296);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblProductQuantity.TabIndex = 21;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // cmbProductSuppliers
            // 
            this.cmbProductSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductSuppliers.FormattingEnabled = true;
            this.cmbProductSuppliers.Location = new System.Drawing.Point(132, 160);
            this.cmbProductSuppliers.Name = "cmbProductSuppliers";
            this.cmbProductSuppliers.Size = new System.Drawing.Size(150, 24);
            this.cmbProductSuppliers.TabIndex = 20;
            this.cmbProductSuppliers.Tag = "non_id";
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSupplier.Location = new System.Drawing.Point(20, 162);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(58, 16);
            this.lblProductSupplier.TabIndex = 19;
            this.lblProductSupplier.Text = "Supplier";
            // 
            // tBoxProductCatNum
            // 
            this.tBoxProductCatNum.Location = new System.Drawing.Point(132, 130);
            this.tBoxProductCatNum.MaxLength = 10;
            this.tBoxProductCatNum.Name = "tBoxProductCatNum";
            this.tBoxProductCatNum.Size = new System.Drawing.Size(150, 22);
            this.tBoxProductCatNum.TabIndex = 18;
            this.tBoxProductCatNum.Tag = "non_id";
            // 
            // lblProductCatNum
            // 
            this.lblProductCatNum.AutoSize = true;
            this.lblProductCatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCatNum.Location = new System.Drawing.Point(20, 132);
            this.lblProductCatNum.Name = "lblProductCatNum";
            this.lblProductCatNum.Size = new System.Drawing.Size(79, 16);
            this.lblProductCatNum.TabIndex = 17;
            this.lblProductCatNum.Text = "Catalog No.";
            // 
            // tBoxProductId
            // 
            this.tBoxProductId.Location = new System.Drawing.Point(132, 39);
            this.tBoxProductId.MaxLength = 10;
            this.tBoxProductId.Name = "tBoxProductId";
            this.tBoxProductId.Size = new System.Drawing.Size(150, 22);
            this.tBoxProductId.TabIndex = 16;
            this.tBoxProductId.Tag = "id";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(20, 41);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(21, 16);
            this.lblProductId.TabIndex = 15;
            this.lblProductId.Text = "ID";
            // 
            // tBoxProductDescription
            // 
            this.tBoxProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxProductDescription.Location = new System.Drawing.Point(132, 220);
            this.tBoxProductDescription.MaxLength = 255;
            this.tBoxProductDescription.Multiline = true;
            this.tBoxProductDescription.Name = "tBoxProductDescription";
            this.tBoxProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxProductDescription.Size = new System.Drawing.Size(150, 36);
            this.tBoxProductDescription.TabIndex = 14;
            this.tBoxProductDescription.Tag = "non_id";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDesc.Location = new System.Drawing.Point(20, 222);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(76, 16);
            this.lblProductDesc.TabIndex = 13;
            this.lblProductDesc.Text = "Description";
            // 
            // tBoxProductImagePath
            // 
            this.tBoxProductImagePath.Enabled = false;
            this.tBoxProductImagePath.Location = new System.Drawing.Point(132, 190);
            this.tBoxProductImagePath.MaxLength = 255;
            this.tBoxProductImagePath.Name = "tBoxProductImagePath";
            this.tBoxProductImagePath.Size = new System.Drawing.Size(150, 22);
            this.tBoxProductImagePath.TabIndex = 12;
            this.tBoxProductImagePath.Tag = "";
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductImage.Location = new System.Drawing.Point(20, 192);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(75, 16);
            this.lblProductImage.TabIndex = 11;
            this.lblProductImage.Text = "Image path";
            // 
            // tBoxProductPrice
            // 
            this.tBoxProductPrice.Location = new System.Drawing.Point(132, 264);
            this.tBoxProductPrice.MaxLength = 10;
            this.tBoxProductPrice.Name = "tBoxProductPrice";
            this.tBoxProductPrice.Size = new System.Drawing.Size(150, 22);
            this.tBoxProductPrice.TabIndex = 10;
            this.tBoxProductPrice.Tag = "non_id";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(20, 266);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(39, 16);
            this.lblProductPrice.TabIndex = 9;
            this.lblProductPrice.Text = "Price";
            // 
            // tBoxProductCategory
            // 
            this.tBoxProductCategory.Location = new System.Drawing.Point(132, 99);
            this.tBoxProductCategory.MaxLength = 30;
            this.tBoxProductCategory.Name = "tBoxProductCategory";
            this.tBoxProductCategory.Size = new System.Drawing.Size(150, 22);
            this.tBoxProductCategory.TabIndex = 8;
            this.tBoxProductCategory.Tag = "non_id";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(20, 101);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(110, 16);
            this.lblProductCategory.TabIndex = 7;
            this.lblProductCategory.Text = "Product category";
            // 
            // btnProductAction
            // 
            this.btnProductAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAction.Location = new System.Drawing.Point(115, 384);
            this.btnProductAction.Name = "btnProductAction";
            this.btnProductAction.Size = new System.Drawing.Size(97, 30);
            this.btnProductAction.TabIndex = 16;
            this.btnProductAction.Tag = "button";
            this.btnProductAction.Text = "button";
            this.btnProductAction.UseVisualStyleBackColor = true;
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gBoxProduct);
            this.Controls.Add(this.btnProductAction);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(343, 442);
            this.Load += new System.EventHandler(this.UserControlProduct_Load);
            this.gBoxProduct.ResumeLayout(false);
            this.gBoxProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gBoxProduct;
        private System.Windows.Forms.TextBox tBoxProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox tBoxProductDescription;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.TextBox tBoxProductImagePath;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.TextBox tBoxProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox tBoxProductCategory;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Button btnProductAction;
        private System.Windows.Forms.TextBox tBoxProductCatNum;
        private System.Windows.Forms.Label lblProductCatNum;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.ComboBox cmbProductSuppliers;
        private System.Windows.Forms.TextBox tBoxProductQuantity;
        private System.Windows.Forms.Label lblProductQuantity;
    }
}
