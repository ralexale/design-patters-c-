using DesingPatterns.FactoryMethod.Products;


namespace DesingPatterns.FactoryMethod.Factories
{
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {

            return new Bike();
        }
    }
}
