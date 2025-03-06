using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Exercise
{
    internal interface IPaymentFactory
    {
        IPaymentProcess CreatePaymentProcess();
        ILogger CreateLogger();
    }
}
