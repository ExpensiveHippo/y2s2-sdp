using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity2
{
    internal class OnMarketState : PropertyState
    {
        private Property _property;
        public OnMarketState(Property p) 
        {
            _property = p;
        }
        public void Offer(Buyer buyer)
        {
            Console.WriteLine($"Offering property to buyer ({buyer.name})");
            _property.state = _property.underOfferState;
        }
        public void SignContract(Buyer buyer)
        {
            Console.WriteLine($"Cannot sign contract at OnMarketState");
        }
        public void VendorPullout()
        {
            Console.WriteLine("Vendor pulling out");
            _property.state = _property.completedState;
            _property.success = false;
        }
        public void BuyerPullout()
        {
            Console.WriteLine("No buyer to pull out at OnMarketState");
        }
        public void PayPrice()
        {
            Console.WriteLine("Cannot pay price at OnMarketState");
        }
    }
}
