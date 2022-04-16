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

        private void addProductButton_Click(object sender, EventArgs e)
        {
           addItemsWindow addItems = new addItemsWindow();
            addItems.ShowDialog();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {

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
