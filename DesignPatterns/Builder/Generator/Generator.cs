using System.Text.Json;
using static DesingPatterns.Builder.Generator.Tools;


namespace DesingPatterns.Builder.Generator
{
    public class Generator
    { 
        public List<string> Content { get;  set; }
        public string Path { get; set; }
        public TypeFormat Format { get; set; }
        public TypeCharacter Character { get; set; }


        public void Save()
        {
            string result = string.Empty;
            result = Format == TypeFormat.Json ? GetJson() : GetPipe(); 

            if (Character == TypeCharacter.Uppercase) result = result.ToUpper();
            if (Character == TypeCharacter.Lowercase) result = result.ToLower();

            File.WriteAllText(Path, result);
        }

        private string GetJson() => JsonSerializer.Serialize(Content);

        private string GetPipe() => Content.Aggregate((accum, current) => accum + "|" + current);
    }
}
