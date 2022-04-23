using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Dice
        {
           // private field for num of sides
            private int sides;
            
            //constructor that randomly generates sides for the dice
            public int DieSides()
            {
                Random s = new Random();
                sides = s.Next(4,21);
                return sides;
            }

            //roll method
            public int Roll()
            {
                int rollDice;
                Random r = new Random();
                rollDice = r.Next(1, sides + 1);
                return rollDice;
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //counter variable
            int counter = 0;

            //creates our dice
            Dice die1 = new Dice();
            Dice die2 = new Dice();

            //gets dice sides
            die1.DieSides();
            die2.DieSides();

            //continuoutsly rolls dice until both die1 and die2 produce ones or snake eyes
            //adds to counter every time snake eyes not produced
            do
            {
                //displays roll results to text box
                die1TextBox.Text = die1.Roll().ToString();
                die2TextBox.Text = die2.Roll().ToString();
                counter++;
            }
            while(die1.Roll() != 1 && die2.Roll() != 1);

            //Message saying how many tries it took to get snake eyes
            MessageBox.Show("it took " + counter + " tries to get snake eyes.");
        }
    }
}
