using System.Text.Json;


namespace DesingPatterns.Builder.Generator
{
    public class GeneratorConcreteBuilder : IBuilderGenerator
    {
        private Generator _generator;

        public GeneratorConcreteBuilder()
        {
            Reset();
        }



        public void Reset() => _generator  = new Generator();

        public void SetCharacter(Tools.TypeCharacter character) => _generator.Character = character;

        public void SetContent(List<string> content) => _generator.Content = content;

        public void SetFormat(Tools.TypeFormat format) => _generator.Format = format;

        public void SetPath(string path) => _generator.Path = path;

        public Generator GetGenerator() => _generator;

      
    }
}
