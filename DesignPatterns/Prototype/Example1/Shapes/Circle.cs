using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype.Example1.Shapes
{
    public class Circle : Shape
    {

        public Circle()
        {
            Name = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine($"drawing a circle with id {Id}.");
        }
    }
}
