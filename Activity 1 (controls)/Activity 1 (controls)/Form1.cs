using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1__controls_
{
    public partial class activity1 : Form
    {
        public activity1()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            //displays a message when button is clicked
            MessageBox.Show("Yeah you pressed a button!");
        }

        private void dogPictureBox_Click(object sender, EventArgs e)
        {
            //displays a message when picturebox is clicked
            MessageBox.Show("Woof!");
        }
    }
}
