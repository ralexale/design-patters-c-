

namespace DesingPatterns.Prototype.Example2.Monsters
{
    public class Mummy : Monster<Mummy>
    {
        public int health { get; set; }


        public Mummy(int health, string name, int id)
        {
            this.name = name;
            this.health = health;
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
