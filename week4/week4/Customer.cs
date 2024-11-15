using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class Customer : Observer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;  }
        }

        private List<CompanyStock> stocks;
        public List<CompanyStock> Stocks
        {
            get { return stocks; }
        }

        public Customer(string name)
        {
            Name = name;
            stocks = new List<CompanyStock>();
        }
        public void addStock(CompanyStock cs)
        {
            stocks.Add(cs);
            cs.registerObserver(this);
        }

        public void removeStock(CompanyStock cs)
        {
            stocks.Remove(cs);
            cs.removeObserver(this);
        }

        public void update(Subject subject)
        {
            CompanyStock cs = (CompanyStock)subject;
            Console.WriteLine($"Customer {Name} received notification on {cs.Name} new price: {cs.CurrentPrice}");
        }

    }
}
