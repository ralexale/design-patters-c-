using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Exercise.ConcreteClasses.Paypal
{
    internal class PaypalPaymentProcess : IPaymentProcess

    {
        public void CreatePayment(double amount)
        {
           Console.WriteLine("Creating payment with Paypal for amount: " + amount);
        }
    }
}
