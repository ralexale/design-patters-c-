using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Exercise.ConcreteClasses.Stripe
{
    internal class StripePaymentProcess: IPaymentProcess
    {
        public void CreatePayment(double amount)
        {
            Console.WriteLine($"Stripe payment created for amount {amount}");
        }
    }
    
    
}
