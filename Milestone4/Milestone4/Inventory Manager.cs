using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4
{
    public class Inventory_Manager
    {
        public string name { get; set; }
        public int inventory_id = 0;
        public int orderAmt = 0;

        List<string> inventory_list = new List<string>();
        List<int> inventory_ids = new List<int>();
        List<int> inventory_orders = new List<int>();

        int output;
        bool IsNumber = false;

        //adds item name, id, and order amount to their lists
        public void Add(TextBox UserInput)
        {
            name = UserInput.Text;
            inventory_id++;

            if (!inventory_list.Contains(name))
            {
                inventory_list.Add(name);
                inventory_ids.Add(inventory_id);
                inventory_orders.Add(orderAmt);
            }
            else
            {
                MessageBox.Show("inventory already has: " + name);
            }
        }

        //removes item from list
        public void Remove(TextBox remove, ListBox items, ListBox ids, ListBox orderNum)
        {
            if (inventory_list.Contains(remove.Text) || inventory_ids.Contains(int.Parse(remove.Text)))
            {
                inventory_id--;

                inventory_list.Remove(name);
                inventory_ids.Remove(inventory_id);
                inventory_orders.Remove(orderAmt);

                items.ClearSelected();
                ids.ClearSelected();
                orderNum.ClearSelected();
            }
            else if(items.SelectedItem.Equals(remove.Text))
            {
                inventory_list.Remove(name.ToString());
                inventory_ids.Remove(inventory_id);
                inventory_orders.Remove(orderAmt);

                items.ClearSelected();
                ids.ClearSelected();
                orderNum.ClearSelected();
            }
            MessageBox.Show("removed " + name);
        }

        //orders an item based on item selected in a list
        //adds the amount to the order
        public void Order(ListBox orderList, TextBox userInput)
        {
            foreach (int order in inventory_orders)
            {
                if(inventory_orders.Contains(order))
                {
                    orderAmt += int.Parse(userInput.Text);
                    orderList.SelectedIndex.Equals(orderAmt);
                }
            }
        }

        //checks the inventory and ID lists to see if they match the content in the search text box
        //if they do a message saying they were found is displayed
        //else an error message is displayed
        public void Search(TextBox userInput)
        {

            IsNumber = int.TryParse(userInput.Text, out output);

            if(!IsNumber)
            {
                foreach(string item in inventory_list)
                {
                    if(item.Contains(userInput.Text))
                    {
                        MessageBox.Show("Found " + item);
                    }
                }
            }
            else if(IsNumber)
            {
               foreach(int id in inventory_ids)
                {
                    if(id.Equals(output))
                    {
                        MessageBox.Show("Found item at ID: " + id);
                    }
                }
            }
        }

        //displays the item, id, and order amount lists
        //to their respective list boxes
        public void Display(ListBox items, ListBox ids, ListBox orderNum)
        {
            if (inventory_id > 0)
            {
                foreach (string item in inventory_list)
                {
                    if (!items.Equals(item))
                    {
                        items.Items.Add(item);
                    }
                }

                foreach (int id in inventory_ids)
                {
                    if(!ids.Equals(id))
                    {
                        ids.Items.Add(id);
                    }
                }

                foreach (int order in inventory_orders)
                {
                    if (!orderNum.Equals(order))
                    {
                        orderNum.Items.Add(order);
                    }
                }
            }
        }
    }
}
