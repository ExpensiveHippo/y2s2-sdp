using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2
{
    internal class InventorySystem
    {
        private Dictionary<string, Item> inventory = [];

        public void addItem(Item item)
        {
            inventory[item.Name] = item;
        }

        public Item getItem(string name)
        {
            return inventory[name];
        }

        public bool checkAvailability(string itemName, int quantity)
        {
            Console.WriteLine($"Checking stock for {itemName}...");
            return inventory[itemName].Quantity >= quantity;
        }

        public void reduceStock(string itemName, int quantity)
        {
            Console.WriteLine(
                $"Reducing stock of {itemName} by {quantity}");
            inventory[itemName].Quantity -= quantity;
        }

    }
}
