

using DesingPatterns.FactoryMethod.NotificationExercise.Products;

namespace DesingPatterns.FactoryMethod.NotificationExercise.Factories
{
    public class PushFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new Push();
        }
    }
}
