using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity2
{
    internal class PaymentSystem
    {
        private double balance = 0;
        public void addFunds(double amount)
        {
            Console.WriteLine($"Adding ${amount:N2} to balance");
            balance += amount;
            Console.WriteLine($"Current funds: ${balance:N2}");
        }

        public bool processPayment(double amount)
        {
            Console.WriteLine(
                $"Processing payment of ${amount:N2}...");
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Payment successful.");
                Console.WriteLine($"Funds left: ${balance:N2}");
                return true;
            }
            else
            {
                Console.WriteLine(
                    "Payment unsuccessful: insufficient funds.");
                return false;
            }
        }
    }
}
