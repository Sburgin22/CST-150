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
            InventoryItem item = new InventoryItem(); // creates new inventory item

            //sets item name and other values to our new created item and give it a number in our ims
            item.name = nameTextBox.Text;
            item.description = descriptionTextBox.Text;
            item.category = categoryTextBox.Text;
            item.price = double.Parse(priceTextBox.Text);
            item.quantity = int.Parse(quantityTextBox.Text);
            item.num = num += 1;

            //display item
            MessageBox.Show("added " + item.name + " to inventory.");

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
