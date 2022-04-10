namespace Activity5
{
    partial class wordSorter
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
            this.components = new System.ComponentModel.Container();
            this.openFileButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.lowerCaseListLabel = new System.Windows.Forms.Label();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.firstWordLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lastWordLabel = new System.Windows.Forms.Label();
            this.longestWordLabel = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.firstWordTextBox = new System.Windows.Forms.TextBox();
            this.lastWordTextBox = new System.Windows.Forms.TextBox();
            this.longestTextBox = new System.Windows.Forms.TextBox();
            this.vowelsTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(39, 281);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 40);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open Text File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(334, 281);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lowerCaseListLabel
            // 
            this.lowerCaseListLabel.AutoSize = true;
            this.lowerCaseListLabel.Location = new System.Drawing.Point(12, 50);
            this.lowerCaseListLabel.Name = "lowerCaseListLabel";
            this.lowerCaseListLabel.Size = new System.Drawing.Size(131, 13);
            this.lowerCaseListLabel.TabIndex = 2;
            this.lowerCaseListLabel.Text = "List of words in lowercase:";
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.Location = new System.Drawing.Point(12, 66);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(155, 173);
            this.wordListBox.TabIndex = 3;
            // 
            // firstWordLabel
            // 
            this.firstWordLabel.AutoSize = true;
            this.firstWordLabel.Location = new System.Drawing.Point(190, 50);
            this.firstWordLabel.Name = "firstWordLabel";
            this.firstWordLabel.Size = new System.Drawing.Size(122, 13);
            this.firstWordLabel.TabIndex = 4;
            this.firstWordLabel.Text = "First word alphabetically:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lastWordLabel
            // 
            this.lastWordLabel.AutoSize = true;
            this.lastWordLabel.Location = new System.Drawing.Point(189, 203);
            this.lastWordLabel.Name = "lastWordLabel";
            this.lastWordLabel.Size = new System.Drawing.Size(123, 13);
            this.lastWordLabel.TabIndex = 5;
            this.lastWordLabel.Text = "Last word alphabetically:";
            // 
            // longestWordLabel
            // 
            this.longestWordLabel.AutoSize = true;
            this.longestWordLabel.Location = new System.Drawing.Point(331, 50);
            this.longestWordLabel.Name = "longestWordLabel";
            this.longestWordLabel.Size = new System.Drawing.Size(74, 13);
            this.longestWordLabel.TabIndex = 6;
            this.longestWordLabel.Text = "Longest word:";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.AutoSize = true;
            this.mostVowelsLabel.Location = new System.Drawing.Point(322, 203);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(119, 13);
            this.mostVowelsLabel.TabIndex = 7;
            this.mostVowelsLabel.Text = "Word with most vowels:";
            // 
            // firstWordTextBox
            // 
            this.firstWordTextBox.Location = new System.Drawing.Point(193, 66);
            this.firstWordTextBox.Name = "firstWordTextBox";
            this.firstWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstWordTextBox.TabIndex = 8;
            // 
            // lastWordTextBox
            // 
            this.lastWordTextBox.Location = new System.Drawing.Point(193, 219);
            this.lastWordTextBox.Name = "lastWordTextBox";
            this.lastWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastWordTextBox.TabIndex = 9;
            // 
            // longestTextBox
            // 
            this.longestTextBox.Location = new System.Drawing.Point(325, 66);
            this.longestTextBox.Name = "longestTextBox";
            this.longestTextBox.Size = new System.Drawing.Size(100, 20);
            this.longestTextBox.TabIndex = 10;
            // 
            // vowelsTextBox
            // 
            this.vowelsTextBox.Location = new System.Drawing.Point(334, 219);
            this.vowelsTextBox.Name = "vowelsTextBox";
            this.vowelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.vowelsTextBox.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(183, 281);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 40);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save to New File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // wordSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 355);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vowelsTextBox);
            this.Controls.Add(this.longestTextBox);
            this.Controls.Add(this.lastWordTextBox);
            this.Controls.Add(this.firstWordTextBox);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.longestWordLabel);
            this.Controls.Add(this.lastWordLabel);
            this.Controls.Add(this.firstWordLabel);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.lowerCaseListLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openFileButton);
            this.Name = "wordSorter";
            this.Text = "Activity 5 Word Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label lowerCaseListLabel;
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.Label firstWordLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lastWordLabel;
        private System.Windows.Forms.Label longestWordLabel;
        private System.Windows.Forms.Label mostVowelsLabel;
        private System.Windows.Forms.TextBox firstWordTextBox;
        private System.Windows.Forms.TextBox lastWordTextBox;
        private System.Windows.Forms.TextBox longestTextBox;
        private System.Windows.Forms.TextBox vowelsTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

