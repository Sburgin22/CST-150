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
    public partial class editItem : Form
    {
        public editItem()
        {
            InitializeComponent();
        }

        InventoryItem item;

        private void editButton_Click(object sender, EventArgs e)
        {
            //changes item information for selected item
            item.name = nameTextBox.Text;
            item.description = descriptionTextBox.Text;
            item.category = categoryTextBox.Text;
            item.price = double.Parse(priceTextBox.Text);
            item.quantity = int.Parse(quantityTextBox.Text);

            //displays message
            MessageBox.Show(item.name + " edited");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
