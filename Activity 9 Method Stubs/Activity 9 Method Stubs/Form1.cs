using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_9_Method_Stubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Begining of Method Stubs
        //
        //
        //

        //adds two numbers together and displays sum
        public int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        //adds 5 doubles and returns the average
        public double AverageFiveDoubles(double num1, double num2, double num3, double num4, double num5)
        {
            double average = (num1 + num2 + num3 + num4 + num5) / 5;
            return average;
        }

        //adds two random integers and displays sum
        public int SumRandomNums(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        //tests if three numbs added together are divisible by three
        public bool DivBy3(int num1, int num2, int num3)
        {
            int sum = (num1 + num2 + num3);

            if(sum % 3 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //compares two strings and displays shortest
        public string ShortestString(string word1, string word2)
        {
            //creates a list containing our two strings
            List<string> list = new List<string>()
            {
                word1,
                word2
            };

            //creates variable for minimum length
            int min = 9999;

            //creates string to output shortest word
            string shortest = "";

            //uses for loop to determine shortest string
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].Length < min)
                {
                    //if current string is smaller than min
                    //string length becomes new min length
                    min = list[i].Length;
                    shortest = list[i];
                }
            }
            return shortest;
        }

        //compares doubles in an array and returns the result
        public double LargestDouble(double[] doubles)
        { 
            //largest set to 0
            double largest = 0;

            //checks for largest double by going through array
            for(int i = 0; i < doubles.Length; i++)
            {
                if(doubles[i] > largest)
                {
                    largest = doubles[i];
                }
            }

            return largest;

        }

        //generates an array of 50 integers randomly
        public int[] GetNumArray()
        {
            //creates new Array of integers
            int[] nums = new int[50];


            //Random number generator initialized
            Random random = new Random();

            //adds integers to the array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(51); //generates numbers between 0-50
            }
            
            //returns array
            return nums;
        }

        //compares boolean values
        public bool IsSame(ref int input1, ref int input2)
        {
            //flag variable to show if input is the same
            bool same = false;

            //compare two integer variables
            if(int.TryParse(number1TextBox.Text, out input1))
                {
                if(int.TryParse(number2TextBox.Text, out input2))
                {
                    if(input1 == input2)
                    {
                        same = true;
                    }
                    else
                    {
                        same = false;
                    }
                }
                else
                {
                    //error message
                    MessageBox.Show("Please enter valid integer value.");
                }
            }
            else
            {
                //error message
                MessageBox.Show("Please enter integer value.");
            }

            return same;
        }

        //multiplies a double and int together and returns the result
        public double Multiply(int num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        //adds values of 2 dimmensional array and finds the average
        public int FindAverageOfArray(int[,] numArray)
        {
            //creates variables for for loop to get sum and average values
            int avgCount = 0;
            int sum = 0;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    sum += numArray[i,j];
                    avgCount++;
                }
            }

            return sum / avgCount;

        }



        //BEGINING OF BUTTON METHODS
        //
        //
        //

        //sum 2 integers button
        private void calcuateSumButton_Click(object sender, EventArgs e)
        {
            //creates variables for our two numbers
            int num1, num2;

            //checks to see if input is valid for each textbox
            //converts to int if it is
            //displays error message if not
            if(int.TryParse(num1TextBox.Text, out num1))
            {
                if(int.TryParse(num2TextBox.Text, out num2))
                {
                    //calls Sum() method
                    sumLabel.Text = Sum(num1, num2).ToString();
                }
                else
                {
                    //display error message for num2
                    MessageBox.Show("Please enter a valid second number.");
                }
            }
            else
            {
                //display error message for num1
                MessageBox.Show("Please enter a valid first number");
            }
        }

        //calculate average button
        private void calculateAverageButton_Click(object sender, EventArgs e)
        {
            //creates variables for our numbers
            double num1, num2, num3, num4, num5;

            //checks if input is valid for each text box
            //converts to double if is
            //displays error message if not
            if(double.TryParse(double1TextBox.Text, out num1))
            {
                if(double.TryParse(double2TextBox.Text, out num2))
                {
                    if(double.TryParse(double3TextBox.Text, out num3))
                    {
                        if(double.TryParse(double4TextBox.Text,out num4))
                        {
                            if(double.TryParse(double5TextBox.Text, out num5))
                            {
                                averageLabel.Text = AverageFiveDoubles(num1,num2,num3,num4,num5).ToString();
                            }
                            else
                            {
                                //error message
                                MessageBox.Show("Enter valid input for fifth double");
                            }
                        }
                        else
                        {
                            //error message
                            MessageBox.Show("Enter valid input for fourth double");
                        }
                    }
                    else
                    {
                        //error message
                        MessageBox.Show("Enter valid input for third double");
                    }
                }
                else
                {
                    //error message
                    MessageBox.Show("Enter valid input for second double.");
                }
            }
            else
            {
                //display error message
                MessageBox.Show("Enter valid input for first double.");
            }
        }

        //sum two rand nums button
        private void sumRandomButton_Click(object sender, EventArgs e)
        {
            //creates random numbers for our first and second num between 0 and 100
            Random random = new Random();
            int num1 = random.Next(101); //first num
            int num2 = random.Next(101); //second num

            //displays randomly generated numbers to their labels
            randNum1Label.Text = num1.ToString();
            randNum2Label.Text = num2.ToString();   

            //calls SumRandomNums and displays results
            randSumLabel.Text = SumRandomNums(num1, num2).ToString();
        }

       //divis by 3 button
        private void divisibleButton_Click(object sender, EventArgs e)
        {
            //make variables for our 3 nums
            int num1, num2, num3;

            //string for our output
            string result;
            
            //checks if input is correct
            //displays error message if not
            if(int.TryParse(firstNumTextBox.Text, out num1))
            {
                if(int.TryParse(secNumTextBox.Text, out num2))
                {
                    if (int.TryParse(thirdNumTextBox.Text, out num3))
                    {
                        //returns false or true
                        result = DivBy3(num1,num2,num3).ToString();

                        //outputs result to label
                        divisLabel.Text = result;
                    }
                    else
                    {
                        //error message
                        MessageBox.Show("Please enter a valid integer for number 3");
                    }
                }
                else
                {
                    //error message
                    MessageBox.Show("Please enter a valid integer for number 2");
                }
            }
            else
            {
                //error message
                MessageBox.Show("Please enter a valid integer for number 1");
            }
        }

        //shortest string button
        private void shortestButton_Click(object sender, EventArgs e)
        {
            //gets values from textboxes
            string word1 = word1TextBox.Text;
            string word2 = word2TextBox.Text;

            //compares strings and displays results in label
            shortestLabel.Text = ShortestString(word1, word2).ToString();
        }

        //Find Largest Double button
        private void largestDoubleButton_Click(object sender, EventArgs e)
        {
            //creates an array of 10 doubles
            double[] doubles = new double[10];

            //creates new random generator
            Random rand = new Random();

            //adds doubles to list
            for (int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = rand.NextDouble();
            }

            //displays array in list box
            for(int i = 0; i < doubles.Length; i++)
            {
                doubleListBox.Items.Add(doubles[i].ToString("n3")); //displays only 3 decimal places
            }

            //calls LargestDouble and displays result to label with only 3 decimal places
            largestDoubleLabel.Text = LargestDouble(doubles).ToString("n3");

        }

        //displays array in list box when clicked
        private void genIntButton_Click(object sender, EventArgs e)
        {
            int[] num = GetNumArray();//creates a new array that gets data from our GetNumArray method

            
            //goes through length of num array and adds the elements to our list box
            for(int i = 0; i < num.Length; i++)
            {
                arrayListBox.Items.Add(num[i].ToString());
            }
        }

        //compare bools button
        private void compareButton_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(number1TextBox.Text);
            int input2 = int.Parse(number2TextBox.Text);

            sameLabel.Text = IsSame(ref input1, ref input2).ToString();
        }

        //multiply int and doub button
        private void calculateIntDoubButton_Click(object sender, EventArgs e)
        {
            //parses input and initializes num variables
            int num1 = int.Parse(integerTextBox.Text);
            double num2 = double.Parse(doubleTextBox.Text);

            //calls multiply method
            //displays result in label
            resultLabel.Text = Multiply(num1, num2).ToString();
        }

        private void calculateTwoDAverageButton_Click(object sender, EventArgs e)
        {
            //creates 2d number array
            int[,] numArray = new int[5, 2]
            {
                { 9, 17 },
                { 1, 2 },
                { 20, 36 },
                { 3, 9 },
                { 4, 50 },
            };

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    twoDListBox.Items.Add(numArray[i,j].ToString());
                }
            }

            //calls function and displays result
            twoDAveragelabel.Text = FindAverageOfArray(numArray).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
        }
    }
}
