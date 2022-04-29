using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //displays array to listbox
        public void DisplayArray(double[] total)
        {
            foreach(double t in total)
            {
                totalListBox.Items.Add(t);
            }
        }

        public double SaleTotal(double[] total)
        {
            double sum = 0;

            for(int index = 0; index < total.Length; index++)
            {
                sum += total[index];
            }

            return sum;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //creates our total array
                double[] total = new double[7];

                //counter variable
                int count = 0;

                double sum;

                //create streamReader
                //gets info from file
                StreamReader inputFile = File.OpenText("Sales.txt");

                //copies contents of file to array
                while (!inputFile.EndOfStream && count < total.Length)
                {
                    total[count] = double.Parse(inputFile.ReadLine());
                    count++;
                }

                //closes file
                inputFile.Close();

                //displays array contents to list
                DisplayArray(total);
                totalListBox.Items.Add("");

                //gets total value of array
                sum = SaleTotal(total);

                //display results to listbox
                totalListBox.Items.Add("The total sales is: " + sum.ToString("n2"));
            }
            //displays error message if file not chosen
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
