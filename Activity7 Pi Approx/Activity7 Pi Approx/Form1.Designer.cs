namespace Activity7_Pi_Approx
{
    partial class approxPi
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.numTermsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.approximateDescripLabel = new System.Windows.Forms.Label();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(80, 80);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(85, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Enter # of terms:";
            // 
            // numTermsTextBox
            // 
            this.numTermsTextBox.Location = new System.Drawing.Point(182, 77);
            this.numTermsTextBox.Name = "numTermsTextBox";
            this.numTermsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numTermsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(83, 159);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // approximateDescripLabel
            // 
            this.approximateDescripLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.approximateDescripLabel.Location = new System.Drawing.Point(83, 238);
            this.approximateDescripLabel.Name = "approximateDescripLabel";
            this.approximateDescripLabel.Size = new System.Drawing.Size(316, 23);
            this.approximateDescripLabel.TabIndex = 3;
            this.approximateDescripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsLabel.Location = new System.Drawing.Point(83, 306);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(316, 23);
            this.ResultsLabel.TabIndex = 4;
            this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // approxPi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 384);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.approximateDescripLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numTermsTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "approxPi";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox numTermsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label approximateDescripLabel;
        private System.Windows.Forms.Label ResultsLabel;
    }
}

