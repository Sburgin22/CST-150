using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//program that takes the month, day, and year you were born and generates in a second form your lucky number
//uses selected indexes from combo boxes to do so
//the total of the combo box indexes is your lucky number


//*ERRORS*
//user must first select year, then month, then day
//if year not chosen first error occurs

namespace Activity15
{
    public partial class LuckyNumberForm : Form
    {
        //variables for our various methods to check day, year and lucky number
        static int Lucky;
        private int dNum;
        private int year;

        ResultsForm r;

        public LuckyNumberForm()
        {
            InitializeComponent();
        }

        //checks if year is leap year or not by seeing if given year
        //is evenly divisible by 4
        //if so, it is deemed a leap year and february gains 29 days
        public bool IsLeapYear(int year)
        {
            //flag for leap year
            bool leapYear = false;

            //turns selected year into integer
            int selectedYear = int.Parse(YearComboBox.SelectedItem.ToString());

            if(selectedYear % 4 == 0)
            {
                leapYear = true;
            }

            else
            {
                leapYear = false;
            }    

            return leapYear;
        }

        //designates a specific amount of days based on the index chosen in the
        //month and year combo boxes. index 1 is February.
        //as such it then checks if the year is a leap year before displaying 28 or 29 days
        //most other months, based on their index, such as January, will display 31 days.
        //every thing else displays with only 30 days
        public void DAY_NUM()
        {
            //dNum designates our day count
            if(MonthComboBox.SelectedIndex == 1)
            {
                if(IsLeapYear(year) == true)
                {
                    dNum = 29;
                }
                else if(IsLeapYear(year) == false)
                {
                    dNum = 28;
                }
            }

            //if selected index is one of these numbers
            //aka january, August, etc there will be 31 days displayed in the day combo box
            else if(MonthComboBox.SelectedIndex == 0 || MonthComboBox.SelectedIndex == 2 || MonthComboBox.SelectedIndex == 4
                || MonthComboBox.SelectedIndex == 6 || MonthComboBox.SelectedIndex == 7 || MonthComboBox.SelectedIndex == 9 ||
                MonthComboBox.SelectedIndex == 11)
            {
                dNum = 31;
            }

            //otherwise display 30 days
            else
            {
                dNum = 30;
            }

            //so long as month combo box has a selected value
            //display the number of days based on month
            if(MonthComboBox.SelectedIndex != -1)
            {
                DayComboBox.Items.Clear();
                for(int day = 0; day < dNum; day++)
                {
                    DayComboBox.Items.Add(day + 1);
                }
            }

            //displays the days to the day combo box
            DayComboBox.Text = dNum.ToString();
        }

        //returns our lucky number
        public int LuckyNum()
        {
            return Lucky;
        }

        //finds lucky number and opens up the second form to display the result
        private void button1_Click(object sender, EventArgs e)
        {
            if(YearComboBox.SelectedIndex != -1 && DayComboBox.SelectedIndex != -1 && MonthComboBox.SelectedIndex != -1)
            {
                Lucky = (MonthComboBox.SelectedIndex + DayComboBox.SelectedIndex + YearComboBox.SelectedIndex);
                r = new ResultsForm();
                r.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please fill in the month, day, and year boxes.");
            }
        }

        //changes number of days in month based off of year and month
        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAY_NUM();
        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            DAY_NUM();
        }

        //resets the combo box values
        private void clearButton_Click(object sender, EventArgs e)
        {
            YearComboBox.Text = "";
            DayComboBox.Text = "";
            MonthComboBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
