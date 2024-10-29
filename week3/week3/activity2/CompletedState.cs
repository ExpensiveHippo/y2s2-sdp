using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity2
{
    internal class CompletedState : PropertyState
    {
        private Property _property;
        public CompletedState(Property p) 
        {
            _property = p;
        }

        public void Offer(Buyer buyer)
        {
            Console.Write("Cannot offer property at CompletedState");
            Console.WriteLine($" - Sale is completed with success = {_property.success}");
        }

        public void SignContract(Buyer buyer)
        {
            Console.Write("Cannot sign contract at CompletedState");
            Console.WriteLine($" - Sale is completed with success = {_property.success}");
        }

        public void VendorPullout()
        {
            Console.Write("Vendor cannot pull out at CompletedState");
            Console.WriteLine($" - Sale is completed with success = {_property.success}");
        }

        public void BuyerPullout()
        {
            Console.Write("Buyer cannot pull out at CompletedState");
            Console.WriteLine($" - Sale is completed with success = {_property.success}");
        }

        public void PayPrice()
        {
            Console.Write("Cannot pay price at CompletedState");
            Console.WriteLine($" - Sale is completed with success = {_property.success}");
        }
    }
}
