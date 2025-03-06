using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesingPatterns.Builder.Generator.Tools;

namespace DesingPatterns.Builder.Generator
{
    public interface IBuilderGenerator
    {
        public void Reset();

        public void SetContent(List<string> content);

        public void SetPath(string path);

        public void SetFormat(TypeFormat format);

        public void SetCharacter(TypeCharacter character = TypeCharacter.Normal);
    }
}
