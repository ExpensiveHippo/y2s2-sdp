using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.activity2
{
    internal class Property
    {
        private PropertyState _onMarketState;
        private PropertyState _underOfferState;
        private PropertyState _contractedState;
        private PropertyState _completedState;
        private PropertyState _state;
        private bool? _success;
        private Buyer? _buyer;

        public Property()
        {
            _onMarketState = new OnMarketState(this);
            _underOfferState = new UnderOfferState(this);
            _contractedState = new ContractedState(this);
            _completedState = new CompletedState(this);
            _state = _onMarketState;
            _success = null;
            _buyer = null;
        }

        public PropertyState onMarketState { get { return _onMarketState; } }
        public PropertyState underOfferState { get { return _underOfferState; } }
        public PropertyState contractedState { get { return _contractedState; } }
        public PropertyState completedState { get { return _completedState; } }

        public PropertyState state { set { _state = value; } }
        public bool? success { 
            get { return _success; }
            set { _success = value; } 
        }
        public Buyer buyer { set { _buyer = value; } }

        public void Offer(Buyer buyer)
        {
            _state.Offer(buyer);
        }

        public void SignContract(Buyer buyer)
        {
            _state.SignContract(buyer);
        }

        public void VendorPullout()
        {
            _state.VendorPullout();
        }

        public void BuyerPullout()
        {
            _state.BuyerPullout();
        }

        public void PayPrice()
        {
            _state.PayPrice();
        }
    }
}
