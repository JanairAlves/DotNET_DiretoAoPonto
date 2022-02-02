using System;

namespace EstruturaDeCondicaoSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo a empresa X!");

            Console.WriteLine("Digite 1 - Contratação de novo plano.");
            Console.WriteLine("Digite 2 - Para fazer uma reclamação.");
            Console.WriteLine("Digite 3 - Segunda via de boleto.");
            Console.WriteLine("Digite 4 - Para sair.");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações de plano novo.");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação.");
                    break;
                case "3":
                    Console.WriteLine("Segunda via do boleto enviada para o e-mail.");
                    break;
                case "4":
                    Console.WriteLine("Tenha um bom dia!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada.");
                    break;
            }

        }
    }
}
