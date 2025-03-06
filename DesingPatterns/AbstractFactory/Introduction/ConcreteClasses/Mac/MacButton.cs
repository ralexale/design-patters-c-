using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingPatterns.AbstractFactory.Introduction;

namespace DesingPatterns.AbstractFactory.Introduction.ConcreteClasses.Mac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Mac Button ");
        }
    }
}
