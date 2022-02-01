using System;

namespace DebugandoAplicacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Debugging
            var numerosString = Console.ReadLine();
            var numeros = numerosString.Split(' '); //Se estiver errada, você pode testar mudar o valor com o código.

            foreach (var numero in numeros)
            {
                var numeroInt = int.Parse(numero);
                var aoQuadrado = Math.Pow(numeroInt, 2);
                Console.WriteLine($"{numeroInt}² = {aoQuadrado}");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
