using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype.Example1.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Name = "Rectangle";
        }
        public override void Draw()
        {
            Console.WriteLine($"drawing a rectangle with id {Id}.");
        }
    }

}
