using DesingPatterns.AbstractFactory.Introduction;
using DesingPatterns.AbstractFactory.Introduction.ConcreteClasses.Mac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Introduction.Factories
{
    internal class MacFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public IDropdown CreateDropdown()
        {
            return new MacDropdown();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
