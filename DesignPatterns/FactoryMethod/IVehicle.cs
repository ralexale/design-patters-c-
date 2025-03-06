using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod
{
    public interface IVehicle
    {
        public void Start();
        public void Stop();
        public void Drive();
    }
}
