using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod.Products
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive the Car");
        }

        public void Start()
        {
            Console.WriteLine("Starting the Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the  Car");
        }
    }
}
