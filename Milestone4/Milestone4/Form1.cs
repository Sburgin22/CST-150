using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventory_Manager i = new Inventory_Manager();

        private void searchButton_Click(object sender, EventArgs e)
        {
            i.Search(searchTextBox); 
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            i.Add(addTextBox);
            if (!NameListBox.Items.Contains(i.name))
            {
                i.Display(NameListBox, IDNumListBox, OrderListBox);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            i.Remove(removeTextBox, NameListBox, IDNumListBox, OrderListBox);
            i.Display(NameListBox, IDNumListBox, OrderListBox);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            i.Order(OrderListBox, orderTextBox);
            i.Display(NameListBox, IDNumListBox, OrderListBox);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
