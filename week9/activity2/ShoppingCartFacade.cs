using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2
{
    internal class ShoppingCartFacade
    {
        private InventorySystem iSys;
        private PaymentSystem pSys;
        private OrderSystem oSys;

        public ShoppingCartFacade(InventorySystem i, PaymentSystem p, OrderSystem o)
        {
            iSys = i;
            pSys = p;
            oSys = o;
        }

        public void checkout(string item, int quantity) 
        {
            Console.WriteLine("Starting checkout process...");
            if (!iSys.checkAvailability(item, quantity)) 
            {
                Console.WriteLine("Insufficient stock.");
                return;
            }

            double amt = iSys.getItem(item).Price * quantity;

            if (!pSys.processPayment(amt)) 
            {
                return;
            }

            iSys.reduceStock(item, quantity);
            oSys.confirmOrder();
            oSys.setDelivery();
        }
    }
}
