namespace InventoryManagementSystem
{
    partial class ModifyProductScreen
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
            this.lblModifyProductAssociatedParts = new System.Windows.Forms.Label();
            this.lblModifyProductAllCandidateParts = new System.Windows.Forms.Label();
            this.btnModifyProductSearch = new System.Windows.Forms.Button();
            this.txtModifyProductSearch = new System.Windows.Forms.TextBox();
            this.btnModifyProductAdd = new System.Windows.Forms.Button();
            this.gridModifyProductAssociatedParts = new System.Windows.Forms.DataGridView();
            this.gridModifyProductAllCandidateParts = new System.Windows.Forms.DataGridView();
            this.btnModifyProductDelete = new System.Windows.Forms.Button();
            this.btnModifyProductCancel = new System.Windows.Forms.Button();
            this.btnModifyProductSave = new System.Windows.Forms.Button();
            this.txtModifyProductMin = new System.Windows.Forms.TextBox();
            this.lblModifyProductMin = new System.Windows.Forms.Label();
            this.lblModifyProductMax = new System.Windows.Forms.Label();
            this.lblModifyProductPrice = new System.Windows.Forms.Label();
            this.lblModifyProductInventory = new System.Windows.Forms.Label();
            this.lblModifyProductName = new System.Windows.Forms.Label();
            this.txtModifyProductMax = new System.Windows.Forms.TextBox();
            this.txtModifyProductPrice = new System.Windows.Forms.TextBox();
            this.txtModifyProductInventory = new System.Windows.Forms.TextBox();
            this.txtModifyProductName = new System.Windows.Forms.TextBox();
            this.lblModifyProductID = new System.Windows.Forms.Label();
            this.txtModifyProductID = new System.Windows.Forms.TextBox();
            this.lblModifyProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductAllCandidateParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModifyProductAssociatedParts
            // 
            this.lblModifyProductAssociatedParts.AutoSize = true;
            this.lblModifyProductAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductAssociatedParts.Location = new System.Drawing.Point(400, 274);
            this.lblModifyProductAssociatedParts.Name = "lblModifyProductAssociatedParts";
            this.lblModifyProductAssociatedParts.Size = new System.Drawing.Size(189, 15);
            this.lblModifyProductAssociatedParts.TabIndex = 78;
            this.lblModifyProductAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // lblModifyProductAllCandidateParts
            // 
            this.lblModifyProductAllCandidateParts.AutoSize = true;
            this.lblModifyProductAllCandidateParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductAllCandidateParts.Location = new System.Drawing.Point(400, 51);
            this.lblModifyProductAllCandidateParts.Name = "lblModifyProductAllCandidateParts";
            this.lblModifyProductAllCandidateParts.Size = new System.Drawing.Size(108, 15);
            this.lblModifyProductAllCandidateParts.TabIndex = 77;
            this.lblModifyProductAllCandidateParts.Text = "All candidate Parts";
            // 
            // btnModifyProductSearch
            // 
            this.btnModifyProductSearch.Location = new System.Drawing.Point(582, 22);
            this.btnModifyProductSearch.Name = "btnModifyProductSearch";
            this.btnModifyProductSearch.Size = new System.Drawing.Size(63, 24);
            this.btnModifyProductSearch.TabIndex = 76;
            this.btnModifyProductSearch.Text = "Search";
            this.btnModifyProductSearch.UseVisualStyleBackColor = true;
            this.btnModifyProductSearch.Click += new System.EventHandler(this.btnModifyProductSearch_Click);
            // 
            // txtModifyProductSearch
            // 
            this.txtModifyProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModifyProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyProductSearch.Location = new System.Drawing.Point(651, 23);
            this.txtModifyProductSearch.Name = "txtModifyProductSearch";
            this.txtModifyProductSearch.Size = new System.Drawing.Size(240, 23);
            this.txtModifyProductSearch.TabIndex = 75;
            // 
            // btnModifyProductAdd
            // 
            this.btnModifyProductAdd.Location = new System.Drawing.Point(815, 240);
            this.btnModifyProductAdd.Name = "btnModifyProductAdd";
            this.btnModifyProductAdd.Size = new System.Drawing.Size(53, 30);
            this.btnModifyProductAdd.TabIndex = 74;
            this.btnModifyProductAdd.Text = "Add";
            this.btnModifyProductAdd.UseVisualStyleBackColor = true;
            this.btnModifyProductAdd.Click += new System.EventHandler(this.btnModifyProductAdd_Click);
            // 
            // gridModifyProductAssociatedParts
            // 
            this.gridModifyProductAssociatedParts.AllowUserToAddRows = false;
            this.gridModifyProductAssociatedParts.AllowUserToDeleteRows = false;
            this.gridModifyProductAssociatedParts.AllowUserToResizeColumns = false;
            this.gridModifyProductAssociatedParts.AllowUserToResizeRows = false;
            this.gridModifyProductAssociatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridModifyProductAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModifyProductAssociatedParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridModifyProductAssociatedParts.Location = new System.Drawing.Point(403, 292);
            this.gridModifyProductAssociatedParts.Name = "gridModifyProductAssociatedParts";
            this.gridModifyProductAssociatedParts.RowHeadersVisible = false;
            this.gridModifyProductAssociatedParts.RowHeadersWidth = 20;
            this.gridModifyProductAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModifyProductAssociatedParts.Size = new System.Drawing.Size(488, 156);
            this.gridModifyProductAssociatedParts.TabIndex = 73;
            // 
            // gridModifyProductAllCandidateParts
            // 
            this.gridModifyProductAllCandidateParts.AllowUserToAddRows = false;
            this.gridModifyProductAllCandidateParts.AllowUserToDeleteRows = false;
            this.gridModifyProductAllCandidateParts.AllowUserToResizeColumns = false;
            this.gridModifyProductAllCandidateParts.AllowUserToResizeRows = false;
            this.gridModifyProductAllCandidateParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridModifyProductAllCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModifyProductAllCandidateParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridModifyProductAllCandidateParts.Location = new System.Drawing.Point(403, 69);
            this.gridModifyProductAllCandidateParts.Name = "gridModifyProductAllCandidateParts";
            this.gridModifyProductAllCandidateParts.RowHeadersVisible = false;
            this.gridModifyProductAllCandidateParts.RowHeadersWidth = 20;
            this.gridModifyProductAllCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModifyProductAllCandidateParts.Size = new System.Drawing.Size(488, 156);
            this.gridModifyProductAllCandidateParts.TabIndex = 72;
            // 
            // btnModifyProductDelete
            // 
            this.btnModifyProductDelete.Location = new System.Drawing.Point(815, 466);
            this.btnModifyProductDelete.Name = "btnModifyProductDelete";
            this.btnModifyProductDelete.Size = new System.Drawing.Size(53, 30);
            this.btnModifyProductDelete.TabIndex = 71;
            this.btnModifyProductDelete.Text = "Delete";
            this.btnModifyProductDelete.UseVisualStyleBackColor = true;
            this.btnModifyProductDelete.Click += new System.EventHandler(this.btnModifyProductDelete_Click);
            // 
            // btnModifyProductCancel
            // 
            this.btnModifyProductCancel.Location = new System.Drawing.Point(815, 511);
            this.btnModifyProductCancel.Name = "btnModifyProductCancel";
            this.btnModifyProductCancel.Size = new System.Drawing.Size(53, 30);
            this.btnModifyProductCancel.TabIndex = 70;
            this.btnModifyProductCancel.Text = "Cancel";
            this.btnModifyProductCancel.UseVisualStyleBackColor = true;
            this.btnModifyProductCancel.Click += new System.EventHandler(this.btnModifyProductCancel_Click);
            // 
            // btnModifyProductSave
            // 
            this.btnModifyProductSave.Location = new System.Drawing.Point(742, 511);
            this.btnModifyProductSave.Name = "btnModifyProductSave";
            this.btnModifyProductSave.Size = new System.Drawing.Size(53, 30);
            this.btnModifyProductSave.TabIndex = 69;
            this.btnModifyProductSave.Text = "Save";
            this.btnModifyProductSave.UseVisualStyleBackColor = true;
            this.btnModifyProductSave.Click += new System.EventHandler(this.btnModifyProductSave_Click);
            // 
            // txtModifyProductMin
            // 
            this.txtModifyProductMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModifyProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyProductMin.Location = new System.Drawing.Point(233, 325);
            this.txtModifyProductMin.Name = "txtModifyProductMin";
            this.txtModifyProductMin.Size = new System.Drawing.Size(80, 23);
            this.txtModifyProductMin.TabIndex = 68;
            this.txtModifyProductMin.TextChanged += new System.EventHandler(this.txtModifyProductMin_TextChanged);
            // 
            // lblModifyProductMin
            // 
            this.lblModifyProductMin.AutoSize = true;
            this.lblModifyProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductMin.Location = new System.Drawing.Point(183, 328);
            this.lblModifyProductMin.Name = "lblModifyProductMin";
            this.lblModifyProductMin.Size = new System.Drawing.Size(30, 17);
            this.lblModifyProductMin.TabIndex = 67;
            this.lblModifyProductMin.Text = "Min";
            // 
            // lblModifyProductMax
            // 
            this.lblModifyProductMax.AutoSize = true;
            this.lblModifyProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductMax.Location = new System.Drawing.Point(26, 328);
            this.lblModifyProductMax.Name = "lblModifyProductMax";
            this.lblModifyProductMax.Size = new System.Drawing.Size(33, 17);
            this.lblModifyProductMax.TabIndex = 66;
            this.lblModifyProductMax.Text = "Max";
            // 
            // lblModifyProductPrice
            // 
            this.lblModifyProductPrice.AutoSize = true;
            this.lblModifyProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductPrice.Location = new System.Drawing.Point(26, 288);
            this.lblModifyProductPrice.Name = "lblModifyProductPrice";
            this.lblModifyProductPrice.Size = new System.Drawing.Size(40, 17);
            this.lblModifyProductPrice.TabIndex = 65;
            this.lblModifyProductPrice.Text = "Price";
            // 
            // lblModifyProductInventory
            // 
            this.lblModifyProductInventory.AutoSize = true;
            this.lblModifyProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductInventory.Location = new System.Drawing.Point(26, 247);
            this.lblModifyProductInventory.Name = "lblModifyProductInventory";
            this.lblModifyProductInventory.Size = new System.Drawing.Size(66, 17);
            this.lblModifyProductInventory.TabIndex = 64;
            this.lblModifyProductInventory.Text = "Inventory";
            // 
            // lblModifyProductName
            // 
            this.lblModifyProductName.AutoSize = true;
            this.lblModifyProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductName.Location = new System.Drawing.Point(26, 208);
            this.lblModifyProductName.Name = "lblModifyProductName";
            this.lblModifyProductName.Size = new System.Drawing.Size(45, 17);
            this.lblModifyProductName.TabIndex = 63;
            this.lblModifyProductName.Text = "Name";
            // 
            // txtModifyProductMax
            // 
            this.txtModifyProductMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModifyProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyProductMax.Location = new System.Drawing.Point(81, 325);
            this.txtModifyProductMax.Name = "txtModifyProductMax";
            this.txtModifyProductMax.Size = new System.Drawing.Size(80, 23);
            this.txtModifyProductMax.TabIndex = 62;
            this.txtModifyProductMax.TextChanged += new System.EventHandler(this.txtModifyProductMax_TextChanged);
            // 
            // txtModifyProductPrice
            // 
            this.txtModifyProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModifyProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyProductPrice.Location = new System.Drawing.Point(127, 285);
            this.txtModifyProductPrice.Name = "txtModifyProductPrice";
            this.txtModifyProductPrice.Size = new System.Drawing.Size(124, 23);
            this.txtModifyProductPrice.TabIndex = 61;
            this.txtModifyProductPrice.TextChanged += new System.EventHandler(this.txtModifyProductPrice_TextChanged);
            // 
            // txtModifyProductInventory
            // 
            this.txtModifyProductInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModifyProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyProductInventory.Location = new System.Drawing.Point(127, 244);
            this.txtModifyProductInventory.Name = "txtModifyProductInventory";
            this.txtModifyProductInventory.Size = new System.Drawing.Size(124, 23);
            this.txtModifyProductInventory.TabIndex = 60;
            this.txtModifyProductInventory.TextChanged += new System.EventHandler(this.txtModifyProductInventory_TextChanged);
            // 
            // txtModifyProductName
            // 
            this.txtModifyProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModifyProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyProductName.Location = new System.Drawing.Point(127, 205);
            this.txtModifyProductName.Name = "txtModifyProductName";
            this.txtModifyProductName.Size = new System.Drawing.Size(124, 23);
            this.txtModifyProductName.TabIndex = 59;
            this.txtModifyProductName.TextChanged += new System.EventHandler(this.txtModifyProductName_TextChanged);
            // 
            // lblModifyProductID
            // 
            this.lblModifyProductID.AutoSize = true;
            this.lblModifyProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProductID.Location = new System.Drawing.Point(26, 166);
            this.lblModifyProductID.Name = "lblModifyProductID";
            this.lblModifyProductID.Size = new System.Drawing.Size(21, 17);
            this.lblModifyProductID.TabIndex = 58;
            this.lblModifyProductID.Text = "ID";
            // 
            // txtModifyProductID
            // 
            this.txtModifyProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtModifyProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifyProductID.Location = new System.Drawing.Point(127, 166);
            this.txtModifyProductID.Name = "txtModifyProductID";
            this.txtModifyProductID.ReadOnly = true;
            this.txtModifyProductID.Size = new System.Drawing.Size(124, 23);
            this.txtModifyProductID.TabIndex = 57;
            // 
            // lblModifyProduct
            // 
            this.lblModifyProduct.AutoSize = true;
            this.lblModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyProduct.Location = new System.Drawing.Point(21, 23);
            this.lblModifyProduct.Name = "lblModifyProduct";
            this.lblModifyProduct.Size = new System.Drawing.Size(114, 20);
            this.lblModifyProduct.TabIndex = 56;
            this.lblModifyProduct.Text = "Modify Product";
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 563);
            this.Controls.Add(this.lblModifyProductAssociatedParts);
            this.Controls.Add(this.lblModifyProductAllCandidateParts);
            this.Controls.Add(this.btnModifyProductSearch);
            this.Controls.Add(this.txtModifyProductSearch);
            this.Controls.Add(this.btnModifyProductAdd);
            this.Controls.Add(this.gridModifyProductAssociatedParts);
            this.Controls.Add(this.gridModifyProductAllCandidateParts);
            this.Controls.Add(this.btnModifyProductDelete);
            this.Controls.Add(this.btnModifyProductCancel);
            this.Controls.Add(this.btnModifyProductSave);
            this.Controls.Add(this.txtModifyProductMin);
            this.Controls.Add(this.lblModifyProductMin);
            this.Controls.Add(this.lblModifyProductMax);
            this.Controls.Add(this.lblModifyProductPrice);
            this.Controls.Add(this.lblModifyProductInventory);
            this.Controls.Add(this.lblModifyProductName);
            this.Controls.Add(this.txtModifyProductMax);
            this.Controls.Add(this.txtModifyProductPrice);
            this.Controls.Add(this.txtModifyProductInventory);
            this.Controls.Add(this.txtModifyProductName);
            this.Controls.Add(this.lblModifyProductID);
            this.Controls.Add(this.txtModifyProductID);
            this.Controls.Add(this.lblModifyProduct);
            this.Name = "ModifyProductScreen";
            this.Text = "ModifyProductScreen";
            this.Load += new System.EventHandler(this.ModifyProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModifyProductAllCandidateParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifyProductAssociatedParts;
        private System.Windows.Forms.Label lblModifyProductAllCandidateParts;
        private System.Windows.Forms.Button btnModifyProductSearch;
        private System.Windows.Forms.TextBox txtModifyProductSearch;
        public System.Windows.Forms.Button btnModifyProductAdd;
        private System.Windows.Forms.DataGridView gridModifyProductAssociatedParts;
        private System.Windows.Forms.DataGridView gridModifyProductAllCandidateParts;
        public System.Windows.Forms.Button btnModifyProductDelete;
        private System.Windows.Forms.Button btnModifyProductCancel;
        public System.Windows.Forms.Button btnModifyProductSave;
        private System.Windows.Forms.TextBox txtModifyProductMin;
        private System.Windows.Forms.Label lblModifyProductMin;
        private System.Windows.Forms.Label lblModifyProductMax;
        private System.Windows.Forms.Label lblModifyProductPrice;
        private System.Windows.Forms.Label lblModifyProductInventory;
        private System.Windows.Forms.Label lblModifyProductName;
        private System.Windows.Forms.TextBox txtModifyProductMax;
        private System.Windows.Forms.TextBox txtModifyProductPrice;
        private System.Windows.Forms.TextBox txtModifyProductInventory;
        private System.Windows.Forms.TextBox txtModifyProductName;
        private System.Windows.Forms.Label lblModifyProductID;
        private System.Windows.Forms.TextBox txtModifyProductID;
        private System.Windows.Forms.Label lblModifyProduct;
    }
}