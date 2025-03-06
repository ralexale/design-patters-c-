using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod.Products
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive the motorcycle");
        }

        public void Start()
        {
            Console.WriteLine("Starting the motorcycle ");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the motorcycle ");
        }
    }
}
