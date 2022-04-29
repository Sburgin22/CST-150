namespace Activity14
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
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.memberRadio = new System.Windows.Forms.CheckBox();
            this.giftCardRadio = new System.Windows.Forms.CheckBox();
            this.booklightRadio = new System.Windows.Forms.CheckBox();
            this.bookmarkRadio = new System.Windows.Forms.CheckBox();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.Items.AddRange(new object[] {
            "Great Gatsby",
            "Count of Monte Cristo",
            "The Black Tulip",
            "1984",
            "Nostromo",
            "The Portrait of Dorian Gray"});
            this.bookListBox.Location = new System.Drawing.Point(6, 21);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(151, 108);
            this.bookListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookListBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noRadioButton);
            this.groupBox2.Controls.Add(this.yesRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(195, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Are You a Member?";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(18, 97);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(18, 39);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.memberRadio);
            this.groupBox3.Controls.Add(this.giftCardRadio);
            this.groupBox3.Controls.Add(this.booklightRadio);
            this.groupBox3.Controls.Add(this.bookmarkRadio);
            this.groupBox3.Location = new System.Drawing.Point(325, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras";
            // 
            // memberRadio
            // 
            this.memberRadio.AutoSize = true;
            this.memberRadio.Location = new System.Drawing.Point(7, 86);
            this.memberRadio.Name = "memberRadio";
            this.memberRadio.Size = new System.Drawing.Size(110, 17);
            this.memberRadio.TabIndex = 3;
            this.memberRadio.Text = "Membership ($25)";
            this.memberRadio.UseVisualStyleBackColor = true;
            // 
            // giftCardRadio
            // 
            this.giftCardRadio.AutoSize = true;
            this.giftCardRadio.Location = new System.Drawing.Point(6, 62);
            this.giftCardRadio.Name = "giftCardRadio";
            this.giftCardRadio.Size = new System.Drawing.Size(88, 17);
            this.giftCardRadio.TabIndex = 2;
            this.giftCardRadio.Text = "$10 Gift Card";
            this.giftCardRadio.UseVisualStyleBackColor = true;
            // 
            // booklightRadio
            // 
            this.booklightRadio.AutoSize = true;
            this.booklightRadio.Location = new System.Drawing.Point(7, 39);
            this.booklightRadio.Name = "booklightRadio";
            this.booklightRadio.Size = new System.Drawing.Size(77, 17);
            this.booklightRadio.TabIndex = 1;
            this.booklightRadio.Text = "Book Light";
            this.booklightRadio.UseVisualStyleBackColor = true;
            // 
            // bookmarkRadio
            // 
            this.bookmarkRadio.AutoSize = true;
            this.bookmarkRadio.Location = new System.Drawing.Point(7, 20);
            this.bookmarkRadio.Name = "bookmarkRadio";
            this.bookmarkRadio.Size = new System.Drawing.Size(74, 17);
            this.bookmarkRadio.TabIndex = 0;
            this.bookmarkRadio.Text = "Bookmark";
            this.bookmarkRadio.UseVisualStyleBackColor = true;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(140, 230);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(75, 23);
            this.checkOutButton.TabIndex = 4;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(221, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 273);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Book Store";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox memberRadio;
        private System.Windows.Forms.CheckBox giftCardRadio;
        private System.Windows.Forms.CheckBox booklightRadio;
        private System.Windows.Forms.CheckBox bookmarkRadio;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button exitButton;
    }
}

