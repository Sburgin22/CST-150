namespace Activity10
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
            this.unionListBox = new System.Windows.Forms.ListBox();
            this.unionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unionListBox
            // 
            this.unionListBox.FormattingEnabled = true;
            this.unionListBox.Location = new System.Drawing.Point(186, 74);
            this.unionListBox.Name = "unionListBox";
            this.unionListBox.Size = new System.Drawing.Size(353, 225);
            this.unionListBox.TabIndex = 0;
            // 
            // unionButton
            // 
            this.unionButton.Location = new System.Drawing.Point(265, 363);
            this.unionButton.Name = "unionButton";
            this.unionButton.Size = new System.Drawing.Size(75, 38);
            this.unionButton.TabIndex = 1;
            this.unionButton.Text = "Display Union";
            this.unionButton.UseVisualStyleBackColor = true;
            this.unionButton.Click += new System.EventHandler(this.unionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(364, 363);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.unionButton);
            this.Controls.Add(this.unionListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox unionListBox;
        private System.Windows.Forms.Button unionButton;
        private System.Windows.Forms.Button exitButton;
    }
}

