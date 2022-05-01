using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InventoryManager item = new InventoryManager();

        public class InventoryManager
        {
            string[] itemsArray = new string[10];

            string item;

            ListBox listBox = new ListBox();

            public string AddItem(string[] itemsArray, string items)
            {
                //adds item to end of array
                if (itemsArray[itemsArray.Length - 1] == null)
                {
                    itemsArray[itemsArray.Length - 1] = item;
                }

                for(int i = 0; i < itemsArray.Length; i++)
                {
                    item = itemsArray[i];
                }

                return items;
            }

            public string Remove()
            { 
               return itemsArray[itemsArray.Length - 1] = null;
            }

            public int Restock(int order)
            {
                int[] restock = new int[10];

                int count = 0;

                if (restock[restock.Length - 1] == null)
                {
                    count += order;
                    restock[restock.Length - 1] = order;
                }

                return order;
            }

            public void Display()
            {
                foreach(string i in itemsArray)
                {
                    listBox.Items.Add(i);
                }
            }
        }

        private void addToArray_Click(object sender, EventArgs e)
        {
            string[] itemArr = new string[10];

            string i = addTextBox.Text.ToString();

            addTextBox.Text = item.AddItem(itemArr, i);

            arrayListBox.Items.Add(i);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(arrayListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item.");
            }

            item.Remove();

            arrayListBox.Items.RemoveAt(arrayListBox.Items.Count - 1);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            int order = int.Parse(orderTextBox.Text.ToString());

            item.Restock(order);

            if (arrayListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                MessageBox.Show("Ordered " + order + " " + arrayListBox.SelectedItem.ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
