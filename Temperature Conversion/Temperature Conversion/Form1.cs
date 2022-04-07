using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Conversion
{
    public partial class TemptConvers : Form
    {
        public TemptConvers()
        {
            InitializeComponent();
        }

        private void convertToCButton_Click(object sender, EventArgs e)
        {
            try
            {
                var far = double.Parse(farenheitTextBox.Text);
                var cel = celsiusTextBox.Text = "";
                double total = (far - 32) * 5 / 9;
                outputLabel.Text = (far + " degrees Farenheit is " + total.ToString("n3") + " degrees Celsus");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid value for 'Farenheit'", ex.Message);
            }
        }

        private void convertToFButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cel = double.Parse(celsiusTextBox.Text);
                var far = farenheitTextBox.Text = "";
                double total = (cel * 9 / 5) + 32;
                outputLabel.Text = (cel + " degrees Celsius is " + total.ToString("n3") + " degrees Farenheit");
            }
            catch
            {
                MessageBox.Show("Please enter a valid value for 'Celsius'");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes application
            this.Close();
        }
    }
}
