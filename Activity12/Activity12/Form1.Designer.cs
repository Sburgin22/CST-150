namespace Activity12
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
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.findWordsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.Location = new System.Drawing.Point(75, 47);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(216, 186);
            this.wordsListBox.TabIndex = 0;
            // 
            // findWordsButton
            // 
            this.findWordsButton.Location = new System.Drawing.Point(103, 264);
            this.findWordsButton.Name = "findWordsButton";
            this.findWordsButton.Size = new System.Drawing.Size(75, 23);
            this.findWordsButton.TabIndex = 1;
            this.findWordsButton.Text = "Find Words";
            this.findWordsButton.UseVisualStyleBackColor = true;
            this.findWordsButton.Click += new System.EventHandler(this.findWordsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(198, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 333);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findWordsButton);
            this.Controls.Add(this.wordsListBox);
            this.Name = "Form1";
            this.Text = "Activity 12 \"Contains \'t\' or \'e\'\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.Button findWordsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

