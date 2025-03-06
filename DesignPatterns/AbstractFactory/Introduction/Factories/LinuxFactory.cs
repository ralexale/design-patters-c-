using DesingPatterns.AbstractFactory.Introduction;
using DesingPatterns.AbstractFactory.Introduction.ConcreteClasses.Linux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Introduction.Factories
{
    public class LinuxFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public IDropdown CreateDropdown()
        {
            return new LinuxDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new LinuxTextBox();
        }
    }
}
