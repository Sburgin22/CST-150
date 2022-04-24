using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Program1
        {
            static void Main(string[] args)
            {
                //make some sets

                //Set A = new Set();
                //Set B = new Set();
                //need to call on Set class to properly create the sets
                Activity10.Set A = new Activity10.Set();
                Activity10.Set B = new Activity10.Set();

                //put some stuff in the sets
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    A.addElement(r.Next(4));
                    B.addElement(r.Next(12));
                }

                //display each set and the union
                Console.WriteLine("A: " + A);
                Console.WriteLine("B: " + B);
                Console.WriteLine("A union B: " + A.union(B));

                //display original sets (should be unchanged)
                Console.WriteLine("After union operation");
                Console.WriteLine("A: " + A);
                Console.WriteLine("B: " + B);

            }
        }

        //attempt to use button event to display unions
        private void unionButton_Click(object sender, EventArgs e)
        {
            Set s = new Set();
            Program1 p = new Program1();
            p.ToString();

            //display union in listbox
            unionListBox.Items.Add(p);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
