
namespace DesingPatterns.FactoryMethod.Factories
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();

        public IVehicle OrderVehicle()
        {
            var vehicle = CreateVehicle();
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();

            return vehicle;
        }

    }
}
