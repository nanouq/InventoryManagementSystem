namespace InventoryManagementSystem
{
    partial class MainScreen
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
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModPart = new System.Windows.Forms.Button();
            this.btnDelPart = new System.Windows.Forms.Button();
            this.lblPart = new System.Windows.Forms.Label();
            this.txtSearchPart = new System.Windows.Forms.TextBox();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.btnSearchProd = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnModProd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelProd
            // 
            this.btnDelProd.Location = new System.Drawing.Point(1002, 332);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(53, 30);
            this.btnDelProd.TabIndex = 2;
            this.btnDelProd.Text = "Delete";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(346, 332);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(53, 30);
            this.btnAddPart.TabIndex = 8;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnModPart
            // 
            this.btnModPart.Location = new System.Drawing.Point(405, 332);
            this.btnModPart.Name = "btnModPart";
            this.btnModPart.Size = new System.Drawing.Size(53, 30);
            this.btnModPart.TabIndex = 7;
            this.btnModPart.Text = "Modify";
            this.btnModPart.UseVisualStyleBackColor = true;
            this.btnModPart.Click += new System.EventHandler(this.btnModPart_Click);
            // 
            // btnDelPart
            // 
            this.btnDelPart.Location = new System.Drawing.Point(464, 332);
            this.btnDelPart.Name = "btnDelPart";
            this.btnDelPart.Size = new System.Drawing.Size(53, 30);
            this.btnDelPart.TabIndex = 6;
            this.btnDelPart.Text = "Delete";
            this.btnDelPart.UseVisualStyleBackColor = true;
            this.btnDelPart.Click += new System.EventHandler(this.btnDelPart_Click);
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.Location = new System.Drawing.Point(24, 73);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(46, 20);
            this.lblPart.TabIndex = 9;
            this.lblPart.Text = "Parts";
            // 
            // txtSearchPart
            // 
            this.txtSearchPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPart.Location = new System.Drawing.Point(346, 59);
            this.txtSearchPart.Name = "txtSearchPart";
            this.txtSearchPart.Size = new System.Drawing.Size(170, 26);
            this.txtSearchPart.TabIndex = 10;
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(277, 60);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(63, 24);
            this.btnSearchPart.TabIndex = 11;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            this.btnSearchPart.Click += new System.EventHandler(this.btnSearchPart_Click);
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Location = new System.Drawing.Point(816, 61);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(63, 24);
            this.btnSearchProd.TabIndex = 13;
            this.btnSearchProd.Text = "Search";
            this.btnSearchProd.UseVisualStyleBackColor = true;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(885, 59);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(170, 26);
            this.txtSearchProduct.TabIndex = 12;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(12, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(229, 20);
            this.lblMain.TabIndex = 14;
            this.lblMain.Text = "Inventory Management System";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(563, 73);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(72, 20);
            this.lblProd.TabIndex = 15;
            this.lblProd.Text = "Products";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(884, 332);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(53, 30);
            this.btnAddProd.TabIndex = 16;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnModProd
            // 
            this.btnModProd.Location = new System.Drawing.Point(943, 332);
            this.btnModProd.Name = "btnModProd";
            this.btnModProd.Size = new System.Drawing.Size(53, 30);
            this.btnModProd.TabIndex = 17;
            this.btnModProd.Text = "Modify";
            this.btnModProd.UseVisualStyleBackColor = true;
            this.btnModProd.Click += new System.EventHandler(this.btnModProd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1002, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 30);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToResizeColumns = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productsGridView.Location = new System.Drawing.Point(567, 96);
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersVisible = false;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(488, 221);
            this.productsGridView.TabIndex = 19;
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.AllowUserToResizeColumns = false;
            this.partsGridView.AllowUserToResizeRows = false;
            this.partsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsGridView.Location = new System.Drawing.Point(28, 96);
            this.partsGridView.MultiSelect = false;
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.RowHeadersVisible = false;
            this.partsGridView.RowHeadersWidth = 20;
            this.partsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsGridView.Size = new System.Drawing.Size(488, 221);
            this.partsGridView.TabIndex = 20;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnSearchProd);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.txtSearchPart);
            this.Controls.Add(this.lblPart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnModPart);
            this.Controls.Add(this.btnDelPart);
            this.Controls.Add(this.btnDelProd);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnModPart;
        private System.Windows.Forms.Button btnDelPart;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.TextBox txtSearchPart;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.Button btnSearchProd;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnModProd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridView partsGridView;
    }
}

