﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingPatterns.AbstractFactory.Introduction;

namespace DesingPatterns.AbstractFactory.Introduction.ConcreteClasses.Windows
{
    public class WinTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render Windows TextBox");
        }
    }
}
