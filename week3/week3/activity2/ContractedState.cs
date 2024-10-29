using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity2
{
    internal class ContractedState : PropertyState
    {
        private Property _property;

        public ContractedState(Property p) 
        {
            _property = p;
        }

        public void Offer(Buyer buyer)
        {
            Console.WriteLine("Cannot offer property at ContractedState");
        }

        public void SignContract(Buyer buyer)
        {
            Console.WriteLine("Cannot sign contract at ContractedState");
        }

        public void VendorPullout()
        {
            Console.WriteLine("Vendor cannot pull out at ContractedState");
        }

        public void BuyerPullout()
        {
            Console.WriteLine("Buyer cannot pull out at ContractedState");
        }

        public void PayPrice()
        {
            Console.WriteLine("Paying price at ContractedState");
            _property.state = _property.completedState;
            _property.success = true;
        }
    }
}
