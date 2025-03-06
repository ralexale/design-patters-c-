using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesingPatterns.Builder.Generator.Tools;

namespace DesingPatterns.Builder.Generator
{
    internal class GeneratorDirector
    {
        private IBuilderGenerator _builderGenerator;

        public GeneratorDirector(IBuilderGenerator builderGenerator)
        {
            SetBuilder(builderGenerator);
        }


        public void SetBuilder(IBuilderGenerator builderGenerator) => _builderGenerator = builderGenerator;

        public void CreateSimpleJsonGenerator(List<string> content, string Path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContent(content);
            _builderGenerator.SetPath(Path);
            _builderGenerator.SetFormat(TypeFormat.Json);
        }

        public void CreateSimplePipeGenerator(List<string> content, string Path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContent(content);
            _builderGenerator.SetPath(Path);
            _builderGenerator.SetFormat(TypeFormat.Pipes);
            _builderGenerator.SetCharacter(TypeCharacter.Uppercase);
        }
    }
}
