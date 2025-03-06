using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder.Burger
{
    public class Burger
    {
        public string bread { get; set; }
        public string meat { get; set; }
        public string cheese { get; set; }
        public string lettuce { get; set; }
        public string tomato { get; set; }
        public string dressing { get; set; }
        public string pickle { get; set; }
        public string bacon { get; set; }

        public void DisplayBurgerInfo()
        {
            Console.WriteLine("---- Burger Info ----");
            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Meat: {meat}");
            Console.WriteLine($"Cheese: {cheese}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Tomato: {tomato}");
            Console.WriteLine($"Dressing: {dressing}");
        }


    }
}
