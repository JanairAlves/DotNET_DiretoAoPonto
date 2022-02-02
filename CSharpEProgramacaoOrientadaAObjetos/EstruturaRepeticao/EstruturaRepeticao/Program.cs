using System;

namespace EstruturaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de números separados por espaço.");
            
            var numerosTexto = Console.ReadLine();
            var numeros = numerosTexto.Split(' ');

            Console.WriteLine();
            Console.WriteLine("Usando for: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Numero: " + numeros[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine("Usando while: ");
            var contador0 = 0;

            while(contador0 < numeros.Length)
            {
                Console.WriteLine("Contador: " + contador0 + " Número: " + numeros[contador0]);
                contador0++;
            }

            Console.WriteLine();
            Console.WriteLine("Usando Do while: ");
            var contador1 = 0;
            do
            {
                Console.WriteLine("Contador: " + contador1 + " Número: " + numeros[contador1]);
                contador1++;
            }
            while (contador1 < numeros.Length);

            Console.WriteLine();
            Console.WriteLine("Usando foreach: ");
            foreach(var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
