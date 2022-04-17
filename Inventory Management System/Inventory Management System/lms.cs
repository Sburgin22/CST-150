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
    public partial class IMS : Form
    {
        public IMS()
        {
            InitializeComponent();
        }
        
        InventoryItem item;

        private void addProductButton_Click(object sender, EventArgs e)
        {
           addItemsWindow addItems = new addItemsWindow();
            addItems.ShowDialog();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            item.name = "";
            item.description = "";
            item.price.ToString("");
            item.quantity.ToString("");
            item.num -= 1;
            item.category = "";
            item.orderNum.ToString("");


            MessageBox.Show("item removed from inventory.");
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            editItem editItem = new editItem();
            editItem.ShowDialog();
        }

        private void orderProductButton_Click(object sender, EventArgs e)
        {
            orderItem orderItem = new orderItem();
            orderItem.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
