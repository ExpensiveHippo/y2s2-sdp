using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class MenuItem
    {

        private string name;
        private float price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        // other implementations, e.g., constructor
        public MenuItem(string name, float price)
        {
            Name = name;
            Price = price;
        }   

    }
}
