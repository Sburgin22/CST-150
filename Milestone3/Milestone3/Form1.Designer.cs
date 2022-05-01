namespace Milestone3
{
    partial class Form1
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
            this.arrayListBox = new System.Windows.Forms.ListBox();
            this.addToArray = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arrayListBox
            // 
            this.arrayListBox.FormattingEnabled = true;
            this.arrayListBox.Location = new System.Drawing.Point(85, 77);
            this.arrayListBox.Name = "arrayListBox";
            this.arrayListBox.Size = new System.Drawing.Size(240, 186);
            this.arrayListBox.TabIndex = 0;
            // 
            // addToArray
            // 
            this.addToArray.Location = new System.Drawing.Point(360, 77);
            this.addToArray.Name = "addToArray";
            this.addToArray.Size = new System.Drawing.Size(75, 23);
            this.addToArray.TabIndex = 1;
            this.addToArray.Text = "Add";
            this.addToArray.UseVisualStyleBackColor = true;
            this.addToArray.Click += new System.EventHandler(this.addToArray_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(351, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(456, 80);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 20);
            this.addTextBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(360, 125);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(360, 180);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(456, 182);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addToArray);
            this.Controls.Add(this.arrayListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox arrayListBox;
        private System.Windows.Forms.Button addToArray;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.TextBox orderTextBox;
    }
}

