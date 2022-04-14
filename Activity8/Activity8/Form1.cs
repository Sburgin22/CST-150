using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8
{
    public partial class activity8 : Form
    {
        public activity8()
        {
            InitializeComponent();
        }

        //variables for fat and carb grams
        int fat;
        int carb;

        //returns the result of fat grams * 9
        public double CalFromFat(double fatCals)
        {
            return fat * 9;
        }

        //returns the result of carb grams * 4
        public double CalFromCarb(double carbCals)
        {
            return carb * 4;
        }

        //calculates calories from fat grams when button pressed
        private void fatCalButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(fatTextBox.Text, out fat))
            {
                //calculate calories from fat
                CalFromFat(fat);

                //display result
                fatCalorieLabel.Text = CalFromFat(fat).ToString();
            }
            else
            {
                //display error message
                MessageBox.Show("Enter an integer value.");
            }
        }

        //calculates calories from carb grams when button pressed
        private void carbCalButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(carbTextBox.Text, out carb))
            {
                //calculate calories from carbs
                CalFromCarb(carb);

                //display result
                carbCalorieLabel.Text = CalFromCarb(carb).ToString();
            }
            else
            {
                //display error message
                MessageBox.Show("Enter an integer value.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
