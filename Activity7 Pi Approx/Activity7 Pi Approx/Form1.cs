using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7_Pi_Approx
{
    public partial class approxPi : Form
    {
        public approxPi()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int terms;
            double pi = 4;

            if (int.TryParse(numTermsTextBox.Text, out terms))
            { 
                for (int i = 0; i < terms; i ++)
                {
                    double den = i * 2 + 3;

                    if (i % 2 == 0)
                    {
                        pi -= (4 / den);
                    }
                    else
                    {
                        pi += (4 / den);
                    }
                }

                approximateDescripLabel.Text = "Approximate value of pi after " + terms + " terms";
                ResultsLabel.Text = "= " + pi ;
            }

            else
            {
                //output error message
                MessageBox.Show("Please enter a numerical value");
            }
        }
    }
}
