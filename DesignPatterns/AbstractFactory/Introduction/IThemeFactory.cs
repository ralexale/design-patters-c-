using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Introduction
{
    public interface IThemeFactory
    {
        IButton CreateButton();
        IDropdown CreateDropdown();
        ITextBox CreateTextBox();
    }
}
