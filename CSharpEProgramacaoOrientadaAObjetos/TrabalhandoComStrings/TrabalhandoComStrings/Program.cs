using System;

namespace TrabalhandoComStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Principais métodos, Campo e Propriedade
            var paragrafo = "   C# é uma linguagem moderna e versátil. " + 
                "Com C# consigo desenvolver para web, desktop, jogos, " + 
                "Mobile, entre outros.  ";

            // Length
            var tamanho = paragrafo.Length;

            // Empty
            var vazio = string.Empty;

            // ToLower, ToUpper
            var fraseMinuscula = paragrafo.ToLower();
            var fraseMaiuscula = paragrafo.ToUpper();

            // Split
            var frases = paragrafo.Split('.');

            // Trim, TrimEnd, TrimStart
            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimEnd = paragrafo.TrimEnd();
            var paragrafoTrimStart = paragrafo.TrimStart();

            // IsNullOrWhiteSpace
            var isNullOrWhitespace = string.IsNullOrWhiteSpace(paragrafo);

            // Replace
            var paragrafoCsharp = paragrafo.Replace("C#", "C-sharp");
#endregion

            #region Busca
            var outroParagrafo = "C# é uma linguagem moderna e versátil. " +
            "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
            "Mobile, entre outros.";

            // IndexOf
            var indexOf = outroParagrafo.IndexOf("C#");

            // LastIndexOf
            var lastIndexOf = outroParagrafo.LastIndexOf("C#");

            // StartWith
            var startWith = outroParagrafo.StartsWith("C#");

            // Substring
            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
            var subString = outroParagrafo.Substring(indexOfMobile, 6);

            // Contains
            var containsJogos = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase);
            var containsJogoExact = outroParagrafo.Contains("Jogos");
            var containsRuim = outroParagrafo.Contains("ruim");

            #endregion
        }
    }
}
