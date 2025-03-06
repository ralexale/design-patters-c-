using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Exercise
{
    internal interface IPaymentProcess
    {
        void CreatePayment(double amount);
    }
}
