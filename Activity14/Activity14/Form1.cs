using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //checks membership status
        //if no or nothing selected membership returns false
        public bool Membership(bool memStatus)
        {
            //flag
            memStatus = false;

            if (yesRadioButton.Checked)
            {
                memStatus = true;
            }
            else
            {
                memStatus = false;
            }
            return memStatus;
        }

        //checks to see if extra items were added
        public double Extras(double price)
        {
            if(bookmarkRadio.Checked)
            {
                price += 2.00;
            }
            if(booklightRadio.Checked)
            {
                price += 5.00;
            }
            if(giftCardRadio.Checked)
            {
                price += 10.00;
            }
            if(memberRadio.Checked)
            {
                price += 25.00;
            }

            return price;
        }
        
        //when clicked calculates total
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            //variables for price and membership flag
            double price = 0;
            bool memStatus = false;

            //checks to see what books were chosen for our list
            //if no book chosen, user is prompted to select a book
            //once selected, book price is added to price
            switch (bookListBox.SelectedItem)
            {
                case ("Great Gatsby"):
                    price += 15.00;
                    break;
                case ("Count of Monte Cristo"):
                    price += 10.00;
                    break;
                case ("The Black Tulip"):
                    price += 12.00;
                    break;
                case ("1984"):
                    price += 10.00;
                    break;
                case ("Nostromo"):
                    price += 20.00;
                    break;
                case ("The Portrait of Dorian Gray"):
                    price += 18.00;
                    break;
                default:
                    MessageBox.Show("Please choose a book to purchase.");
                    break;
            }

            //checks for extra purchases
            //adds to total price based on what is selected
            price = Extras(price);


            //checks to see if membership status is clicked
            if(Membership(memStatus) == true)
            {
                //gets 10% discount of total price
                double discount = (price * .10);

                //if membership selected discount is applied
                price = price - discount;
            }

            //display message showing total price owed
            MessageBox.Show("Your total today is: " + price.ToString("c"));

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thank you for visiting");
            this.Close();
        }
    }
}
