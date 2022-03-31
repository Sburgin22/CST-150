using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4__Time_Converter_
{
    public partial class TimeConverter : Form
    {
        public TimeConverter()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //initialize variables
            int userInput; //gathers users input
            int seconds; //will be the seconds displayed in output
            int minutes; //will be the minutes displayed in output
            int hours; //will be the hours displayed in output
            int days; //will be the days displayed in output

            //clears output data when calculate button is pressed
            secondsOutputLabel.Text = "";
            minutesOutputLabel.Text = "";
            hoursOutputLabel.Text = "";
            daysOutputLabel.Text = "";

            if(int.TryParse(userInputTextBox.Text, out userInput)) //checks if user input can be turned into integer
            {
                if(userInput >= 60 && userInput < 3600) // checks if total seconds is greater than 60 and less than 3600 do the following calculations
                {
                    minutes = userInput / 60; //gets total minutes
                    seconds = userInput % 60; //gets remaining seconds
                    
                    minutesOutputLabel.Text = minutes.ToString(); //displays total minutes in label
                    secondsOutputLabel.Text = seconds.ToString(); //displays total seconds in label
                }

                else if(userInput >= 3600 && userInput < 86400) //if greater than 3600 but less than 86400 does the following calculations
                {
                    hours = userInput / 3600; //gets total hours
                    minutes = (userInput - (hours * 3600)) / 60; //gets total minutes
                    seconds = (userInput - (minutes * 60)) % 3600; //gets remaining seconds

                    hoursOutputLabel.Text = hours.ToString(); //displays total hours in label
                    minutesOutputLabel.Text = minutes.ToString(); //displays total minutes in label
                    secondsOutputLabel.Text = seconds.ToString(); //displays total seconds in label
                }

                else if(userInput >= 86400)
                {
                    days = userInput / 86400; //gets total days
                    hours = (userInput - (days * 86400)) / 3600; //gets total hours
                    minutes = (userInput - (days * 86400) - (hours * 3600)) / 60; //gets total minutes
                    seconds = (userInput - (minutes * 60)) % 3600; //gets remaining seconds
                    
                    daysOutputLabel.Text = days.ToString(); //displays total days in label 
                    hoursOutputLabel.Text = hours.ToString(); //displays total hours in label
                    minutesOutputLabel.Text = minutes.ToString(); //displays total minutes in label
                    secondsOutputLabel.Text = seconds.ToString(); //displays total seconds in label
                }

                else // if less than 60...
                {
                    secondsOutputLabel.Text = userInput.ToString(); //displays total seconds
                }
            }

            else //displays error message if wrong data format is entered
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears data
            userInputTextBox.Text = "";
            secondsOutputLabel.Text = "";
            minutesOutputLabel.Text = "";
            hoursOutputLabel.Text = "";
            daysOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
