using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype.Example2.Monsters
{
    public class Zombie : Monster<Zombie>
    {
        public int bite { get; set; }
        public Zombie(string name, int bite, int id)
        {
            Id = id;
            this.name = name;
            this.bite = bite;
        }
        public override void Attack()
        {
           Console.WriteLine($"{name} attacks");
        }

        public override void Move()
        {
            Console.WriteLine($"{name} moves");
        }
    }
}
