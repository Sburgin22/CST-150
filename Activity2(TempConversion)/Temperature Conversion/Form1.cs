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
            //uses try / catch incase improper data is entered
            try
            {
                var far = double.Parse(farenheitTextBox.Text);//creates farenheit variable as a double
                var cel = celsiusTextBox.Text = ""; //makes the celsius textbox blank
                double total = (far - 32) * 5 / 9; //formula to convert farenheit to celsius
                outputLabel.Text = (far + " degrees Farenheit is " + total.ToString("n1") + " degrees Celsus"); //displays message with results of conversion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid value for 'Farenheit'", ex.Message); // error message if a number is not entered
            }
        }

        private void convertToFButton_Click(object sender, EventArgs e)
        {
            //uses try / catch incase of invalid input
            try
            {
                var cel = double.Parse(celsiusTextBox.Text); // creates celsius variable as a double
                var far = farenheitTextBox.Text = ""; //makes farenheit textbox blank
                double total = (cel * 9 / 5) + 32; //formula to convert celsius to farenheit
                outputLabel.Text = (cel + " degrees Celsius is " + total.ToString("n1") + " degrees Farenheit"); //outputs message with results of conversion
            }
            catch
            {
                MessageBox.Show("Please enter a valid value for 'Celsius'"); //error message if a number is not entered
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes application
            this.Close();
        }
    }
}
