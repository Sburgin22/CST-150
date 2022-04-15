using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falling_Distance
{
    public partial class Form1 : Form
    {
        //variables
        double d; //distance
        const double g = 9.8; //gravity
        int t; //time


        //calculates the falling distance given t
        private double FallingDistance(int t)
        {
            d = 0.5 * g * Math.Pow(t, 2);//pow gets t to the power of 2
            return d;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateDistanceButton_Click(object sender, EventArgs e)
        {
            //gets user input
            //if can be converted to int it does so
            //else returns an error message
            if(int.TryParse(timeTextBox.Text, out t))
            {
                //use fallingDistance to find distance fallen
                d = FallingDistance(t);

                //display results
                distanceLabel.Text = d.ToString("n0") + " meters";//n0 displays comma befor thousands place
            }
            else
            {
                //display error message
                MessageBox.Show("Please enter an integer value.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();
        }
    }
}
