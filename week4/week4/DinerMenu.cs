using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class DinerMenu : Aggregate
    {

        int numberOfItems;
        MenuItem[] menuItems;

        public int NumberOfItems { get { return numberOfItems; } }

        public Iterator createIterator(float maxPrice)
        {
            return new PriceIterator(this, maxPrice);
        }

        public void addItem(MenuItem item)
        {
            menuItems[numberOfItems++] = item;
        }

        public MenuItem getItem(int position) { return menuItems[position]; }

        // other implementations, e.g., constructor, addItem(), getItem() etc.
        public DinerMenu()
        {
            numberOfItems = 0;
            menuItems = new MenuItem[20];
        }

    }
}
