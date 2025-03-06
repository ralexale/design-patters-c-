using DesingPatterns.AbstractFactory.Exercise.ConcreteClasses.Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Exercise.Factories
{
    internal class StripePaymentFactory : IPaymentFactory
    {
        public ILogger CreateLogger()
        {
           return new StripeLogger();
        }

        public IPaymentProcess CreatePaymentProcess()
        {
            return new StripePaymentProcess();
        }
    }
}
