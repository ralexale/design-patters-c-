
using DesingPatterns.FactoryMethod.NotificationExercise.Products;


namespace DesingPatterns.FactoryMethod.NotificationExercise.Factories
{
    internal class EmailFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
           return new Email();
        }
    }
}
