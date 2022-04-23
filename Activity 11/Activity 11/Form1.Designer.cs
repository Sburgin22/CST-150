namespace Activity_11
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
            this.rollButton = new System.Windows.Forms.Button();
            this.die1TextBox = new System.Windows.Forms.TextBox();
            this.die2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(27, 72);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // die1TextBox
            // 
            this.die1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die1TextBox.Location = new System.Drawing.Point(154, 37);
            this.die1TextBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.die1TextBox.Multiline = true;
            this.die1TextBox.Name = "die1TextBox";
            this.die1TextBox.Size = new System.Drawing.Size(100, 100);
            this.die1TextBox.TabIndex = 1;
            this.die1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // die2TextBox
            // 
            this.die2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die2TextBox.Location = new System.Drawing.Point(296, 37);
            this.die2TextBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.die2TextBox.Multiline = true;
            this.die2TextBox.Name = "die2TextBox";
            this.die2TextBox.Size = new System.Drawing.Size(100, 100);
            this.die2TextBox.TabIndex = 2;
            this.die2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 174);
            this.Controls.Add(this.die2TextBox);
            this.Controls.Add(this.die1TextBox);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox die1TextBox;
        private System.Windows.Forms.TextBox die2TextBox;
    }
}

