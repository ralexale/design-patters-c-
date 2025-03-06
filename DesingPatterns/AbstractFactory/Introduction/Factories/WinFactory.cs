using DesingPatterns.AbstractFactory.Introduction;
using DesingPatterns.AbstractFactory.Introduction.ConcreteClasses.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Introduction.Factories
{
    internal class WinFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public IDropdown CreateDropdown()
        {
            return new WinDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextBox();
        }
    }
}
