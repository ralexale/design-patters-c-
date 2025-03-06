using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod.NotificationExercise.Products
{
    public class Push : INotification
    {
        public void Send()
        {
           Console.WriteLine("Sending a push notification");
        }
    }
}
