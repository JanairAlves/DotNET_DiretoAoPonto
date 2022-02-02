using System;

namespace EstruturaDeCondicaoIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notaDigitada = Console.ReadLine();
            var nota = int.Parse(notaDigitada);

            if(nota >= 70)
            {
                Console.WriteLine("Aprovado.");
            }
            else if (nota >= 40)
            {
                Console.WriteLine("Recuperação.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
        }
    }
}
