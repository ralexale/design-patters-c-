using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype.Example1.Shapes
{
    public class Square : Shape
    {
        public Square()
        {
            Name = "Square";
        }
        public override void Draw()
        {
            Console.WriteLine($"drawing a square with id {Id}.");
        }
    }

}
