using DesingPatterns.AbstractFactory.Exercise.ConcreteClasses.Paypal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Exercise.Factories
{
    internal class PaypalPaymentProcesor : IPaymentFactory
    {
        public ILogger CreateLogger()
        {
           return new PaypalLogger();
        }

        public IPaymentProcess CreatePaymentProcess()
        {
           return new PaypalPaymentProcess();
        }
    }
}
