
using DesingPatterns.FactoryMethod.NotificationExercise.Products;

namespace DesingPatterns.FactoryMethod.NotificationExercise.Factories
{
    public class SmsFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new Sms();
        }
    }
}
