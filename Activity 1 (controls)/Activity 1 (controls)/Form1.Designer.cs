namespace Activity_1__controls_
{
    partial class activity1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activity1));
            this.messageButton = new System.Windows.Forms.Button();
            this.testText = new System.Windows.Forms.TextBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonLabel = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.checklistLabel = new System.Windows.Forms.Label();
            this.dogPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(30, 111);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(75, 37);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "Click Me";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // testText
            // 
            this.testText.Location = new System.Drawing.Point(210, 55);
            this.testText.Name = "testText";
            this.testText.Size = new System.Drawing.Size(100, 20);
            this.testText.TabIndex = 1;
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "download Visual Studio",
            "create form",
            "add controls"});
            this.checkedListBox.Location = new System.Drawing.Point(190, 218);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(30, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "This is a Label";
            // 
            // buttonLabel
            // 
            this.buttonLabel.AutoSize = true;
            this.buttonLabel.Location = new System.Drawing.Point(30, 95);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(79, 13);
            this.buttonLabel.TabIndex = 4;
            this.buttonLabel.Text = "This is a button";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(207, 39);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(83, 13);
            this.textBoxLabel.TabIndex = 5;
            this.textBoxLabel.Text = "This is a textbox";
            // 
            // checklistLabel
            // 
            this.checklistLabel.AutoSize = true;
            this.checklistLabel.Location = new System.Drawing.Point(210, 199);
            this.checklistLabel.Name = "checklistLabel";
            this.checklistLabel.Size = new System.Drawing.Size(91, 13);
            this.checklistLabel.TabIndex = 6;
            this.checklistLabel.Text = "This is a checklist";
            // 
            // dogPictureBox
            // 
            this.dogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox.Image")));
            this.dogPictureBox.Location = new System.Drawing.Point(433, 111);
            this.dogPictureBox.Name = "dogPictureBox";
            this.dogPictureBox.Size = new System.Drawing.Size(168, 156);
            this.dogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPictureBox.TabIndex = 7;
            this.dogPictureBox.TabStop = false;
            this.dogPictureBox.Click += new System.EventHandler(this.dogPictureBox_Click);
            // 
            // pictureBoxLabel
            // 
            this.pictureBoxLabel.AutoSize = true;
            this.pictureBoxLabel.Location = new System.Drawing.Point(479, 84);
            this.pictureBoxLabel.Name = "pictureBoxLabel";
            this.pictureBoxLabel.Size = new System.Drawing.Size(86, 13);
            this.pictureBoxLabel.TabIndex = 8;
            this.pictureBoxLabel.Text = "Click on the Dog";
            // 
            // activity1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxLabel);
            this.Controls.Add(this.dogPictureBox);
            this.Controls.Add(this.checklistLabel);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.buttonLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.testText);
            this.Controls.Add(this.messageButton);
            this.Name = "activity1";
            this.Text = "Activity 1 Controls";
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.TextBox testText;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.Label checklistLabel;
        private System.Windows.Forms.PictureBox dogPictureBox;
        private System.Windows.Forms.Label pictureBoxLabel;
    }
}

