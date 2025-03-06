using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype.Example2.Monsters
{
    public class Vampire : Monster<Vampire>
    {
        public int BloodLust { get; set; }
        public Vampire(int bloodLust, string name, int id)
        {
            this.name = name;
            BloodLust = bloodLust;
            Id = id;
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
