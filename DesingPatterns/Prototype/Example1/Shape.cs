

namespace DesingPatterns.Prototype.Example1
{
    public abstract class Shape : IClonable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Draw();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
