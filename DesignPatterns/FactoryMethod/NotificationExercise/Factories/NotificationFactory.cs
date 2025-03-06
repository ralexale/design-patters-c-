using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod.NotificationExercise.Factories
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();

        public INotification SendNotification()
        {
            var notification = CreateNotification();
            
            notification.Send();
            return notification;
        }
    }
}
