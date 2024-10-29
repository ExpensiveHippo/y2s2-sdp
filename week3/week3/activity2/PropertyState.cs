using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity2
{
    internal interface PropertyState
    {
        void Offer(Buyer buyer);
        void SignContract(Buyer buyer);
        void VendorPullout();
        void BuyerPullout();
        void PayPrice();
    }
}
