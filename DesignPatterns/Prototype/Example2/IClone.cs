using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype.Example2
{
    public interface IClone<T>
    {
        T Clone();
    }
}
