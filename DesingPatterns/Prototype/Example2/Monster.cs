using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype.Example2
{
   public abstract class Monster<T> : IClone<T> where T : Monster<T>
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public abstract void Attack();
        public abstract void Move();

        public virtual T Clone()
        {
            // MemberwiseClone preserva el tipo real del objeto.
            return (T)this.MemberwiseClone();
        }
    }
}
