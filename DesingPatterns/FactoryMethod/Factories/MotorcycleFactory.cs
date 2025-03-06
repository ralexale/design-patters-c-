using DesingPatterns.FactoryMethod.Products;


namespace DesingPatterns.FactoryMethod.Factories
{
    public class MotorcycleFactory : VehicleFactory
    {
        private readonly string _motorModel;

        public MotorcycleFactory(string motorModel)
        {
            _motorModel = motorModel;
        }

        public override IVehicle CreateVehicle()
        {
            Console.WriteLine($"Creating a {_motorModel} motorcycle");
            return new Motorcycle();
        }
    }
}
