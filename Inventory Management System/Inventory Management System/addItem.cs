using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class addItemsWindow : Form
    {
        public addItemsWindow()
        {
            InitializeComponent();
        }

        int num = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
