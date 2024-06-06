namespace InventoryManagementSystem
{
    partial class AddPartScreen
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
            this.lblAddPart = new System.Windows.Forms.Label();
            this.rdBtnAddPartInHouse = new System.Windows.Forms.RadioButton();
            this.rdBtnAddPartOutsourced = new System.Windows.Forms.RadioButton();
            this.txtAddPartID = new System.Windows.Forms.TextBox();
            this.lblAddPartID = new System.Windows.Forms.Label();
            this.txtAddPartName = new System.Windows.Forms.TextBox();
            this.txtAddPartInventory = new System.Windows.Forms.TextBox();
            this.txtAddPartPrice = new System.Windows.Forms.TextBox();
            this.txtAddPartMax = new System.Windows.Forms.TextBox();
            this.txtAddPartMachineIDCompanyName = new System.Windows.Forms.TextBox();
            this.lblAddPartName = new System.Windows.Forms.Label();
            this.lblAddPartInventory = new System.Windows.Forms.Label();
            this.lblAddPartPrice = new System.Windows.Forms.Label();
            this.lblAddPartMax = new System.Windows.Forms.Label();
            this.lblAddPartMin = new System.Windows.Forms.Label();
            this.lblAddPartMachineIDCompanyName = new System.Windows.Forms.Label();
            this.txtAddPartMin = new System.Windows.Forms.TextBox();
            this.btnAddPartSave = new System.Windows.Forms.Button();
            this.btnAddPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddPart
            // 
            this.lblAddPart.AutoSize = true;
            this.lblAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPart.Location = new System.Drawing.Point(12, 13);
            this.lblAddPart.Name = "lblAddPart";
            this.lblAddPart.Size = new System.Drawing.Size(71, 20);
            this.lblAddPart.TabIndex = 0;
            this.lblAddPart.Text = "Add Part";
            // 
            // rdBtnAddPartInHouse
            // 
            this.rdBtnAddPartInHouse.AutoSize = true;
            this.rdBtnAddPartInHouse.Checked = true;
            this.rdBtnAddPartInHouse.Location = new System.Drawing.Point(143, 13);
            this.rdBtnAddPartInHouse.Name = "rdBtnAddPartInHouse";
            this.rdBtnAddPartInHouse.Size = new System.Drawing.Size(68, 17);
            this.rdBtnAddPartInHouse.TabIndex = 1;
            this.rdBtnAddPartInHouse.TabStop = true;
            this.rdBtnAddPartInHouse.Text = "In-House";
            this.rdBtnAddPartInHouse.UseVisualStyleBackColor = true;
            this.rdBtnAddPartInHouse.CheckedChanged += new System.EventHandler(this.rdBtnAddPartInHouse_CheckedChanged);
            // 
            // rdBtnAddPartOutsourced
            // 
            this.rdBtnAddPartOutsourced.AutoSize = true;
            this.rdBtnAddPartOutsourced.Location = new System.Drawing.Point(234, 13);
            this.rdBtnAddPartOutsourced.Name = "rdBtnAddPartOutsourced";
            this.rdBtnAddPartOutsourced.Size = new System.Drawing.Size(80, 17);
            this.rdBtnAddPartOutsourced.TabIndex = 2;
            this.rdBtnAddPartOutsourced.Text = "Outsourced";
            this.rdBtnAddPartOutsourced.UseVisualStyleBackColor = true;
            this.rdBtnAddPartOutsourced.CheckedChanged += new System.EventHandler(this.rdBtnAddPartOutsourced_CheckedChanged);
            // 
            // txtAddPartID
            // 
            this.txtAddPartID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPartID.Location = new System.Drawing.Point(162, 78);
            this.txtAddPartID.Name = "txtAddPartID";
            this.txtAddPartID.ReadOnly = true;
            this.txtAddPartID.Size = new System.Drawing.Size(124, 23);
            this.txtAddPartID.TabIndex = 3;
            // 
            // lblAddPartID
            // 
            this.lblAddPartID.AutoSize = true;
            this.lblAddPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartID.Location = new System.Drawing.Point(113, 81);
            this.lblAddPartID.Name = "lblAddPartID";
            this.lblAddPartID.Size = new System.Drawing.Size(21, 17);
            this.lblAddPartID.TabIndex = 4;
            this.lblAddPartID.Text = "ID";
            // 
            // txtAddPartName
            // 
            this.txtAddPartName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPartName.BackColor = System.Drawing.Color.Salmon;
            this.txtAddPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPartName.Location = new System.Drawing.Point(162, 117);
            this.txtAddPartName.Name = "txtAddPartName";
            this.txtAddPartName.Size = new System.Drawing.Size(124, 23);
            this.txtAddPartName.TabIndex = 5;
            this.txtAddPartName.TextChanged += new System.EventHandler(this.txtAddPartName_TextChanged);
            // 
            // txtAddPartInventory
            // 
            this.txtAddPartInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPartInventory.BackColor = System.Drawing.Color.Salmon;
            this.txtAddPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPartInventory.Location = new System.Drawing.Point(162, 156);
            this.txtAddPartInventory.Name = "txtAddPartInventory";
            this.txtAddPartInventory.Size = new System.Drawing.Size(124, 23);
            this.txtAddPartInventory.TabIndex = 6;
            this.txtAddPartInventory.TextChanged += new System.EventHandler(this.txtAddPartInventory_TextChanged);
            // 
            // txtAddPartPrice
            // 
            this.txtAddPartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPartPrice.BackColor = System.Drawing.Color.Salmon;
            this.txtAddPartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPartPrice.Location = new System.Drawing.Point(162, 197);
            this.txtAddPartPrice.Name = "txtAddPartPrice";
            this.txtAddPartPrice.Size = new System.Drawing.Size(124, 23);
            this.txtAddPartPrice.TabIndex = 7;
            this.txtAddPartPrice.TextChanged += new System.EventHandler(this.txtAddPartPrice_TextChanged);
            // 
            // txtAddPartMax
            // 
            this.txtAddPartMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPartMax.BackColor = System.Drawing.Color.Salmon;
            this.txtAddPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPartMax.Location = new System.Drawing.Point(162, 237);
            this.txtAddPartMax.Name = "txtAddPartMax";
            this.txtAddPartMax.Size = new System.Drawing.Size(80, 23);
            this.txtAddPartMax.TabIndex = 8;
            this.txtAddPartMax.TextChanged += new System.EventHandler(this.txtAddPartMax_TextChanged);
            // 
            // txtAddPartMachineIDCompanyName
            // 
            this.txtAddPartMachineIDCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPartMachineIDCompanyName.BackColor = System.Drawing.Color.Salmon;
            this.txtAddPartMachineIDCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPartMachineIDCompanyName.Location = new System.Drawing.Point(162, 277);
            this.txtAddPartMachineIDCompanyName.Name = "txtAddPartMachineIDCompanyName";
            this.txtAddPartMachineIDCompanyName.Size = new System.Drawing.Size(124, 23);
            this.txtAddPartMachineIDCompanyName.TabIndex = 9;
            this.txtAddPartMachineIDCompanyName.TextChanged += new System.EventHandler(this.txtAddPartMachineIDCompanyName_TextChanged);
            // 
            // lblAddPartName
            // 
            this.lblAddPartName.AutoSize = true;
            this.lblAddPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartName.Location = new System.Drawing.Point(89, 120);
            this.lblAddPartName.Name = "lblAddPartName";
            this.lblAddPartName.Size = new System.Drawing.Size(45, 17);
            this.lblAddPartName.TabIndex = 11;
            this.lblAddPartName.Text = "Name";
            // 
            // lblAddPartInventory
            // 
            this.lblAddPartInventory.AutoSize = true;
            this.lblAddPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartInventory.Location = new System.Drawing.Point(68, 159);
            this.lblAddPartInventory.Name = "lblAddPartInventory";
            this.lblAddPartInventory.Size = new System.Drawing.Size(66, 17);
            this.lblAddPartInventory.TabIndex = 12;
            this.lblAddPartInventory.Text = "Inventory";
            // 
            // lblAddPartPrice
            // 
            this.lblAddPartPrice.AutoSize = true;
            this.lblAddPartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartPrice.Location = new System.Drawing.Point(54, 200);
            this.lblAddPartPrice.Name = "lblAddPartPrice";
            this.lblAddPartPrice.Size = new System.Drawing.Size(80, 17);
            this.lblAddPartPrice.TabIndex = 13;
            this.lblAddPartPrice.Text = "Price / Cost";
            // 
            // lblAddPartMax
            // 
            this.lblAddPartMax.AutoSize = true;
            this.lblAddPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartMax.Location = new System.Drawing.Point(101, 240);
            this.lblAddPartMax.Name = "lblAddPartMax";
            this.lblAddPartMax.Size = new System.Drawing.Size(33, 17);
            this.lblAddPartMax.TabIndex = 14;
            this.lblAddPartMax.Text = "Max";
            // 
            // lblAddPartMin
            // 
            this.lblAddPartMin.AutoSize = true;
            this.lblAddPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartMin.Location = new System.Drawing.Point(256, 240);
            this.lblAddPartMin.Name = "lblAddPartMin";
            this.lblAddPartMin.Size = new System.Drawing.Size(30, 17);
            this.lblAddPartMin.TabIndex = 15;
            this.lblAddPartMin.Text = "Min";
            // 
            // lblAddPartMachineIDCompanyName
            // 
            this.lblAddPartMachineIDCompanyName.AutoSize = true;
            this.lblAddPartMachineIDCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPartMachineIDCompanyName.Location = new System.Drawing.Point(26, 280);
            this.lblAddPartMachineIDCompanyName.Name = "lblAddPartMachineIDCompanyName";
            this.lblAddPartMachineIDCompanyName.Size = new System.Drawing.Size(78, 17);
            this.lblAddPartMachineIDCompanyName.TabIndex = 16;
            this.lblAddPartMachineIDCompanyName.Text = "Machine ID";
            // 
            // txtAddPartMin
            // 
            this.txtAddPartMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddPartMin.BackColor = System.Drawing.Color.Salmon;
            this.txtAddPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPartMin.Location = new System.Drawing.Point(301, 237);
            this.txtAddPartMin.Name = "txtAddPartMin";
            this.txtAddPartMin.Size = new System.Drawing.Size(80, 23);
            this.txtAddPartMin.TabIndex = 17;
            this.txtAddPartMin.TextChanged += new System.EventHandler(this.txtAddPartMin_TextChanged);
            // 
            // btnAddPartSave
            // 
            this.btnAddPartSave.Enabled = false;
            this.btnAddPartSave.Location = new System.Drawing.Point(292, 336);
            this.btnAddPartSave.Name = "btnAddPartSave";
            this.btnAddPartSave.Size = new System.Drawing.Size(53, 30);
            this.btnAddPartSave.TabIndex = 18;
            this.btnAddPartSave.Text = "Save";
            this.btnAddPartSave.UseVisualStyleBackColor = true;
            this.btnAddPartSave.Click += new System.EventHandler(this.btnAddPartSave_Click);
            // 
            // btnAddPartCancel
            // 
            this.btnAddPartCancel.Location = new System.Drawing.Point(365, 336);
            this.btnAddPartCancel.Name = "btnAddPartCancel";
            this.btnAddPartCancel.Size = new System.Drawing.Size(53, 30);
            this.btnAddPartCancel.TabIndex = 19;
            this.btnAddPartCancel.Text = "Cancel";
            this.btnAddPartCancel.UseVisualStyleBackColor = true;
            this.btnAddPartCancel.Click += new System.EventHandler(this.btnAddPartCancel_Click);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 383);
            this.Controls.Add(this.btnAddPartCancel);
            this.Controls.Add(this.btnAddPartSave);
            this.Controls.Add(this.txtAddPartMin);
            this.Controls.Add(this.lblAddPartMachineIDCompanyName);
            this.Controls.Add(this.lblAddPartMin);
            this.Controls.Add(this.lblAddPartMax);
            this.Controls.Add(this.lblAddPartPrice);
            this.Controls.Add(this.lblAddPartInventory);
            this.Controls.Add(this.lblAddPartName);
            this.Controls.Add(this.txtAddPartMachineIDCompanyName);
            this.Controls.Add(this.txtAddPartMax);
            this.Controls.Add(this.txtAddPartPrice);
            this.Controls.Add(this.txtAddPartInventory);
            this.Controls.Add(this.txtAddPartName);
            this.Controls.Add(this.lblAddPartID);
            this.Controls.Add(this.txtAddPartID);
            this.Controls.Add(this.rdBtnAddPartOutsourced);
            this.Controls.Add(this.rdBtnAddPartInHouse);
            this.Controls.Add(this.lblAddPart);
            this.Name = "AddPartScreen";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddPart;
        private System.Windows.Forms.RadioButton rdBtnAddPartInHouse;
        private System.Windows.Forms.RadioButton rdBtnAddPartOutsourced;
        private System.Windows.Forms.TextBox txtAddPartID;
        private System.Windows.Forms.Label lblAddPartID;
        private System.Windows.Forms.TextBox txtAddPartName;
        private System.Windows.Forms.TextBox txtAddPartInventory;
        private System.Windows.Forms.TextBox txtAddPartPrice;
        private System.Windows.Forms.TextBox txtAddPartMax;
        private System.Windows.Forms.TextBox txtAddPartMachineIDCompanyName;
        private System.Windows.Forms.Label lblAddPartName;
        private System.Windows.Forms.Label lblAddPartInventory;
        private System.Windows.Forms.Label lblAddPartPrice;
        private System.Windows.Forms.Label lblAddPartMax;
        private System.Windows.Forms.Label lblAddPartMin;
        private System.Windows.Forms.Label lblAddPartMachineIDCompanyName;
        private System.Windows.Forms.TextBox txtAddPartMin;
        public System.Windows.Forms.Button btnAddPartSave;
        private System.Windows.Forms.Button btnAddPartCancel;
    }
}