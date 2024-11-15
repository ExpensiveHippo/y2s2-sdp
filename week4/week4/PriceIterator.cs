using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class PriceIterator : Iterator
    {
        private DinerMenu menu;
        private int index;
        private float maxPrice;

        public PriceIterator(DinerMenu dm, float price)
        {
            this.menu = dm;
            this.index = 0;
            this.maxPrice = price;
            while (
                this.hasNext() && 
                this.menu.getItem(index).Price > this.maxPrice
            )
            {
                this.index++;
            }
        }

        public bool hasNext()
        {
            return index < menu.NumberOfItems;
        }

        public object next()
        {
            MenuItem item = menu.getItem(index);
            index++;
            while (
            this.hasNext() &&
            this.menu.getItem(index).Price > this.maxPrice
            )
            {
                index++;
            }
            return item;
        }
    }
}
