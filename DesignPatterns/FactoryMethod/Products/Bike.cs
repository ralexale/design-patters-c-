using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod.Products
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive the Bike");
        }

        public void Start()
        {
            Console.WriteLine("Starting the Bike");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the Bike");
        }
    }
}
