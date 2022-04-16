namespace Inventory_Management_System
{
    partial class IMS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.orderProductButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.seachButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumber,
            this.itemName,
            this.description,
            this.quantity,
            this.itemType,
            this.onOrder,
            this.itemPrice});
            this.dataGridView1.Location = new System.Drawing.Point(135, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // itemNumber
            // 
            this.itemNumber.HeaderText = "Product Number";
            this.itemNumber.Name = "itemNumber";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // itemType
            // 
            this.itemType.HeaderText = "Category";
            this.itemType.Name = "itemType";
            // 
            // onOrder
            // 
            this.onOrder.HeaderText = "On Order";
            this.onOrder.Name = "onOrder";
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(135, 538);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 38);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // removeProductButton
            // 
            this.removeProductButton.Location = new System.Drawing.Point(301, 538);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(75, 39);
            this.removeProductButton.TabIndex = 2;
            this.removeProductButton.Text = "Remove Product";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(466, 538);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(75, 39);
            this.editProductButton.TabIndex = 3;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // orderProductButton
            // 
            this.orderProductButton.Location = new System.Drawing.Point(637, 539);
            this.orderProductButton.Name = "orderProductButton";
            this.orderProductButton.Size = new System.Drawing.Size(75, 38);
            this.orderProductButton.TabIndex = 4;
            this.orderProductButton.Text = "Order Product";
            this.orderProductButton.UseVisualStyleBackColor = true;
            this.orderProductButton.Click += new System.EventHandler(this.orderProductButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(774, 538);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // seachButton
            // 
            this.seachButton.Location = new System.Drawing.Point(774, 107);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(75, 23);
            this.seachButton.TabIndex = 6;
            this.seachButton.Text = "Search";
            this.seachButton.UseVisualStyleBackColor = true;
            this.seachButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(637, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 7;
            // 
            // imsLabel
            // 
            this.imsLabel.AutoSize = true;
            this.imsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imsLabel.Location = new System.Drawing.Point(340, 40);
            this.imsLabel.Name = "imsLabel";
            this.imsLabel.Size = new System.Drawing.Size(372, 24);
            this.imsLabel.TabIndex = 8;
            this.imsLabel.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 629);
            this.Controls.Add(this.imsLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.seachButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.orderProductButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IMS";
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn onOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button orderProductButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button seachButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label imsLabel;
    }
}

