using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class CompanyStock : Subject
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }
        private double currentPrice;
        public double CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; notifyObservers(); }
        }
        private List<Observer> observers;

        public CompanyStock(string name, double price)
        {
            Name = name;
            currentPrice = price;
            observers = new List<Observer>();
        }

        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update(this);
            }
        }
    }
}
