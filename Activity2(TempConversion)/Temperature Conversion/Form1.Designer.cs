namespace Temperature_Conversion
{
    partial class TemptConvers
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.farenheitLabel = new System.Windows.Forms.Label();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.conversionLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.convertToCButton = new System.Windows.Forms.Button();
            this.convertToFButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.farenheitTextBox = new System.Windows.Forms.TextBox();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(105, 52);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(324, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter a temperature into the Farenheit OR Celsius field to convert it:";
            // 
            // farenheitLabel
            // 
            this.farenheitLabel.AutoSize = true;
            this.farenheitLabel.Location = new System.Drawing.Point(74, 107);
            this.farenheitLabel.Name = "farenheitLabel";
            this.farenheitLabel.Size = new System.Drawing.Size(54, 13);
            this.farenheitLabel.TabIndex = 1;
            this.farenheitLabel.Text = "Farenheit:";
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Location = new System.Drawing.Point(85, 158);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(43, 13);
            this.celsiusLabel.TabIndex = 2;
            this.celsiusLabel.Text = "Celsius:";
            // 
            // conversionLabel
            // 
            this.conversionLabel.AutoSize = true;
            this.conversionLabel.Location = new System.Drawing.Point(6, 202);
            this.conversionLabel.Name = "conversionLabel";
            this.conversionLabel.Size = new System.Drawing.Size(122, 13);
            this.conversionLabel.TabIndex = 3;
            this.conversionLabel.Text = "Converted Temperature:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(150, 202);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(265, 23);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertToCButton
            // 
            this.convertToCButton.Location = new System.Drawing.Point(150, 265);
            this.convertToCButton.Name = "convertToCButton";
            this.convertToCButton.Size = new System.Drawing.Size(75, 37);
            this.convertToCButton.TabIndex = 5;
            this.convertToCButton.Text = "Convert to Celsius";
            this.convertToCButton.UseVisualStyleBackColor = true;
            this.convertToCButton.Click += new System.EventHandler(this.convertToCButton_Click);
            // 
            // convertToFButton
            // 
            this.convertToFButton.Location = new System.Drawing.Point(248, 265);
            this.convertToFButton.Name = "convertToFButton";
            this.convertToFButton.Size = new System.Drawing.Size(75, 37);
            this.convertToFButton.TabIndex = 6;
            this.convertToFButton.Text = "Convert to Farenheit";
            this.convertToFButton.UseVisualStyleBackColor = true;
            this.convertToFButton.Click += new System.EventHandler(this.convertToFButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(340, 265);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // farenheitTextBox
            // 
            this.farenheitTextBox.Location = new System.Drawing.Point(150, 99);
            this.farenheitTextBox.Name = "farenheitTextBox";
            this.farenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.farenheitTextBox.TabIndex = 8;
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Location = new System.Drawing.Point(150, 151);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.celsiusTextBox.TabIndex = 0;
            // 
            // TemptConvers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 436);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.farenheitTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertToFButton);
            this.Controls.Add(this.convertToCButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.conversionLabel);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.farenheitLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "TemptConvers";
            this.Text = "Tempature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label farenheitLabel;
        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.Label conversionLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button convertToCButton;
        private System.Windows.Forms.Button convertToFButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox farenheitTextBox;
        private System.Windows.Forms.TextBox celsiusTextBox;
    }
}

