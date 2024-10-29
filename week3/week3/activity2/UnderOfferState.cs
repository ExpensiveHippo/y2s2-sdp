using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity2
{
    internal class UnderOfferState : PropertyState
    {
        private Property _property;

        public UnderOfferState(Property p) 
        {
            _property = p;
        }

        public void Offer(Buyer buyer)
        {
            Console.WriteLine("Cannot offer property at UnderOfferState");
        }

        public void SignContract(Buyer buyer)
        {
            Console.WriteLine($"Signing contract with buyer ({buyer.name})");
            _property.state = _property.contractedState;
        }

        public void VendorPullout()
        {
            Console.WriteLine("Vendor pulling out");
            _property.state = _property.completedState;
            _property.success = false;
        }

        public void BuyerPullout()
        {
            Console.WriteLine("Buyer pulling out");
            _property.state = _property.onMarketState;
        }

        public void PayPrice()
        {
            Console.WriteLine("Cannot pay price at UnderOfferState");
        }
    }
}
