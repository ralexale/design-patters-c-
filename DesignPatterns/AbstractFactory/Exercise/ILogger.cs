using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory.Exercise
{
    internal interface ILogger
    {
        void LogError(string message);
        void LogWarning(string message);
        void LogInfo(string message);

    }
}
