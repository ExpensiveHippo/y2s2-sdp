using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2
{
    internal class Item
    {
        private string name;
        public string Name { get => name; set => name = value; }
        private double price;
        public double Price { get => price; set => price = value; }
        private int quantity;
        public int Quantity { get => quantity; set => quantity = value; }

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
