namespace Activity_4__Time_Converter_
{
    partial class TimeConverter
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.secondsOutputLabel = new System.Windows.Forms.Label();
            this.minutesOutputLabel = new System.Windows.Forms.Label();
            this.daysOutputLabel = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(95, 102);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(121, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter # of Seconds:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(164, 155);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(52, 13);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "Seconds:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(169, 215);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(47, 13);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "Minutes:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(182, 318);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(34, 13);
            this.daysLabel.TabIndex = 3;
            this.daysLabel.Text = "Days:";
            // 
            // secondsOutputLabel
            // 
            this.secondsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondsOutputLabel.Location = new System.Drawing.Point(225, 150);
            this.secondsOutputLabel.Name = "secondsOutputLabel";
            this.secondsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.secondsOutputLabel.TabIndex = 4;
            this.secondsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesOutputLabel
            // 
            this.minutesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutesOutputLabel.Location = new System.Drawing.Point(225, 210);
            this.minutesOutputLabel.Name = "minutesOutputLabel";
            this.minutesOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.minutesOutputLabel.TabIndex = 5;
            this.minutesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysOutputLabel
            // 
            this.daysOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysOutputLabel.Location = new System.Drawing.Point(225, 318);
            this.daysOutputLabel.Name = "daysOutputLabel";
            this.daysOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.daysOutputLabel.TabIndex = 6;
            this.daysOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(225, 99);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.userInputTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(128, 391);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(225, 391);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(319, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(22, 57);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(520, 16);
            this.instructionLabel.TabIndex = 11;
            this.instructionLabel.Text = "Enter a number and I will convert it to seconds, minutes, hours, and/or days";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(178, 263);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 12;
            this.hoursLabel.Text = "Hours:";
            // 
            // hoursOutputLabel
            // 
            this.hoursOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOutputLabel.Location = new System.Drawing.Point(225, 263);
            this.hoursOutputLabel.Name = "hoursOutputLabel";
            this.hoursOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.hoursOutputLabel.TabIndex = 13;
            this.hoursOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 472);
            this.Controls.Add(this.hoursOutputLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.daysOutputLabel);
            this.Controls.Add(this.minutesOutputLabel);
            this.Controls.Add(this.secondsOutputLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.promptLabel);
            this.Name = "TimeConverter";
            this.Text = "Time Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label secondsOutputLabel;
        private System.Windows.Forms.Label minutesOutputLabel;
        private System.Windows.Forms.Label daysOutputLabel;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label hoursOutputLabel;
    }
}

