using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod.NotificationExercise.Products
{
    public class Sms : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending an sms notification");
        }
    }
}
