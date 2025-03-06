using DesingPatterns.FactoryMethod.Products;

namespace DesingPatterns.FactoryMethod.Factories
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
