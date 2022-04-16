using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class InventoryItem
    {
        String name;
        String description;
        string category;
        int price;
        int quantity;
        int num;
        int orderNum;

        //empty constructor
        public InventoryItem()
        {

        }

        //constructor with parameters
        public InventoryItem(string name, string description, string category, int price, int quantity, int num, int orderNum)
        {
            this.name = name;
            this.description = description;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.num = num;
            this.orderNum = orderNum;
        }
    }
}
